using MakeMeUpzz.Controller;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Controller;
using MakeMeUpzz.Factory;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class CartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["user_cookie"] != null && Session["user"] == null)
                {
                    int userId = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    User user = UserHandler.GetUserByUserId(userId);
                    Session["user"] = user;
                }

                User u = (User)Session["user"];
                if (u == null || u.UserRole != "customer")
                {
                    Response.Redirect("~/View/Home.aspx");
                }

                BindGridView();
            }
        }

        protected void BindGridView()
        {
            User u = (User)Session["user"];

            List<Cart> cartList = CartController.GetCartByUserId(u.UserId);
            List<Makeup> makeupList = MakeupController.GetMakeups();

            var res = cartList.Join(
                makeupList,
                cart => cart.MakeupId,
                makeup => makeup.MakeupId,
                (cart, makeup) => new
                {
                    makeup.MakeupId,
                    makeup.MakeupName,
                    makeup.MakeupPrice,
                    cart.Quantity
                }).ToList();

            if (res.Count == 0)
            {
                CheckOutButton.Visible = false;
                CartIsEmptyLabel.Visible = true;
            }

            CartGridView.DataSource = res;
            CartGridView.DataBind();
        }

        protected void CartGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makeupId = CartGridView.DataKeys[CartGridView.SelectedIndex].Value.ToString();
            Response.Redirect("~/View/UpdateCart.aspx?makeup_id=" + makeupId);
        }

        protected void CartGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int makeupId = Convert.ToInt32(CartGridView.DataKeys[e.RowIndex].Value.ToString());
            User u = (User)Session["user"];
            int userId = u.UserId;
            CartController.DeleteCart(userId, makeupId);

            BindGridView();
        }

        protected void CheckOutButton_Click(object sender, EventArgs e)
        {
            User u = (User)Session["user"];
            DateTime dt = DateTime.Now;
            int thId = TransactionHeaderController.InsertTransactionHeader(u.UserId, dt);

            List<Cart> cartList = CartController.GetCartByUserId(u.UserId);
            foreach (Cart cart in cartList)
            {
                TransactionDetailController.InsertTransactionDetail(thId, cart.MakeupId, cart.Quantity);
                CartController.DeleteCart(u.UserId, cart.MakeupId);
            }

            Response.Redirect("~/View/Home.aspx");
        }
    }
}