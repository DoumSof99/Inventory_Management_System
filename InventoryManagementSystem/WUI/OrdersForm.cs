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
    public partial class OrdersForm : Form {

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-O3H1CKS\SQLCS412_SOFIA;Initial Catalog=Inventorydb;Integrated Security=True");

        int num = 0;
        int uPrice;
        int totalPrice;
        int quantity;
        string product;
        int flag = 0;
        int sum = 0;
        int stock;

        public OrdersForm() {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e) {
            PopulateCustomer();
            PopulateProducts();
            FillCategory();
        }

        private void ctrlSearchComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            FilterByCategory();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            PopulateProducts();
        }

        private void btnAddOrder_Click(object sender, EventArgs e) {
            AddOrder();
            UpdateProduct();
            PopulateProducts();
        }

        private void btnInsertOrder_Click(object sender, EventArgs e) {
            InsertOrder();
        }

        private void btnViewOrder_Click(object sender, EventArgs e) {
            ViewOrdersForm viewOrdersForm = new ViewOrdersForm();
            viewOrdersForm.Show();
        }

        /////////////////////////////////////////////////////////////////////////

        private void InsertOrder() {
            string orderId = Convert.ToString(ctrlOrderId.Text);
            string custId = Convert.ToString(ctrlCustomerId.Text);
            string custName = Convert.ToString(ctrlCustName.Text);
            string totalAmount = Convert.ToString(ctrlAmount.Text);
             

            if (orderId == "" || custId == "" || custName == "" || totalAmount == "") {
                MessageBox.Show("Please Fill The Data");
            }
            else {
                try {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO OrderTbl(Id, OrderId, CustId, CustName, OrderDate, TotalAmount) VALUES(NEWID(), '" + ctrlOrderId.Text + "', '" + ctrlCustomerId.Text + "', '" + ctrlCustName.Text + "', '" + ctrlOrderDate.Text + "', '" + ctrlAmount.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Succesfully Added");
                    Con.Close();
                }
                catch (Exception) {

                    MessageBox.Show("Something went wrong");
                }
            }
        }

        private void PopulateCustomer() {
            try {
                Con.Open();
                string MyQuery = "SELECT CustName, CustLastName, Id FROM CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridCustomerList.DataSource = ds.Tables[0];
                Con.Close();
                gridCustomerList.Columns["Id"].Visible = false;
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateProducts() {
            try {
                Con.Open();
                string MyQuery = "SELECT ProdName, ProdQty, ProdPrice, ProdDesc, ProdCat, Id FROM ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridProductsList.DataSource = ds.Tables[0];
                Con.Close();
                gridProductsList.Columns["Id"].Visible = false;
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
                //ctrlProdCategory.ValueMember = "CatName";
                //ctrlProdCategory.DataSource = dt;
                ctrlSearchComboBox.ValueMember = "CatName";
                Con.Close();
                ctrlSearchComboBox.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                throw;
            }
}

        private void FilterByCategory() {
            try {
                Con.Open();
                string MyQuery = "SELECT ProdName, ProdQty, ProdPrice, ProdDesc, ProdCat, Id FROM ProductTbl WHERE ProdCat = '" + ctrlSearchComboBox.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gridProductsList.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        DataTable table = new DataTable() {
            Columns = { { "Num" }, { "Product" }, { "Quantity" }, { "UPrice" }, { "TotalPrice" } }
        };

        private void UpdateProduct() {
            try {
                Guid id = Guid.Parse(gridProductsList.SelectedRows[0].Cells[5].Value.ToString());
                int newQuantity = stock - Convert.ToInt32(ctrlQuantity.Text);
                if (newQuantity < 0) {
                    MessageBox.Show("Oparation Failed");
                }
                else {
                    Con.Open();
                    string MyQuery = "UPDATE ProductTbl SET ProdQty = '" + newQuantity + "' WHERE Id = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(MyQuery, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddOrder() {
            if(ctrlQuantity.Text == "") {
                MessageBox.Show("Please enter quantity of the products");
            }
            else if (flag == 0) {
                MessageBox.Show("Select a Product");
            }
            else if (Convert.ToInt32(ctrlQuantity.Text) > stock) {
                MessageBox.Show("Not enough stock available.");
            }
            else {
                num += 1;
                quantity = Convert.ToInt32(ctrlQuantity.Text);
                totalPrice = uPrice * quantity;
                table.Rows.Add(num, product, quantity, uPrice, totalPrice);
                gridOrder.DataSource = table;
                flag = 0;
            }
            sum += totalPrice;
            ctrlAmount.Text = sum.ToString();
        }

        private void gridCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            Guid id = Guid.Parse(gridCustomerList.SelectedRows[0].Cells[2].Value.ToString());
            ctrlCustomerId.Text = Convert.ToString(id);
            ctrlCustName.Text = gridCustomerList.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void gridCategoriesList_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            product = gridProductsList.SelectedRows[0].Cells[4].Value.ToString();
            stock = Convert.ToInt32(gridProductsList.SelectedRows[0].Cells[1].Value.ToString());
            uPrice = Convert.ToInt32(gridProductsList.SelectedRows[0].Cells[2].Value.ToString());
            flag = 1;
        }
    }
}

