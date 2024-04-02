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
    public partial class FrmAddEmployee : Form
    {
        RepositoryCRUD<Employees> emp = new RepositoryCRUD<Employees>();

        public int employeeId = 0;
        public FrmAddEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool status;
            if (chkStatus.Checked==true)
            {
                status =true;
            }
            else
            {
                status=false;
            }
            Employees employee = new Employees()
            {
                UserID = (int)txtUserId.Value,
                FirstName = txtName.Text,
                LastName = txtLastName.Text,
                TitleID = comboRole.SelectedIndex+1,
                MobileNumber = txtMobliePhone.Text,
                HomePhone = txtHomePhone.Text,
                LastDegree = txtlastDegree.Text,
                HireDate = dateTimePicker2.Value,
                Birthdate = dateTimePicker1.Value,
                EmployeeStatus = status,
                Address = txtAddress.Text,

            };

            if (employeeId == 0)
            {
                emp.Insert(employee);

            }
            else
            {
                var existingEmployee = emp.GetById(employeeId);

                if (existingEmployee != null)
                {

                    existingEmployee.FirstName = employee.FirstName;
                    existingEmployee.LastName = employee.LastName;
                    existingEmployee.TitleID = employee.TitleID;
                    existingEmployee.HomePhone = employee.HomePhone;
                    existingEmployee.LastDegree = employee.LastDegree;
                    existingEmployee.HireDate = employee.HireDate;
                    existingEmployee.Birthdate = employee.Birthdate;



                    emp.Update(existingEmployee);
                }
            }


            emp.Save();


            this.Close();


            DialogResult = DialogResult.OK;

        }

        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            if (employeeId != 0)
            {
                lblTitle.Text = "ویرایش کارکنان";
                btnSubmit.Text = "ویرایش";
                using (RS_Model rs = new RS_Model())
                {
                    var employee = emp.GetById(employeeId);
                    txtName.Text = employee.FirstName;
                    txtLastName.Text = employee.LastName;
                    txtlastDegree.Text = employee.LastDegree;
                    txtMobliePhone.Text = employee.MobileNumber;
                    txtHomePhone.Text = employee.HomePhone;
                    txtAddress.Text = employee.Address;
                    

                }

            }
        }
    }
}
