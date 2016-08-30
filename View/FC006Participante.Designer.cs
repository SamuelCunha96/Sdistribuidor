namespace Sdistribuidor.View
{
    partial class FC006Participante
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDadosParticipante = new System.Windows.Forms.TabPage();
            this.lblIE = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.lblIdParticipante = new System.Windows.Forms.Label();
            this.chkComercial = new System.Windows.Forms.CheckBox();
            this.ucUfCidade1 = new Sdistribuidor.View.UC.UCUfCidade();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.MskCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.rbCNPJ = new System.Windows.Forms.RadioButton();
            this.rbCPF = new System.Windows.Forms.RadioButton();
            this.TxtFantasia = new System.Windows.Forms.TextBox();
            this.TxtNrEnder = new System.Windows.Forms.TextBox();
            this.TxtLogradouro = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNomeFantasia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCnpjCpf = new System.Windows.Forms.Label();
            this.tpCadastroLocalEntrega = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtObs = new System.Windows.Forms.TextBox();
            this.grdListaLocalEntrega = new System.Windows.Forms.DataGridView();
            this.ColEntUF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntLogradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntNrEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEntTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParticipante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ucUfCidadeLocalEntrega = new Sdistribuidor.View.UC.UCUfCidade();
            this.TxtBairroEntrega = new System.Windows.Forms.TextBox();
            this.MskTelefoneEntrega = new System.Windows.Forms.MaskedTextBox();
            this.TxtEndEntrega = new System.Windows.Forms.TextBox();
            this.TxtLogEntrega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkIsento = new System.Windows.Forms.CheckBox();
            this.tcBase.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            this.tpDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbDadosParticipante.SuspendLayout();
            this.tpCadastroLocalEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaLocalEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(184, 328);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(103, 328);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(22, 328);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(82, 328);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(3, 328);
            // 
            // tcBase
            // 
            this.tcBase.Size = new System.Drawing.Size(653, 385);
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Size = new System.Drawing.Size(645, 359);
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.tabControl1);
            this.tpDados.Size = new System.Drawing.Size(645, 359);
            this.tpDados.Controls.SetChildIndex(this.BtnSalvar, 0);
            this.tpDados.Controls.SetChildIndex(this.BtnExcluir, 0);
            this.tpDados.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.tpDados.Controls.SetChildIndex(this.tabControl1, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(639, 257);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbDadosParticipante);
            this.tabControl1.Controls.Add(this.tpCadastroLocalEntrega);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 319);
            this.tabControl1.TabIndex = 1;
            // 
            // tbDadosParticipante
            // 
            this.tbDadosParticipante.Controls.Add(this.chkIsento);
            this.tbDadosParticipante.Controls.Add(this.mskCep);
            this.tbDadosParticipante.Controls.Add(this.label12);
            this.tbDadosParticipante.Controls.Add(this.lblIE);
            this.tbDadosParticipante.Controls.Add(this.txtIE);
            this.tbDadosParticipante.Controls.Add(this.lblIdParticipante);
            this.tbDadosParticipante.Controls.Add(this.chkComercial);
            this.tbDadosParticipante.Controls.Add(this.ucUfCidade1);
            this.tbDadosParticipante.Controls.Add(this.TxtBairro);
            this.tbDadosParticipante.Controls.Add(this.MskCpfCnpj);
            this.tbDadosParticipante.Controls.Add(this.mskTelefone);
            this.tbDadosParticipante.Controls.Add(this.rbCNPJ);
            this.tbDadosParticipante.Controls.Add(this.rbCPF);
            this.tbDadosParticipante.Controls.Add(this.TxtFantasia);
            this.tbDadosParticipante.Controls.Add(this.TxtNrEnder);
            this.tbDadosParticipante.Controls.Add(this.TxtLogradouro);
            this.tbDadosParticipante.Controls.Add(this.TxtNome);
            this.tbDadosParticipante.Controls.Add(this.LblNomeFantasia);
            this.tbDadosParticipante.Controls.Add(this.label11);
            this.tbDadosParticipante.Controls.Add(this.label8);
            this.tbDadosParticipante.Controls.Add(this.label7);
            this.tbDadosParticipante.Controls.Add(this.label6);
            this.tbDadosParticipante.Controls.Add(this.label5);
            this.tbDadosParticipante.Controls.Add(this.lblCnpjCpf);
            this.tbDadosParticipante.Location = new System.Drawing.Point(4, 22);
            this.tbDadosParticipante.Name = "tbDadosParticipante";
            this.tbDadosParticipante.Padding = new System.Windows.Forms.Padding(3);
            this.tbDadosParticipante.Size = new System.Drawing.Size(631, 293);
            this.tbDadosParticipante.TabIndex = 0;
            this.tbDadosParticipante.Text = "Participante";
            this.tbDadosParticipante.UseVisualStyleBackColor = true;
            // 
            // lblIE
            // 
            this.lblIE.AutoSize = true;
            this.lblIE.Location = new System.Drawing.Point(141, 29);
            this.lblIE.Name = "lblIE";
            this.lblIE.Size = new System.Drawing.Size(17, 13);
            this.lblIE.TabIndex = 19;
            this.lblIE.Text = "IE";
            this.lblIE.Visible = false;
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(144, 45);
            this.txtIE.MaxLength = 100;
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(131, 21);
            this.txtIE.TabIndex = 18;
            this.txtIE.Visible = false;
            // 
            // lblIdParticipante
            // 
            this.lblIdParticipante.AutoSize = true;
            this.lblIdParticipante.Location = new System.Drawing.Point(477, 243);
            this.lblIdParticipante.Name = "lblIdParticipante";
            this.lblIdParticipante.Size = new System.Drawing.Size(78, 13);
            this.lblIdParticipante.TabIndex = 17;
            this.lblIdParticipante.Text = "Nome Fantasia";
            this.lblIdParticipante.Visible = false;
            // 
            // chkComercial
            // 
            this.chkComercial.AutoSize = true;
            this.chkComercial.Location = new System.Drawing.Point(6, 192);
            this.chkComercial.Name = "chkComercial";
            this.chkComercial.Size = new System.Drawing.Size(122, 17);
            this.chkComercial.TabIndex = 10;
            this.chkComercial.Text = "Cliente Comerciante";
            this.chkComercial.UseVisualStyleBackColor = true;
            // 
            // ucUfCidade1
            // 
            this.ucUfCidade1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUfCidade1.IdCidade = 0;
            this.ucUfCidade1.IdUf = 0;
            this.ucUfCidade1.Location = new System.Drawing.Point(3, 108);
            this.ucUfCidade1.Name = "ucUfCidade1";
            this.ucUfCidade1.Size = new System.Drawing.Size(238, 36);
            this.ucUfCidade1.TabIndex = 5;
            // 
            // TxtBairro
            // 
            this.TxtBairro.Location = new System.Drawing.Point(243, 122);
            this.TxtBairro.MaxLength = 50;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(184, 21);
            this.TxtBairro.TabIndex = 6;
            // 
            // MskCpfCnpj
            // 
            this.MskCpfCnpj.Location = new System.Drawing.Point(6, 45);
            this.MskCpfCnpj.Mask = "999,999,000-00";
            this.MskCpfCnpj.Name = "MskCpfCnpj";
            this.MskCpfCnpj.Size = new System.Drawing.Size(121, 21);
            this.MskCpfCnpj.TabIndex = 2;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(369, 164);
            this.mskTelefone.Mask = "(99)0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(84, 21);
            this.mskTelefone.SkipLiterals = false;
            this.mskTelefone.TabIndex = 9;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbCNPJ
            // 
            this.rbCNPJ.AutoSize = true;
            this.rbCNPJ.Location = new System.Drawing.Point(56, 6);
            this.rbCNPJ.Name = "rbCNPJ";
            this.rbCNPJ.Size = new System.Drawing.Size(50, 17);
            this.rbCNPJ.TabIndex = 1;
            this.rbCNPJ.TabStop = true;
            this.rbCNPJ.Text = "CNPJ";
            this.rbCNPJ.UseVisualStyleBackColor = true;
            this.rbCNPJ.Click += new System.EventHandler(this.rbCNPJ_Click);
            // 
            // rbCPF
            // 
            this.rbCPF.AutoSize = true;
            this.rbCPF.Checked = true;
            this.rbCPF.Location = new System.Drawing.Point(6, 6);
            this.rbCPF.Name = "rbCPF";
            this.rbCPF.Size = new System.Drawing.Size(44, 17);
            this.rbCPF.TabIndex = 0;
            this.rbCPF.TabStop = true;
            this.rbCPF.Text = "CPF";
            this.rbCPF.UseVisualStyleBackColor = true;
            this.rbCPF.Click += new System.EventHandler(this.rbCPF_Click);
            // 
            // TxtFantasia
            // 
            this.TxtFantasia.Location = new System.Drawing.Point(295, 84);
            this.TxtFantasia.MaxLength = 100;
            this.TxtFantasia.Name = "TxtFantasia";
            this.TxtFantasia.Size = new System.Drawing.Size(284, 21);
            this.TxtFantasia.TabIndex = 4;
            this.TxtFantasia.Visible = false;
            // 
            // TxtNrEnder
            // 
            this.TxtNrEnder.Location = new System.Drawing.Point(294, 164);
            this.TxtNrEnder.Name = "TxtNrEnder";
            this.TxtNrEnder.Size = new System.Drawing.Size(71, 21);
            this.TxtNrEnder.TabIndex = 8;
            // 
            // TxtLogradouro
            // 
            this.TxtLogradouro.Location = new System.Drawing.Point(6, 164);
            this.TxtLogradouro.Name = "TxtLogradouro";
            this.TxtLogradouro.Size = new System.Drawing.Size(284, 21);
            this.TxtLogradouro.TabIndex = 7;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(6, 84);
            this.TxtNome.MaxLength = 100;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(284, 21);
            this.TxtNome.TabIndex = 3;
            // 
            // LblNomeFantasia
            // 
            this.LblNomeFantasia.AutoSize = true;
            this.LblNomeFantasia.Location = new System.Drawing.Point(292, 68);
            this.LblNomeFantasia.Name = "LblNomeFantasia";
            this.LblNomeFantasia.Size = new System.Drawing.Size(78, 13);
            this.LblNomeFantasia.TabIndex = 15;
            this.LblNomeFantasia.Text = "Nome Fantasia";
            this.LblNomeFantasia.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nr. End.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Logradouro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nome";
            // 
            // lblCnpjCpf
            // 
            this.lblCnpjCpf.AutoSize = true;
            this.lblCnpjCpf.Location = new System.Drawing.Point(3, 29);
            this.lblCnpjCpf.Name = "lblCnpjCpf";
            this.lblCnpjCpf.Size = new System.Drawing.Size(26, 13);
            this.lblCnpjCpf.TabIndex = 10;
            this.lblCnpjCpf.Text = "CPF";
            // 
            // tpCadastroLocalEntrega
            // 
            this.tpCadastroLocalEntrega.Controls.Add(this.label10);
            this.tpCadastroLocalEntrega.Controls.Add(this.TxtObs);
            this.tpCadastroLocalEntrega.Controls.Add(this.grdListaLocalEntrega);
            this.tpCadastroLocalEntrega.Controls.Add(this.BtnAdd);
            this.tpCadastroLocalEntrega.Controls.Add(this.ucUfCidadeLocalEntrega);
            this.tpCadastroLocalEntrega.Controls.Add(this.TxtBairroEntrega);
            this.tpCadastroLocalEntrega.Controls.Add(this.MskTelefoneEntrega);
            this.tpCadastroLocalEntrega.Controls.Add(this.TxtEndEntrega);
            this.tpCadastroLocalEntrega.Controls.Add(this.TxtLogEntrega);
            this.tpCadastroLocalEntrega.Controls.Add(this.label2);
            this.tpCadastroLocalEntrega.Controls.Add(this.label3);
            this.tpCadastroLocalEntrega.Controls.Add(this.label4);
            this.tpCadastroLocalEntrega.Controls.Add(this.label9);
            this.tpCadastroLocalEntrega.Location = new System.Drawing.Point(4, 22);
            this.tpCadastroLocalEntrega.Name = "tpCadastroLocalEntrega";
            this.tpCadastroLocalEntrega.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastroLocalEntrega.Size = new System.Drawing.Size(631, 293);
            this.tpCadastroLocalEntrega.TabIndex = 1;
            this.tpCadastroLocalEntrega.Text = "Local de Entrega";
            this.tpCadastroLocalEntrega.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Obs";
            // 
            // TxtObs
            // 
            this.TxtObs.Location = new System.Drawing.Point(400, 62);
            this.TxtObs.MaxLength = 50;
            this.TxtObs.Name = "TxtObs";
            this.TxtObs.Size = new System.Drawing.Size(164, 21);
            this.TxtObs.TabIndex = 16;
            // 
            // grdListaLocalEntrega
            // 
            this.grdListaLocalEntrega.AllowUserToAddRows = false;
            this.grdListaLocalEntrega.AllowUserToDeleteRows = false;
            this.grdListaLocalEntrega.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdListaLocalEntrega.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdListaLocalEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaLocalEntrega.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEntUF,
            this.ColEntCidade,
            this.ColEntBairro,
            this.ColEntLogradouro,
            this.ColEntNrEnd,
            this.ColEntTelefone,
            this.ColParticipante,
            this.ColID});
            this.grdListaLocalEntrega.EnableHeadersVisualStyles = false;
            this.grdListaLocalEntrega.Location = new System.Drawing.Point(7, 91);
            this.grdListaLocalEntrega.Name = "grdListaLocalEntrega";
            this.grdListaLocalEntrega.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdListaLocalEntrega.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdListaLocalEntrega.RowHeadersVisible = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.grdListaLocalEntrega.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdListaLocalEntrega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdListaLocalEntrega.Size = new System.Drawing.Size(616, 198);
            this.grdListaLocalEntrega.TabIndex = 18;
            this.grdListaLocalEntrega.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdListaLocalEntrega_KeyDown);
            // 
            // ColEntUF
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.ColEntUF.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColEntUF.HeaderText = "Uf";
            this.ColEntUF.Name = "ColEntUF";
            this.ColEntUF.ReadOnly = true;
            this.ColEntUF.Width = 60;
            // 
            // ColEntCidade
            // 
            this.ColEntCidade.HeaderText = "Cidade";
            this.ColEntCidade.Name = "ColEntCidade";
            this.ColEntCidade.ReadOnly = true;
            this.ColEntCidade.Width = 70;
            // 
            // ColEntBairro
            // 
            this.ColEntBairro.HeaderText = "Bairro";
            this.ColEntBairro.Name = "ColEntBairro";
            this.ColEntBairro.ReadOnly = true;
            // 
            // ColEntLogradouro
            // 
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.ColEntLogradouro.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColEntLogradouro.HeaderText = "Logradouro";
            this.ColEntLogradouro.Name = "ColEntLogradouro";
            this.ColEntLogradouro.ReadOnly = true;
            this.ColEntLogradouro.Width = 130;
            // 
            // ColEntNrEnd
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColEntNrEnd.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColEntNrEnd.HeaderText = "Nr. End.";
            this.ColEntNrEnd.Name = "ColEntNrEnd";
            this.ColEntNrEnd.ReadOnly = true;
            this.ColEntNrEnd.Width = 80;
            // 
            // ColEntTelefone
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.ColEntTelefone.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColEntTelefone.HeaderText = "Telefone";
            this.ColEntTelefone.Name = "ColEntTelefone";
            this.ColEntTelefone.ReadOnly = true;
            // 
            // ColParticipante
            // 
            this.ColParticipante.HeaderText = "Participante";
            this.ColParticipante.Name = "ColParticipante";
            this.ColParticipante.ReadOnly = true;
            this.ColParticipante.Visible = false;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAdd.FlatAppearance.BorderSize = 2;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(565, 54);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(59, 34);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ucUfCidadeLocalEntrega
            // 
            this.ucUfCidadeLocalEntrega.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucUfCidadeLocalEntrega.IdCidade = 0;
            this.ucUfCidadeLocalEntrega.IdUf = 0;
            this.ucUfCidadeLocalEntrega.Location = new System.Drawing.Point(6, 6);
            this.ucUfCidadeLocalEntrega.Name = "ucUfCidadeLocalEntrega";
            this.ucUfCidadeLocalEntrega.Size = new System.Drawing.Size(238, 36);
            this.ucUfCidadeLocalEntrega.TabIndex = 11;
            // 
            // TxtBairroEntrega
            // 
            this.TxtBairroEntrega.Location = new System.Drawing.Point(246, 20);
            this.TxtBairroEntrega.MaxLength = 50;
            this.TxtBairroEntrega.Name = "TxtBairroEntrega";
            this.TxtBairroEntrega.Size = new System.Drawing.Size(287, 21);
            this.TxtBairroEntrega.TabIndex = 12;
            // 
            // MskTelefoneEntrega
            // 
            this.MskTelefoneEntrega.Location = new System.Drawing.Point(314, 62);
            this.MskTelefoneEntrega.Mask = "(99)0000-0000";
            this.MskTelefoneEntrega.Name = "MskTelefoneEntrega";
            this.MskTelefoneEntrega.Size = new System.Drawing.Size(84, 21);
            this.MskTelefoneEntrega.SkipLiterals = false;
            this.MskTelefoneEntrega.TabIndex = 15;
            this.MskTelefoneEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEndEntrega
            // 
            this.TxtEndEntrega.Location = new System.Drawing.Point(256, 62);
            this.TxtEndEntrega.Name = "TxtEndEntrega";
            this.TxtEndEntrega.Size = new System.Drawing.Size(55, 21);
            this.TxtEndEntrega.TabIndex = 14;
            // 
            // TxtLogEntrega
            // 
            this.TxtLogEntrega.Location = new System.Drawing.Point(9, 62);
            this.TxtLogEntrega.Name = "TxtLogEntrega";
            this.TxtLogEntrega.Size = new System.Drawing.Size(243, 21);
            this.TxtLogEntrega.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nr. End.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Logradouro";
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(429, 122);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(84, 21);
            this.mskCep.SkipLiterals = false;
            this.mskCep.TabIndex = 33;
            this.mskCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Cep";
            // 
            // chkIsento
            // 
            this.chkIsento.AutoSize = true;
            this.chkIsento.Location = new System.Drawing.Point(130, 192);
            this.chkIsento.Name = "chkIsento";
            this.chkIsento.Size = new System.Drawing.Size(57, 17);
            this.chkIsento.TabIndex = 35;
            this.chkIsento.Text = "Isento";
            this.chkIsento.UseVisualStyleBackColor = true;
            // 
            // FC006Participante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(653, 385);
            this.Name = "FC006Participante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Participante";
            this.tcBase.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbDadosParticipante.ResumeLayout(false);
            this.tbDadosParticipante.PerformLayout();
            this.tpCadastroLocalEntrega.ResumeLayout(false);
            this.tpCadastroLocalEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaLocalEntrega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbDadosParticipante;
        private System.Windows.Forms.CheckBox chkComercial;
        private UC.UCUfCidade ucUfCidade1;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.MaskedTextBox MskCpfCnpj;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.RadioButton rbCNPJ;
        private System.Windows.Forms.RadioButton rbCPF;
        private System.Windows.Forms.TextBox TxtFantasia;
        private System.Windows.Forms.TextBox TxtNrEnder;
        private System.Windows.Forms.TextBox TxtLogradouro;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNomeFantasia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCnpjCpf;
        private System.Windows.Forms.TabPage tpCadastroLocalEntrega;
        private UC.UCUfCidade ucUfCidadeLocalEntrega;
        private System.Windows.Forms.TextBox TxtBairroEntrega;
        private System.Windows.Forms.MaskedTextBox MskTelefoneEntrega;
        private System.Windows.Forms.TextBox TxtEndEntrega;
        private System.Windows.Forms.TextBox TxtLogEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView grdListaLocalEntrega;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtObs;
        private System.Windows.Forms.Label lblIdParticipante;
        private System.Windows.Forms.Label lblIE;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntLogradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntNrEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEntTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticipante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkIsento;
    }
}
