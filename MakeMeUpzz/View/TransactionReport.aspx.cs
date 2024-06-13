using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class TransactionReport : System.Web.UI.Page
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
            }
        }
    }
}