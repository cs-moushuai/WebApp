<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="WebApp.Administrator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
		div .main {
			height: 200px;
			width:200px;
			background-color: #dea46b;
			text-align: center; 
			line-height: 200px;/*文字水平居中*/
			margin:auto;/*div水平居中*/
		}
    </style>
</head>
<body>
    <form id="UpdateForm" runat="server">
        <div class="main">
            <h1>信息显示</h1>
            <div>
                部门选择：
                <asp:DropDownList ID="DepartmentDDL" runat="server">
                </asp:DropDownList>
                <asp:Button ID="QueryBtn" runat="server" Text="查看" onclick="QueryBtn_Click"/>
            </div>
            <div>
                <div>
                    <h2>部门员工信息</h2>
                    <asp:Label ID="Cnt" runat="server"></asp:Label>
                </div>
                <asp:GridView ID="DepartmentInfo" runat="server" BackColor="White" BorderColor="#999999"  
                    BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">  
                    <AlternatingRowStyle BackColor="#DCDCDC" />  
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />  
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />  
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />  
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />  
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />  
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />  
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />  
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />  
                    <SortedDescendingHeaderStyle BackColor="#000065" />  
                </asp:GridView> 
                <asp:Label ID="Result" runat="server"></asp:Label>
            </div>
            <asp:Button ID="ShowAllBtn" runat="server" Text="显示所有员工" onclick="ShowAllBtn_Click"/>
        </div>
            
    </form>
</body>
</html>
