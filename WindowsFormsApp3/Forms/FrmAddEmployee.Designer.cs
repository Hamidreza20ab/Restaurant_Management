namespace WindowsFormsApp3.Forms
{
    partial class FrmAddEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpBirthDate = new System.Windows.Forms.PersianDatePicker();
            this.dtpHireDate = new System.Windows.Forms.PersianDatePicker();
            this.comboRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblhireDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtMobliePhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHomePhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMobliePhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Vazirmatn", 14F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(645, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(114, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "افزودن کارمند";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazirmatn", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(469, 95);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(243, 37);
            this.txtName.TabIndex = 4;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(469, 155);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(243, 37);
            this.guna2TextBox1.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(61, 348);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(664, 57);
            this.txtAddress.TabIndex = 6;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.AutoSize = true;
            this.dtpBirthDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dtpBirthDate.BackColor = System.Drawing.Color.White;
            this.dtpBirthDate.GeorgianDate = null;
            this.dtpBirthDate.Location = new System.Drawing.Point(56, 111);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.PersianDate.Day = 0;
            this.dtpBirthDate.PersianDate.Month = 0;
            this.dtpBirthDate.PersianDate.Year = 0;
            this.dtpBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpBirthDate.Size = new System.Drawing.Size(248, 21);
            this.dtpBirthDate.TabIndex = 16;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.AutoSize = true;
            this.dtpHireDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dtpHireDate.BackColor = System.Drawing.Color.White;
            this.dtpHireDate.GeorgianDate = null;
            this.dtpHireDate.Location = new System.Drawing.Point(56, 182);
            this.dtpHireDate.Margin = new System.Windows.Forms.Padding(0);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.PersianDate.Day = 0;
            this.dtpHireDate.PersianDate.Month = 0;
            this.dtpHireDate.PersianDate.Year = 0;
            this.dtpHireDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpHireDate.Size = new System.Drawing.Size(248, 21);
            this.dtpHireDate.TabIndex = 17;
            // 
            // comboRole
            // 
            this.comboRole.BackColor = System.Drawing.Color.Transparent;
            this.comboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboRole.ItemHeight = 30;
            this.comboRole.Location = new System.Drawing.Point(469, 214);
            this.comboRole.Name = "comboRole";
            this.comboRole.Size = new System.Drawing.Size(243, 36);
            this.comboRole.TabIndex = 18;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Vazirmatn", 9.25F);
            this.lblBirthDate.Location = new System.Drawing.Point(325, 113);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(63, 22);
            this.lblBirthDate.TabIndex = 19;
            this.lblBirthDate.Text = "تاریخ تولد:";
            // 
            // lblhireDate
            // 
            this.lblhireDate.AutoSize = true;
            this.lblhireDate.Font = new System.Drawing.Font("Vazirmatn", 9.25F);
            this.lblhireDate.Location = new System.Drawing.Point(325, 182);
            this.lblhireDate.Name = "lblhireDate";
            this.lblhireDate.Size = new System.Drawing.Size(87, 22);
            this.lblhireDate.TabIndex = 20;
            this.lblhireDate.Text = "تاریخ استخدام:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Vazirmatn", 9.25F);
            this.lblName.Location = new System.Drawing.Point(731, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 22);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "نام:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Vazirmatn", 9.25F);
            this.lblLastName.Location = new System.Drawing.Point(718, 170);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 22);
            this.lblLastName.TabIndex = 22;
            this.lblLastName.Text = "نام خانوادگی:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Vazirmatn", 9.25F);
            this.lblRole.Location = new System.Drawing.Point(731, 228);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(43, 22);
            this.lblRole.TabIndex = 23;
            this.lblRole.Text = "سمت:";
            // 
            // txtMobliePhone
            // 
            this.txtMobliePhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobliePhone.DefaultText = "";
            this.txtMobliePhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMobliePhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMobliePhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobliePhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobliePhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobliePhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMobliePhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobliePhone.Location = new System.Drawing.Point(469, 271);
            this.txtMobliePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMobliePhone.Name = "txtMobliePhone";
            this.txtMobliePhone.PasswordChar = '\0';
            this.txtMobliePhone.PlaceholderText = "";
            this.txtMobliePhone.SelectedText = "";
            this.txtMobliePhone.Size = new System.Drawing.Size(243, 37);
            this.txtMobliePhone.TabIndex = 24;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHomePhone.DefaultText = "";
            this.txtHomePhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHomePhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHomePhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHomePhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHomePhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHomePhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHomePhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHomePhone.Location = new System.Drawing.Point(61, 271);
            this.txtHomePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.PasswordChar = '\0';
            this.txtHomePhone.PlaceholderText = "";
            this.txtHomePhone.SelectedText = "";
            this.txtHomePhone.Size = new System.Drawing.Size(243, 37);
            this.txtHomePhone.TabIndex = 25;
            // 
            // lblMobliePhone
            // 
            this.lblMobliePhone.AutoSize = true;
            this.lblMobliePhone.Font = new System.Drawing.Font("Vazirmatn", 9.25F);
            this.lblMobliePhone.Location = new System.Drawing.Point(718, 286);
            this.lblMobliePhone.Name = "lblMobliePhone";
            this.lblMobliePhone.Size = new System.Drawing.Size(75, 22);
            this.lblMobliePhone.TabIndex = 26;
            this.lblMobliePhone.Text = "شماره همراه:";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Font = new System.Drawing.Font("Vazirmatn", 9.25F);
            this.lblHomePhone.Location = new System.Drawing.Point(310, 286);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(70, 22);
            this.lblHomePhone.TabIndex = 27;
            this.lblHomePhone.Text = "شماره منزل:";
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(61, 214);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(243, 37);
            this.guna2TextBox3.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazirmatn", 9.25F);
            this.label2.Location = new System.Drawing.Point(310, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "آخرین مدرک:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Vazirmatn", 9.25F);
            this.lblAddress.Location = new System.Drawing.Point(733, 365);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 22);
            this.lblAddress.TabIndex = 30;
            this.lblAddress.Text = "آدرس:";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Font = new System.Drawing.Font("Vazirmatn", 8.25F);
            this.chkStatus.Location = new System.Drawing.Point(641, 422);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(84, 23);
            this.chkStatus.TabIndex = 31;
            this.chkStatus.Text = "وضعیت کاربر";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.btnSubmit.Font = new System.Drawing.Font("Vazirmatn", 9.25F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(61, 422);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 40);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.lblMobliePhone);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.txtMobliePhone);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblhireDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FrmAddEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        public Guna.UI2.WinForms.Guna2TextBox txtName;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        public Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.PersianDatePicker dtpBirthDate;
        private System.Windows.Forms.PersianDatePicker dtpHireDate;
        private Guna.UI2.WinForms.Guna2ComboBox comboRole;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblhireDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblRole;
        public Guna.UI2.WinForms.Guna2TextBox txtMobliePhone;
        public Guna.UI2.WinForms.Guna2TextBox txtHomePhone;
        private System.Windows.Forms.Label lblMobliePhone;
        private System.Windows.Forms.Label lblHomePhone;
        public Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.Button btnSubmit;
    }
}