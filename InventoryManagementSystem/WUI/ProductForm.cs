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
using DevExpress.Utils;

namespace InventoryManagementSystem {
    public partial class ProductForm : Form {

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-O3H1CKS\SQLCS412_SOFIA;Initial Catalog=Inventorydb;Integrated Security=True");

        public ProductForm() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void ProductForm_Load(object sender, EventArgs e) {
            FillCategory();
            Populate();
            ResetFields();
        }
        private void btnAdd_Click_1(object sender, EventArgs e) {
            AddProduct();
            Populate();
            ResetFields();
        }
        private void btnDelete_Click_1(object sender, EventArgs e) {
            DeleteProduct();
            Populate();
            ResetFields();
        }

        private void btnEdit_Click_1(object sender, EventArgs e) {
            EditProduct();
            Populate();
            ResetFields();
        }

        private void btnSearch_Click_1(object sender, EventArgs e) {
            FilterByCategory();
            ResetFields();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e) {
            Populate();
            ResetFields();
        }
       
        /// <summary>
        /// //////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        private void ResetFields() {
            ctrlName.Text = String.Empty;
            ctrlQuantity.Text = String.Empty;
            ctrlPrice.Text = String.Empty;
            ctrlDescription.Text = String.Empty;
        }

        private void Populate() {
            try {
                Con.Open();
                string MyQuery = "SELECT ProdName, ProdQty, ProdPrice, ProdDesc, ProdCat, Id FROM ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridProducts.DataSource = ds.Tables[0];
                Con.Close();
                gridProducts.Columns["Id"].Visible = false;
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void FillCategory() {

            string Query = "SELECT CatName, Id FROM CategoryTbl";
            SqlCommand cmd = new SqlCommand(Query, Con);
            SqlDataReader rdr;

            try {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                ctrlProdCategory.ValueMember = "CatName";
                ctrlProdCategory.DataSource = dt;
                ctrlSearchComboBox.ValueMember = "CatName";
                ctrlSearchComboBox.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void AddProduct() {

            string prodName = Convert.ToString(ctrlName.Text);
            int prodQty = Convert.ToInt32(ctrlQuantity.Text);
            int prodPrice = Convert.ToInt32(ctrlPrice.Text);
            string prodDesc = Convert.ToString(ctrlDescription.Text);
            string prodCat = Convert.ToString(ctrlProdCategory.SelectedValue.ToString());

            try {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ProductTbl(Id, ProdName, ProdQty, ProdPrice, ProdDesc, ProdCat) VALUES(NEWID(), '" + prodName + "', '" + prodQty + "', '" + prodPrice + "', '" + prodDesc + "', '" + prodCat + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Succesfully Added");
                Con.Close();
                Populate();

            }
            catch (Exception) {

                MessageBox.Show("Something went wrong");
            }
        }

        private void DeleteProduct() {
            try {
                Guid id = Guid.Parse(gridProducts.SelectedRows[0].Cells[5].Value.ToString());

                Con.Open();
                string query = "DELETE FROM ProductTbl WHERE Id = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Succesfully Deleted");
                Con.Close();
                Populate();

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void EditProduct() {
            try {
                Guid id = Guid.Parse(gridProducts.SelectedRows[0].Cells[5].Value.ToString());
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ProductTbl SET ProdName='" + ctrlName.Text + "', ProdQty ='" + ctrlQuantity.Text + "', ProdPrice = '" + ctrlPrice.Text + "', ProdDesc = '" + ctrlDescription.Text + "', ProdCat = '" + ctrlProdCategory.SelectedValue.ToString() + "' WHERE Id = '" + id + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                Populate();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //private void gridViewProducts_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
        //    ctrlName.EditValue = Convert.ToString(gridViewProducts.GetFocusedRowCellValue("ProdName"));
        //    ctrlQuantity.EditValue = Convert.ToInt32(gridViewProducts.GetFocusedRowCellValue("ProdQty"));
        //    ctrlPrice.EditValue = Convert.ToInt32(gridViewProducts.GetFocusedRowCellValue("ProdPrice"));
        //    ctrlDescription.EditValue = Convert.ToString(gridViewProducts.GetFocusedRowCellValue("ProdDesc"));
        //    ctrlProdCategory.SelectedValue = Convert.ToString(gridViewProducts.GetFocusedRowCellValue("ProdCat"));
        //}

        private void FilterByCategory() {
            try {
                Con.Open();
                string MyQuery = "SELECT ProdName, ProdQty, ProdPrice, ProdDesc, ProdCat, Id FROM ProductTbl WHERE ProdCat = '" + ctrlSearchComboBox.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridProducts.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            ctrlName.Text = gridProducts.SelectedRows[0].Cells[0].Value.ToString();
            ctrlQuantity.Text = gridProducts.SelectedRows[0].Cells[1].Value.ToString();
            ctrlPrice.Text = gridProducts.SelectedRows[0].Cells[2].Value.ToString();
            ctrlDescription.Text = gridProducts.SelectedRows[0].Cells[3].Value.ToString();
            ctrlProdCategory.SelectedValue = gridProducts.SelectedRows[0].Cells[4].Value.ToString();
        }

        
    }
}
