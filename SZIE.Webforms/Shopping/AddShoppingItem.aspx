<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddShoppingItem.aspx.cs" Inherits="WebApplication4.Shopping.AddShoppingItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:DropDownList ID="ddlOcc" runat="server"></asp:DropDownList>
        <asp:DropDownList ID="ddlPlace" runat="server"></asp:DropDownList>
    </p>
    <p>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtUnit" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Add" OnClick="btnSubmit_Click" />

        <asp:Literal ID="ltrResult" runat="server"></asp:Literal>
    </p>
</asp:Content>
