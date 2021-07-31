using NotDefteriUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteriUygulamasi.Repositories
{
    class UserManagement
    {
        public UserManagement()
        {
            dbContext = NoteContext.GetInstance();
        }
        NoteContext dbContext;

        public void UserSignUp(string name, string surName, string userName, string password)
        {
            if (name == "" || surName == "" || userName == "" || password == "")//Burayı hocaya sor!! Ne kadar constraint koysam da bazen db ye boş veri ekleyebiliyordu. Bu yüzden bu kontrolü koymak zorunda kaldım.
            {
                throw new Exception("Lütfen bilgilerinizi doğru giriniz.");
            }
            else if (dbContext.Users.Any(x => x.UserName == userName))
            {
                throw new Exception("Bu kullanıcı adına ait bir kullanıcı bulunmaktadır.");
            }
            User user = new User()
            {
                Name = name,
                SurName = surName,
                UserName = userName,
                Password = password
            };

            dbContext.Users.Add(user);
            dbContext.SaveChanges();

        }

        public User UserLogin(string userName, string password)
        {
            List<User> users = dbContext.Users.Where(x => x.UserName == userName).ToList();
            User user = new User();
            if (users.Count == 0)
            {
                throw new Exception("Kullanıcı adı ya da şifreniz yanlış, lütfen tekrar deneyiniz.");
            }
            user = users[0];
            List<UserPassword> passwords = dbContext.UserPasswords.Where(x => x.UserID == user.UserID).OrderByDescending(x => x.VerifiedDate).Take(1).ToList();
            if (passwords[0].Password != password)
            {
                throw new Exception("Kullanıcı adı ya da şifreniz yanlış, lütfen tekrar deneyiniz.");
            }
            if (!user.IsVerified)
            {
                throw new Exception("Hesabınız henüz onaylanmamıştır.");
            }
            return user;
        }

        public void ChangePassword(int userID, string newPassword)
        {
            User user = dbContext.Users.Find(userID);
            var result = (from p in dbContext.UserPasswords
                          where p.UserID == userID
                          orderby p.VerifiedDate descending
                          select p).Take(3).ToList();


            foreach (var item in result)
            {
                if (item.Password == newPassword)
                {

                    throw new Exception("Şifreniz son üç şifrenizle aynı olamaz.");
                }

            }
            UserPassword userPassword = new UserPassword()
            {
                UserID = userID,
                Password = newPassword,
                VerifiedDate = DateTime.Now
            };
            dbContext.UserPasswords.Add(userPassword);
            user.Password = newPassword;
            dbContext.SaveChanges();
        }
    }
}
