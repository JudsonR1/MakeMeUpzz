<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateMakeup.aspx.cs" Inherits="MakeMeUpzz.View.UpdateMakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Update Stationery</h1>

    <div>
        Name
        <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
    </div>
    <div>
        Price
        <asp:TextBox ID="PriceTextBox" runat="server" TextMode="Number"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
    </div>
    <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />

    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

</asp:Content>
