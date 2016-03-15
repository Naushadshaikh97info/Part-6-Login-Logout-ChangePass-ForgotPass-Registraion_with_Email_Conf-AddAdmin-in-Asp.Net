<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Forgot Password.aspx.cs" Inherits="Forgot_Password" %>

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
    <td colspan="2">
    <h1>Forgot Password</h1>
    </td>
    </tr>
    <tr>
    <td>
    EmailID
    </td>
    <td>
        <asp:TextBox ID="txt_email_id" runat="server"></asp:TextBox>
    </td>
    </tr>
    <tr>
    <td>
    MobileNo
    </td>
    <td>
        <asp:TextBox ID="txt_mobileno" runat="server"></asp:TextBox>
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
