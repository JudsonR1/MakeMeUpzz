using MakeMeUpzz.Model;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.Master
{
    public partial class NavigationBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                User u = (User)Session["user"];
                if (u == null) // ga login
                {
                    NotLoginPanel.Visible = true;
                    LoginAsAdminPanel.Visible = false;
                    LoginAsCustomerPanel.Visible = false;
                }
                else if (u.UserRole == "customer")
                {
                    NotLoginPanel.Visible = false;
                    LoginAsAdminPanel.Visible = false;
                    LoginAsCustomerPanel.Visible = true;
                }
                else if (u.UserRole == "admin")
                {
                    NotLoginPanel.Visible = false;
                    LoginAsAdminPanel.Visible = true;
                    LoginAsCustomerPanel.Visible = false;
                }
            }
        }

        #region CLICK EVENT
        protected void HomeLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home.aspx");
        }

        protected void RegisterLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Register.aspx");
        }

        protected void LoginLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login.aspx");
        }

        protected void CustomerCartLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/CartPage.aspx");
        }

        protected void CustomerTransactionLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionHistory.aspx");
        }

        protected void AdminTransactionLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionReport.aspx");
        }

        protected void ProfileLinkButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile.aspx");
        }

        protected void LogoutLinkButton_Click(object sender, EventArgs e)
        {
            Session.Remove("user");

            if (Request.Cookies["user_cookie"] != null)
            {
                HttpCookie cookie = Request.Cookies["user_cookie"];
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }

            Response.Redirect("~/View/Home.aspx");
        }

        #endregion

    }
}