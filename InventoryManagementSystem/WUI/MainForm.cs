using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.WUI {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void btnUserForm_Click(object sender, EventArgs e) {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void btnCustomerForm_Click(object sender, EventArgs e) {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e) {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
        }

        private void btnProductForm_Click(object sender, EventArgs e) {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void btnOrderForm_Click(object sender, EventArgs e) {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.Show();
        }
    }
}
