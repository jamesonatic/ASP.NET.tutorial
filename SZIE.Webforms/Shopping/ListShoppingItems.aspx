<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListShoppingItems.aspx.cs" Inherits="WebApplication4.Shopping.ListShoppingItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <p>
        SQL Data Source, generated <br />
        <asp:DropDownList ID="ddlSelectedDate1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Date" DataValueField="ShoppinOccasionID" AutoPostBack="True" OnSelectedIndexChanged="ddlSelectedDate1_SelectedIndexChanged"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [ShoppinOccasionID], [Date] FROM [ShoppingOccation]"></asp:SqlDataSource>
        <br />

        SQL Data Source, custom query <br />
        <asp:DropDownList ID="ddlSelectedDate2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Date" DataValueField="ShoppinOccasionID"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT ShoppinOccasionID, Date FROM ShoppingOccation WHERE (GETDATE() &lt; Date) ORDER BY Date"></asp:SqlDataSource>
        <br />

        Code behind, existing data source <br />
        <asp:DropDownList ID="ddlSelectedDate3" runat="server" AutoPostBack="True"></asp:DropDownList>
        <br />

        Object <br />
        <asp:DropDownList ID="ddlSelectedDate4" runat="server" DataSourceID="ObjectDataSource1" DataTextField="Text" DataValueField="Value" AutoPostBack="True" OnSelectedIndexChanged="ddlSelectedDate4_SelectedIndexChanged"></asp:DropDownList>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetFutureShoppingOccs" TypeName="WebApplication4.App_Code.ShoppingQueries"></asp:ObjectDataSource>
    </p>


    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="listItemsDataSource">
            <Columns>
                <asp:BoundField DataField="ShoppingItemID" HeaderText="ShoppingItemID" SortExpression="ShoppingItemID" />
                <asp:BoundField DataField="ItemName" HeaderText="Item Name" SortExpression="ItemName" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:BoundField DataField="Unit" HeaderText="Unit" SortExpression="Unit" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="listItemsDataSource" runat="server" SelectMethod="GetShoppingItems" TypeName="WebApplication4.App_Code.ShoppingQueries">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlSelectedDate4" Name="ID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
    <p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:BoundField DataField="ShoppingItemName" HeaderText="ShoppingItemName" SortExpression="ShoppingItemName" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                <asp:BoundField DataField="Unit" HeaderText="Unit" SortExpression="Unit" />
                <asp:BoundField DataField="ShoppingPlaceName" HeaderText="ShoppingPlaceName" SortExpression="ShoppingPlaceName" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetShoppingItemsViewModel" TypeName="WebApplication4.App_Code.ShoppingQueries">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlSelectedDate1" Name="ID" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
</asp:Content>
