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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=InventoryManagementSystem;Trusted_Connection=True");

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            Populate();
            ResetFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTb values('" + ctrlId.Text + "', '" + ctrlName.Text + "', '" + ctrlPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Added");
                Con.Close();
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Populate()
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
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ctrlId.Text == "CustomerId")
            {
                MessageBox.Show("Enter the Customer Id");
            }
            else
            {
                Con.Open();
                string myquery = "delete from CustomerTb where CustomerId='" + ctrlId.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                Con.Close();
                Populate();
                ResetFields();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTb set CustomerName='" + ctrlName.Text + "',CustomerPhone='" + ctrlPhone.Text + "' where CustomerId='" + ctrlId.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Updated");
                Con.Close();
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetFields()
        {
            ctrlId.Text = "CustomerId";
            ctrlName.Text = "CustomerName";
            ctrlPhone.Text = "CustomerPhone";
        }

        private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ctrlId.Text = gridViewCustomers.GetFocusedRowCellValue("CustomerId").ToString();
            ctrlName.Text = gridViewCustomers.GetFocusedRowCellValue("CustomerName").ToString();
            ctrlPhone.Text = gridViewCustomers.GetFocusedRowCellValue("CustomerPhone").ToString();
        }
    }
}
