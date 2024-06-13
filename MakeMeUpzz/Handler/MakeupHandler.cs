using MakeMeUpzz.Controller;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Handler
{
    public class MakeupHandler
    {
        public static string InsertMakeup(string name, int price)
        {
            Makeup s = MakeupFactory.CreateMakeup(name, price);
            MakeupRepository.InsertMakeup(s);

            return "sukses";
        }

        public static string UpdateMakeup(int id, string name, int price)
        {
            MakeupRepository.UpdateMakeup(id, name, price);
            return "sukses";
        }

        public static List<Makeup> GetMakeups()
        {
            return MakeupRepository.GetMakeups();
        }

        public static void DeleteMakeup(int id)
        {
            MakeupRepository.DeleteMakeup(id);
        }

        public static Makeup GetMakeupById(int id)
        {
            return MakeupRepository.GetMakeupById(id);
        }
    }
}