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
    public partial class frmRelCli : Form
    {
        public frmRelCli()
        {
            InitializeComponent();
        }

        private void frmRelCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this._farmacia_mdfDataSet.cliente);

            this.reportViewer1.RefreshReport();
        }
    }
}
