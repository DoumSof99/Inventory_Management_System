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

namespace InventoryManagementSystem.WUI {
    public partial class ViewOrdersForm : Form {

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-O3H1CKS\SQLCS412_SOFIA;Initial Catalog=Inventorydb;Integrated Security=True");

        public ViewOrdersForm() {
            InitializeComponent();
        }

        #region Events

        private void printPreviewDialog_Load(object sender, EventArgs e) {

        }

        private void ViewOrdersForm_Load(object sender, EventArgs e) {
            PopulateViewOrders();
        }

        private void gridViewOrdersList_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (printPreviewDialog.ShowDialog() == DialogResult.OK) {
                printDocument.Print();
            }            
            printDocument.Print();
        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            e.Graphics.DrawString("Order Summary", new Font("Century", 35, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Order Summary", new Font("Century", 35, FontStyle.Bold), Brushes.Red, new Point(230, 150));

        }

        #endregion

        #region Methods

        private void PopulateViewOrders() {
            try {
                Con.Open();
                string MyQuery = "SELECT CustName, OrderDate, TotalAmount FROM OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridViewOrdersList.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }




        #endregion

        
    }
}
