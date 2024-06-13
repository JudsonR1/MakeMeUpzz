using MakeMeUpzz.Controller;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace MakeMeUpzz.Handler
{
    public class CartHandler
    {
        public static string InsertCart(int userId, int makeupId, int quantity)
        {
            if (UserRepository.GetUserByUserId(userId) == null)
            {
                return "User tidak ditemukan";
            }
            if (MakeupRepository.GetMakeupById(makeupId) == null)
            {
                return "Produk Makeup tidak ditemukan";
            }

            Cart c = CartFactory.CreateCart(userId, makeupId, quantity);
            CartRepository.InsertCart(c);
            return "sukses";
        }

        public static string UpdateCart(int userId, int makeupId, int quantity)
        {
            if (UserRepository.GetUserByUserId(userId) == null)
            {
                return "User tidak ditemukan";
            }
            if (MakeupRepository.GetMakeupById(makeupId) == null)
            {
                return "Produk Makeup tidak ditemukan";
            }

            Cart c = CartFactory.CreateCart(userId, makeupId, quantity);
            CartRepository.UpdateCart(c);
            return "sukses";
        }

        public static List<Cart> GetCartByUserId(int userId)
        {
            return CartRepository.GetCartByUserId(userId);
        }

        public static void DeleteCart(int userId, int makeupId)
        {
            CartRepository.DeleteCart(userId, makeupId);
        }

        public static Cart GetCartByUserIdAndMakeupId(int userId, int makeupId)
        {
            return CartRepository.GetCartByUserIdAndMakeupId(userId, makeupId);
        }
    }
}