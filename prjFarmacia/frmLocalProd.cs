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
    public partial class frmLocalProd : Form
    {
        public frmLocalProd()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._farmacia_mdfDataSet);

        }

        private void frmLocalProd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this._farmacia_mdfDataSet.produto);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            produtoBindingSource.Filter = "pro_descrição like'" + textBox1.Text + "%'";
        }

        private void produtoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Class1.CodTroca = int.Parse(produtoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                Class1.CodTroca = 0;
            }
            this.Dispose();
        }
    }
}
