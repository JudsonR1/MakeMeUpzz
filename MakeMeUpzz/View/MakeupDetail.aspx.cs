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
using System.Xml;

namespace MakeMeUpzz.View
{
    public partial class MakeupDetail : System.Web.UI.Page
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

                QuantityTextBox.Focus();

                if (Request["makeup_id"] == null || Request["makeup_id"] == String.Empty)
                {
                    Response.Redirect("~/View/Home.aspx");
                }
                User u = (User)Session["user"];
                if (u != null && u.UserRole == "customer")
                {
                    CustomerPanel.Visible = true;
                }


                int id = Convert.ToInt32(Request["makeup_id"]);
                Makeup s = MakeupController.GetMakeupById(id);
                NameLabel.Text = $"Name : {s.MakeupName}";
                PriceLabel.Text = $"Price : {s.MakeupPrice}";
            }
        }

        protected void AddToCartButton_Click(object sender, EventArgs e)
        {
            User u = (User)Session["user"];
            int user_id = u.UserId;
            int makeup_id = Convert.ToInt32(Request["makeup_id"]);
            string quantity = QuantityTextBox.Text;

            string status = CartController.InsertCart(user_id, makeup_id, quantity);
            if (status == "sukses")
            {
                Response.Redirect("~/View/Home.aspx");
            }
            else
            {
                StatusLabel.Text = status;
            }
        }
    }
}