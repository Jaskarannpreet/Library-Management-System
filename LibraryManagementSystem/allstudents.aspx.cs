using System;
using System.Data;

namespace LibraryManagementSystem
{
    public partial class allstudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LibraryManagementSystem.index.DataAccess dataAccess = new LibraryManagementSystem.index.DataAccess();
            DataSet dataSet = dataAccess.GetData();
            DataTable AddBook = dataSet.Tables["Table1"];
            GridView1.DataSource = AddBook;
            GridView1.DataBind();
        }
    }
}