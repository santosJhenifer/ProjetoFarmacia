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
    public partial class frmRelProd : Form
    {
        public frmRelProd()
        {
            InitializeComponent();
        }

        private void frmRelProd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this._farmacia_mdfDataSet.produto);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        //private void frmRelProd_Move(object sender, EventArgs e)
        //{
        //    this.Location=defaultl
        //}


        //private Point _pos;
        //private void frmRelProd_LocationChanged(object sender, EventArgs e)
        //{
        //    if (this.Location!=_pos)
        //    {
        //        this.Location = _pos;
        //    }
        //}
    }
}
