using MakeMeUpzz.Model;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace MakeMeUpzz.Repository
{
    public class CartRepository
    {
        public static void InsertCart(Cart cart)
        {
            Database1Entities db = new Database1Entities();

            Cart c = db.Carts.Where(x => x.UserId == cart.UserId && x.MakeupId == cart.MakeupId).FirstOrDefault();
            if (c == null)
            {
                db.Carts.Add(cart);
            }
            else
            {
                c.Quantity += cart.Quantity;
            }
            db.SaveChanges();
        }

        public static List<Cart> GetCartByUserId(int userId)
        {
            Database1Entities db = new Database1Entities();
            return db.Carts.Where(x => x.UserId == userId).ToList();
        }

        public static Cart GetCartByUserIdAndMakeupId(int userId, int makeupId)
        {
            Database1Entities db = new Database1Entities();
            return db.Carts.Where(x => x.UserId == userId && x.MakeupId == makeupId).FirstOrDefault();
        }

        public static void DeleteCart(int userId, int makeupId)
        {
            Database1Entities db = new Database1Entities();
            Cart c = db.Carts.Where(x => x.UserId == userId && x.MakeupId == makeupId).FirstOrDefault();
            db.Carts.Remove(c);
            db.SaveChanges();
        }

        public static void UpdateCart(Cart cart)
        {
            Database1Entities db = new Database1Entities();
            Cart c = db.Carts.Where(x => x.UserId == cart.UserId && x.MakeupId == cart.MakeupId).FirstOrDefault();
            c.Quantity = cart.Quantity;
            db.SaveChanges();
        }
    }
}