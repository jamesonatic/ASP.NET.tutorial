<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="WebApplication4.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Hello World!</h1>
    <p>
        Tényleg működik?
    </p>
    <asp:DropDownList ID="ddl1" runat="server"></asp:DropDownList>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
</asp:Content>
