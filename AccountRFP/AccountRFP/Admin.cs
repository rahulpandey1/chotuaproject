using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRFP
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent(); 
            dataGridView1.Rows.Add(GetNewRow(DataSetupGrid.GetNewGridData()));
        }      

        private DataGridViewRow GetNewRow(GridData gridData)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dataGridView1);
            newRow.Cells[0].Value = gridData.no;
            DataGridViewComboBoxColumn comboBoxColumn = this.dataGridView1.Columns["vertical"] as DataGridViewComboBoxColumn;
            comboBoxColumn = CreateComboBoxWithEnums(gridData.vertical);              
            newRow.Cells[2].Value = gridData.customer;
            //newRow.Cells[3].Value = new BindingSource(gridData.b2bproducts, null);  ;
            newRow.Cells[4].Value = gridData.dealDescr;
            newRow.Cells[5].Value = gridData.engType;
            newRow.Cells[6].Value = gridData.dealSize;
            newRow.Cells[7].Value = gridData.cp;
            //newRow.Cells[8].Value = new BindingSource(gridData.currentStatus, null);  ;
            newRow.Cells[9].Value = gridData.comments;
            newRow.Cells[10].Value = gridData.pocName;
            newRow.Cells[11].Value = gridData.month;
            return newRow;
        }
        DataGridViewComboBoxColumn CreateComboBoxWithEnums(object input)
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = new BindingSource(input, null);
            combo.DataPropertyName = "Key";
            combo.Name = "Value";
            return combo;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
