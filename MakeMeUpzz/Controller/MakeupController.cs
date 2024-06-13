using MakeMeUpzz.Factory;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Controller
{
    public class MakeupController
    {
        public static string InsertMakeup(string name, string price)
        {
            if (name == "" || price == "")
            {
                return "Tidak boleh kosong";
            }
            if (name.Length < 3 || name.Length > 50)
            {
                return "name length 3-50";
            }

            int newPrice = Convert.ToInt32(price);
            if (newPrice < 2000)
            {
                return "Price minimal 2000";
            }

            return MakeupHandler.InsertMakeup(name, newPrice);
        }

        public static string UpdateMakeup(int id, string name, string price)
        {
            if (name == "" || price == "")
            {
                return "Tidak boleh kosong";
            }

            int newPrice = Convert.ToInt32(price);
            if (name.Length < 3 || name.Length > 50)
            {
                return "name length 3-50";
            }
            if (newPrice < 2000)
            {
                return "Price minimal 2000";
            }

            return MakeupHandler.UpdateMakeup(id, name, newPrice);
        }

        public static List<Makeup> GetMakeups()
        {
            return MakeupHandler.GetMakeups();
        }

        public static void DeleteMakeup(int id)
        {
            MakeupHandler.DeleteMakeup(id);
        }

        public static Makeup GetMakeupById(int id)
        {
            return MakeupHandler.GetMakeupById(id);
        }
    }
}