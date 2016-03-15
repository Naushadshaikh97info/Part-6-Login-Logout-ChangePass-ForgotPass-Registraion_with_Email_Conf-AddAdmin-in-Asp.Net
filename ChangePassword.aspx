<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="ChangePassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    OldPassword
                </td>
                <td>
                    <asp:TextBox ID="txt_oldpassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td>
            NewPassword
            </td>
            <td>
                <asp:TextBox ID="txt_newpassword" runat="server"></asp:TextBox>
            </td>
            </tr>
            <tr>
            <td>
            Conformpassword
            </td>
            <td>
                <asp:TextBox ID="txt_confrompassword" runat="server"></asp:TextBox>
            </td>
            </tr>
            <tr>
            <td colspan="2">
                <asp:Button ID="btn_submit" runat="server" Text="Submit" 
                    onclick="btn_submit_Click" />
            </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
