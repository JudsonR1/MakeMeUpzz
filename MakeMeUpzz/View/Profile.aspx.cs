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
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakeMeUpzz.View
{
    public partial class Profile : System.Web.UI.Page
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
                if (u == null)
                {
                    Response.Redirect("~/View/Home.aspx");
                }

                NameTextBox.Text = u.UserName;
                DobTextBox.Text = u.UserDOB.ToString("yyyy-MM-dd");
                GenderRadioButtonList.SelectedValue = u.UserGender;
                AddressTextBox.Text = u.UserAddress;
                PasswordTextBox.Text = u.UserPassword;
                PhoneTextBox.Text = u.UserPhone;
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            User u = (User)Session["user"];
            int id = u.UserId;

            string name = NameTextBox.Text;
            string dob = DobTextBox.Text;
            string gender = GenderRadioButtonList.SelectedValue;
            string address = AddressTextBox.Text;
            string password = PasswordTextBox.Text;
            string phone = PhoneTextBox.Text;

            string status = UserController.ValidateProfileInformation(name, dob, gender, address, password, phone, id);
            if (status != "sukses")
            {
                StatusLabel.Text = status;
                return;
            }

            DateTime newDob = DateTime.Parse(dob);

            User newUser = UserController.UpdateUser(id, name, newDob, gender, address, password, phone);

            Session["user"] = newUser;

            StatusLabel.Text = "sukses";
        }
    }
}