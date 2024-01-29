using System;
using System.Data;

namespace LibraryManagementSystem
{
    public partial class addstudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LibraryManagementSystem.index.DataAccess dataAccess = new LibraryManagementSystem.index.DataAccess();
            DataSet dataSet = dataAccess.GetData();
            DataTable AddStudent = dataSet.Tables["Table1"];
            GridView1.DataSource = AddStudent;
            GridView1.DataBind();
            ViewState["dirState"] = AddStudent;
            ViewState["sortdr"] = "Asc";
        }

        protected void GridView1_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            DataTable dtrslt = (DataTable)ViewState["dirState"];
            if (dtrslt.Rows.Count > 0)
            {
                if (Convert.ToString(ViewState["sortdr"]) == "Asc")
                {
                    dtrslt.DefaultView.Sort = e.SortExpression + " Desc";
                    ViewState["sortdr"] = "Desc";
                }
                else
                {
                    dtrslt.DefaultView.Sort = e.SortExpression + " Asc";
                    ViewState["sortdr"] = "Asc";
                }
                GridView1.DataSource = dtrslt;
                GridView1.DataBind();
            }
        }
    }
}