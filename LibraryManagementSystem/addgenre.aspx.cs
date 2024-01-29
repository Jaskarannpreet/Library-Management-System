using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace LibraryManagementSystem
{
    public partial class addgenre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataAccess dataAccess = new DataAccess();
            //DataSet dataSet = dataAccess.GetData();
            //DataTable BooksDetails = dataSet.Tables["Table6"];




            //index index = new index();
            //index.DataAccess dataAccess = new index.DataAccess;
            //dataAccess

            LibraryManagementSystem.index.DataAccess dataAccess = new LibraryManagementSystem.index.DataAccess();
            DataSet dataSet = dataAccess.GetData();
            DataTable BookType = dataSet.Tables["Table4"];
            GridView1.DataSource = BookType;
            GridView1.DataBind();
            ViewState["dirState"] = BookType;
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

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertIntoGenre", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string GenreType = BookGenre.Value;
                string Email = HttpContext.Current.Session["Email"].ToString();
                DateTime Date = DateTime.Now;
                cmd.Parameters.AddWithValue("@GenreType", GenreType);
                cmd.Parameters.AddWithValue("@CreatedBy", Email);
                cmd.Parameters.AddWithValue("@CreatedDate", Date);
               

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LibraryManagementSystem.index.DataAccess dataAccess = new LibraryManagementSystem.index.DataAccess();
                DataSet dataSet = dataAccess.GetData();
                DataTable BookType = dataSet.Tables["Table4"];
                GridView1.DataSource = BookType;
                GridView1.DataBind();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //DataSet dataSet = new DataSet();
                //da.Fill(dataSet);
                //con.Close();
                //return dataSet;

            }
        }
    }
}