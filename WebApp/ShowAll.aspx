<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAll.aspx.cs" Inherits="WebApp.ShowAll" %>

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
            <asp:GridView ID="EmployeeInfo" runat="server" BackColor="White" BorderColor="#999999"  
                BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" 
                pagesize="5" allowpaging="true" OnPageIndexChanging="OnPageIndexChanging"
                AutoGenerateSelectButton="True">  
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
        </div>
            
    </form>
</body>
</html>
