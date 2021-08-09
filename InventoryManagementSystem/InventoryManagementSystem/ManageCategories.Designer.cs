
namespace InventoryManagementSystem
{
    partial class ManageCategories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new DevExpress.XtraEditors.LabelControl();
            this.sptFullName = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.sptUserName = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCategories = new DevExpress.XtraGrid.GridControl();
            this.gridViewCategories = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHome = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(306, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(266, 33);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Manage Categories";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(186, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(528, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 100);
            this.panel1.TabIndex = 1;
            // 
            // lblClose
            // 
            this.lblClose.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblClose.Appearance.Options.UseFont = true;
            this.lblClose.Appearance.Options.UseForeColor = true;
            this.lblClose.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Location = new System.Drawing.Point(884, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(16, 33);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            // 
            // sptFullName
            // 
            this.sptFullName.LineColor = System.Drawing.Color.DarkViolet;
            this.sptFullName.LineThickness = 5;
            this.sptFullName.Location = new System.Drawing.Point(48, 243);
            this.sptFullName.Margin = new System.Windows.Forms.Padding(0);
            this.sptFullName.Name = "sptFullName";
            this.sptFullName.Padding = new System.Windows.Forms.Padding(0);
            this.sptFullName.Size = new System.Drawing.Size(189, 5);
            this.sptFullName.TabIndex = 12;
            // 
            // ctrlName
            // 
            this.ctrlName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlName.EditValue = "CategoriesName";
            this.ctrlName.Location = new System.Drawing.Point(48, 217);
            this.ctrlName.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlName.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlName.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlName.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlName.Properties.Appearance.Options.UseFont = true;
            this.ctrlName.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlName.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlName.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlName.Properties.AppearanceFocused.Options.UseFont = true;
            this.ctrlName.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.ctrlName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlName.Size = new System.Drawing.Size(189, 26);
            this.ctrlName.TabIndex = 11;
            // 
            // sptUserName
            // 
            this.sptUserName.LineColor = System.Drawing.Color.DarkViolet;
            this.sptUserName.LineThickness = 5;
            this.sptUserName.Location = new System.Drawing.Point(48, 203);
            this.sptUserName.Margin = new System.Windows.Forms.Padding(0);
            this.sptUserName.Name = "sptUserName";
            this.sptUserName.Padding = new System.Windows.Forms.Padding(0);
            this.sptUserName.Size = new System.Drawing.Size(189, 5);
            this.sptUserName.TabIndex = 10;
            // 
            // ctrlId
            // 
            this.ctrlId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlId.EditValue = "CategoriesId";
            this.ctrlId.Location = new System.Drawing.Point(48, 177);
            this.ctrlId.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlId.Name = "ctrlId";
            this.ctrlId.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ctrlId.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlId.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlId.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlId.Properties.Appearance.Options.UseFont = true;
            this.ctrlId.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlId.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlId.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlId.Properties.AppearanceFocused.Options.UseFont = true;
            this.ctrlId.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.ctrlId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlId.Size = new System.Drawing.Size(189, 26);
            this.ctrlId.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(562, 144);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(211, 33);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "CATEGORIES LIST";
            // 
            // ctrlCategories
            // 
            this.ctrlCategories.Location = new System.Drawing.Point(381, 183);
            this.ctrlCategories.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.ctrlCategories.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ctrlCategories.MainView = this.gridViewCategories;
            this.ctrlCategories.Name = "ctrlCategories";
            this.ctrlCategories.Size = new System.Drawing.Size(499, 452);
            this.ctrlCategories.TabIndex = 20;
            this.ctrlCategories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCategories});
            // 
            // gridViewCategories
            // 
            this.gridViewCategories.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Crimson;
            this.gridViewCategories.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Crimson;
            this.gridViewCategories.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategories.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White;
            this.gridViewCategories.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridViewCategories.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewCategories.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewCategories.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewCategories.ColumnPanelRowHeight = 20;
            this.gridViewCategories.GridControl = this.ctrlCategories;
            this.gridViewCategories.Name = "gridViewCategories";
            this.gridViewCategories.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewCategories.OptionsView.ShowGroupPanel = false;
            this.gridViewCategories.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewCategories_FocusedRowChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 653);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 15);
            this.panel2.TabIndex = 22;
            // 
            // btnHome
            // 
            this.btnHome.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnHome.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnHome.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnHome.Appearance.Options.UseBackColor = true;
            this.btnHome.Appearance.Options.UseBorderColor = true;
            this.btnHome.Appearance.Options.UseFont = true;
            this.btnHome.Appearance.Options.UseForeColor = true;
            this.btnHome.Location = new System.Drawing.Point(142, 396);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(88, 33);
            this.btnHome.TabIndex = 26;
            this.btnHome.Text = "Home";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.Location = new System.Drawing.Point(236, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 33);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnEdit.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Appearance.Options.UseBackColor = true;
            this.btnEdit.Appearance.Options.UseBorderColor = true;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Appearance.Options.UseForeColor = true;
            this.btnEdit.Location = new System.Drawing.Point(142, 343);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 33);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnAdd.Appearance.BorderColor = System.Drawing.Color.Crimson;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseBorderColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.Location = new System.Drawing.Point(48, 343);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 33);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 668);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ctrlCategories);
            this.Controls.Add(this.sptFullName);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.sptUserName);
            this.Controls.Add(this.ctrlId);
            this.Controls.Add(this.panel1);
            this.Name = "ManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lblClose;
        private DevExpress.XtraEditors.SeparatorControl sptFullName;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.SeparatorControl sptUserName;
        private DevExpress.XtraEditors.TextEdit ctrlId;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl ctrlCategories;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCategories;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnHome;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}