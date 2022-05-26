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
    public partial class frmLocalizarCid : Form
    {
        public frmLocalizarCid()
        {
            InitializeComponent();
        }

        private void cidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cidadeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._farmacia_mdfDataSet);

        }

        private void frmLocalizarCid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this._farmacia_mdfDataSet.cidade);

        }

        private void txtLocalCid_TextChanged(object sender, EventArgs e)
        {
            cidadeBindingSource.Filter = "cid_nome like '" + txtLocalCid.Text + "%'";
        }

        private void cidadeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Class1.CodTroca=int.Parse(cidadeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                Class1.CodTroca = 0;
            }
            this.Dispose();
        }
    }
}
