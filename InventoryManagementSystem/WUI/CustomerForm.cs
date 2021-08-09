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
    public partial class CustomerForm : Form {

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-O3H1CKS\SQLCS412_SOFIA;Initial Catalog=Inventorydb;Integrated Security=True");

        public CustomerForm() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void CustomerForm_Load(object sender, EventArgs e) {
            Populate();
            ResetFields();
        }
        private void btnAdd_Click_1(object sender, EventArgs e) {
            AddCustomer();
            Populate();
            ResetFields();
        }

        private void btnEdit_Click_1(object sender, EventArgs e) {
            EditCustomer();
            Populate();
            ResetFields();
        }

        private void btnDelete_Click_1(object sender, EventArgs e) {
            DeleteCustomer();
            Populate();
            ResetFields();
        }
       
        /// <summary>
        /// Methods
        /// </summary>
        /// 

        private void ResetFields() {
            ctrlName.Text = String.Empty;
            ctrlLastName.Text = String.Empty;
        }

        private void Populate() {
            try {
                Con.Open();
                string MyQuery = "SELECT CustName, CustLastname, Id FROM CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridCustomer.DataSource = ds.Tables[0];
                Con.Close();
                gridCustomer.Columns["Id"].Visible = false;
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddCustomer() {

            string custName = Convert.ToString(ctrlName.Text);
            string custLastname = Convert.ToString(ctrlLastName.Text);

            try {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTbl (Id, CustName, CustLastname) values(NEWID(), '" + custName + "', '" + custLastname + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Succesfully Added");
                Con.Close();
                Populate();

            }
            catch (Exception) {

                MessageBox.Show("Something went wrong");
            }

        }

        private void EditCustomer() {
            Guid id = Guid.Parse(gridCustomer.SelectedRows[0].Cells[2].Value.ToString());

            Con.Open(); 
            SqlCommand cmd = new SqlCommand("UPDATE CustomerTbl SET CustName='" + ctrlName.Text + "', CustLastname='" + ctrlLastName.Text + "' WHERE Id = '" + id + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Customer Successfully Updated");
            Con.Close();
            Populate();
        }

        //private void gridViewCustomers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
        //    ctrlName.EditValue = Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("CustName"));
        //    ctrlLastName.EditValue = Convert.ToString(gridViewCustomers.GetFocusedRowCellValue("CustLastname"));
        //}

        private void DeleteCustomer() {
            try {
                Guid id = Guid.Parse(gridCustomer.SelectedRows[0].Cells[2].Value.ToString());

                Con.Open();
                string query = "DELETE FROM CustomerTbl WHERE Id = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Succesfully Deleted");
                Con.Close();
                Populate();

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            Guid id = Guid.Parse(gridCustomer.SelectedRows[0].Cells[2].Value.ToString());

            ctrlName.Text = gridCustomer.SelectedRows[0].Cells[0].Value.ToString();
            ctrlLastName.Text = gridCustomer.SelectedRows[0].Cells[1].Value.ToString();
            Con.Open();
            
            string CountQuery = "SELECT COUNT(*) FROM OrderTbl WHERE CustId = '" + id + "'";
            SqlDataAdapter sdaCount = new SqlDataAdapter(CountQuery, Con);
            DataTable dtCount = new DataTable();
            sdaCount.Fill(dtCount);
            lblCount.Text = dtCount.Rows[0][0].ToString();
            
            string AmountQuery = "SELECT SUM(TotalAmount) FROM OrderTbl WHERE CustId = '" + id + "'";
            SqlDataAdapter sdaAmount = new SqlDataAdapter(AmountQuery, Con);
            DataTable dtAmount = new DataTable();
            sdaAmount.Fill(dtAmount);
            lblAmount.Text = dtAmount.Rows[0][0].ToString();

            string DateQuery = "SELECT MAX(OrderDate) FROM OrderTbl WHERE CustId = '" + id + "'";
            SqlDataAdapter sdaDate = new SqlDataAdapter(DateQuery, Con);
            DataTable dtDate = new DataTable();
            sdaDate.Fill(dtDate);
            lblDate.Text = dtDate.Rows[0][0].ToString();

            Con.Close();
        }

        
    }
}
