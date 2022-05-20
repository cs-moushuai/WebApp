<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="WebApp.User" %>

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
                    用户修改</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    用户名：</td>
                <td>
                    <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="NameRequiredFieldValidator" runat="server" 
                        ControlToValidate="NameTxt" ErrorMessage="此项必填"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    密码：</td>
                <td>
                    <asp:TextBox ID="PswTxt" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="PswRequiredFieldValidator" runat="server" 
                        ControlToValidate="PswTxt" ErrorMessage="此项必填"></asp:RequiredFieldValidator>
                    </td>
                <td>
                    </td>
            </tr>
            <tr>
                <td>
                    性别：</td>
                <td>
                    <asp:RadioButtonList ID="SexRL" runat="server" 
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
                    <asp:TextBox ID="AgeTxt" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:RangeValidator ID="AgeRangeValidator" runat="server" 
                        ControlToValidate="AgeTxt" ErrorMessage="范围[0-150]" MaximumValue="150" 
                        MinimumValue="0" Type="Integer"></asp:RangeValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    学院：</td>
                <td>
                    <asp:DropDownList ID="DepartmentDDL" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    兴趣爱好：</td>
                <td>
                    <asp:DropDownList ID="HobbyDDL" runat="server">
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
                    <asp:FileUpload ID="ImgFileUpload" runat="server"/>
                    <asp:Button ID="btnUpload" Text="Upload" runat="server" OnClick="UploadFile" />
                    <hr />
                    <asp:Image ID="Img" runat="server" Height = "100" Width = "100" />
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
