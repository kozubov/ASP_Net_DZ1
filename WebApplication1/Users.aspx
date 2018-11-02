<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="WebApplication1.Users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="style.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Cuprum:400,400i,700,700i&amp;subset=cyrillic" rel="stylesheet"/>
    <title>Users List</title>
</head>
<body>
    <div class="title_form"><span>Users</span> List</div>
    <form class="form_list" id="form1" runat="server">
        <div>
            <asp:Table ID="User_List" runat="server">
                <asp:TableRow CssClass="rows">
                    <asp:TableCell runat="server">Id</asp:TableCell>
                    <asp:TableCell runat="server">Login</asp:TableCell>
                    <asp:TableCell runat="server">Password</asp:TableCell>
                    <asp:TableCell runat="server">Role</asp:TableCell>
                    <asp:TableCell runat="server">Edit</asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <asp:HyperLink CssClass="button_back" ID="HyperLink2" runat="server">Back To Users Form</asp:HyperLink>
    </form>
</body>
</html>
