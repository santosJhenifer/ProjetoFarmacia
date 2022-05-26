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
    public partial class frmCidade : Form
    {
        public frmCidade()
        {
            InitializeComponent();
        }

        private void cidadeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                 this.Validate();
                 this.cidadeBindingSource.EndEdit();
                 this.tableAdapterManager.UpdateAll(this._farmacia_mdfDataSet);
                 gbDcidade.Enabled = false;
                 MessageBox.Show("Registro Salvo", "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar seu registro" + erro.Message, "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cidadeTableAdapter.Fill(_farmacia_mdfDataSet.cidade);
            }

        }

        private void frmCidade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this._farmacia_mdfDataSet.cidade);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gbDcidade.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            gbDcidade.Enabled = false;
            cidadeBindingSource.CancelEdit();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            gbDcidade.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma exclusão", "Farmácia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cidadeBindingSource.RemoveCurrent();
                    cidadeTableAdapter.Update(_farmacia_mdfDataSet.cidade);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Registro não pode ser removido" + erro.Message, "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cidadeTableAdapter.Fill(_farmacia_mdfDataSet.cidade);
            }
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmLocalizarCid localizar = new frmLocalizarCid();
            localizar.ShowDialog();

            if (Class1.CodTroca>0)
            {
                cidadeBindingSource.Position = cidadeBindingSource.Find("Cid_cod", Class1.CodTroca);
            }
        }

    }
}
