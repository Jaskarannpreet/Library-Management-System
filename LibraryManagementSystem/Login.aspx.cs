using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Services;
using System.Web.SessionState;

namespace LibraryManagementSystem
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{ 
        //    if (Email.Text != string.Empty || Password.Text != string.Empty || admin.text )
        //}
        //public class DataAccess
        //{
        //    public DataSet GetData()
        //    {
        //        string connectionString = ConfigurationManager.ConnectionStrings["crud"].ConnectionString;
        //        CommandType comand;
        //        using (SqlConnection conn = new SqlConnection(connectionString))

        //        {
        //            SqlCommand cmd = new SqlCommand("sp_ValidateLogin", conn);
        //            comand = cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@Email", UserEmail);
        //            cmd.Parameters.AddWithValue("@Password", UserPassward);
        //            cmd.Parameters.AddWithValue("@UserType", UserType);
        //            conn.Open();
        //            // Bind data to controls or use it as needed
        //            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //            DataSet dataSet = new DataSet();
        //            adapter.Fill(dataSet);
        //            return dataSet;
        //        }

        //    }
        //}
        
        [WebMethod]
        public static bool ValidateLogin(string UserType, string UserEmail, string UserPassward)
        {
            
            string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem"].ConnectionString;
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ValidateLogin", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", UserEmail);
                cmd.Parameters.AddWithValue("@Password", UserPassward);
                cmd.Parameters.AddWithValue("@UserType", UserType);
                conn.Open();
                //SqlDataReader reader = cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                conn.Close();
                if (ds.Tables.Count > 0)
                {
                    HttpContext.Current.Session["Email"] = UserEmail;
                    using (DataTable UserOwnDetails = ds.Tables["Table"])
                    foreach (DataRow row in UserOwnDetails.Rows)
                        {
                            if (row["Email"].ToString() == UserEmail)
                            {
                                HttpContext.Current.Session["UserID"] = row["UserID"].ToString();
                            }
                        }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



        //[WebMethod]
        //public static string ValidateLogin(string UserType, string UserEmail, string UserPassward)
        //{
        //string msg = "";


        //    {
        //    string connectionString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem"].ConnectionString;

        //    using (SqlConnection conn = new SqlConnection(connectionString))

        //    {
        //        SqlCommand cmd = new SqlCommand("sp_ValidateLogin", conn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@Email", UserEmail);
        //        cmd.Parameters.AddWithValue("@Password", UserPassward);
        //        cmd.Parameters.AddWithValue("@UserType", UserType);
        //        conn.Open();
        //        // Bind data to controls or use it as needed
        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        DataSet dataSet = new DataSet();
        //        adapter.Fill(dataSet);
        //        conn.Close();
        //        SqlDataReader sdr = cmd.ExecuteReader();
        //        if (sdr.Read())
        //        {
        //            Label1.Text = "loginseccuseeful"
        //        }
        //        else
        //        {
        //            msg = "false";
        //        }

        //    }
        //    return msg;

        //    }



        //}


    }    
}