using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Week9Disconnected
{
    public class Data
    {
        private static string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                        Initial Catalog=Northwind;
                                        Integrated Security=True";
        public static string ConnectionString { get => connStr; }
        public DataTable GetAllProducts()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            string query = "Select ProductID, ProductName, UnitPrice,UnitsInStock from Products";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Products");
            DataTable tblProducts = ds.Tables["Products"];
            return tblProducts;
        }

    }

}
