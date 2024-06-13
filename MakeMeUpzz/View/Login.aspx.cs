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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["user_cookie"] != null && Session["user"] == null)
            {
                int userId = Convert.ToInt32(Request.Cookies["user_cookie"].Value);
                User user = UserHandler.GetUserByUserId(userId);
                Session["user"] = user;
            }

            NameTextBox.Focus();

            if (Session["user"] != null)
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home.aspx");
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string password = PasswordTextBox.Text;
            bool rememberMe = RememberMeCheckBox.Checked;

            string status = UserController.Login(name, password);
            if (status == "sukses")
            {
                User u = UserController.GetUserByName(name);

                if (rememberMe == true)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = u.UserId.ToString();
                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);
                }

                Session["user"] = u;

                Response.Redirect("~/View/Home.aspx");
            }
            else
            {
                StatusLabel.Text = status;
            }
        }

        

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Register.aspx");
        }
    }
}