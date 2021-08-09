
namespace InventoryManagementSystem.WUI {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.btnUserForm = new System.Windows.Forms.Button();
            this.btnCustomerForm = new System.Windows.Forms.Button();
            this.btnProductForm = new System.Windows.Forms.Button();
            this.btnOrderForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnExit);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(657, 132);
            this.panelControl1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(908, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "x";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(193, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(378, 31);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Inventory Management System";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(285, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(137, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Main Menu";
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 444);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(657, 26);
            this.panelControl2.TabIndex = 15;
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.Location = new System.Drawing.Point(474, 170);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(120, 73);
            this.btnCategoryForm.TabIndex = 17;
            this.btnCategoryForm.Text = "Category Form";
            this.btnCategoryForm.UseVisualStyleBackColor = true;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // btnUserForm
            // 
            this.btnUserForm.Location = new System.Drawing.Point(77, 170);
            this.btnUserForm.Name = "btnUserForm";
            this.btnUserForm.Size = new System.Drawing.Size(120, 73);
            this.btnUserForm.TabIndex = 18;
            this.btnUserForm.Text = "User Form";
            this.btnUserForm.UseVisualStyleBackColor = true;
            this.btnUserForm.Click += new System.EventHandler(this.btnUserForm_Click);
            // 
            // btnCustomerForm
            // 
            this.btnCustomerForm.Location = new System.Drawing.Point(275, 170);
            this.btnCustomerForm.Name = "btnCustomerForm";
            this.btnCustomerForm.Size = new System.Drawing.Size(120, 73);
            this.btnCustomerForm.TabIndex = 19;
            this.btnCustomerForm.Text = "Customer Form";
            this.btnCustomerForm.UseVisualStyleBackColor = true;
            this.btnCustomerForm.Click += new System.EventHandler(this.btnCustomerForm_Click);
            // 
            // btnProductForm
            // 
            this.btnProductForm.Location = new System.Drawing.Point(160, 317);
            this.btnProductForm.Name = "btnProductForm";
            this.btnProductForm.Size = new System.Drawing.Size(120, 73);
            this.btnProductForm.TabIndex = 20;
            this.btnProductForm.Text = "Product Form";
            this.btnProductForm.UseVisualStyleBackColor = true;
            this.btnProductForm.Click += new System.EventHandler(this.btnProductForm_Click);
            // 
            // btnOrderForm
            // 
            this.btnOrderForm.Location = new System.Drawing.Point(377, 317);
            this.btnOrderForm.Name = "btnOrderForm";
            this.btnOrderForm.Size = new System.Drawing.Size(120, 73);
            this.btnOrderForm.TabIndex = 21;
            this.btnOrderForm.Text = "Order Form";
            this.btnOrderForm.UseVisualStyleBackColor = true;
            this.btnOrderForm.Click += new System.EventHandler(this.btnOrderForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(657, 470);
            this.Controls.Add(this.btnOrderForm);
            this.Controls.Add(this.btnProductForm);
            this.Controls.Add(this.btnCustomerForm);
            this.Controls.Add(this.btnUserForm);
            this.Controls.Add(this.btnCategoryForm);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Button btnUserForm;
        private System.Windows.Forms.Button btnCustomerForm;
        private System.Windows.Forms.Button btnProductForm;
        private System.Windows.Forms.Button btnOrderForm;
    }
}