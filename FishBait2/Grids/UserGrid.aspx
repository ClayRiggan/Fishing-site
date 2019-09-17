<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserGrid.aspx.cs" Inherits="FishBait2.Grids.UserGrid" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="panel1" runat="server">
        <asp:GridView ID="CurrentUserGrid" runat="server">

            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="First Name" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="State" HeaderText="State" />
            </Columns>

        </asp:GridView>
    </asp:Panel>
</asp:Content>
