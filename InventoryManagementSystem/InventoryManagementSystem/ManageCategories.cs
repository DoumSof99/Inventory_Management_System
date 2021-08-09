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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=InventoryManagementSystem;Trusted_Connection=True");

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            Populate();
            ResetFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTb values('" + ctrlId.Text + "', '" + ctrlName.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added");
                Con.Close();
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoryTb set CatName='" + ctrlName.Text + "' where CatId='" + ctrlId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Updated");
                Con.Close();
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ctrlId.Text == "CategoriesId")
            {
                MessageBox.Show("Enter the Category Id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CategoryTb where CatId='" + ctrlId.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                Con.Close();
                Populate();
                ResetFields();
            }
        }

        private void Populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from  CategoryTb";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ctrlCategories.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ResetFields()
        {
            ctrlId.Text = "CategoryId";
            ctrlName.Text = "CategoryName";
        }

        private void gridViewCategories_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ctrlId.Text = gridViewCategories.GetFocusedRowCellValue("CatId").ToString();
            ctrlName.Text = gridViewCategories.GetFocusedRowCellValue("CatName").ToString();
        }
    }
}
