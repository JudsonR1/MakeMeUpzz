using MakeMeUpzz.Factory;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace MakeMeUpzz.Controller
{
    public class CartController
    {
        public static string InsertCart(int userId, int makeupId, string quantity)
        {
            if (quantity == "")
            {
                return "Mesti di isi";
            }

            int newQuantity = Convert.ToInt32(quantity);
            if (newQuantity <= 0)
            {
                return "Quantity harus lebih besar dari 0";
            }

            return CartHandler.InsertCart(userId, makeupId, newQuantity);
        }

        public static string UpdateCart(int userId, int makeupId, string quantity)
        {
            if (quantity == "")
            {
                return "Tidak boleh kosong";
            }

            int newQuantity = Convert.ToInt32(quantity);
            if (newQuantity <= 0)
            {
                return "Quantity harus lebih besar dari 0";
            }

            return CartHandler.UpdateCart(userId, makeupId, newQuantity);
        }

        public static List<Cart> GetCartByUserId(int userId)
        {
            return CartHandler.GetCartByUserId(userId);
        }

        public static void DeleteCart(int userId, int makeupId)
        {
            CartHandler.DeleteCart(userId, makeupId);
        }

        public static Cart GetCartByUserIdAndMakeupId(int userId, int makeupId)
        {
            return CartHandler.GetCartByUserIdAndMakeupId(userId, makeupId);
        }
    }
}