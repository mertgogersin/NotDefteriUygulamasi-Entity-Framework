using NotDefteriUygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteriUygulamasi.Repositories
{
    class AdminManagement
    {
        public AdminManagement()
        {
            dbContext = NoteContext.GetInstance();
        }
        NoteContext dbContext;
        public bool AdminLogin(string userName, string password)
        {
            if (userName == "admin" && password == "qwerty")
            {
                return true;
            }
            return false;
        }
        public void DeleteNonVerifiedUser(int userID) //admin sayfasında admin tarafından onaylanmak istenmeyen kullanıcıları silmek için kullanılacak.
        {
            User user = dbContext.Users.Find(userID);
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }
        public void VerifyUser(int userID)
        {
            User user = dbContext.Users.Find(userID);
            user.IsVerified = true;

            UserPassword userPassword = new UserPassword()
            {
                UserID = user.UserID,
                Password = user.Password,
                VerifiedDate = DateTime.Now
            };

            dbContext.UserPasswords.Add(userPassword);
            dbContext.SaveChanges();
        }
        List<User> users=new List<User>();
        public List<User> GetUnVerifiedUsers()
        {
            users=dbContext.Users.Where(x => x.IsVerified == false).ToList();
            return users;
        }
    }
}
