using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Week9Disconnected
{
    public class CrudOperationsInDataSet
    {


        private DataSet ds;
        private SqlDataAdapter adapter;
        private DataTable tblProducts;
        private SqlCommandBuilder cmdBuilder;
        private SqlConnection conn;
        private Data data = new Data();

        public CrudOperationsInDataSet()
        {
            FillDataSet(); ;
        }


        private void FillDataSet()
        {

            conn = new SqlConnection(Data.ConnectionString);
            string query = "Select ProductID, ProductName, UnitPrice,UnitsInStock from Products";

            adapter = new SqlDataAdapter(query, conn);
            ds = new DataSet();

            adapter.Fill(ds, "Products");
            tblProducts = ds.Tables["Products"];

            cmdBuilder = new SqlCommandBuilder(adapter);
            // reset the dataset
            // define primary key

            DataColumn[] pk = new DataColumn[1];
            pk[0] = tblProducts.Columns["ProductID"];
            pk[0].AutoIncrement = true;
            tblProducts.PrimaryKey = pk;
        }


        public DataTable GetAllProducts()
        {
            FillDataSet();
            return tblProducts;
        }

        public DataRow GetProductById(int id)
        {
            // find a row based on its primary key

            DataRow row = tblProducts.Rows.Find(id);
            return row;
        }


public void InsertProduct(string name, decimal price, short quantity)
        {
            try
            {
                DataRow newRow = tblProducts.NewRow();
                newRow["ProductName"] = name;
                newRow["UnitPrice"] = price;
                newRow["UnitsInStock"] = quantity;

                tblProducts.Rows.Add(newRow);

                adapter.InsertCommand = cmdBuilder.GetInsertCommand();
                adapter.Update(tblProducts);

                Console.WriteLine("Producto insertado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar el producto: {ex.Message}");
            }
        }

        public void UpdateProduct(int id, string name, decimal price, short quantity)
        {
            DataRow row = tblProducts.Rows.Find(id);
            if (row != null)
            {
                row["ProductName"] = name;
                row["UnitPrice"] = price;
                row["UnitsInStock"] = quantity;
                adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
                adapter.Update(tblProducts);
            }
            else {
                Console.WriteLine("Not found.");
            }
        }

        public void DeleteProduct(int id)
        {
            DataRow row = tblProducts.Rows.Find(id);
            row.Delete();
            adapter.DeleteCommand = cmdBuilder.GetDeleteCommand();
            adapter.Update(tblProducts);
        }




    }
}