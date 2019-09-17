<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddFish.aspx.cs" Inherits="FishBait2.Members.AddFish" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" Width="100%">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Type of Fish:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtType" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Lenght:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLength" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Weight:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Date Caught:"></asp:Label>
                </td>
                <td>
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    <%--<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>--%>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Boat Using:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddBoat" runat="server"></asp:DropDownList>
                    <%--<asp:TextBox ID="txtBoat" runat="server"></asp:TextBox>--%>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Location:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Notes:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNotes" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
