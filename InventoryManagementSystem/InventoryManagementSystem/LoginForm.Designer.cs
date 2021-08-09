
namespace InventoryManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlShowPassword = new DevExpress.XtraEditors.CheckEdit();
            this.lblClear = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlPasswordSeparator = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlPassword = new DevExpress.XtraEditors.TextEdit();
            this.ctrlUserNameSeparator = new DevExpress.XtraEditors.SeparatorControl();
            this.ctrlUserName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlShowPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPasswordSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUserNameSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.ctrlShowPassword);
            this.panel1.Controls.Add(this.lblClear);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.ctrlPasswordSeparator);
            this.panel1.Controls.Add(this.ctrlPassword);
            this.panel1.Controls.Add(this.ctrlUserNameSeparator);
            this.panel1.Controls.Add(this.ctrlUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(131, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 332);
            this.panel1.TabIndex = 0;
            // 
            // ctrlShowPassword
            // 
            this.ctrlShowPassword.Location = new System.Drawing.Point(89, 285);
            this.ctrlShowPassword.Name = "ctrlShowPassword";
            this.ctrlShowPassword.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlShowPassword.Properties.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.ctrlShowPassword.Properties.Appearance.Options.UseFont = true;
            this.ctrlShowPassword.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlShowPassword.Properties.Caption = "Show Password";
            this.ctrlShowPassword.Size = new System.Drawing.Size(127, 20);
            this.ctrlShowPassword.TabIndex = 8;
            this.ctrlShowPassword.CheckedChanged += new System.EventHandler(this.ctrlShowPassword_CheckedChanged);
            // 
            // lblClear
            // 
            this.lblClear.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClear.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lblClear.Appearance.Options.UseFont = true;
            this.lblClear.Appearance.Options.UseForeColor = true;
            this.lblClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClear.Location = new System.Drawing.Point(27, 287);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(36, 16);
            this.lblClear.TabIndex = 6;
            this.lblClear.Text = "Clear";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.DodgerBlue;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(27, 224);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(189, 34);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "LOGIN";
            // 
            // ctrlPasswordSeparator
            // 
            this.ctrlPasswordSeparator.LineColor = System.Drawing.Color.DarkViolet;
            this.ctrlPasswordSeparator.LineThickness = 5;
            this.ctrlPasswordSeparator.Location = new System.Drawing.Point(27, 186);
            this.ctrlPasswordSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlPasswordSeparator.Name = "ctrlPasswordSeparator";
            this.ctrlPasswordSeparator.Padding = new System.Windows.Forms.Padding(0);
            this.ctrlPasswordSeparator.Size = new System.Drawing.Size(189, 5);
            this.ctrlPasswordSeparator.TabIndex = 4;
            // 
            // ctrlPassword
            // 
            this.ctrlPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlPassword.EditValue = "Password";
            this.ctrlPassword.Location = new System.Drawing.Point(27, 162);
            this.ctrlPassword.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlPassword.Name = "ctrlPassword";
            this.ctrlPassword.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.ctrlPassword.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPassword.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ctrlPassword.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlPassword.Properties.Appearance.Options.UseFont = true;
            this.ctrlPassword.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlPassword.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPassword.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White;
            this.ctrlPassword.Properties.AppearanceFocused.Options.UseFont = true;
            this.ctrlPassword.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.ctrlPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlPassword.Properties.UseSystemPasswordChar = true;
            this.ctrlPassword.Size = new System.Drawing.Size(189, 22);
            this.ctrlPassword.TabIndex = 3;
            this.ctrlPassword.Enter += new System.EventHandler(this.ctrlPassword_Enter);
            this.ctrlPassword.Leave += new System.EventHandler(this.ctrlPassword_Leave);
            // 
            // ctrlUserNameSeparator
            // 
            this.ctrlUserNameSeparator.LineColor = System.Drawing.Color.DarkViolet;
            this.ctrlUserNameSeparator.LineThickness = 5;
            this.ctrlUserNameSeparator.Location = new System.Drawing.Point(27, 141);
            this.ctrlUserNameSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlUserNameSeparator.Name = "ctrlUserNameSeparator";
            this.ctrlUserNameSeparator.Padding = new System.Windows.Forms.Padding(0);
            this.ctrlUserNameSeparator.Size = new System.Drawing.Size(189, 5);
            this.ctrlUserNameSeparator.TabIndex = 2;
            // 
            // ctrlUserName
            // 
            this.ctrlUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ctrlUserName.EditValue = "UserName";
            this.ctrlUserName.Location = new System.Drawing.Point(27, 117);
            this.ctrlUserName.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlUserName.Name = "ctrlUserName";
            this.ctrlUserName.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.ctrlUserName.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUserName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ctrlUserName.Properties.Appearance.Options.UseBackColor = true;
            this.ctrlUserName.Properties.Appearance.Options.UseFont = true;
            this.ctrlUserName.Properties.Appearance.Options.UseForeColor = true;
            this.ctrlUserName.Properties.AppearanceFocused.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlUserName.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White;
            this.ctrlUserName.Properties.AppearanceFocused.Options.UseFont = true;
            this.ctrlUserName.Properties.AppearanceFocused.Options.UseForeColor = true;
            this.ctrlUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ctrlUserName.Size = new System.Drawing.Size(189, 22);
            this.ctrlUserName.TabIndex = 1;
            this.ctrlUserName.Enter += new System.EventHandler(this.ctrlUserName_Enter);
            this.ctrlUserName.Leave += new System.EventHandler(this.ctrlUserName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlShowPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPasswordSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUserNameSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlUserName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit ctrlUserName;
        private DevExpress.XtraEditors.SeparatorControl ctrlUserNameSeparator;
        private DevExpress.XtraEditors.CheckEdit ctrlShowPassword;
        private DevExpress.XtraEditors.LabelControl lblClear;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SeparatorControl ctrlPasswordSeparator;
        private DevExpress.XtraEditors.TextEdit ctrlPassword;
    }
}

