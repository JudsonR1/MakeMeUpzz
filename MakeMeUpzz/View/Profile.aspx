<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="MakeMeUpzz.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Profile</h1>

    <div>
        Name
        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        Date of Birth
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
        Address
        <asp:TextBox ID="AddressTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        Password
        <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
    </div>
     <div>
        Phone
        <asp:TextBox ID="PhoneTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />
    </div>


    

</asp:Content>
