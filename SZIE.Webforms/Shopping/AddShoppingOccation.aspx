<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddShoppingOccation.aspx.cs" Inherits="WebApplication4.Shopping.AddShoppingOccation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <asp:Calendar ID="cndDate" runat="server"></asp:Calendar>
        <asp:TextBox ID="txtDescription" runat="server" Width="319px"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Add" OnClick="btnSubmit_Click" />
        <asp:Literal ID="ltrResult" runat="server"></asp:Literal>


    </p>
</asp:Content>
