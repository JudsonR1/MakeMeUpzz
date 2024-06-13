using MakeMeUpzz.Controller;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using MakeMeUpzz.Controller;
using MakeMeUpzz.Handler;
using MakeMeUpzz.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class Register : System.Web.UI.Page
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

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string dob = DobTextBox.Text;
            string gender = GenderRadioButtonList.SelectedValue;
            string address = AddressTextBox.Text;
            string password = PasswordTextBox.Text;
            string phone = PhoneTextBox.Text;
            string role = "customer";

            string statusValidate = UserController.ValidateProfileInformation(name, dob, gender, address, password, phone);
            if (statusValidate != "sukses")
            {
                StatusLabel.Text = statusValidate;
                return;
            }

            DateTime newDob = DateTime.Parse(dob);

            UserController.InsertUser(name, newDob, gender, address, password, phone, role);

            Response.Redirect("~/View/Login.aspx");
        }

        protected void HomeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home.aspx");
        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login.aspx");
        }
    }
}