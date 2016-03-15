<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registarion.aspx.cs" Inherits="Registarion" %>

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
        Registarion
        </td>
        </tr>
            <tr>
                <td>
                    Name
                </td>
                <td>
                    <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    SurName
                </td>
                <td>
                    <asp:TextBox ID="txt_surname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    UserName
                </td>
                <td>
                    <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password
                </td>
                <td>
                    <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td>
            EmailID
            </td>
            <td>
                <asp:TextBox ID="txt_emailid" runat="server"></asp:TextBox>
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
            <tr>
            <td colspan="2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" 
                    AllowPaging="true" PageSize="5" DataKeyNames="code" 
                    onpageindexchanging="GridView1_PageIndexChanging">
                <Columns>
                <asp:BoundField HeaderText="Name" DataField="name" />
                <asp:BoundField HeaderText="SurName" DataField="surname" />
                <asp:BoundField HeaderText="UserName" DataField="username" />
                <asp:BoundField HeaderText="password" DataField="password" />
                <asp:BoundField HeaderText="Emailid" DataField="emailid" />
                <asp:BoundField HeaderText="MobileNo" DataField="mobileno" />
                </Columns>
                </asp:GridView>
            </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
