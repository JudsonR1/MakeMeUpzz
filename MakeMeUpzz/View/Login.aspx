<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MakeMeUpzz.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .bottom-right {
    position: fixed;
    bottom: 0px; 
    right: 0px; 
    background-color: #f0f0f0;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 5px;
}
    </style>
    <link rel="stylesheet" type="text/css" href="style/style.css" />

</head>
<body>
    <form id="form1" runat="server">

       

        <h1>Login</h1>

        <div>
            Name       <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            Password <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="RememberMeCheckBox" runat="server" Text="Remember Me" />
        </div>
        <div>
            <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
           </div>
            <div>
                 <asp:Button ID="Button1" runat="server" Text="Register" OnClick="RegisterButton_Click" />
 <asp:Button ID="Button2" runat="server" Text="Home" CssClass="top-left" OnClick="HomeButton_Click" />
        
            </div>        
       

        <div class="bottom-right">
            <asp:Label ID="Note" runat="server" Text="Note: Username admin: Admin, Password: Admin123"></asp:Label>
        </div>

    </form>
</body>
</html>
