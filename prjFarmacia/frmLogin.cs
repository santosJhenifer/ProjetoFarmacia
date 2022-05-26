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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Administrador")
            {
                if (txtLogin.Text == "admin")
            {

                if (txtSenha.Text == "admin")
                {
                    this.Hide();
                    Form1 inicial = new Form1();
                    inicial.ShowDialog();
                    this.Show();
                    txtLogin.Clear();
                    txtSenha.Clear();
                    txtLogin.Focus();
                }
                else
                {
                    MessageBox.Show("Acesso Negado", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Focus();
                }
            }
            else
            {
                MessageBox.Show("Acesso Negado", "Login Incorreto",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            }

            else if (comboBox1.Text == "Caixa")
            {
                funcionarioBindingSource.Filter = "Fun_login like'" + txtLogin.Text + "'";
                if (funcionarioBindingSource.Filter == txtLogin.Text)
                {
                    funcionarioBindingSource.Filter = "Fun_senha like'" + txtSenha.Text + "'";
                    if (funcionarioBindingSource.Filter == txtSenha.Text)
                    {
                        this.Hide();
                        Form1 inicial = new Form1();
                        inicial.ShowDialog();
                        this.Show();
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Acesso Negado", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSenha.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Acesso Negado", "Login Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLogin.Focus();
                }

            }
            

            
        }

        private void funcionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._farmacia_mdfDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_farmacia_mdfDataSet.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this._farmacia_mdfDataSet.funcionario);

        }


       
    }
}
