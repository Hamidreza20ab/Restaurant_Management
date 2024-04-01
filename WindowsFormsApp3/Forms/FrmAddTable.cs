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
    public partial class FrmAddTable : Form
    {RepositoryCRUD<Tables> table = new RepositoryCRUD<Tables>();
        public int tableId = 0;
        public FrmAddTable()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        { string status;
            if (chkStatus.Checked==true) {
                status = "فعال";
            }
            else { status = "غیرفعال"; }
            Tables newTable = new Tables()
            {
                TableName = txtName.Text,
                TableSize = (int)txtSize.Value,TableStatus = status

            };
            if (tableId == 0)
            {
                table.Insert(newTable);
            }
            else
            {
                var existingTable = table.GetById(tableId);
                if (existingTable != null)
                {

                    existingTable.TableName = newTable.TableName;


                    table.Update(existingTable);
                }
            }


            table.Save();


            this.Close();


            DialogResult = DialogResult.OK;
        }

        private void FrmAddTable_Load(object sender, EventArgs e)
        {
            if (tableId != 0)
            {
                lblTitle.Text = "ویرایش میز";
                btnSubmit.Text = "ویرایش";
                using (RS_Model rs = new RS_Model())
                {
                    var tables = table.GetById(tableId);
                    txtName.Text = tables.TableName;
                }

            }
        }
    }
}
