using MakeMeUpzz.Model;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class MakeupRepository
    {
        public static List<Makeup> GetMakeups()
        {
            Database1Entities db = new Database1Entities();
            return db.Makeups.ToList();
        }

        public static Makeup GetMakeupById(int id)
        {
            Database1Entities db = new Database1Entities();
            return db.Makeups.Find(id);
        }

        public static void InsertMakeup(Makeup makeup)
        {
            Database1Entities db = new Database1Entities();
            db.Makeups.Add(makeup);
            db.SaveChanges();
        }

        public static void UpdateMakeup(int id, string name, int price)
        {
            Database1Entities db = new Database1Entities();
            Makeup newMakeup = db.Makeups.Find(id);
            newMakeup.MakeupName = name;
            newMakeup.MakeupPrice = price;
            db.SaveChanges();
        }

        public static void DeleteMakeup(int stationeryId)
        {
            Database1Entities db = new Database1Entities();
            Makeup removeStationery = db.Makeups.Find(stationeryId);
            db.Makeups.Remove(removeStationery);
            db.SaveChanges();
        }
    }
}