using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagementSystem
{
    public partial class issuedbooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LibraryManagementSystem.index.DataAccess dataAccess = new LibraryManagementSystem.index.DataAccess();
            DataSet dataSet = dataAccess.GetData();
            DataTable IssuedBkkos = dataSet.Tables["Table7"];
            GridView1.DataSource = IssuedBkkos;
            GridView1.DataBind();
            ViewState["dirState"] = IssuedBkkos;
            ViewState["sortdr"] = "Asc";
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
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