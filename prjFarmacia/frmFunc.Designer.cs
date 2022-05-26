namespace prjFarmacia
{
    partial class frmFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fun_nomeLabel;
            System.Windows.Forms.Label fun_enderecoLabel;
            System.Windows.Forms.Label fun_telLabel;
            System.Windows.Forms.Label fun_loginLabel;
            System.Windows.Forms.Label fun_senhaLabel;
            System.Windows.Forms.Label fun_cidLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFunc));
            this._farmacia_mdfDataSet = new prjFarmacia._farmacia_mdfDataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioTableAdapter = new prjFarmacia._farmacia_mdfDataSetTableAdapters.funcionarioTableAdapter();
            this.tableAdapterManager = new prjFarmacia._farmacia_mdfDataSetTableAdapters.TableAdapterManager();
            this.funcionarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.funcionarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.fun_nomeTextBox = new System.Windows.Forms.TextBox();
            this.fun_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.fun_telMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fun_loginTextBox = new System.Windows.Forms.TextBox();
            this.gbFunc = new System.Windows.Forms.GroupBox();
            this.fun_cidComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fun_senhaTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTableAdapter = new prjFarmacia._farmacia_mdfDataSetTableAdapters.cidadeTableAdapter();
            fun_nomeLabel = new System.Windows.Forms.Label();
            fun_enderecoLabel = new System.Windows.Forms.Label();
            fun_telLabel = new System.Windows.Forms.Label();
            fun_loginLabel = new System.Windows.Forms.Label();
            fun_senhaLabel = new System.Windows.Forms.Label();
            fun_cidLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._farmacia_mdfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).BeginInit();
            this.funcionarioBindingNavigator.SuspendLayout();
            this.gbFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fun_nomeLabel
            // 
            fun_nomeLabel.AutoSize = true;
            fun_nomeLabel.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fun_nomeLabel.Location = new System.Drawing.Point(51, 38);
            fun_nomeLabel.Name = "fun_nomeLabel";
            fun_nomeLabel.Size = new System.Drawing.Size(56, 23);
            fun_nomeLabel.TabIndex = 3;
            fun_nomeLabel.Text = "Nome:";
            // 
            // fun_enderecoLabel
            // 
            fun_enderecoLabel.AutoSize = true;
            fun_enderecoLabel.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fun_enderecoLabel.Location = new System.Drawing.Point(51, 80);
            fun_enderecoLabel.Name = "fun_enderecoLabel";
            fun_enderecoLabel.Size = new System.Drawing.Size(82, 23);
            fun_enderecoLabel.TabIndex = 5;
            fun_enderecoLabel.Text = "Endereço:";
            // 
            // fun_telLabel
            // 
            fun_telLabel.AutoSize = true;
            fun_telLabel.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fun_telLabel.Location = new System.Drawing.Point(51, 117);
            fun_telLabel.Name = "fun_telLabel";
            fun_telLabel.Size = new System.Drawing.Size(74, 23);
            fun_telLabel.TabIndex = 7;
            fun_telLabel.Text = "Telefone:";
            // 
            // fun_loginLabel
            // 
            fun_loginLabel.AutoSize = true;
            fun_loginLabel.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fun_loginLabel.Location = new System.Drawing.Point(51, 203);
            fun_loginLabel.Name = "fun_loginLabel";
            fun_loginLabel.Size = new System.Drawing.Size(53, 23);
            fun_loginLabel.TabIndex = 11;
            fun_loginLabel.Text = "Login:";
            // 
            // fun_senhaLabel
            // 
            fun_senhaLabel.AutoSize = true;
            fun_senhaLabel.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fun_senhaLabel.Location = new System.Drawing.Point(51, 246);
            fun_senhaLabel.Name = "fun_senhaLabel";
            fun_senhaLabel.Size = new System.Drawing.Size(60, 23);
            fun_senhaLabel.TabIndex = 15;
            fun_senhaLabel.Text = "Senha:";
            // 
            // fun_cidLabel
            // 
            fun_cidLabel.AutoSize = true;
            fun_cidLabel.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fun_cidLabel.Location = new System.Drawing.Point(51, 163);
            fun_cidLabel.Name = "fun_cidLabel";
            fun_cidLabel.Size = new System.Drawing.Size(64, 23);
            fun_cidLabel.TabIndex = 16;
            fun_cidLabel.Text = "Cidade:";
            // 
            // _farmacia_mdfDataSet
            // 
            this._farmacia_mdfDataSet.DataSetName = "_farmacia_mdfDataSet";
            this._farmacia_mdfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "funcionario";
            this.funcionarioBindingSource.DataSource = this._farmacia_mdfDataSet;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cidadeTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.funcionarioTableAdapter = this.funcionarioTableAdapter;
            this.tableAdapterManager.itens_vendaTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = prjFarmacia._farmacia_mdfDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.vendaTableAdapter = null;
            // 
            // funcionarioBindingNavigator
            // 
            this.funcionarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionarioBindingNavigator.BindingSource = this.funcionarioBindingSource;
            this.funcionarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionarioBindingNavigator.DeleteItem = null;
            this.funcionarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.funcionarioBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.funcionarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.funcionarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.funcionarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.funcionarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.funcionarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.funcionarioBindingNavigator.Name = "funcionarioBindingNavigator";
            this.funcionarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funcionarioBindingNavigator.Size = new System.Drawing.Size(854, 25);
            this.funcionarioBindingNavigator.TabIndex = 0;
            this.funcionarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(78, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(61, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // funcionarioBindingNavigatorSaveItem
            // 
            this.funcionarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionarioBindingNavigatorSaveItem.Image")));
            this.funcionarioBindingNavigatorSaveItem.Name = "funcionarioBindingNavigatorSaveItem";
            this.funcionarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(58, 22);
            this.funcionarioBindingNavigatorSaveItem.Text = "Salvar";
            this.funcionarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionarioBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Cancelar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton2.Text = "Editar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton3.Text = "Sair";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton4.Text = "Localizar";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // fun_nomeTextBox
            // 
            this.fun_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_nome", true));
            this.fun_nomeTextBox.Location = new System.Drawing.Point(155, 38);
            this.fun_nomeTextBox.Name = "fun_nomeTextBox";
            this.fun_nomeTextBox.Size = new System.Drawing.Size(219, 26);
            this.fun_nomeTextBox.TabIndex = 4;
            // 
            // fun_enderecoTextBox
            // 
            this.fun_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_endereco", true));
            this.fun_enderecoTextBox.Location = new System.Drawing.Point(155, 80);
            this.fun_enderecoTextBox.Name = "fun_enderecoTextBox";
            this.fun_enderecoTextBox.Size = new System.Drawing.Size(219, 26);
            this.fun_enderecoTextBox.TabIndex = 6;
            // 
            // fun_telMaskedTextBox
            // 
            this.fun_telMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_tel", true));
            this.fun_telMaskedTextBox.Location = new System.Drawing.Point(155, 117);
            this.fun_telMaskedTextBox.Mask = "(99) 00000-0000";
            this.fun_telMaskedTextBox.Name = "fun_telMaskedTextBox";
            this.fun_telMaskedTextBox.Size = new System.Drawing.Size(177, 26);
            this.fun_telMaskedTextBox.TabIndex = 8;
            // 
            // fun_loginTextBox
            // 
            this.fun_loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_login", true));
            this.fun_loginTextBox.Location = new System.Drawing.Point(155, 203);
            this.fun_loginTextBox.Name = "fun_loginTextBox";
            this.fun_loginTextBox.Size = new System.Drawing.Size(219, 26);
            this.fun_loginTextBox.TabIndex = 12;
            // 
            // gbFunc
            // 
            this.gbFunc.Controls.Add(fun_cidLabel);
            this.gbFunc.Controls.Add(this.fun_cidComboBox);
            this.gbFunc.Controls.Add(fun_senhaLabel);
            this.gbFunc.Controls.Add(this.fun_senhaTextBox);
            this.gbFunc.Controls.Add(fun_nomeLabel);
            this.gbFunc.Controls.Add(this.fun_nomeTextBox);
            this.gbFunc.Controls.Add(fun_enderecoLabel);
            this.gbFunc.Controls.Add(this.fun_enderecoTextBox);
            this.gbFunc.Controls.Add(fun_telLabel);
            this.gbFunc.Controls.Add(this.fun_telMaskedTextBox);
            this.gbFunc.Controls.Add(fun_loginLabel);
            this.gbFunc.Controls.Add(this.fun_loginTextBox);
            this.gbFunc.Enabled = false;
            this.gbFunc.Location = new System.Drawing.Point(141, 102);
            this.gbFunc.Name = "gbFunc";
            this.gbFunc.Size = new System.Drawing.Size(518, 328);
            this.gbFunc.TabIndex = 15;
            this.gbFunc.TabStop = false;
            this.gbFunc.Text = "Dados Do Funcionário";
            // 
            // fun_cidComboBox
            // 
            this.fun_cidComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.funcionarioBindingSource, "fun_cid", true));
            this.fun_cidComboBox.DataSource = this.cidadeBindingSource;
            this.fun_cidComboBox.DisplayMember = "Cid_nome";
            this.fun_cidComboBox.FormattingEnabled = true;
            this.fun_cidComboBox.Location = new System.Drawing.Point(155, 164);
            this.fun_cidComboBox.Name = "fun_cidComboBox";
            this.fun_cidComboBox.Size = new System.Drawing.Size(121, 26);
            this.fun_cidComboBox.TabIndex = 17;
            this.fun_cidComboBox.ValueMember = "Cid_cod";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "cidade";
            this.cidadeBindingSource.DataSource = this._farmacia_mdfDataSet;
            // 
            // fun_senhaTextBox
            // 
            this.fun_senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionarioBindingSource, "fun_senha", true));
            this.fun_senhaTextBox.Location = new System.Drawing.Point(155, 243);
            this.fun_senhaTextBox.Name = "fun_senhaTextBox";
            this.fun_senhaTextBox.PasswordChar = '*';
            this.fun_senhaTextBox.Size = new System.Drawing.Size(100, 26);
            this.fun_senhaTextBox.TabIndex = 16;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // frmFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(854, 504);
            this.Controls.Add(this.gbFunc);
            this.Controls.Add(this.funcionarioBindingNavigator);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFunc";
            this.Load += new System.EventHandler(this.frmFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this._farmacia_mdfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingNavigator)).EndInit();
            this.funcionarioBindingNavigator.ResumeLayout(false);
            this.funcionarioBindingNavigator.PerformLayout();
            this.gbFunc.ResumeLayout(false);
            this.gbFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _farmacia_mdfDataSet _farmacia_mdfDataSet;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private _farmacia_mdfDataSetTableAdapters.funcionarioTableAdapter funcionarioTableAdapter;
        private _farmacia_mdfDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton funcionarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fun_nomeTextBox;
        private System.Windows.Forms.TextBox fun_enderecoTextBox;
        private System.Windows.Forms.MaskedTextBox fun_telMaskedTextBox;
        private System.Windows.Forms.TextBox fun_loginTextBox;
        private System.Windows.Forms.GroupBox gbFunc;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox fun_senhaTextBox;
        private System.Windows.Forms.ComboBox fun_cidComboBox;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private _farmacia_mdfDataSetTableAdapters.cidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}