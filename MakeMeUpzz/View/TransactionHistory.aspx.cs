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
    public partial class TransactionHistory : System.Web.UI.Page
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


                List<TransactionHeader> thList = TransactionHeaderController.GetTransactionHeadersByUserId(u.UserId);

                TransactionHistoryGridView.DataSource = thList;
                TransactionHistoryGridView.DataBind();

               
                for (int i = 0; i < thList.Count; i++)
                {
                    TransactionHistoryGridView.Rows[i].Cells[2].Text = u.UserName;
                }
            }
        }

        protected void TransactionHistoryGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TransactionHistoryGridView.SelectedRow.Cells[0].Text);
            Response.Redirect("~/View/TransactionDetailPage.aspx?transaction_id=" + id);
        }
    }
}