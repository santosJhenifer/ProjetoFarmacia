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
    public partial class frmLocalizarCli : Form
    {
        public frmLocalizarCli()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._farmacia_mdfDataSet);

        }

        private void frmLocalizarCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this._farmacia_mdfDataSet.cliente);

        }

        private void txtLocalCli_TextChanged(object sender, EventArgs e)
        {
            clienteBindingSource.Filter = "cli_nome like'" + txtLocalCli.Text + "%'";
        }

        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Class1.CodTroca = int.Parse(clienteDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                Class1.CodTroca = 0;
            }
            this.Dispose();
        }
    }
}
