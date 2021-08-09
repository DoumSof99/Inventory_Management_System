
namespace InventoryManagementSystem.WUI {
    partial class OrdersForm {
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrl = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlOrderDate = new System.Windows.Forms.DateTimePicker();
            this.ctrlSearchComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlOrderId = new System.Windows.Forms.TextBox();
            this.ctrlCustomerId = new System.Windows.Forms.TextBox();
            this.gridCustomerList = new System.Windows.Forms.DataGridView();
            this.gridProductsList = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridOrder = new System.Windows.Forms.DataGridView();
            this.ctrlQuantity = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCustName = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.ctrlAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1145, 132);
            this.panelControl1.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(222, 23);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(378, 31);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Inventory Management System";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(317, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(194, 31);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Manage Orders";
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 869);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1145, 26);
            this.panelControl2.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 138);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(164, 27);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Customers List";
            // 
            // ctrl
            // 
            this.ctrl.Location = new System.Drawing.Point(30, 696);
            this.ctrl.Name = "ctrl";
            this.ctrl.Size = new System.Drawing.Size(54, 13);
            this.ctrl.TabIndex = 44;
            this.ctrl.Text = "Order Date";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 577);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "Customer Id";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(30, 514);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(41, 13);
            this.labelControl6.TabIndex = 41;
            this.labelControl6.Text = "Order Id";
            // 
            // ctrlOrderDate
            // 
            this.ctrlOrderDate.CustomFormat = "MM/dd/yyyy";
            this.ctrlOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ctrlOrderDate.Location = new System.Drawing.Point(30, 715);
            this.ctrlOrderDate.Name = "ctrlOrderDate";
            this.ctrlOrderDate.Size = new System.Drawing.Size(261, 20);
            this.ctrlOrderDate.TabIndex = 45;
            // 
            // ctrlSearchComboBox
            // 
            this.ctrlSearchComboBox.FormattingEnabled = true;
            this.ctrlSearchComboBox.Location = new System.Drawing.Point(710, 144);
            this.ctrlSearchComboBox.Name = "ctrlSearchComboBox";
            this.ctrlSearchComboBox.Size = new System.Drawing.Size(190, 21);
            this.ctrlSearchComboBox.TabIndex = 47;
            this.ctrlSearchComboBox.SelectedIndexChanged += new System.EventHandler(this.ctrlSearchComboBox_SelectedIndexChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(562, 141);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(142, 21);
            this.labelControl7.TabIndex = 48;
            this.labelControl7.Text = "Select Category";
            // 
            // ctrlOrderId
            // 
            this.ctrlOrderId.Location = new System.Drawing.Point(30, 533);
            this.ctrlOrderId.Name = "ctrlOrderId";
            this.ctrlOrderId.Size = new System.Drawing.Size(261, 20);
            this.ctrlOrderId.TabIndex = 49;
            // 
            // ctrlCustomerId
            // 
            this.ctrlCustomerId.Location = new System.Drawing.Point(30, 596);
            this.ctrlCustomerId.Name = "ctrlCustomerId";
            this.ctrlCustomerId.Size = new System.Drawing.Size(261, 20);
            this.ctrlCustomerId.TabIndex = 50;
            // 
            // gridCustomerList
            // 
            this.gridCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCustomerList.Location = new System.Drawing.Point(12, 180);
            this.gridCustomerList.Name = "gridCustomerList";
            this.gridCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomerList.Size = new System.Drawing.Size(535, 313);
            this.gridCustomerList.TabIndex = 53;
            this.gridCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCustomerList_CellContentClick);
            // 
            // gridProductsList
            // 
            this.gridProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductsList.Location = new System.Drawing.Point(553, 180);
            this.gridProductsList.Name = "gridProductsList";
            this.gridProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductsList.Size = new System.Drawing.Size(580, 313);
            this.gridProductsList.TabIndex = 54;
            this.gridProductsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCategoriesList_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(906, 140);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 27);
            this.btnRefresh.TabIndex = 55;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridOrder
            // 
            this.gridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrder.Location = new System.Drawing.Point(402, 555);
            this.gridOrder.Name = "gridOrder";
            this.gridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrder.Size = new System.Drawing.Size(731, 275);
            this.gridOrder.TabIndex = 56;
            // 
            // ctrlQuantity
            // 
            this.ctrlQuantity.Location = new System.Drawing.Point(634, 499);
            this.ctrlQuantity.Name = "ctrlQuantity";
            this.ctrlQuantity.Size = new System.Drawing.Size(261, 20);
            this.ctrlQuantity.TabIndex = 57;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(552, 500);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 21);
            this.labelControl2.TabIndex = 58;
            this.labelControl2.Text = "Quantity";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(901, 495);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(83, 27);
            this.btnAddOrder.TabIndex = 59;
            this.btnAddOrder.Text = "Add to Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(584, 836);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(117, 21);
            this.labelControl8.TabIndex = 60;
            this.labelControl8.Text = "Total Amount";
            // 
            // ctrlCustName
            // 
            this.ctrlCustName.Location = new System.Drawing.Point(30, 655);
            this.ctrlCustName.Name = "ctrlCustName";
            this.ctrlCustName.Size = new System.Drawing.Size(261, 20);
            this.ctrlCustName.TabIndex = 63;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(30, 636);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(76, 13);
            this.labelControl9.TabIndex = 62;
            this.labelControl9.Text = "Customer Name";
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.Location = new System.Drawing.Point(30, 784);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(83, 27);
            this.btnInsertOrder.TabIndex = 64;
            this.btnInsertOrder.Text = "Insert Order";
            this.btnInsertOrder.UseVisualStyleBackColor = true;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.Location = new System.Drawing.Point(133, 784);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(83, 27);
            this.btnViewOrder.TabIndex = 65;
            this.btnViewOrder.Text = "View Order";
            this.btnViewOrder.UseVisualStyleBackColor = true;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // ctrlAmount
            // 
            this.ctrlAmount.AutoSize = true;
            this.ctrlAmount.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlAmount.Location = new System.Drawing.Point(716, 833);
            this.ctrlAmount.Name = "ctrlAmount";
            this.ctrlAmount.Size = new System.Drawing.Size(78, 21);
            this.ctrlAmount.TabIndex = 66;
            this.ctrlAmount.Text = "Amount";
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1145, 895);
            this.Controls.Add(this.ctrlAmount);
            this.Controls.Add(this.btnViewOrder);
            this.Controls.Add(this.btnInsertOrder);
            this.Controls.Add(this.ctrlCustName);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ctrlQuantity);
            this.Controls.Add(this.gridOrder);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.gridProductsList);
            this.Controls.Add(this.gridCustomerList);
            this.Controls.Add(this.ctrlCustomerId);
            this.Controls.Add(this.ctrlOrderId);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.ctrlSearchComboBox);
            this.Controls.Add(this.ctrlOrderDate);
            this.Controls.Add(this.ctrl);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl ctrl;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DateTimePicker ctrlOrderDate;
        private System.Windows.Forms.ComboBox ctrlSearchComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox ctrlOrderId;
        private System.Windows.Forms.TextBox ctrlCustomerId;
        private System.Windows.Forms.DataGridView gridCustomerList;
        private System.Windows.Forms.DataGridView gridProductsList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView gridOrder;
        private System.Windows.Forms.TextBox ctrlQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btnAddOrder;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.TextBox ctrlCustName;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.Button btnInsertOrder;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Label ctrlAmount;
    }
}