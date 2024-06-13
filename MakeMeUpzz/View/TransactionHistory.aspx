<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="MakeMeUpzz.View.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Transaction History</h1>

    <asp:GridView ID="TransactionHistoryGridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="TransactionHistoryGridView_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="TransactionId" HeaderText="Id" />
              <asp:BoundField DataField="TransactionDate" HeaderText="Date" DataFormatString="{0:d}" />
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    
                </ItemTemplate>
            </asp:TemplateField>
            <asp:ButtonField ButtonType="Button" CommandName="Select" Text="Detail" />
        </Columns>
    </asp:GridView>

  
   

</asp:Content>
