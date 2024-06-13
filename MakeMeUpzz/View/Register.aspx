<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="MakeMeUpzz.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
   <style>
       .top-left {
    position: fixed;
    top: 050px;
    left: 0px;
    background-color: #f0f0f0;
    padding: 10px;
    border: 1px solid #ccc;
    border-radius: 5px;
}
   </style>
<head runat="server">
    <title></title>
      
</head>
<body>
    <form id="form1" runat="server">
        
        
       <h1>Register </h1>
        <p>&nbsp;</p>

        <div>
            <div>Name</div>
            <asp:TextBox ID="NameTextBox" runat="server" ></asp:TextBox>
        </div>
        
        <div>
            <div>Date of Birth</div>
            <asp:TextBox ID="DobTextBox" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        <div>
            <div>Gender</div>
            <asp:RadioButtonList ID="GenderRadioButtonList" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <div>Address</div>
            <asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <div>Password</div>
            <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <div>Phone Number</div>
            <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />

        </div>
        <div>
             <asp:Button ID="Login" runat="server" Text="Login" OnClick="LoginButton_Click" />
 <asp:Button ID="HomeButton" runat="server" Text="Home"  OnClick="HomeButton_Click" />
        
        </div>
       
    </form>
</body>
</html>
