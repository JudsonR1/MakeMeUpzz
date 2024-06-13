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
    public partial class UpdateMakeup : System.Web.UI.Page
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

                if (Request["makeup_id"] == null || Request["makeup_id"] == String.Empty)
                {
                    Response.Redirect("~/View/Home.aspx");
                }

                int id = Convert.ToInt32(Request["makeup_id"]);
                Makeup s = MakeupController.GetMakeupById(id);
                NameTextBox.Text = s.MakeupName;
                PriceTextBox.Text = s.MakeupPrice.ToString();
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["makeup_id"]);
            string name = NameTextBox.Text;
            string price = PriceTextBox.Text;

            string status = MakeupController.UpdateMakeup(id, name, price);
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
