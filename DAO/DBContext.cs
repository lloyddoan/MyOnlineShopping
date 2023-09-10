using System;
using System.Configuration;
using System.Data.SqlClient;

namespace OnlineShop
{
    public class DbContext
    {
        string str = ConfigurationManager.ConnectionStrings["DBContext"].ConnectionString;
        SqlConnection con;
        public DbContext()
        {
            con = new SqlConnection(str);
        }


    }
}
