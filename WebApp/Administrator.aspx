<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrator.aspx.cs" Inherits="WebApp.Administrator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="UpdateForm" runat="server">
    <div>
    
        <table style="width: 100%; height: 329px;">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    信息显示</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    部门选择：</td>
                <td>
                    <asp:DropDownList ID="DepartmentDDL" runat="server">
                    </asp:DropDownList>
                <td>
                    <asp:Button ID="QueryBtn" runat="server" Text="查看" onclick="QueryBtn_Click"/>
                </td>
            </tr>
                        <tr>
                <td>
                    &nbsp;</td>
                <td>
                    部门员工信息</td>
                <td>
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
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
