using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

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
    }
}
