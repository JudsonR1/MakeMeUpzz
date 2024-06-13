<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="MakeMeUpzz.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Cart</h1>

    <asp:GridView ID="CartGridView" runat="server" 
        AutoGenerateColumns="false" 
        DataKeyNames="MakeupId"
        OnSelectedIndexChanged="CartGridView_SelectedIndexChanged"
        OnRowDeleting="CartGridView_RowDeleting">
        <Columns>
            <asp:BoundField DataField="MakeupId" HeaderText="Id" Visible="false" />
            <asp:BoundField DataField="MakeupName" HeaderText="Name" />
            <asp:BoundField DataField="MakeupPrice" HeaderText="Price" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />

            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Update" />
            <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Remove" />
        </Columns>

    </asp:GridView>

    <div>
        <asp:Label ID="CartIsEmptyLabel" runat="server" Text="Cart is Empty" Visible="false"></asp:Label>
        <asp:Button ID="CheckOutButton" runat="server" Text="Check Out" OnClick="CheckOutButton_Click" />
    </div>

</asp:Content>
