using Activity3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Activity3.Services.Data
{
    public class SecurityDAO
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;initial catalog=Test ;Integrated Security=True;";
        public bool FindByUser(UserModel user)
        {

            // SqlConnection conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["connString"].ConnectionString);
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand sql = new SqlCommand("SELECT * FROM [Users] WHERE USERNAME = @User  AND PASSWORD = @Pass", conn);

            conn.Open();

            SqlDataReader read = sql.ExecuteReader();

            if (read.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}