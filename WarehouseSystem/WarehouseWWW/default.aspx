<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WarehouseWWW._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="style.css" />
    <title>Warehouse system</title>
</head>
<body>
    <form id="form1" runat="server">

    <div class="container">    
        <h2> Available articles</h2>
        <!-- Creating table with available articles-->
        <asp:GridView ID="gridView" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="dataSource" CssClass="tableView" HeaderStyle-CssClass="tableHeader" BorderStyle="None">
            <Columns>
                <asp:BoundField DataField="Code" HeaderText="Code" SortExpression="Code" ItemStyle-CssClass="colTbl" >
<ItemStyle CssClass="colTbl"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" ItemStyle-CssClass="colTbl" >
<ItemStyle CssClass="colTbl"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Expiry date" HeaderText="Expiry date" SortExpression="Expiry date" ItemStyle-CssClass="colTbl" >
<ItemStyle CssClass="colTbl"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Article type" HeaderText="Article type" SortExpression="Article type" ItemStyle-CssClass="colTbl" >
<ItemStyle CssClass="colTbl"></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" ItemStyle-CssClass="colTbl" >
<ItemStyle CssClass="colTbl"></ItemStyle>
                </asp:BoundField>
            </Columns>
            <HeaderStyle BackColor="#DFDFDF" CssClass="tableHeader" />
        </asp:GridView>
        <asp:SqlDataSource ID="dataSource" runat="server" ConnectionString="<%$ ConnectionStrings:warehouse_dbConnectionString %>" SelectCommand="Select Code, Name, Garantee_expiry_date as 'Expiry date', Type as 'Article type', Amount from Articles"></asp:SqlDataSource>
     </div>

        <hr />

        <div class="container">
            <h2>Create order</h2>
            <!-- Creating form to create order-->
            <ul>
                <li>
                    <asp:Label ID="orderDateLbl" runat="server" Text="Date: " ></asp:Label>
                    <asp:ImageButton ID="calenderImgBtn" runat="server" Height="32px" ImageUrl="~/calendar.ico" OnClick="calenderImgBtn_Click" Width="32px" />
                    <asp:Calendar ID="orderDateCal" runat="server" class="calendar" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="32px" Width="32px" OnSelectionChanged="orderDateCal_SelectionChanged" Visible="False">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                    </asp:Calendar>
                </li>
                <li>
                <asp:Label ID="nameLbl" runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="nameTxtBx" runat="server" CssClass="inBxStyle"></asp:TextBox>
                </li>
                <li>
                <asp:Label ID="surnameLbl" runat="server" Text="Surname: "></asp:Label>
                <asp:TextBox ID="surnameTxtBx" runat="server" CssClass="inBxStyle"></asp:TextBox>
                </li>
                <li>
                <asp:Label ID="addressLbl" runat="server" Text="Name: "></asp:Label>
                <asp:TextBox ID="addressTxtBx" runat="server" CssClass="inBxStyle"></asp:TextBox>
                </li>
                <li>
                <asp:Label ID="articleCodeLbl" runat="server" Text="Article code: "></asp:Label>
                <asp:DropDownList ID="articleCmbBx" runat="server" DataSourceID="articleCodeDataSrc" DataTextField="Article code" DataValueField="Article code" CssClass="inBxStyle"></asp:DropDownList>
                <asp:SqlDataSource ID="articleCodeDataSrc" runat="server" ConnectionString="<%$ ConnectionStrings:warehouse_dbConnectionString %>" SelectCommand="selectArticlesCode" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
                </li>
                <li>
                <asp:Label ID="articleAmountLbl" runat="server" Text="Article amount: "></asp:Label>
                <asp:TextBox ID="articleAmountTxtBx" runat="server" CssClass="inBxStyle"></asp:TextBox>
                </li>
                <li>
                <asp:Label ID="deliveryWayLbl" runat="server" Text="Delivery way: "></asp:Label>
                <asp:TextBox ID="deliveryWayTxtBx" runat="server" CssClass="inBxStyle"></asp:TextBox>
                </li>
                <li>
                    <asp:Button ID="saveBtn" runat="server" Text="Save order" Height="34px" OnClick="saveBtn_Click" Width="116px" />
                </li>
            </ul>
        </div>
    </form>
</body>
</html>

