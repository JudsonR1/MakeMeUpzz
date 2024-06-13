<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MakeMeUpzz.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>MakeMeUpzz</h1>
  <div>
      <asp:Label ID="Label3" runat="server" Text="Username:"></asp:Label>
      <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
  </div>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Role: "></asp:Label>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    </div>
    <asp:Panel ID="CustomerPanel" runat="server" Visible="false">
        <asp:GridView ID="CustomerGridView" runat="server"
            AutoGenerateColumns="false"
            OnSelectedIndexChanged="CustomerGridView_SelectedIndexChanged"
            DataKeyNames="MakeupId">
            <Columns>
                <asp:BoundField DataField="MakeupId" HeaderText="Id" Visible="false" />
                <asp:BoundField DataField="MakeupName" HeaderText="Name" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Price" /> 
                
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Detail" />
            </Columns>
        </asp:GridView>
    </asp:Panel>

    <asp:Panel ID="AdminPanel" runat="server" Visible="false">
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/View/InsertMakeup.aspx" OnClick="LinkButton1_Click">Insert Makeup</asp:LinkButton>
        <asp:GridView ID="AdminGridView" runat="server" 
            AutoGenerateColumns="False"
            OnSelectedIndexChanged="AdminGridView_SelectedIndexChanged"
            OnRowUpdating="AdminGridView_RowUpdating"
            OnRowDeleting="AdminGridView_RowDeleting"
            DataKeyNames="MakeupId">
            <Columns>
                <asp:BoundField DataField="MakeupId" HeaderText="Id" Visible="false" />
                <asp:BoundField DataField="MakeupName" HeaderText="Name" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Price" /> 
    
                
                <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Detail" />
                <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
            </Columns>
        </asp:GridView>

    

        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    </asp:Panel>

</asp:Content>