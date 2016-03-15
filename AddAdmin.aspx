<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddAdmin.aspx.cs" Inherits="AddAdmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <table>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td colspan="2">
                                <h1>
                                    Add Admin
                                </h1>
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
                            <tr>
                                <td>
                                    Password
                                </td>
                                <td>
                                    <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </tr>
                        <tr>
                            <td>
                                ConfromPassword
                            </td>
                            <td>
                                <asp:TextBox ID="txt_confrompasword" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Role
                            </td>
                            <td>
                                <asp:DropDownList ID="ddl_role" runat="server">
                                    <asp:ListItem>--Select--</asp:ListItem>
                                    <asp:ListItem>User</asp:ListItem>
                                    <asp:ListItem>Admin</asp:ListItem>
                                    <asp:ListItem>Employee</asp:ListItem>
                                    <asp:ListItem>Super Admin</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Button ID="btn_submit" runat="server" Text="Submit" OnClick="btn_submit_Click" />
                                <asp:Button ID="btn_cancel" runat="server" Text="Cancel" OnClick="btn_cancel_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true"
                                PageSize="5" DataKeyNames="code">
                                <Columns>
                                <asp:CommandField HeaderText="Delete" ShowDeleteButton="true" ButtonType="Link" />
                                    <asp:BoundField HeaderText="UserName" DataField="username" />
                                    <asp:BoundField HeaderText="Role" DataField="role" />
                                </Columns>
                            </asp:GridView>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
