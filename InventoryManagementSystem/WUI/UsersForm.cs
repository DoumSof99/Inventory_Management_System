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
    public partial class UsersForm : Form {

        SqlConnection Con =  new SqlConnection(@"Data Source=DESKTOP-O3H1CKS\SQLCS412_SOFIA;Initial Catalog=Inventorydb;Integrated Security=True");

        public UsersForm() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Populate();
            ResetFields();
        }
        private void btnAdd_Click_1(object sender, EventArgs e) {
            AddUser();
            Populate();
            ResetFields();
        }
        private void btnEdit_Click_1(object sender, EventArgs e) {
            EditUser();
            Populate();
            ResetFields();
        }
        private void btnDelete_Click_1(object sender, EventArgs e) {
            DeleteUser();
            Populate();
            ResetFields();
        }
        
        private void ResetFields() {
            ctrlName.Text = String.Empty;
            ctrlLastName.Text = String.Empty;
            ctrlPassword.Text = String.Empty;
            ctrlPhone.Text = String.Empty;
        }

        private void AddUser() {

            string uname = Convert.ToString(ctrlName.Text);
            string ulastname = Convert.ToString(ctrlLastName.Text);
            string upassword = Convert.ToString(ctrlPassword.Text);
            string uphone = Convert.ToString(ctrlPhone.Text);

            try {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO UserTbl (ID, Uname, Ulastname, Upassword, UPhone) values(NEWID(), '" + uname + "', '" + ulastname + "', '" + upassword + "', '" + uphone + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Succesfully Added");
                Con.Close();
                Populate();

            }
            catch (Exception) {

                MessageBox.Show("Something went wrong");
            }

        }

        private void Populate() {
            try {
                Con.Open();
                string MyQuery = "SELECT Uname, Ulastname, Upassword, UPhone, Id FROM UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridUsers.DataSource = ds.Tables[0];
                Con.Close();
                gridUsers.Columns["Id"].Visible = false;
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteUser() {
            try {
                Guid id = Guid.Parse(gridUsers.SelectedRows[0].Cells[4].Value.ToString());

                Con.Open();
                string query = "DELETE FROM UserTbl WHERE Id = '" + id + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Succesfully Deleted");
                Con.Close();
                Populate();

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        //private void gridViewUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
        //    ctrlName.EditValue = Convert.ToString(gridViewUsers.GetFocusedRowCellValue("Uname"));
        //    ctrlLastName.EditValue = Convert.ToString(gridViewUsers.GetFocusedRowCellValue("Ulastname"));
        //    ctrlPassword.EditValue = Convert.ToString(gridViewUsers.GetFocusedRowCellValue("Upassword"));
        //    ctrlPhone.EditValue = Convert.ToString(gridViewUsers.GetFocusedRowCellValue("UPhone"));
        //}

        private void EditUser() {
            Guid id = Guid.Parse(gridUsers.SelectedRows[0].Cells[4].Value.ToString());

            Con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE UserTbl SET Uname='" + ctrlName.Text + "', Ulastname='" + ctrlLastName.Text + "', Upassword='" + ctrlPassword.Text + "', UPhone = '" + ctrlPhone.Text + "' WHERE Id ='" + id + "'", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Users Successfully Updated");
            Con.Close();
            Populate();
        }

        private void gridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            ctrlName.Text = gridUsers.SelectedRows[0].Cells[0].Value.ToString();
            ctrlLastName.Text = gridUsers.SelectedRows[0].Cells[1].Value.ToString();
            ctrlPassword.Text = gridUsers.SelectedRows[0].Cells[2].Value.ToString();
            ctrlPhone.Text = gridUsers.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
