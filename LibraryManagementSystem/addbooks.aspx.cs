using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace LibraryManagementSystem
{
    public partial class addbooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LibraryManagementSystem.index.DataAccess dataAccess = new LibraryManagementSystem.index.DataAccess();
            DataSet dataSet = dataAccess.GetData();
            DataTable AddBook = dataSet.Tables["Table6"];
            GridView1.DataSource = AddBook;
            GridView1.DataBind();
            ViewState["dirState"] = AddBook;
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

        protected void AddBook_Click(object sender, EventArgs e)
        {

        }

        protected void AddBook_Click1(object sender, EventArgs e)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertIntoBooksDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string booktitle = BookTitle.Value;
                string author = Author.Value;
                string publisher = Publisher.Value;
                string publisheddate = PublishedDate.Value;
                string edition = Edition.Value;
                string language = Language.Value;
                string volume = Volume.Value;
                string noofbooks = NoOfBooks.Value;
                string description = Description.Value;

                string Email = HttpContext.Current.Session["Email"].ToString();
                DateTime Date = DateTime.Now;

                cmd.Parameters.AddWithValue("@BookTitle", booktitle);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@Publisher", publisher);
                cmd.Parameters.AddWithValue("@PublishedDate", publisheddate);
                cmd.Parameters.AddWithValue("@Edition", edition);
                cmd.Parameters.AddWithValue("@Language", language);
                cmd.Parameters.AddWithValue("@Volume", volume);
                cmd.Parameters.AddWithValue("@NoOfBooks", noofbooks);
                cmd.Parameters.AddWithValue("@Description", description);

                cmd.Parameters.AddWithValue("@CreatedBy", Email);
                cmd.Parameters.AddWithValue("@CreatedDate", Date);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                LibraryManagementSystem.index.DataAccess dataAccess = new LibraryManagementSystem.index.DataAccess();
                DataSet dataSet = dataAccess.GetData();
                DataTable BookType = dataSet.Tables["Table6"];
                GridView1.DataSource = BookType;
                GridView1.DataBind();
            }
        }
    }
}