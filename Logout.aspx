<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Logout.aspx.cs" Inherits="Logout" %>

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
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Naushad_Software@yahoo.com"></asp:Label>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Logout" onclick="Button1_Click" />
        </td>
        </tr>
        <tr>
        <td>
            <asp:HyperLink ID="HyperLink1" runat="server" 
                NavigateUrl="~/ChangePassword.aspx">ChangePassword</asp:HyperLink></td>
                <td>
                   <asp:HyperLink ID="HyperLink2" runat="server" 
                NavigateUrl="~/AddAdmin.aspx">AddAdmin</asp:HyperLink></td>
                </td>
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
