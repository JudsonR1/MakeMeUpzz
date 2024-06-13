﻿using MakeMeUpzz.Controller;
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
    public partial class TransactionDetailPage : System.Web.UI.Page
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
                if (u == null || u.UserRole != "customer" || Request["transaction_id"] == null || Request["transaction_id"] == String.Empty)
                {
                    Response.Redirect("~/View/Home.aspx");
                }

                int id = Convert.ToInt32(Request["transaction_id"]);

                List<TransactionDetail> tdList = TransactionDetailController.GetTransactionDetailByTransactionId(id);
                List<Makeup> sList = MakeupController.GetMakeups();

                var res = tdList.Join(
                    sList,
                    td => td.MakeupId,
                    s => s.MakeupId,
                    (td, s) => new
                    {
                        s.MakeupName,
                        s.MakeupPrice,
                        td.Quantity
                    }).ToList();

                GridView.DataSource = res;
                GridView.DataBind();
            }
        }
    }
}