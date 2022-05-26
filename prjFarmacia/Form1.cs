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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade cidade = new frmCidade();
            cidade.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFunc funcionario = new frmFunc();
            funcionario.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto produto = new frmProduto();
            produto.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelCid relcid = new frmRelCid();
            relcid.ShowDialog();
            relcid.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelCli relcli = new frmRelCli();
            relcli.ShowDialog();
            relcli.Dispose();
        }

        private void funcionárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelFunc relfunc = new frmRelFunc();
            relfunc.ShowDialog();
            relfunc.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelProd relprod = new frmRelProd();
            relprod.ShowDialog();
            relprod.Dispose();
        }
        
      
    }
}
