using Restaurant_Management.DataLayer.Models;
using Restaurant_Management.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.Columns["Foods"].Visible = false;
            

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            RS_Model rs = new RS_Model();
            guna2DataGridView1.DataSource = (rs.Categories.Where(item => item.CategoryName.Contains(txtSearchBox.Text)).ToList());
            cat.GetAll();

        }

        private void pcNewCategory_Click(object sender, EventArgs e)
        {
            FrmAddCategory frm = new FrmAddCategory();
            frm.ShowDialog();

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {



                if (guna2DataGridView1.CurrentRow != null)
                {
                    
                    int categoryId = int.Parse(guna2DataGridView1.CurrentRow.Cells["dgvID"].Value.ToString());
                    FrmAddCategory frmAdd = new FrmAddCategory();
                    frmAdd.categoryId = categoryId;
                    if (frmAdd.ShowDialog() == DialogResult.OK)
                    {
                        cat.GetAll();
                        
                    }


                }


            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvDelete")
            {
                if (guna2DataGridView1.CurrentRow != null)
                {
                    string name = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                    int categoryId = int.Parse(guna2DataGridView1.CurrentRow.Cells["dgvID"].Value.ToString());
                    var existingCategory = cat.GetById(categoryId);
                    if (MessageBox.Show($"آیا از حذف {name} مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        cat.DeleteById(categoryId);
                        cat.Save();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("لطفا یک دسته بندی را انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
        private void LoadData()
        {
            var data = cat.GetAll();
            guna2DataGridView1.DataSource = data;
        }
        private void pcRefresh_Click(object sender, EventArgs e)
        {
            
           LoadData();
           
            
        }
        
    }
}



