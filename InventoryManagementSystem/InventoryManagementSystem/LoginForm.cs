using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ctrlUserName.Focus();
        }

        private void ctrlUserName_Enter(object sender, EventArgs e)
        {
            ctrlUserNameSeparator.LineColor = Color.White;
        }

        private void ctrlUserName_Leave(object sender, EventArgs e)
        {
            ctrlUserNameSeparator.LineColor = Color.DarkViolet;
        }

        private void ctrlPassword_Enter(object sender, EventArgs e)
        {
            ctrlPasswordSeparator.LineColor = Color.White;
        }

        private void ctrlPassword_Leave(object sender, EventArgs e)
        {
            ctrlPasswordSeparator.LineColor = Color.DarkViolet;
        }

        private void ctrlShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(!ctrlShowPassword.Checked)
            {
                ctrlPassword.Properties.UseSystemPasswordChar = true;
            } else
            {
                ctrlPassword.Properties.UseSystemPasswordChar = false;
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            ctrlUserName.Text = "";
            ctrlPassword.Text = "";
        }
    }
}
