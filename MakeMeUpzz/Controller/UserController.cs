using MakeMeUpzz.Factory;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class UserController
    {
        public static string ValidateProfileInformation(string name, string dob, string gender, string address, string password, string phone, int id = 0)
        {
            Regex regex = new Regex("^(?=.*[a-zA-Z])(?=.*[0-9])[A-Za-z0-9]+$");

            if (name == "" || dob == "" || gender == "" || address == "" || password == "" || phone == "")
            {
                return "Tidak boleh kosong";
            }
            if (name.Length < 5 || name.Length > 50)
            {
                return "nama length 5-50";
            }
            if (isLessThanOneYear(DateTime.Parse(dob)))
            {
                return "DOB minimal satu tahun dari sekarang";
            }
            if (!regex.IsMatch(password))
            {
                return "password harus ada huruf dan angka dan tidak boleh ada special character";
            }

            return UserHandler.ValidateProfileInformation(name, id);
        }

        public static bool isLessThanOneYear(DateTime dob)
        {
            DateTime dtNow = DateTime.Now;
            TimeSpan ts = dtNow - dob;
            return ts.Days < 365;
        }

        public static void InsertUser(string name, DateTime dob, string gender, string phone, string address, string password, string role)
        {
            UserHandler.InsertUser(name, dob, gender, phone, address, password, role);
        }

        public static string Login(string name, string password)
        {
            if (name == "" || password == "")
            {
                return "Tidak boleh kosong";
            }

            return UserHandler.Login(name, password);
        }

        public static User GetUserByName(string name)
        {
            return UserHandler.GetUserByName(name);
        }

        public static User UpdateUser(int id, string name, DateTime dob, string gender, string address, string password, string phone)
        {
            return UserHandler.UpdateUser(id, name, dob, gender, address, password, phone);
        }

        public static User GetUserByUserId(int userId)
        {
            return UserRepository.GetUserByUserId(userId);
        }
    }
}