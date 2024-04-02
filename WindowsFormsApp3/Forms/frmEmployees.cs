using Guna.UI2.WinForms;
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
    public partial class FrmEmployees : Form
    {
        RepositoryCRUD<Employees> employees = new RepositoryCRUD<Employees>();
        public FrmEmployees()
        {
            InitializeComponent();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.DataSource = employees.GetAll();
        }

        private void pcNewEmployee_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frmAddEmployee = new FrmAddEmployee();
            frmAddEmployee.ShowDialog();
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            RS_Model rs = new RS_Model();
            dgvEmployees.DataSource = (rs.Employees.Where(item => item.FirstName.Contains(txtSearchBox.Text) || item.LastName.Contains(txtSearchBox.Text) || item.MobileNumber.Contains(txtSearchBox.Text)).ToList());
            employees.GetAll();
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.CurrentCell.OwningColumn.Name == "dgvEdit")
            {



                if (dgvEmployees.CurrentRow != null)
                {

                    int employeeId = int.Parse(dgvEmployees.CurrentRow.Cells["dgvEmployeeID"].Value.ToString());
                    FrmAddEmployee frmAdd = new FrmAddEmployee();
                    frmAdd.employeeId = employeeId;
                    if (frmAdd.ShowDialog() == DialogResult.OK)
                    {
                        employees.GetAll();

                    }


                }


            }
            if (dgvEmployees.CurrentCell.OwningColumn.Name == "dgvDelete")
            {
                if (dgvEmployees.CurrentRow != null)
                {
                    string name = Convert.ToString(dgvEmployees.CurrentRow.Cells["dgvName"].Value);
                    string lastName = Convert.ToString(dgvEmployees.CurrentRow.Cells["dgvLastName"].Value);
                    int employeeId = int.Parse(dgvEmployees.CurrentRow.Cells["dgvEmployeeID"].Value.ToString());
                    var existingemployee = employees.GetById(employeeId);
                    if (MessageBox.Show($"آیا از حذف {name + lastName} مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        employees.DeleteById(employeeId);
                        employees.Save();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("لطفا یک کارمند را انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
        private void LoadData()
        {
            var data = employees.GetAll();
            dgvEmployees.DataSource = data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmuser frmuser = new frmuser();
            frmuser.ShowDialog();

        }

        private void pcRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
