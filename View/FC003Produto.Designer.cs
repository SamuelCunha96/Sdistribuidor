namespace Sdistribuidor.View
{
    partial class FC003Produto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpProduto = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtFatorConv = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.grdUnidConv = new System.Windows.Forms.DataGridView();
            this.ColUnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColConversao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboUnidConv = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCodigoRef = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ucUnidade1 = new Sdistribuidor.Uc.UCUnidade();
            this.ucGrupo1 = new Sdistribuidor.Uc.UCGrupo();
            this.TxtPrecoFin = new System.Windows.Forms.TextBox();
            this.TxtPrecoRest = new System.Windows.Forms.TextBox();
            this.TxtPesoItem = new System.Windows.Forms.TextBox();
            this.TxtNCM = new System.Windows.Forms.TextBox();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtVlPreco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tpTributacao = new System.Windows.Forms.TabPage();
            this.CboCfopExterno = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CboCfopInterno = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CboCofins = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CboIpi = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CboPis = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CboIcms = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tcBase.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            this.tpDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpProduto.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidConv)).BeginInit();
            this.tpTributacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(170, 353);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(89, 353);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(8, 353);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(85, 339);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(6, 339);
            // 
            // tcBase
            // 
            this.tcBase.Size = new System.Drawing.Size(653, 413);
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Size = new System.Drawing.Size(645, 387);
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.tabControl1);
            this.tpDados.Size = new System.Drawing.Size(645, 387);
            this.tpDados.Controls.SetChildIndex(this.BtnSalvar, 0);
            this.tpDados.Controls.SetChildIndex(this.BtnExcluir, 0);
            this.tpDados.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.tpDados.Controls.SetChildIndex(this.tabControl1, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(639, 268);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(253, 151);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "0,00";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpProduto);
            this.tabControl1.Controls.Add(this.tpTributacao);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 344);
            this.tabControl1.TabIndex = 11;
            // 
            // tpProduto
            // 
            this.tpProduto.Controls.Add(this.groupBox3);
            this.tpProduto.Controls.Add(this.TxtCodigoRef);
            this.tpProduto.Controls.Add(this.label7);
            this.tpProduto.Controls.Add(this.ucUnidade1);
            this.tpProduto.Controls.Add(this.ucGrupo1);
            this.tpProduto.Controls.Add(this.TxtPrecoFin);
            this.tpProduto.Controls.Add(this.TxtPrecoRest);
            this.tpProduto.Controls.Add(this.TxtPesoItem);
            this.tpProduto.Controls.Add(this.TxtNCM);
            this.tpProduto.Controls.Add(this.txtDescProd);
            this.tpProduto.Controls.Add(this.txtID);
            this.tpProduto.Controls.Add(this.label9);
            this.tpProduto.Controls.Add(this.label8);
            this.tpProduto.Controls.Add(this.label6);
            this.tpProduto.Controls.Add(this.label4);
            this.tpProduto.Controls.Add(this.label3);
            this.tpProduto.Controls.Add(this.label2);
            this.tpProduto.Controls.Add(this.TxtVlPreco);
            this.tpProduto.Controls.Add(this.label5);
            this.tpProduto.Location = new System.Drawing.Point(4, 22);
            this.tpProduto.Name = "tpProduto";
            this.tpProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduto.Size = new System.Drawing.Size(631, 318);
            this.tpProduto.TabIndex = 0;
            this.tpProduto.Text = "Produto";
            this.tpProduto.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtFatorConv);
            this.groupBox3.Controls.Add(this.BtnAdd);
            this.groupBox3.Controls.Add(this.grdUnidConv);
            this.groupBox3.Controls.Add(this.cboUnidConv);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(385, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 152);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unidade Conversão";
            // 
            // TxtFatorConv
            // 
            this.TxtFatorConv.Location = new System.Drawing.Point(63, 33);
            this.TxtFatorConv.MaxLength = 20;
            this.TxtFatorConv.Name = "TxtFatorConv";
            this.TxtFatorConv.Size = new System.Drawing.Size(57, 21);
            this.TxtFatorConv.TabIndex = 8;
            this.TxtFatorConv.Text = "0,0000";
            this.TxtFatorConv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtFatorConv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFatorConv_KeyPress);
            this.TxtFatorConv.Leave += new System.EventHandler(this.TxtFatorConv_Leave);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAdd.FlatAppearance.BorderSize = 2;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(184, 29);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(54, 28);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // grdUnidConv
            // 
            this.grdUnidConv.AllowUserToAddRows = false;
            this.grdUnidConv.AllowUserToDeleteRows = false;
            this.grdUnidConv.BackgroundColor = System.Drawing.Color.White;
            this.grdUnidConv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdUnidConv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUnidConv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdUnidConv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUnid,
            this.ColConversao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUnidConv.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdUnidConv.EnableHeadersVisualStyles = false;
            this.grdUnidConv.Location = new System.Drawing.Point(10, 60);
            this.grdUnidConv.Name = "grdUnidConv";
            this.grdUnidConv.ReadOnly = true;
            this.grdUnidConv.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.grdUnidConv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grdUnidConv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUnidConv.Size = new System.Drawing.Size(228, 85);
            this.grdUnidConv.TabIndex = 4;
            this.grdUnidConv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUnidConv_CellClick);
            this.grdUnidConv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdUnidConv_KeyDown);
            // 
            // ColUnid
            // 
            this.ColUnid.HeaderText = "Unid.";
            this.ColUnid.Name = "ColUnid";
            this.ColUnid.ReadOnly = true;
            this.ColUnid.Width = 60;
            // 
            // ColConversao
            // 
            this.ColConversao.HeaderText = "Fotor Conv.";
            this.ColConversao.Name = "ColConversao";
            this.ColConversao.ReadOnly = true;
            this.ColConversao.Width = 90;
            // 
            // cboUnidConv
            // 
            this.cboUnidConv.FormattingEnabled = true;
            this.cboUnidConv.Location = new System.Drawing.Point(10, 33);
            this.cboUnidConv.Name = "cboUnidConv";
            this.cboUnidConv.Size = new System.Drawing.Size(49, 21);
            this.cboUnidConv.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fator de Conversão";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Unidade";
            // 
            // TxtCodigoRef
            // 
            this.TxtCodigoRef.Location = new System.Drawing.Point(5, 231);
            this.TxtCodigoRef.MaxLength = 20;
            this.TxtCodigoRef.Name = "TxtCodigoRef";
            this.TxtCodigoRef.Size = new System.Drawing.Size(101, 21);
            this.TxtCodigoRef.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Código Referencia";
            // 
            // ucUnidade1
            // 
            this.ucUnidade1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUnidade1.Location = new System.Drawing.Point(297, 55);
            this.ucUnidade1.Name = "ucUnidade1";
            this.ucUnidade1.Size = new System.Drawing.Size(212, 36);
            this.ucUnidade1.TabIndex = 19;
            this.ucUnidade1.Unidade = "";
            // 
            // ucGrupo1
            // 
            this.ucGrupo1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucGrupo1.IdGrupo = 0;
            this.ucGrupo1.Location = new System.Drawing.Point(5, 173);
            this.ucGrupo1.Name = "ucGrupo1";
            this.ucGrupo1.Size = new System.Drawing.Size(267, 35);
            this.ucGrupo1.TabIndex = 25;
            // 
            // TxtPrecoFin
            // 
            this.TxtPrecoFin.Location = new System.Drawing.Point(250, 145);
            this.TxtPrecoFin.MaxLength = 20;
            this.TxtPrecoFin.Name = "TxtPrecoFin";
            this.TxtPrecoFin.Size = new System.Drawing.Size(113, 21);
            this.TxtPrecoFin.TabIndex = 24;
            this.TxtPrecoFin.Text = "0,00";
            this.TxtPrecoFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecoFin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecoFin_KeyPress);
            this.TxtPrecoFin.Leave += new System.EventHandler(this.TxtPrecoFin_Leave);
            // 
            // TxtPrecoRest
            // 
            this.TxtPrecoRest.Location = new System.Drawing.Point(129, 145);
            this.TxtPrecoRest.MaxLength = 20;
            this.TxtPrecoRest.Name = "TxtPrecoRest";
            this.TxtPrecoRest.Size = new System.Drawing.Size(113, 21);
            this.TxtPrecoRest.TabIndex = 23;
            this.TxtPrecoRest.Text = "0,00";
            this.TxtPrecoRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecoRest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecoRest_KeyPress);
            this.TxtPrecoRest.Leave += new System.EventHandler(this.TxtPrecoRest_Leave);
            // 
            // TxtPesoItem
            // 
            this.TxtPesoItem.Location = new System.Drawing.Point(517, 69);
            this.TxtPesoItem.MaxLength = 20;
            this.TxtPesoItem.Name = "TxtPesoItem";
            this.TxtPesoItem.Size = new System.Drawing.Size(72, 21);
            this.TxtPesoItem.TabIndex = 20;
            this.TxtPesoItem.Text = "0,00";
            this.TxtPesoItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPesoItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPesoItem_KeyPress);
            this.TxtPesoItem.Leave += new System.EventHandler(this.TxtPesoItem_Leave);
            // 
            // TxtNCM
            // 
            this.TxtNCM.Location = new System.Drawing.Point(5, 107);
            this.TxtNCM.MaxLength = 20;
            this.TxtNCM.Name = "TxtNCM";
            this.TxtNCM.Size = new System.Drawing.Size(101, 21);
            this.TxtNCM.TabIndex = 21;
            // 
            // txtDescProd
            // 
            this.txtDescProd.Location = new System.Drawing.Point(6, 69);
            this.txtDescProd.MaxLength = 60;
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(285, 21);
            this.txtDescProd.TabIndex = 18;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(5, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(113, 21);
            this.txtID.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Preço Compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(127, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Preço Restaurante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Peso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "NCM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Código";
            // 
            // TxtVlPreco
            // 
            this.TxtVlPreco.Location = new System.Drawing.Point(8, 145);
            this.TxtVlPreco.MaxLength = 20;
            this.TxtVlPreco.Name = "TxtVlPreco";
            this.TxtVlPreco.Size = new System.Drawing.Size(113, 21);
            this.TxtVlPreco.TabIndex = 7;
            this.TxtVlPreco.Text = "0,00";
            this.TxtVlPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtVlPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtVlPreco_KeyPress);
            this.TxtVlPreco.Leave += new System.EventHandler(this.TxtVlPreco_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preço Final";
            // 
            // tpTributacao
            // 
            this.tpTributacao.Controls.Add(this.CboCfopExterno);
            this.tpTributacao.Controls.Add(this.label17);
            this.tpTributacao.Controls.Add(this.CboCfopInterno);
            this.tpTributacao.Controls.Add(this.label16);
            this.tpTributacao.Controls.Add(this.CboCofins);
            this.tpTributacao.Controls.Add(this.label15);
            this.tpTributacao.Controls.Add(this.CboIpi);
            this.tpTributacao.Controls.Add(this.label14);
            this.tpTributacao.Controls.Add(this.CboPis);
            this.tpTributacao.Controls.Add(this.label13);
            this.tpTributacao.Controls.Add(this.CboIcms);
            this.tpTributacao.Controls.Add(this.label12);
            this.tpTributacao.Location = new System.Drawing.Point(4, 22);
            this.tpTributacao.Name = "tpTributacao";
            this.tpTributacao.Padding = new System.Windows.Forms.Padding(3);
            this.tpTributacao.Size = new System.Drawing.Size(631, 318);
            this.tpTributacao.TabIndex = 1;
            this.tpTributacao.Text = "Tributação";
            this.tpTributacao.UseVisualStyleBackColor = true;
            // 
            // CboCfopExterno
            // 
            this.CboCfopExterno.DisplayMember = "descricao";
            this.CboCfopExterno.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCfopExterno.FormattingEnabled = true;
            this.CboCfopExterno.Location = new System.Drawing.Point(10, 263);
            this.CboCfopExterno.Name = "CboCfopExterno";
            this.CboCfopExterno.Size = new System.Drawing.Size(619, 20);
            this.CboCfopExterno.TabIndex = 11;
            this.CboCfopExterno.ValueMember = "cfop";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Cfop Externo";
            // 
            // CboCfopInterno
            // 
            this.CboCfopInterno.DisplayMember = "descricao";
            this.CboCfopInterno.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCfopInterno.FormattingEnabled = true;
            this.CboCfopInterno.Location = new System.Drawing.Point(9, 210);
            this.CboCfopInterno.Name = "CboCfopInterno";
            this.CboCfopInterno.Size = new System.Drawing.Size(619, 20);
            this.CboCfopInterno.TabIndex = 9;
            this.CboCfopInterno.ValueMember = "cfop";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 194);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Cfop Interno";
            // 
            // CboCofins
            // 
            this.CboCofins.DisplayMember = "descricao";
            this.CboCofins.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboCofins.FormattingEnabled = true;
            this.CboCofins.Location = new System.Drawing.Point(9, 159);
            this.CboCofins.Name = "CboCofins";
            this.CboCofins.Size = new System.Drawing.Size(619, 20);
            this.CboCofins.TabIndex = 7;
            this.CboCofins.ValueMember = "cst";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Cofins";
            // 
            // CboIpi
            // 
            this.CboIpi.DisplayMember = "descricao";
            this.CboIpi.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboIpi.FormattingEnabled = true;
            this.CboIpi.Location = new System.Drawing.Point(9, 72);
            this.CboIpi.Name = "CboIpi";
            this.CboIpi.Size = new System.Drawing.Size(619, 20);
            this.CboIpi.TabIndex = 5;
            this.CboIpi.ValueMember = "cst";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Ipi";
            // 
            // CboPis
            // 
            this.CboPis.DisplayMember = "descricao";
            this.CboPis.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPis.FormattingEnabled = true;
            this.CboPis.Location = new System.Drawing.Point(9, 113);
            this.CboPis.Name = "CboPis";
            this.CboPis.Size = new System.Drawing.Size(619, 20);
            this.CboPis.TabIndex = 3;
            this.CboPis.ValueMember = "cst";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Pis";
            // 
            // CboIcms
            // 
            this.CboIcms.DisplayMember = "descricao";
            this.CboIcms.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboIcms.FormattingEnabled = true;
            this.CboIcms.Location = new System.Drawing.Point(9, 28);
            this.CboIcms.Name = "CboIcms";
            this.CboIcms.Size = new System.Drawing.Size(619, 20);
            this.CboIcms.TabIndex = 1;
            this.CboIcms.ValueMember = "cst";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Icms";
            // 
            // FC003Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(653, 413);
            this.Name = "FC003Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.tcBase.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpProduto.ResumeLayout(false);
            this.tpProduto.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnidConv)).EndInit();
            this.tpTributacao.ResumeLayout(false);
            this.tpTributacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpProduto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtFatorConv;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView grdUnidConv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColConversao;
        private System.Windows.Forms.ComboBox cboUnidConv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCodigoRef;
        private System.Windows.Forms.Label label7;
        private Uc.UCUnidade ucUnidade1;
        private Uc.UCGrupo ucGrupo1;
        private System.Windows.Forms.TextBox TxtPrecoFin;
        private System.Windows.Forms.TextBox TxtPrecoRest;
        private System.Windows.Forms.TextBox TxtPesoItem;
        private System.Windows.Forms.TextBox TxtNCM;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtVlPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpTributacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CboIcms;
        private System.Windows.Forms.ComboBox CboCofins;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CboIpi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox CboPis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CboCfopInterno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CboCfopExterno;
        private System.Windows.Forms.Label label17;
    }
}
