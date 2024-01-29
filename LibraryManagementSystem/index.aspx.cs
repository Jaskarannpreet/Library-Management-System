using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace LibraryManagementSystem
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            DataSet dataSet = dataAccess.GetData();
            DataTable BooksDetails = dataSet.Tables["Table6"];
            // Bind data to controls or use it as needed
            GridView1.DataSource = BooksDetails;
            GridView1.DataBind();
            ViewState["dirState"] = BooksDetails;
            ViewState["sortdr"] = "Asc";
            DataTable UserOwnDetial = dataSet.Tables["Table"];

            foreach (DataRow row in UserOwnDetial.Rows)
            {
                UserName.InnerText = row["Name"].ToString();
                Contact.InnerText = row["Contact"].ToString();
                DateOfBirth.InnerText = row["DateOfBirth"].ToString();
                Gender.InnerText = row["Gender"].ToString();
            }
            
        }
        public class DataAccess
        {
            public DataSet GetData()
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_RetriveData", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    string UserID = HttpContext.Current.Session["UserID"].ToString();
                    //string UserID = "1";
                    cmd.Parameters.AddWithValue("@UserID", UserID);

                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    da.Fill(dataSet);
                    con.Close();
                    return dataSet;

                }
            }
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