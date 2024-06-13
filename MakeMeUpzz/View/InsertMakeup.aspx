<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="InsertMakeup.aspx.cs" Inherits="MakeMeUpzz.View.InsertMakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Insert Makeup</h1>

    <div>
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

        <asp:Button ID="AddButton" runat="server" Text="Insert" OnClick="AddButton_Click" />

      
    </div>
</asp:Content>
