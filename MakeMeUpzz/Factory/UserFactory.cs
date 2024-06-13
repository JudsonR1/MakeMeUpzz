using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Factory
{
    public class UserFactory
    {
        public static User CreateUser(string name, DateTime dob, string gender, string address, string password, string phone, string role = "customer")
        {
            User user = new User
            {
                UserName = name,
                UserDOB = dob,
                UserGender = gender,
                UserAddress = address,
                UserPassword = password,
                UserPhone = phone,
                UserRole = role
            };

            return user;
        }
    }
}