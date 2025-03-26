using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;


namespace Week9Disconnected
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Data data = new Data();
        private CrudOperationsInDataSet crud = new CrudOperationsInDataSet();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnLoadAllProducts_Click(object sender, RoutedEventArgs e)
        {
            grdProducts.ItemsSource = data.GetAllProducts().DefaultView;
        }

        private void btnShowWindow2_Click(object sender, RoutedEventArgs e)
        {
            DataSetWithMultipleTables win2 = new DataSetWithMultipleTables();
            win2.Show();
        }


        private void btnFind_Click(object sender,RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            DataRow row = crud.GetProductById(id);
            if (row != null)
            {
                txtName.Text = row["ProductName"].ToString();
                txtPrice.Text = row["UnitPrice"].ToString();
                txtQuantity.Text = row["UnitsInStock"].ToString();
            }
            else
                MessageBox.Show("Invalid Product ID. Please try again.");
        }

        private void btnInsert_Click(object sender,RoutedEventArgs e)
        {
            string name = txtName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            short quantity = short.Parse(txtQuantity.Text);
            crud.InsertProduct(name, price, quantity);
            grdProducts.ItemsSource = crud.GetAllProducts().DefaultView;
        }

        private void btnUpdate_Click(object sender,RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string name = txtName.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            short quantity = short.Parse(txtQuantity.Text);
            crud.UpdateProduct(id, name, price, quantity);
            grdProducts.ItemsSource = crud.GetAllProducts().DefaultView;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            crud.DeleteProduct(id);
            grdProducts.ItemsSource = crud.GetAllProducts().DefaultView;
        }

        private void btnClearData_Click(object sender, RoutedEventArgs e)
        {
            grdProducts.ItemsSource = null;
        }


    }

    public partial class DataSetWithMultipleTables : Window

    {
        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conn = new SqlConnection(Data.ConnectionString);
            string query = "Select * from Categories; Select * from Products";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable tblCategories = ds.Tables[0];
            DataTable tblProducts = ds.Tables[1];
            grdCategories.ItemsSource = tblCategories.DefaultView;
            grdProducts.ItemsSource = tblProducts.DefaultView;
        }
    }
}
