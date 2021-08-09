
namespace InventoryManagementSystem {
    partial class ProductForm {
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlProdCategory = new System.Windows.Forms.ComboBox();
            this.ctrl = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSearchComboBox = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlName = new System.Windows.Forms.TextBox();
            this.ctrlQuantity = new System.Windows.Forms.TextBox();
            this.ctrlPrice = new System.Windows.Forms.TextBox();
            this.ctrlDescription = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(907, 132);
            this.panelControl1.TabIndex = 5;
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
            this.labelControl4.Size = new System.Drawing.Size(213, 31);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Manage Products";
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 589);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(907, 26);
            this.panelControl2.TabIndex = 25;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 219);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(82, 13);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Product Quantity";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 154);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Product Name";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(30, 348);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "Description";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(30, 283);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 32;
            this.labelControl6.Text = "Product Price";
            // 
            // ctrlProdCategory
            // 
            this.ctrlProdCategory.FormattingEnabled = true;
            this.ctrlProdCategory.Location = new System.Drawing.Point(30, 434);
            this.ctrlProdCategory.Name = "ctrlProdCategory";
            this.ctrlProdCategory.Size = new System.Drawing.Size(261, 21);
            this.ctrlProdCategory.TabIndex = 34;
            // 
            // ctrl
            // 
            this.ctrl.Location = new System.Drawing.Point(30, 415);
            this.ctrl.Name = "ctrl";
            this.ctrl.Size = new System.Drawing.Size(85, 13);
            this.ctrl.TabIndex = 35;
            this.ctrl.Text = "Product Category";
            // 
            // ctrlSearchComboBox
            // 
            this.ctrlSearchComboBox.FormattingEnabled = true;
            this.ctrlSearchComboBox.Location = new System.Drawing.Point(512, 146);
            this.ctrlSearchComboBox.Name = "ctrlSearchComboBox";
            this.ctrlSearchComboBox.Size = new System.Drawing.Size(190, 21);
            this.ctrlSearchComboBox.TabIndex = 40;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(352, 146);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(142, 21);
            this.labelControl7.TabIndex = 4;
            this.labelControl7.Text = "Select Category";
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(30, 176);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(261, 20);
            this.ctrlName.TabIndex = 43;
            // 
            // ctrlQuantity
            // 
            this.ctrlQuantity.Location = new System.Drawing.Point(30, 238);
            this.ctrlQuantity.Name = "ctrlQuantity";
            this.ctrlQuantity.Size = new System.Drawing.Size(261, 20);
            this.ctrlQuantity.TabIndex = 44;
            // 
            // ctrlPrice
            // 
            this.ctrlPrice.Location = new System.Drawing.Point(30, 302);
            this.ctrlPrice.Name = "ctrlPrice";
            this.ctrlPrice.Size = new System.Drawing.Size(261, 20);
            this.ctrlPrice.TabIndex = 45;
            // 
            // ctrlDescription
            // 
            this.ctrlDescription.Location = new System.Drawing.Point(30, 367);
            this.ctrlDescription.Name = "ctrlDescription";
            this.ctrlDescription.Size = new System.Drawing.Size(261, 20);
            this.ctrlDescription.TabIndex = 46;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(799, 142);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 27);
            this.btnRefresh.TabIndex = 47;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(710, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 27);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(59, 530);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 32);
            this.btnEdit.TabIndex = 51;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(159, 530);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 32);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(109, 479);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 32);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // gridProducts
            // 
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(317, 176);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(590, 407);
            this.gridProducts.TabIndex = 52;
            this.gridProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProducts_CellContentClick);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(907, 615);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ctrlDescription);
            this.Controls.Add(this.ctrlPrice);
            this.Controls.Add(this.ctrlQuantity);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.ctrlSearchComboBox);
            this.Controls.Add(this.ctrl);
            this.Controls.Add(this.ctrlProdCategory);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox ctrlProdCategory;
        private DevExpress.XtraEditors.LabelControl ctrl;
        private System.Windows.Forms.ComboBox ctrlSearchComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox ctrlName;
        private System.Windows.Forms.TextBox ctrlQuantity;
        private System.Windows.Forms.TextBox ctrlPrice;
        private System.Windows.Forms.TextBox ctrlDescription;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gridProducts;
    }
}