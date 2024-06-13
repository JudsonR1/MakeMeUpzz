using MakeMeUpzz.Controller;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using MakeMeUpzz.Controller;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class UserHandler
    {
        public static void InsertUser(string name, DateTime dob, string gender, string phone, string address, string password, string role)
        {
            User user = UserFactory.CreateUser(name, dob, gender, phone, address, password, role);
            UserRepository.InsertUser(user);
        }

        public static string Login(string name, string password)
        {
            User u = UserRepository.GetUserByName(name);
            if (u == null)
            {
                return "Username tidak ditemukan";
            }
            else if (u.UserName == name && u.UserPassword != password)
            {
                return "Password tidak sesuai";
            }
            else
            {
                return "sukses";
            }
        }

        public static User GetUserByName(string name)
        {
            return UserRepository.GetUserByName(name);
        }

        public static string ValidateProfileInformation(string name, int id)
        {
            User user = UserRepository.GetUserByName(name);
            if (user != null && user.UserId == id)
            {
                return "sukses";
            }
            if (user != null)
            {
                return "uda ada username yang sama";
            }

            return "sukses";
        }

        public static User UpdateUser(int id, string name, DateTime dob, string gender, string address, string password, string phone)
        {
            return UserRepository.UpdateUser(id, name, dob, gender, address, password, phone);
        }

        public static User GetUserByUserId(int userId)
        {
            return UserController.GetUserByUserId(userId);
        }

    }
}