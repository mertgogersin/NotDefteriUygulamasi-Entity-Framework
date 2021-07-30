﻿using NotDefteriUygulamasi.Entities;
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
            if (name == "" || surName == "" || userName == "" || password == "")
            {
                throw new Exception("Lütfen bilgilerinizi doğru giriniz.");
            }
            else if(dbContext.Users.Any(x=>x.UserName==userName))
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
            if (users.Count != 0)
            {
                user = users[0];
            }
            if (user != null && user.Password == password)
            {
                if (user.IsVerified == true)
                {
                    return user;
                }
                else
                {
                    throw new Exception("Hesabınız henüz onaylanmamıştır.");
                }
            }
            else
            {
                throw new Exception("Kullanıcı bilgileriniz yanlış ya da kayıtlı değil, lütfen tekrar deneyiniz.");
            }
        }

        public void ChangePassword(User user, string newPassword)
        {
            var result = (from p in dbContext.UserPasswords
                          where p.UserID == user.UserID
                          orderby p.VerifiedDate descending
                          select p).Take(3).ToList();

            bool passwordCheck = false;
            foreach (var item in result)
            {
                if (item.Password == newPassword)
                {
                    passwordCheck = false;
                    throw new Exception("Şifreniz son üç şifrenizle aynı olamaz.");
                }
                passwordCheck = true;
            }
            if (passwordCheck)
            {
                UserPassword userPassword = new UserPassword()
                {
                    UserID = user.UserID,
                    Password = newPassword,
                    VerifiedDate = DateTime.Now
                };
                dbContext.UserPasswords.Add(userPassword);
                user.Password = newPassword;
                dbContext.SaveChanges();
            }
        }


    }
}