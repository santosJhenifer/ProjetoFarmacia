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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                 this.Validate();
                 this.clienteBindingSource.EndEdit();
                 this.tableAdapterManager.UpdateAll(this._farmacia_mdfDataSet);
                 gbDcliente.Enabled = false;
                 MessageBox.Show("Registro Salvo", "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar seu registro" + erro.Message, "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Error );
                cidadeTableAdapter.Fill(_farmacia_mdfDataSet.cidade);
            }

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this._farmacia_mdfDataSet.cidade);
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this._farmacia_mdfDataSet.cliente);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gbDcliente.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            gbDcliente.Enabled = false;
            cidadeBindingSource.CancelEdit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            gbDcliente.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirma exclusão", "Farmácia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent();
                    clienteTableAdapter.Update(_farmacia_mdfDataSet.cliente);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Registro não pode ser removido" + erro.Message, "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clienteTableAdapter.Fill(_farmacia_mdfDataSet.cliente);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmLocalizarCli localcli = new frmLocalizarCli();
            localcli.ShowDialog();

            if (Class1.CodTroca>0)
            {
                clienteBindingSource.Position = clienteBindingSource.Find("Cli_cod", Class1.CodTroca);
            }
            
        }

    }
}
