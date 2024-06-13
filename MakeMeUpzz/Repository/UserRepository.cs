using MakeMeUpzz.Model;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Xml.Linq;

namespace MakeMeUpzz.Repository
{
    public class UserRepository
    {
        public static void InsertUser(User user)
        {
            Database1Entities db = new Database1Entities();
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User GetUserByUserId(int id)
        {
            Database1Entities db = new Database1Entities();
            return db.Users.Find(id);
        }

        public static User GetUserByName(string name)
        {
            Database1Entities db = new Database1Entities();
            return db.Users.Where(x => x.UserName == name).FirstOrDefault();
        }
        public static List<User> GetAllUsers()
        {
            Database1Entities db = new Database1Entities();
            return db.Users.ToList();
        }

        public static User UpdateUser(int id, string name, DateTime dob, string gender, string address, string password, string phone)
        {
            Database1Entities db = new Database1Entities();
            User newUser = db.Users.Find(id);
            newUser.UserName = name;
            newUser.UserDOB = dob;
            newUser.UserGender = gender;
            newUser.UserAddress = address;
            newUser.UserPassword = password;
            newUser.UserPhone = phone;
            db.SaveChanges();
            return newUser;
        }
    }
}