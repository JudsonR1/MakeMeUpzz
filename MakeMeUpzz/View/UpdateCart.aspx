<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateCart.aspx.cs" Inherits="MakeMeUpzz.View.UpdateCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Update Cart</h1>

    <div>
        <div>
            <asp:Label ID="NameLabel" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <asp:Label ID="PriceLabel" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            Quantity
            <asp:TextBox ID="QuantityTextBox" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
        </div>
        <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />
    </div>

</asp:Content>
