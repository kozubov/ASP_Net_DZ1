<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="style.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Cuprum:400,400i,700,700i&amp;subset=cyrillic" rel="stylesheet"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.6.0/css/font-awesome.min.css"/>
    <title>User Register Form</title>
</head>
<body>
    <form class="user_form" id="form1" runat="server">
        <div>
            <div class="title_form"><span>Add</span> User Form</div>

            <div class="login_block">
                <i class="fa fa-user" aria-hidden="true"></i>   
                <asp:TextBox CssClass="input_form" ID="TextBox_login" placeholder = "Login" runat="server"></asp:TextBox>
            </div>

            <div class="login_block">
                <i class="fa fa-key" aria-hidden="true"></i>            
                <asp:TextBox CssClass="input_form" ID="TextBox_Password"  placeholder = "Password" runat="server"></asp:TextBox>
            </div>
            <div class="role_block">
                <i class="fa fa-shield" aria-hidden="true"></i>            
                <asp:DropDownList CssClass="select_form" ID="DropDownList_Roles" runat="server">
                    <asp:ListItem Text="User" Value="1" Selected="true" />
                    <asp:ListItem Text="Author" Value="2"  />
                    <asp:ListItem Text="Editor" Value="3"  />
                    <asp:ListItem Text="Administrator" Value="4"  />
                    <asp:ListItem Text="Super User" Value="5" />
                </asp:DropDownList>
            </div>
            <div class="buttons">                
                <asp:Button CssClass="button_add" ID="Button_Add" runat="server" Text="Add User" OnClick="Button_Add_OnClick" />
                <asp:HyperLink CssClass="button_link" ID="HyperLink_ToUsers" runat="server">To Users List</asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
