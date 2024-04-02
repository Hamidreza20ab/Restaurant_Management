using Guna.UI2.WinForms;
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
    public partial class FrmTables : Form
    {RepositoryCRUD<Tables> table = new RepositoryCRUD<Tables>();
        public FrmTables()
        {
            InitializeComponent();
        }

        private void FrmTables_Load(object sender, EventArgs e)
        {
            dgvTables.AutoGenerateColumns=false;
            dgvTables.DataSource=table.GetAll();
        }

        private void pcNewTable_Click(object sender, EventArgs e)
        {
            FrmAddTable frmAddTable = new FrmAddTable();
            frmAddTable.ShowDialog();

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            RS_Model rs = new RS_Model();
            dgvTables.DataSource = (rs.Tables.Where(item => item.TableName.Contains(txtSearchBox.Text)).ToList());
            table.GetAll();
        }

        private void dgvTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTables.CurrentCell.OwningColumn.Name == "dgvEdit")
            {



                if (dgvTables.CurrentRow != null)
                {

                    int tableId = int.Parse(dgvTables.CurrentRow.Cells["dgvID"].Value.ToString());
                    FrmAddTable frmAdd = new FrmAddTable();
                    frmAdd.tableId = tableId;
                    if (frmAdd.ShowDialog() == DialogResult.OK)
                    {
                        table.GetAll();

                    }


                }


            }
            if (dgvTables.CurrentCell.OwningColumn.Name == "dgvDelete")
            {
                if (dgvTables.CurrentRow != null)
                {
                    string name = Convert.ToString(dgvTables.CurrentRow.Cells["dgvName"].Value);
                    int tableId = int.Parse(dgvTables.CurrentRow.Cells["dgvID"].Value.ToString());
                    var existingTable = table.GetById(tableId);
                    if (MessageBox.Show($"آیا از حذف {name} مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        table.DeleteById(tableId);
                        table.Save();
                    }
                    else
                    {
                        MessageBox.Show("لطفا یک دسته بندی را انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void pcRefresh_Click(object sender, EventArgs e)
        {

            dgvTables.DataSource = table.GetAll();


        }
    }
    }

