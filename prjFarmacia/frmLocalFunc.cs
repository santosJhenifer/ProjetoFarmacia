using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjFarmacia
{
    public partial class frmLocalFunc : Form
    {
        public frmLocalFunc()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._farmacia_mdfDataSet);

        }

        private void frmLocalFunc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this._farmacia_mdfDataSet.funcionario);

        }

        private void txtLocalFunc_TextChanged(object sender, EventArgs e)
        {
            funcionarioBindingSource.Filter = "fun_nome like '" + txtLocalFunc.Text + "%'";
        }

        private void funcionarioDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Class1.CodTroca = int.Parse(funcionarioDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                Class1.CodTroca = 0;
            }
            this.Dispose();
        }
    }
}
