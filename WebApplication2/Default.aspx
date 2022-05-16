<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            text-align: center;
        }
        .style2
        {
            height: 24px;
        }
    </style>
</head>
<body>
    <div align="center">
    <form id="form1" runat="server">
        <div style="display: inline-block;">
            用户名：<br />
            密码：
        </div>
        <div style="display: inline-block;">
            <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="PswTxt" runat="server" TextMode="Password"></asp:TextBox>
        </div>
    
    <br />
    <asp:Button ID="LoginBtn" runat="server" onclick="LoginBtn_Click" Text="登录" />
    <asp:Button ID="ExitBtn" runat="server" onclick="ExitBtn_Click" Text="注册" />
    
    
    <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                个人信息</td>
        </tr>
        <tr>
            <td class="style2" style="text-align: right">
                输入数据：</td>
            <td class="style2">
                <asp:TextBox ID="InputData" runat="server" AutoPostBack="True" 
                    BorderStyle="Double"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2" style="text-align: right">
                结果：</td>
            <td class="style2">
                <asp:Label ID="Result" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2">
            </td>
            <td class="style2">
                <asp:Button ID="CountBtn" runat="server" onclick="CountBtn_Click" Text="计算" />
            </td>
        </tr>
    </table>
    </form>
    
    </div>
    个人信息：<asp:Label ID="Lblinfo" runat="server"></asp:Label>
    
</body>
</html>
