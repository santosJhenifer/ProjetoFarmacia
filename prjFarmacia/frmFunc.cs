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
    public partial class frmFunc : Form
    {
        public frmFunc()
        {
            InitializeComponent();
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                 this.Validate();
                 this.funcionarioBindingSource.EndEdit();
                 this.tableAdapterManager.UpdateAll(this._farmacia_mdfDataSet);
                 gbFunc.Enabled = false;
                 MessageBox.Show("Registro Salvo", "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao salvar seu registro" + erro.Message, "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                funcionarioTableAdapter.Fill(_farmacia_mdfDataSet.funcionario);
              
            }                 
        }

        private void frmFunc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this._farmacia_mdfDataSet.cidade);
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this._farmacia_mdfDataSet.funcionario);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gbFunc.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            gbFunc.Enabled = false;
            funcionarioBindingSource.CancelEdit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            gbFunc.Enabled = true;
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
                    funcionarioBindingSource.RemoveCurrent();
                    funcionarioTableAdapter.Update(_farmacia_mdfDataSet.funcionario);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Registro não pode ser removido" + erro.Message, "Farmácia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                funcionarioTableAdapter.Fill(_farmacia_mdfDataSet.funcionario);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmLocalFunc localfunc = new frmLocalFunc();
            localfunc.ShowDialog();

            if (Class1.CodTroca>0)
            {
                funcionarioBindingSource.Position = funcionarioBindingSource.Find("fun_cod",Class1.CodTroca);
            }
            
        }
    }
}
