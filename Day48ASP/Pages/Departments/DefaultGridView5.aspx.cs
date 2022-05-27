using System;


namespace Day48ASP.Pages.Departments
{
    public partial class DefaultGridView5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            SqlDataSource1.Insert();
        }
    }
}