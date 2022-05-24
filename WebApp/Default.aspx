<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            text-align: center;
        }
        .hint
        {
        }
    </style>
</head>
<body>
    <div align="center">
        <form id="form1" runat="server">
            <div>
                <div style="display: inline-block">
                    <span class="hint">用户名：</span>
                    <br/>
                    <span class="hint">密码: </span>
                </div>
                <div style="display: inline-block">
                    <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
                    <br/>
                    <asp:TextBox ID="PswTxt" runat="server" TextMode="Password"></asp:TextBox>
                </div>
            </div>
        
            <br />
            <asp:Button ID="LoginBtn" runat="server" onclick="LoginBtn_Click" Text="登录" />
            <asp:Button ID="RegBtn" runat="server" onclick="RegBtn_Click" Text="注册" />
        </form>
        
    </div>
    
</body>
</html>
