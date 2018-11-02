using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Users : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.HyperLink2.NavigateUrl = "Default.aspx";
            Create_Table();
        }
        public void Create_Table()
        {
            Singleton single = Singleton.Get_singleton();
            foreach (User VARIABLE in single.Get_users())
            {
                TableRow row = new TableRow();

                TableCell cell = new TableCell();
                cell.Text = VARIABLE.Id.ToString();
                row.Cells.Add(cell);

                TableCell cell1 = new TableCell();
                cell1.Text = VARIABLE.Login;
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = VARIABLE.Password;
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = VARIABLE.Get_role().Role_type;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();          
                LinkButton link2 = new LinkButton();
                link2.Text = "Delete";
                link2.CssClass = "button_delete";
                link2.PostBackUrl = $"Delete.ashx?id={VARIABLE.Id}";
                cell4.Controls.Add(link2);
                row.Cells.Add(cell4);
                User_List.Rows.Add(row);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Singleton single = Singleton.Get_singleton();
            for (int i = 0; i < single.Get_users().Count; i++)
            {
                if ((sender as Button).ID.Equals(single.Get_users()[i].Id.ToString()))
                {
                    single.Remove_user(i);
                    break;
                }
            }
            for (int j = 1; j < User_List.Rows.Count; j++)
            {
                User_List.Rows.RemoveAt(j);
                j--;
            }            
            Create_Table();
        }
    }
}