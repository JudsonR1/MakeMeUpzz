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
    public partial class Home : System.Web.UI.Page
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

                if (u != null)
                {
                    Label1.Text = u.UserName;
                    Label2.Text = u.UserRole;

                    if (u.UserRole == "customer")
                    {
                        CustomerPanel.Visible = true;
                    }
                    else if (u.UserRole == "admin")
                    {
                        AdminPanel.Visible = true;
                    }

                    BindGridView();
                }
               


                if (u == null || u.UserRole == "customer")
                {
                    CustomerPanel.Visible = true;
                }
                else if (u.UserRole == "admin")
                {
                    AdminPanel.Visible = true;
                }
                BindGridView();

              
            }
        }

        protected void BindGridView()
        {
            CustomerGridView.DataSource = MakeupController.GetMakeups();
            CustomerGridView.DataBind();

            AdminGridView.DataSource = MakeupController.GetMakeups();
            AdminGridView.DataBind();
        }

        protected void AdminGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(AdminGridView.DataKeys[e.RowIndex].Value);
            try
            {
                MakeupController.DeleteMakeup(id);
            }
            catch
            {
                ErrorLabel.Text = "REFERENCE DELETE ERROR";
            }
            BindGridView();
        }

        protected void AdminGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(AdminGridView.DataKeys[AdminGridView.SelectedIndex].Value);
            Response.Redirect("~/View/MakeupDetail.aspx?makeup_id=" + id);
        }

        protected void CustomerGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(CustomerGridView.DataKeys[CustomerGridView.SelectedIndex].Value);
            Response.Redirect("~/View/MakeupDetail.aspx?makeup_id=" + id);
        }

        protected void AdminGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(AdminGridView.DataKeys[e.RowIndex].Value);
            Response.Redirect("~/View/UpdateMakeup.aspx?makeup_id=" + id);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
    }
}