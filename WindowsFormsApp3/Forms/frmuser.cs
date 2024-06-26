﻿using Restaurant_Management.DataLayer.Models;
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
    public partial class frmuser : Form
    { RepositoryCRUD<Users>user = new RepositoryCRUD<Users>();
        public frmuser()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Users newUser = new Users()
            { UserName = txtUserName.Text, Password = txtPassword.Text,CreationDate=DateTime.Now
            };
            user.Insert(newUser);
            user.Save();
            this.Close();
        }
    }
}
