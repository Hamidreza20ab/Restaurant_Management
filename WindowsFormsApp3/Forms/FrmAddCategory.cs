using Restaurant_Management.DataLayer.Models;
using Restaurant_Management.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.Forms
{
    public partial class FrmAddCategory : Form
    {   RepositoryCRUD<Categories> cat = new RepositoryCRUD<Categories>();
       
        public int categoryId = 0;

        public FrmAddCategory()
        {
            InitializeComponent(); 
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories()
            {
                CategoryName = txtName.Text,
            };

            if (categoryId == 0)
            {
                cat.Insert(categories);
            }
            else
            {
                var existingCategory = cat.GetById(categoryId); 
                if (existingCategory != null)
                {
                    
                    existingCategory.CategoryName = categories.CategoryName;

                 
                    cat.Update(existingCategory);
                }
            }

            
            cat.Save();

            
            this.Close();

           
            DialogResult = DialogResult.OK;
            

        }

        private void FrmAddCategory_Load(object sender, EventArgs e)
        {
            
            if (categoryId != 0)
            {
                lblTitle.Text = "ویرایش دسته بندی";
                btnSubmit.Text = "ویرایش";
                using (RS_Model rs = new RS_Model())
                {
                    var category = cat.GetById(categoryId);
                    txtName.Text = category.CategoryName;
                }

            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
