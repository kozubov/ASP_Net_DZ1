using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink_ToUsers.NavigateUrl = "Users.aspx";
        }

        protected void Button_Add_OnClick(object sender, EventArgs e)
        {
            Singleton single = Singleton.Get_singleton();
            single.Set_user(TextBox_login.Text, TextBox_Password.Text, DropDownList_Roles.SelectedItem.Text);
            TextBox_login.Text = null;
            TextBox_Password.Text = null;
        }
    }
}