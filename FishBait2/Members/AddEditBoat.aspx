<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEditBoat.aspx.cs" Inherits="FishBait2.Members.AddEditBoat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Manufacturer:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMfg" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Model:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Name:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Hull #:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHullNum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="Boat size:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSize" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Powered by:"></asp:Label>
                </td>
                <td>
                    <asp:CheckBoxList ID="cbPowerType" runat="server" OnInit="cbPowerType_Init"></asp:CheckBoxList>
                    <%--<asp:DropDownList ID="cbPowerType" runat="server" OnInit="cbPowerType_Init"></asp:DropDownList>--%>
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
