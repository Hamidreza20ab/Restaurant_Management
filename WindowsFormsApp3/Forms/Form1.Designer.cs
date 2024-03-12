namespace WindowsFormsApp3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pnLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnTickets = new System.Windows.Forms.Panel();
            this.btnTickets = new System.Windows.Forms.Button();
            this.pnKitchen = new System.Windows.Forms.Panel();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.pnOrders = new System.Windows.Forms.Panel();
            this.btnOrders = new System.Windows.Forms.Button();
            this.pnEmployees = new System.Windows.Forms.Panel();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.pnTables = new System.Windows.Forms.Panel();
            this.btnTables = new System.Windows.Forms.Button();
            this.pnFoods = new System.Windows.Forms.Panel();
            this.btnFoods = new System.Windows.Forms.Button();
            this.pnCategories = new System.Windows.Forms.Panel();
            this.btnCategories = new System.Windows.Forms.Button();
            this.pnDashboard = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnLogout.SuspendLayout();
            this.pnTickets.SuspendLayout();
            this.pnKitchen.SuspendLayout();
            this.pnOrders.SuspendLayout();
            this.pnEmployees.SuspendLayout();
            this.pnTables.SuspendLayout();
            this.pnFoods.SuspendLayout();
            this.pnCategories.SuspendLayout();
            this.pnDashboard.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 36);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(1196, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kalameh", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1010, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "نرم افزار مدیریت رستوران";
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // pnLogout
            // 
            this.pnLogout.Controls.Add(this.btnLogout);
            this.pnLogout.Location = new System.Drawing.Point(-21, 568);
            this.pnLogout.Margin = new System.Windows.Forms.Padding(3, 80, 3, 3);
            this.pnLogout.Name = "pnLogout";
            this.pnLogout.Size = new System.Drawing.Size(218, 55);
            this.pnLogout.TabIndex = 11;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.btnLogout.Font = new System.Drawing.Font("Kalameh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::WindowsFormsApp3.Properties.Resources.icons8_logout_64__2_;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, -15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnLogout.Size = new System.Drawing.Size(228, 79);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "خروج";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // pnTickets
            // 
            this.pnTickets.Controls.Add(this.btnTickets);
            this.pnTickets.Location = new System.Drawing.Point(-21, 430);
            this.pnTickets.Name = "pnTickets";
            this.pnTickets.Size = new System.Drawing.Size(218, 55);
            this.pnTickets.TabIndex = 10;
            // 
            // btnTickets
            // 
            this.btnTickets.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.btnTickets.Font = new System.Drawing.Font("Kalameh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTickets.ForeColor = System.Drawing.Color.White;
            this.btnTickets.Image = global::WindowsFormsApp3.Properties.Resources.icons8_email_48;
            this.btnTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTickets.Location = new System.Drawing.Point(-14, -15);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnTickets.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnTickets.Size = new System.Drawing.Size(242, 79);
            this.btnTickets.TabIndex = 2;
            this.btnTickets.Text = "نامه نگاری";
            this.btnTickets.UseVisualStyleBackColor = false;
            // 
            // pnKitchen
            // 
            this.pnKitchen.Controls.Add(this.btnKitchen);
            this.pnKitchen.Location = new System.Drawing.Point(-21, 369);
            this.pnKitchen.Name = "pnKitchen";
            this.pnKitchen.Size = new System.Drawing.Size(218, 55);
            this.pnKitchen.TabIndex = 9;
            // 
            // btnKitchen
            // 
            this.btnKitchen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.btnKitchen.Font = new System.Drawing.Font("Kalameh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.ForeColor = System.Drawing.Color.White;
            this.btnKitchen.Image = global::WindowsFormsApp3.Properties.Resources.icons8_chef_50;
            this.btnKitchen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKitchen.Location = new System.Drawing.Point(-14, -15);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnKitchen.Size = new System.Drawing.Size(242, 79);
            this.btnKitchen.TabIndex = 2;
            this.btnKitchen.Text = "آشپزخانه";
            this.btnKitchen.UseVisualStyleBackColor = false;
            // 
            // pnOrders
            // 
            this.pnOrders.Controls.Add(this.btnOrders);
            this.pnOrders.Location = new System.Drawing.Point(-21, 308);
            this.pnOrders.Name = "pnOrders";
            this.pnOrders.Size = new System.Drawing.Size(218, 55);
            this.pnOrders.TabIndex = 8;
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.btnOrders.Font = new System.Drawing.Font("Kalameh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Image = global::WindowsFormsApp3.Properties.Resources.icons8_order_48;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(-14, -15);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnOrders.Size = new System.Drawing.Size(242, 79);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "سفارش گیری";
            this.btnOrders.UseVisualStyleBackColor = false;
            // 
            // pnEmployees
            // 
            this.pnEmployees.Controls.Add(this.btnEmployees);
            this.pnEmployees.Location = new System.Drawing.Point(-21, 247);
            this.pnEmployees.Name = "pnEmployees";
            this.pnEmployees.Size = new System.Drawing.Size(218, 55);
            this.pnEmployees.TabIndex = 7;
            // 
            // btnEmployees
            // 
            this.btnEmployees.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.btnEmployees.Font = new System.Drawing.Font("Kalameh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Image = global::WindowsFormsApp3.Properties.Resources.icons8_person_64__2_;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(-14, -15);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnEmployees.Size = new System.Drawing.Size(242, 79);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "کارکنان";
            this.btnEmployees.UseVisualStyleBackColor = false;
            // 
            // pnTables
            // 
            this.pnTables.Controls.Add(this.btnTables);
            this.pnTables.Location = new System.Drawing.Point(-21, 186);
            this.pnTables.Name = "pnTables";
            this.pnTables.Size = new System.Drawing.Size(218, 55);
            this.pnTables.TabIndex = 6;
            // 
            // btnTables
            // 
            this.btnTables.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.btnTables.Font = new System.Drawing.Font("Kalameh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTables.ForeColor = System.Drawing.Color.White;
            this.btnTables.Image = global::WindowsFormsApp3.Properties.Resources.icons8_table_26;
            this.btnTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTables.Location = new System.Drawing.Point(-14, -15);
            this.btnTables.Name = "btnTables";
            this.btnTables.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnTables.Size = new System.Drawing.Size(242, 79);
            this.btnTables.TabIndex = 2;
            this.btnTables.Text = "میز ها";
            this.btnTables.UseVisualStyleBackColor = false;
            // 
            // pnFoods
            // 
            this.pnFoods.Controls.Add(this.btnFoods);
            this.pnFoods.Location = new System.Drawing.Point(-21, 125);
            this.pnFoods.Name = "pnFoods";
            this.pnFoods.Size = new System.Drawing.Size(218, 55);
            this.pnFoods.TabIndex = 5;
            // 
            // btnFoods
            // 
            this.btnFoods.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.btnFoods.Font = new System.Drawing.Font("Kalameh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoods.ForeColor = System.Drawing.Color.White;
            this.btnFoods.Image = global::WindowsFormsApp3.Properties.Resources.icons8_process_lists_66__1_;
            this.btnFoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoods.Location = new System.Drawing.Point(-14, -15);
            this.btnFoods.Name = "btnFoods";
            this.btnFoods.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnFoods.Size = new System.Drawing.Size(242, 79);
            this.btnFoods.TabIndex = 2;
            this.btnFoods.Text = "لیست غذا ها";
            this.btnFoods.UseVisualStyleBackColor = false;
            // 
            // pnCategories
            // 
            this.pnCategories.Controls.Add(this.btnCategories);
            this.pnCategories.Location = new System.Drawing.Point(-21, 64);
            this.pnCategories.Name = "pnCategories";
            this.pnCategories.Size = new System.Drawing.Size(218, 55);
            this.pnCategories.TabIndex = 4;
            // 
            // btnCategories
            // 
            this.btnCategories.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.btnCategories.Font = new System.Drawing.Font("Kalameh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Image = global::WindowsFormsApp3.Properties.Resources.icons8_categorize_64__1_;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(-14, -15);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnCategories.Size = new System.Drawing.Size(242, 79);
            this.btnCategories.TabIndex = 2;
            this.btnCategories.Text = "دسته بندی غذا ها";
            this.btnCategories.UseVisualStyleBackColor = false;
            // 
            // pnDashboard
            // 
            this.pnDashboard.Controls.Add(this.btnDashboard);
            this.pnDashboard.Location = new System.Drawing.Point(-21, 3);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(218, 55);
            this.pnDashboard.TabIndex = 3;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.btnDashboard.Font = new System.Drawing.Font("Kalameh", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::WindowsFormsApp3.Properties.Resources.icons8_line_chart_24;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(-14, -15);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(0, 0, 35, 0);
            this.btnDashboard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDashboard.Size = new System.Drawing.Size(242, 79);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "داشبورد";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(35)))));
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Controls.Add(this.pnCategories);
            this.sidebar.Controls.Add(this.pnFoods);
            this.sidebar.Controls.Add(this.pnTables);
            this.sidebar.Controls.Add(this.pnEmployees);
            this.sidebar.Controls.Add(this.pnOrders);
            this.sidebar.Controls.Add(this.pnKitchen);
            this.sidebar.Controls.Add(this.pnTickets);
            this.sidebar.Controls.Add(this.pnLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebar.Location = new System.Drawing.Point(1048, 36);
            this.sidebar.MaximumSize = new System.Drawing.Size(200, 694);
            this.sidebar.MinimumSize = new System.Drawing.Size(86, 680);
            this.sidebar.Name = "sidebar";
            this.sidebar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sidebar.Size = new System.Drawing.Size(200, 694);
            this.sidebar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 730);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnLogout.ResumeLayout(false);
            this.pnTickets.ResumeLayout(false);
            this.pnKitchen.ResumeLayout(false);
            this.pnOrders.ResumeLayout(false);
            this.pnEmployees.ResumeLayout(false);
            this.pnTables.ResumeLayout(false);
            this.pnFoods.ResumeLayout(false);
            this.pnCategories.ResumeLayout(false);
            this.pnDashboard.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnTickets;
        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.Panel pnKitchen;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Panel pnOrders;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Panel pnEmployees;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Panel pnTables;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Panel pnFoods;
        private System.Windows.Forms.Button btnFoods;
        private System.Windows.Forms.Panel pnCategories;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Panel pnDashboard;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
    }
}

