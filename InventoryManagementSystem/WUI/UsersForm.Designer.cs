
namespace InventoryManagementSystem {
    partial class UsersForm {
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.userTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventorydbDataSet = new InventoryManagementSystem.InventorydbDataSet();
            this.userTblTableAdapter = new InventoryManagementSystem.InventorydbDataSetTableAdapters.UserTblTableAdapter();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.ctrlName = new System.Windows.Forms.TextBox();
            this.ctrlLastName = new System.Windows.Forms.TextBox();
            this.ctrlPassword = new System.Windows.Forms.TextBox();
            this.ctrlPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(928, 132);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(290, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(378, 31);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Inventory Management System";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(385, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(174, 31);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Manage Users";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 176);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "User Name";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 230);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Last Name";
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 530);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(928, 26);
            this.panelControl2.TabIndex = 14;
            // 
            // userTblBindingSource
            // 
            this.userTblBindingSource.DataMember = "UserTbl";
            this.userTblBindingSource.DataSource = this.inventorydbDataSet;
            // 
            // inventorydbDataSet
            // 
            this.inventorydbDataSet.DataSetName = "InventorydbDataSet";
            this.inventorydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTblTableAdapter
            // 
            this.userTblTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 285);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Password";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 343);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(30, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Phone";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(78, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 32);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(128, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 32);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(28, 469);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 32);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // gridUsers
            // 
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Location = new System.Drawing.Point(310, 148);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsers.Size = new System.Drawing.Size(606, 376);
            this.gridUsers.TabIndex = 19;
            this.gridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsers_CellContentClick);
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(12, 195);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(261, 20);
            this.ctrlName.TabIndex = 20;
            // 
            // ctrlLastName
            // 
            this.ctrlLastName.Location = new System.Drawing.Point(12, 249);
            this.ctrlLastName.Name = "ctrlLastName";
            this.ctrlLastName.Size = new System.Drawing.Size(261, 20);
            this.ctrlLastName.TabIndex = 21;
            // 
            // ctrlPassword
            // 
            this.ctrlPassword.Location = new System.Drawing.Point(12, 304);
            this.ctrlPassword.Name = "ctrlPassword";
            this.ctrlPassword.Size = new System.Drawing.Size(261, 20);
            this.ctrlPassword.TabIndex = 22;
            // 
            // ctrlPhone
            // 
            this.ctrlPhone.Location = new System.Drawing.Point(12, 362);
            this.ctrlPhone.Name = "ctrlPhone";
            this.ctrlPhone.Size = new System.Drawing.Size(261, 20);
            this.ctrlPhone.TabIndex = 23;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(928, 556);
            this.Controls.Add(this.ctrlPhone);
            this.Controls.Add(this.ctrlPassword);
            this.Controls.Add(this.ctrlLastName);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.gridUsers);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panelControl1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private InventorydbDataSet inventorydbDataSet;
        private System.Windows.Forms.BindingSource userTblBindingSource;
        private InventorydbDataSetTableAdapters.UserTblTableAdapter userTblTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.TextBox ctrlName;
        private System.Windows.Forms.TextBox ctrlLastName;
        private System.Windows.Forms.TextBox ctrlPassword;
        private System.Windows.Forms.TextBox ctrlPhone;
    }
}

