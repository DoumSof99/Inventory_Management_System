using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=InventoryManagementSystem;Trusted_Connection=True");

        int num = 0;
        int uprice, totprice, quantity;
        string product;
        private void ManageOrders_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
            PopulateProducts();
            FillCategpry();
        }

        private void PopulateCustomers()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from  CustomerTb";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ctrlCustomers.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void PopulateProducts()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from  ProductTb";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ctrlProducts.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void FillCategpry()
        {
            string query = "select * from CategoryTb";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                ctrlSearchCombo.ValueMember = "CatName";
                ctrlSearchCombo.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void FilterByCategory()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from  ProductTb where ProdCat='" + ctrlSearchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ctrlProducts.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void ctrlId_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void UpadateProduct()
        {
            Con.Open();
            int newQty;
            Con.Close();
        }

        int flag = 0;
        int stock;
        private void gridViewProducts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            product = gridViewProducts.GetFocusedRowCellValue("ProdName").ToString();
            //quantity = Convert.ToInt32(ctrlQuantity.Text);
            stock = Convert.ToInt32(gridViewProducts.GetFocusedRowCellValue("ProdQty").ToString());
            uprice = Convert.ToInt32(gridViewProducts.GetFocusedRowCellValue("ProdPrice").ToString());
            //totprice = quantity * uprice;
            flag = 1;
        }

        DataTable table = new DataTable() {
            Columns = { { "Num" }, { "Product"}, { "Quantity"}, { "UPrice" }, { "TotalPrice" } }
        };

        int sum = 0;
        
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {    
            if (ctrlQuantity.Text == "")
            {
                MessageBox.Show("Enter the quantity of Products");
            } else if(flag == 0)
            {
                MessageBox.Show("Select The Product");
            } 
            else if(Convert.ToInt32(ctrlQuantity.Text) > stock ) {
                MessageBox.Show("Not Enough Stock Available");
            }
            else
            {
                num = num + 1;
                quantity = Convert.ToInt32(ctrlQuantity.Text);
                totprice = quantity * uprice;              
                table.Rows.Add(num, product, quantity, uprice, totprice);
                ctrlOrders.DataSource = table;             
                flag = 0;             
            }
            sum = sum + totprice;
            lblTotalAmount.Text = "Rs" + sum.ToString();
        }

        private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ctrlCustomerId.Text = gridViewCustomers.GetFocusedRowCellValue("CustomerId").ToString();
        }

        private void ctrlSearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();
        }
    }
}
