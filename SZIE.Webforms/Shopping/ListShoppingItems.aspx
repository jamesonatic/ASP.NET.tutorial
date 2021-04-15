<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListShoppingItems.aspx.cs" Inherits="WebApplication4.Shopping.ListShoppingItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <p>
        SQL Data Source, generated <br />
        <asp:DropDownList ID="ddlSelectedDate1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Date" DataValueField="ShoppinOccasionID"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ShoppinOccasionID], [Date] FROM [ShoppingOccation]"></asp:SqlDataSource>
        <br />

        SQL Data Source, custom query <br />
        <asp:DropDownList ID="ddlSelectedDate2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Date" DataValueField="ShoppinOccasionID"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT ShoppinOccasionID, Date FROM ShoppingOccation WHERE (GETDATE() &lt; Date) ORDER BY Date"></asp:SqlDataSource>
        <br />

        Code behind, existing data source <br />
        <asp:DropDownList ID="ddlSelectedDate3" runat="server"></asp:DropDownList>
        <br />

        Object <br />
        <asp:DropDownList ID="ddlSelectedDate4" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Text" DataValueField="Value"></asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetFutureShoppingOccs" TypeName="WebApplication4.App_Code.ShoppingQueries"></asp:ObjectDataSource>
    </p>
    <p>

    </p>
</asp:Content>
