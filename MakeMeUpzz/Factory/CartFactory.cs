using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace MakeMeUpzz.Factory
{
    public class CartFactory
    {
        public static Cart CreateCart(int userId, int makeupId, int quantity)
        {
            Cart cart = new Cart
            {
                UserId = userId,
                MakeupId= makeupId,
                Quantity = quantity
            };

            return cart;
        }
    }
}