using Restaurant_Management.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        frmDashboard dashboard;
        frmCategories categories;
        FrmFoodsList foodsList;
        FrmTables tables;
        FrmEmployees employees;
        FrmOrders orders;
        frmKitchen kitchen;
        FrmTickets tickets;
        public Form1()
        {
            InitializeComponent();
        }
        public void AddControls(Form form)
        {
            Form1 n = new Form1();
            n.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            n.Controls.Add(form);
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (dashboard == null)
            {
                dashboard = new frmDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.Activate();
            }
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();


        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 4;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebar.Width = sidebar.MinimumSize.Width; // Ensure it doesn't go below minimum
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    pnDashboard.Width = sidebar.Width;
                    pnCategories.Width = sidebar.Width;
                    pnFoods.Width = sidebar.Width;
                    pnTables.Width = sidebar.Width;
                    pnEmployees.Width = sidebar.Width;
                    pnOrders.Width = sidebar.Width;
                    pnKitchen.Width = sidebar.Width;
                    pnTickets.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 4;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebar.Width = sidebar.MaximumSize.Width; // Ensure it doesn't go above maximum
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    pnDashboard.Width = sidebar.Width;
                    pnCategories.Width = sidebar.Width;
                    pnFoods.Width = sidebar.Width;
                    pnTables.Width = sidebar.Width;
                    pnEmployees.Width = sidebar.Width;
                    pnOrders.Width = sidebar.Width;
                    pnKitchen.Width = sidebar.Width;
                    pnTickets.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;

                }
            }



        }

        private void btnCategories_Click(object sender, EventArgs e)
        {

            if (categories == null)
            {
                categories = new frmCategories();
                categories.FormClosed += Categories_FormClosed;
                categories.MdiParent = this;
                categories.Dock = DockStyle.Fill;
                categories.Show();
            }
            else
            {
                categories.Activate();
            }
        }
        private void Categories_FormClosed(object sender, FormClosedEventArgs e)
        {
            categories = null;
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            if (foodsList == null)
            {
                foodsList = new FrmFoodsList();
                foodsList.FormClosed += FoodsList_FormClosed;
                foodsList.MdiParent = this;
                foodsList.Dock = DockStyle.Fill;
                foodsList.Show();
            }
            else
            {
                foodsList.Activate();
            }
        }
        private void FoodsList_FormClosed(object sender, FormClosedEventArgs e)
        {
            foodsList = null;
        }

        private void btnTables_Click(object sender, EventArgs e)
        {

            if (tables == null)
            {
                tables = new FrmTables();
                tables.FormClosed += Tables_FormClosed;
                tables.MdiParent = this;
                tables.Dock = DockStyle.Fill;
                tables.Show();
            }
            else
            {
                tables.Activate();
            }
        }
        private void Tables_FormClosed(object sender, FormClosedEventArgs e)
        {
            tables = null;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (employees == null)
            {
                employees = new FrmEmployees();
                employees.FormClosed += Employees_FormClosed;
                employees.MdiParent = this;
                employees.Dock = DockStyle.Fill;
                employees.Show();
            }
            else
            {
                employees.Activate();
            }
        }
        private void Employees_FormClosed(object sender, FormClosedEventArgs e)
        {
            employees = null;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (orders == null)
            {
                orders = new FrmOrders();
                orders.FormClosed += Orders_FormClosed;
                orders.MdiParent = this;
                orders.Dock = DockStyle.Fill;
                orders.Show();
            }
            else
            {
                orders.Activate();
            }
        }
        private void Orders_FormClosed(object sender, FormClosedEventArgs e)
        {
            orders = null;
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            if (kitchen == null)
            {
                kitchen = new frmKitchen();
                kitchen.FormClosed += Kitchen_FormClosed;
                kitchen.MdiParent = this;
                kitchen.Dock = DockStyle.Fill;
                kitchen.Show();
            }
            else
            {
                kitchen.Activate();
            }
        }
        private void Kitchen_FormClosed(object sender, FormClosedEventArgs e)
        {
            kitchen = null;
        }
        private void btnTickets_Click(object sender, EventArgs e)
        {
            if (tickets == null)
            {
                tickets = new FrmTickets();
                tickets.FormClosed += Tickets_FormClosed;
                tickets.MdiParent = this;
                tickets.Dock = DockStyle.Fill;
                tickets.Show();
            }
            else
            {
                tickets.Activate();
            }
        }
        private void Tickets_FormClosed(object sender, FormClosedEventArgs e)
        {
            tickets = null;
        }
    }
}
