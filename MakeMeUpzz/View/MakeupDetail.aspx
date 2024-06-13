<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="MakeupDetail.aspx.cs" Inherits="MakeMeUpzz.View.MakeupDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Makeup Detail</h1>

    <div>
        <div>
            <asp:Label ID="NameLabel" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <asp:Label ID="PriceLabel" runat="server" Text="Label"></asp:Label>
        </div>

        <asp:Panel ID="CustomerPanel" runat="server" Visible="false">
            <div>
                Quantity
                <asp:TextBox ID="QuantityTextBox" runat="server" TextMode="Number"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="StatusLabel" runat="server" Text=""></asp:Label>
            </div>
            <asp:Button ID="AddToCartButton" runat="server" Text="Add to Cart" OnClick="AddToCartButton_Click" />
        </asp:Panel>
    </div>

</asp:Content>
