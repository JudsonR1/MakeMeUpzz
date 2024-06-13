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
    public partial class InsertMakeup : System.Web.UI.Page
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
                if (u == null || u.UserRole != "admin")
                {
                    Response.Redirect("~/View/Home.aspx");
                }

                NameTextBox.Focus();
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string price = PriceTextBox.Text;

            string status = MakeupController.InsertMakeup(name, price);
            if (status == "sukses")
            {
                NameTextBox.Text = "";
                PriceTextBox.Text = "";
                StatusLabel.Text = "";
            }
            else
            {
                StatusLabel.Text = status;
            }
        }
    }
}