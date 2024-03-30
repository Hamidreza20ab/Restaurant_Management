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
    public partial class FrmAddCategory : Form
    {
        public FrmAddCategory()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        { 
            RepositoryCRUD<Categories> cat = new RepositoryCRUD<Categories>();
            var Name = txtName.Text;
            var category = new Categories();
            category.CategoryName = Name;
            
            cat.Insert(category);
            cat.Save();
            this.Close();
            
        }
    }
}
