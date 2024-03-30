using Restaurant_Management.DataLayer.Models;
using Restaurant_Management.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class frmCategories : Form
    {
        RepositoryCRUD<Categories> cat = new RepositoryCRUD<Categories>();
        public frmCategories()
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = cat.GetAll();
            guna2DataGridView1.AutoGenerateColumns=false;
            guna2DataGridView1.Columns["Foods"].Visible=false;
            
            
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {RS_Model rs = new RS_Model();
            guna2DataGridView1.DataSource = (rs.Categories.Where(item => item.CategoryName.Contains(txtSearchBox.Text)).ToList());
            cat.GetAll();
            
        }

        private void pcNewCategory_Click(object sender, EventArgs e)
        {
            FrmAddCategory frm = new FrmAddCategory();
            frm.ShowDialog();
            
        }
    }
}
