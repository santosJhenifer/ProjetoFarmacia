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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                 this.Validate();
                 this.produtoBindingSource.EndEdit();
                 this.tableAdapterManager.UpdateAll(this._farmacia_mdfDataSet);
                 gbProduto.Enabled = false;
                 MessageBox.Show("Registro Salvo", "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar seu registro" + erro.Message, "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                produtoTableAdapter.Fill(_farmacia_mdfDataSet.produto);
            }

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this._farmacia_mdfDataSet.produto);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gbProduto.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            gbProduto.Enabled = false;
            produtoBindingSource.CancelEdit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            gbProduto.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirmar exclusão", "Farmácia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    produtoBindingSource.RemoveCurrent();
                    produtoTableAdapter.Update(_farmacia_mdfDataSet.produto);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Registro não pode ser removido" + erro.Message, "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                produtoTableAdapter.Fill(_farmacia_mdfDataSet.produto);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmLocalProd produto = new frmLocalProd();
            produto.ShowDialog();

            if (Class1.CodTroca>0)
            {
                produtoBindingSource.Position = produtoBindingSource.Find("pro_cod",Class1.CodTroca);
            }
            
        }
    }
}
