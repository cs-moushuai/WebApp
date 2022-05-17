<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Second.aspx.cs" Inherits="WebApplication2.Second" %>

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
    <form id="form1" runat="server">
    <div>
    
        <table style="width: 100%; height: 329px;">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    用户修改</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    用户名：</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="TextBox1" ErrorMessage="此项必填"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    密码：</td>
                <td class="style2">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="TextBox2" ErrorMessage="此项必填"></asp:RequiredFieldValidator>
                    </td>
                <td class="style2">
                    </td>
            </tr>
            <tr>
                <td>
                    性别：</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                        RepeatDirection="Horizontal" Width="144px">
                        <asp:ListItem Selected="True">男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    年龄：</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="TextBox3" ErrorMessage="范围一定" MaximumValue="150" 
                        MinimumValue="0" Type="Integer"></asp:RangeValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    兴趣爱好：</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" 
                        onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>唱</asp:ListItem>
                        <asp:ListItem>跳</asp:ListItem>
                        <asp:ListItem>Rap</asp:ListItem>
                        <asp:ListItem>篮球</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    照片：</td>
                <td>
                <!--
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="60px" Width="104px" />
                    <asp:FileUpload ID="FileUpload2" runat="server" />-->
                    <asp:FileUpload ID="FileUpload1" runat="server"/>
                    <asp:Button ID="btnUpload" Text="Upload" runat="server" OnClick="UploadFile"/>
                    <hr />
                    <asp:Image ID="Image1" runat="server" Height = "100" Width = "100" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="UpdateBtn" runat="server" Text="更新" onclick="UpdateBtn_Click"/>
                </td>
                <td>
                    <asp:Button ID="QueryBtn" runat="server" Text="查看" onclick="QueryBtn_Click"/>
                </td>
            </tr>
        </table>
    
    </div>
    <table style="width:100%;">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                用户信息</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="LblInfo" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
