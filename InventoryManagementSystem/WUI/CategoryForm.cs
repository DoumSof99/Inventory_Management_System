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

namespace InventoryManagementSystem {
    public partial class CategoryForm : Form {

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-O3H1CKS\SQLCS412_SOFIA;Initial Catalog=Inventorydb;Integrated Security=True");

        public CategoryForm() {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e) {
            Populate();
            ResetFields();
        }
        private void btnAdd_Click_1(object sender, EventArgs e) {
            AddCategory();
            Populate();
            ResetFields();
        }

        private void btnEdit_Click_1(object sender, EventArgs e) {
            EditCategory();
            Populate();
            ResetFields();
        }

        private void btnDelete_Click_1(object sender, EventArgs e) {
            DeleteCategory();
            Populate();
            ResetFields();
        }
       
        /////////////////////////////////////////////////////////////////////////////

        private void ResetFields() {
            ctrlName.Text = String.Empty;
        }

        private void Populate() {
            try {
                Con.Open();
                string MyQuery = "SELECT CatName, Id FROM CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridCategory.DataSource = ds.Tables[0];
                Con.Close();
                gridCategory.Columns["Id"].Visible = false;
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddCategory() {
            string catName = Convert.ToString(ctrlName.Text);

            try {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CategoryTbl(Id, CatName) VALUES(NEWID(), '" + catName + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Succesfully Added");
                Con.Close();
                Populate();

            }
            catch (Exception) {

                MessageBox.Show("Something went wrong");
            }
        }

        private void DeleteCategory() {
            try {
                Guid id = Guid.Parse(gridCategory.SelectedRows[0].Cells[1].Value.ToString());

                Con.Open();
                string query = "DELETE FROM CategoryTbl WHERE Id = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Succesfully Deleted");
                Con.Close();
                Populate();

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void EditCategory() {
            try {
                Guid id = Guid.Parse(gridCategory.SelectedRows[0].Cells[1].Value.ToString());

                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CategoryTbl SET CatName='" + ctrlName.Text + "' WHERE Id = '" + id + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Updated");
                Con.Close();
                Populate();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridCategory_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            ctrlName.Text = gridCategory.SelectedRows[0].Cells[0].Value.ToString();
        }

        //private void gridViewCategory_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
        //    ctrlCategory.EditValue = Convert.ToString(gridViewCategory.GetFocusedRowCellValue("CatName"));
        //}

    }
}
