using MakeMeUpzz.Controller;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Controller;
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
    public partial class UpdateCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["user_cookie"] != null && Session["user"] == null)
                {
                    int id = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                    User user = UserHandler.GetUserByUserId(id);
                    Session["user"] = user;
                }

                QuantityTextBox.Focus();

                User u = (User)Session["user"];
                if (u == null || u.UserRole != "customer")
                {
                    Response.Redirect("~/View/Home.aspx");
                }

                if (Request["makeup_id"] == null || Request["makeup_id"] == String.Empty)
                {
                    Response.Redirect("~/View/Home.aspx");
                }

                int userId = u.UserId;
                int makeupId = Convert.ToInt32(Request["makeup_id"]);
                Makeup s = MakeupController.GetMakeupById(makeupId);
                Cart c = CartController.GetCartByUserIdAndMakeupId(userId, makeupId);
                NameLabel.Text = "Name: " + s.MakeupName;
                PriceLabel.Text = "Price: " + s.MakeupPrice.ToString();
                QuantityTextBox.Text = c.Quantity.ToString();
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            User u = (User)Session["user"];
            int userId = u.UserId;
            int makeupId = Convert.ToInt32(Request["makeup_id"]);
            string quantity = QuantityTextBox.Text;

            string status = CartController.UpdateCart(userId, makeupId, quantity);
            if (status == "sukses")
            {
                Response.Redirect("~/View/CartPage.aspx");
            }
            else
            {
                StatusLabel.Text = status;
            }
        }
    }
}
