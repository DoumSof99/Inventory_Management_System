using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=InventoryManagementSystem;Trusted_Connection=True");    

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            FillCategpry();
            Populate();
            ResetFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTb values('" + ctrlId.Text + "', '" + ctrlName.Text + "', '" + ctrlQuantity.Text + "', '" + ctrlPrice.Text + "', '" + ctrlDescription.Text + "', '" + ctrlCatCombo.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTb set ProdName='" + ctrlName.Text + "',ProdQty='" + ctrlQuantity.Text + "' ,ProdPrice='" + ctrlPrice.Text + "' ,ProdDesc='" + ctrlDescription.Text + "' ,ProdCat='" + ctrlCatCombo.SelectedValue.ToString() + "' where ProdId='" + ctrlId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ctrlId.Text == "ProductId")
            {
                MessageBox.Show("Enter the Product Id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductTb where ProdId='" + ctrlId.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                Populate();
                ResetFields();
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
                ctrlCatCombo.ValueMember = "CatName";
                ctrlCatCombo.DataSource = dt;
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

        private void Populate()
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

        private void ResetFields()
        {
            ctrlId.Text = "ProductId";
            ctrlName.Text = "ProductName";
            ctrlQuantity.Text = "ProductQty";
            ctrlPrice.Text = "ProductPrice";
            ctrlDescription.Text = "Description";
        }

        private void gridViewProducts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ctrlId.Text = gridViewProducts.GetFocusedRowCellValue("ProdId").ToString();
            ctrlName.Text = gridViewProducts.GetFocusedRowCellValue("ProdName").ToString();
            ctrlQuantity.Text = gridViewProducts.GetFocusedRowCellValue("ProdQty").ToString();
            ctrlPrice.Text = gridViewProducts.GetFocusedRowCellValue("ProdPrice").ToString();
            ctrlDescription.Text = gridViewProducts.GetFocusedRowCellValue("ProdDesc").ToString();
            ctrlCatCombo.SelectedValue = gridViewProducts.GetFocusedRowCellValue("ProdCat").ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
