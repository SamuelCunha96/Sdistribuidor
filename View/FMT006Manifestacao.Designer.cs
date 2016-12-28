namespace Sdistribuidor.View
{
    partial class FMT006Manifestacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbGeral = new System.Windows.Forms.TabControl();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.btnManifestar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdNotaManifestacao = new System.Windows.Forms.DataGridView();
            this.ColChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColChAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVlNf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSitNFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbManifestacao = new System.Windows.Forms.TabPage();
            this.tabManifestacaoDest = new System.Windows.Forms.TabControl();
            this.tpLoteManifestacao = new System.Windows.Forms.TabPage();
            this.btnRetManifestacao = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grdChaManRetorno = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbNaoRealizacao = new System.Windows.Forms.RadioButton();
            this.RbDesconhecimento = new System.Windows.Forms.RadioButton();
            this.RbCiencia = new System.Windows.Forms.RadioButton();
            this.RbOperacao = new System.Windows.Forms.RadioButton();
            this.tpManifestacaoEnv = new System.Windows.Forms.TabPage();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grdChaveManifestacao = new System.Windows.Forms.DataGridView();
            this.ColTxChaveAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CboManifestacao = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.MskChDest = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trConsultaDest = new System.Windows.Forms.Timer(this.components);
            this.ColChkRetManifestacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColEmitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtEmissaoEmitente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColChaveNFeRetMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorNFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRetornoMan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbGeral.SuspendLayout();
            this.tpConsulta.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotaManifestacao)).BeginInit();
            this.tbManifestacao.SuspendLayout();
            this.tabManifestacaoDest.SuspendLayout();
            this.tpLoteManifestacao.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChaManRetorno)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpManifestacaoEnv.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChaveManifestacao)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbGeral
            // 
            this.tbGeral.Controls.Add(this.tpConsulta);
            this.tbGeral.Controls.Add(this.tbManifestacao);
            this.tbGeral.Location = new System.Drawing.Point(12, 12);
            this.tbGeral.Name = "tbGeral";
            this.tbGeral.SelectedIndex = 0;
            this.tbGeral.Size = new System.Drawing.Size(760, 375);
            this.tbGeral.TabIndex = 0;
            // 
            // tpConsulta
            // 
            this.tpConsulta.Controls.Add(this.btnManifestar);
            this.tpConsulta.Controls.Add(this.panel2);
            this.tpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta.Size = new System.Drawing.Size(752, 349);
            this.tpConsulta.TabIndex = 0;
            this.tpConsulta.Text = "Notas Fiscais Sem Manifestação";
            this.tpConsulta.UseVisualStyleBackColor = true;
            // 
            // btnManifestar
            // 
            this.btnManifestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.btnManifestar.FlatAppearance.BorderSize = 0;
            this.btnManifestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManifestar.ForeColor = System.Drawing.Color.White;
            this.btnManifestar.Location = new System.Drawing.Point(3, 312);
            this.btnManifestar.Name = "btnManifestar";
            this.btnManifestar.Size = new System.Drawing.Size(75, 31);
            this.btnManifestar.TabIndex = 2;
            this.btnManifestar.Text = "Manifestar";
            this.btnManifestar.UseVisualStyleBackColor = false;
            this.btnManifestar.Click += new System.EventHandler(this.btnManifestar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdNotaManifestacao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(746, 303);
            this.panel2.TabIndex = 1;
            // 
            // grdNotaManifestacao
            // 
            this.grdNotaManifestacao.AllowUserToAddRows = false;
            this.grdNotaManifestacao.AllowUserToDeleteRows = false;
            this.grdNotaManifestacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNotaManifestacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColChk,
            this.ColChAcesso,
            this.ColNome,
            this.ColIE,
            this.ColDtEmissao,
            this.ColVlNf,
            this.ColSitNFe});
            this.grdNotaManifestacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNotaManifestacao.Location = new System.Drawing.Point(0, 0);
            this.grdNotaManifestacao.Name = "grdNotaManifestacao";
            this.grdNotaManifestacao.ReadOnly = true;
            this.grdNotaManifestacao.RowHeadersVisible = false;
            this.grdNotaManifestacao.Size = new System.Drawing.Size(746, 303);
            this.grdNotaManifestacao.TabIndex = 0;
            this.grdNotaManifestacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNotaManifestacao_CellClick);
            // 
            // ColChk
            // 
            this.ColChk.HeaderText = "";
            this.ColChk.Name = "ColChk";
            this.ColChk.ReadOnly = true;
            this.ColChk.Width = 30;
            // 
            // ColChAcesso
            // 
            this.ColChAcesso.DataPropertyName = "chacessonfeformatada";
            dataGridViewCellStyle16.NullValue = null;
            this.ColChAcesso.DefaultCellStyle = dataGridViewCellStyle16;
            this.ColChAcesso.HeaderText = "Chave de Acesso";
            this.ColChAcesso.Name = "ColChAcesso";
            this.ColChAcesso.ReadOnly = true;
            this.ColChAcesso.Width = 300;
            // 
            // ColNome
            // 
            this.ColNome.DataPropertyName = "nomeemitente";
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            this.ColNome.Width = 300;
            // 
            // ColIE
            // 
            this.ColIE.HeaderText = "IE";
            this.ColIE.Name = "ColIE";
            this.ColIE.ReadOnly = true;
            // 
            // ColDtEmissao
            // 
            this.ColDtEmissao.DataPropertyName = "dhautorizacao";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "G";
            dataGridViewCellStyle17.NullValue = null;
            this.ColDtEmissao.DefaultCellStyle = dataGridViewCellStyle17;
            this.ColDtEmissao.HeaderText = "Dt. Autorização";
            this.ColDtEmissao.Name = "ColDtEmissao";
            this.ColDtEmissao.ReadOnly = true;
            this.ColDtEmissao.Width = 150;
            // 
            // ColVlNf
            // 
            this.ColVlNf.DataPropertyName = "vlnfe";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "n2";
            this.ColVlNf.DefaultCellStyle = dataGridViewCellStyle18;
            this.ColVlNf.HeaderText = "Vl. NFe";
            this.ColVlNf.Name = "ColVlNf";
            this.ColVlNf.ReadOnly = true;
            this.ColVlNf.Width = 80;
            // 
            // ColSitNFe
            // 
            this.ColSitNFe.DataPropertyName = "descsitnfe";
            this.ColSitNFe.HeaderText = "Sit. NFe";
            this.ColSitNFe.Name = "ColSitNFe";
            this.ColSitNFe.ReadOnly = true;
            this.ColSitNFe.Width = 200;
            // 
            // tbManifestacao
            // 
            this.tbManifestacao.Controls.Add(this.tabManifestacaoDest);
            this.tbManifestacao.Location = new System.Drawing.Point(4, 22);
            this.tbManifestacao.Name = "tbManifestacao";
            this.tbManifestacao.Padding = new System.Windows.Forms.Padding(3);
            this.tbManifestacao.Size = new System.Drawing.Size(752, 349);
            this.tbManifestacao.TabIndex = 1;
            this.tbManifestacao.Text = "Manifestação";
            this.tbManifestacao.UseVisualStyleBackColor = true;
            // 
            // tabManifestacaoDest
            // 
            this.tabManifestacaoDest.Controls.Add(this.tpLoteManifestacao);
            this.tabManifestacaoDest.Controls.Add(this.tpManifestacaoEnv);
            this.tabManifestacaoDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManifestacaoDest.Location = new System.Drawing.Point(3, 3);
            this.tabManifestacaoDest.Name = "tabManifestacaoDest";
            this.tabManifestacaoDest.SelectedIndex = 0;
            this.tabManifestacaoDest.Size = new System.Drawing.Size(746, 343);
            this.tabManifestacaoDest.TabIndex = 0;
            // 
            // tpLoteManifestacao
            // 
            this.tpLoteManifestacao.Controls.Add(this.btnRetManifestacao);
            this.tpLoteManifestacao.Controls.Add(this.panel4);
            this.tpLoteManifestacao.Controls.Add(this.panel1);
            this.tpLoteManifestacao.Location = new System.Drawing.Point(4, 22);
            this.tpLoteManifestacao.Name = "tpLoteManifestacao";
            this.tpLoteManifestacao.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoteManifestacao.Size = new System.Drawing.Size(738, 317);
            this.tpLoteManifestacao.TabIndex = 0;
            this.tpLoteManifestacao.Text = "Lote Manifestação";
            this.tpLoteManifestacao.UseVisualStyleBackColor = true;
            // 
            // btnRetManifestacao
            // 
            this.btnRetManifestacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.btnRetManifestacao.FlatAppearance.BorderSize = 0;
            this.btnRetManifestacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetManifestacao.ForeColor = System.Drawing.Color.White;
            this.btnRetManifestacao.Location = new System.Drawing.Point(3, 280);
            this.btnRetManifestacao.Name = "btnRetManifestacao";
            this.btnRetManifestacao.Size = new System.Drawing.Size(75, 31);
            this.btnRetManifestacao.TabIndex = 7;
            this.btnRetManifestacao.Text = "Manifestar";
            this.btnRetManifestacao.UseVisualStyleBackColor = false;
            this.btnRetManifestacao.Click += new System.EventHandler(this.btnRetManifestacao_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grdChaManRetorno);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 69);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(732, 203);
            this.panel4.TabIndex = 4;
            // 
            // grdChaManRetorno
            // 
            this.grdChaManRetorno.AllowUserToAddRows = false;
            this.grdChaManRetorno.AllowUserToDeleteRows = false;
            this.grdChaManRetorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChaManRetorno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColChkRetManifestacao,
            this.ColEmitente,
            this.ColDtEmissaoEmitente,
            this.ColChaveNFeRetMan,
            this.ColValorNFe,
            this.ColRetornoMan});
            this.grdChaManRetorno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdChaManRetorno.Location = new System.Drawing.Point(0, 0);
            this.grdChaManRetorno.Name = "grdChaManRetorno";
            this.grdChaManRetorno.ReadOnly = true;
            this.grdChaManRetorno.RowHeadersVisible = false;
            this.grdChaManRetorno.Size = new System.Drawing.Size(732, 203);
            this.grdChaManRetorno.TabIndex = 0;
            this.grdChaManRetorno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdChaManRetorno_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 66);
            this.panel1.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(598, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 31);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbNaoRealizacao);
            this.groupBox1.Controls.Add(this.RbDesconhecimento);
            this.groupBox1.Controls.Add(this.RbCiencia);
            this.groupBox1.Controls.Add(this.RbOperacao);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a Manifestação";
            // 
            // RbNaoRealizacao
            // 
            this.RbNaoRealizacao.AutoSize = true;
            this.RbNaoRealizacao.ForeColor = System.Drawing.Color.Black;
            this.RbNaoRealizacao.Location = new System.Drawing.Point(433, 24);
            this.RbNaoRealizacao.Name = "RbNaoRealizacao";
            this.RbNaoRealizacao.Size = new System.Drawing.Size(142, 17);
            this.RbNaoRealizacao.TabIndex = 6;
            this.RbNaoRealizacao.Text = "Operação não Realizada";
            this.RbNaoRealizacao.UseVisualStyleBackColor = true;
            // 
            // RbDesconhecimento
            // 
            this.RbDesconhecimento.AutoSize = true;
            this.RbDesconhecimento.ForeColor = System.Drawing.Color.Black;
            this.RbDesconhecimento.Location = new System.Drawing.Point(262, 24);
            this.RbDesconhecimento.Name = "RbDesconhecimento";
            this.RbDesconhecimento.Size = new System.Drawing.Size(174, 17);
            this.RbDesconhecimento.TabIndex = 5;
            this.RbDesconhecimento.Text = "Desconhecimento da Operação";
            this.RbDesconhecimento.UseVisualStyleBackColor = true;
            // 
            // RbCiencia
            // 
            this.RbCiencia.AutoSize = true;
            this.RbCiencia.ForeColor = System.Drawing.Color.Black;
            this.RbCiencia.Location = new System.Drawing.Point(151, 23);
            this.RbCiencia.Name = "RbCiencia";
            this.RbCiencia.Size = new System.Drawing.Size(115, 17);
            this.RbCiencia.TabIndex = 4;
            this.RbCiencia.Text = "Ciência da Emissão";
            this.RbCiencia.UseVisualStyleBackColor = true;
            // 
            // RbOperacao
            // 
            this.RbOperacao.AutoSize = true;
            this.RbOperacao.Checked = true;
            this.RbOperacao.ForeColor = System.Drawing.Color.Black;
            this.RbOperacao.Location = new System.Drawing.Point(4, 22);
            this.RbOperacao.Name = "RbOperacao";
            this.RbOperacao.Size = new System.Drawing.Size(150, 17);
            this.RbOperacao.TabIndex = 3;
            this.RbOperacao.TabStop = true;
            this.RbOperacao.Text = "Confirmação da Operação";
            this.RbOperacao.UseVisualStyleBackColor = true;
            // 
            // tpManifestacaoEnv
            // 
            this.tpManifestacaoEnv.Controls.Add(this.btnConfirmar);
            this.tpManifestacaoEnv.Controls.Add(this.panel5);
            this.tpManifestacaoEnv.Controls.Add(this.label1);
            this.tpManifestacaoEnv.Controls.Add(this.CboManifestacao);
            this.tpManifestacaoEnv.Controls.Add(this.panel3);
            this.tpManifestacaoEnv.Location = new System.Drawing.Point(4, 22);
            this.tpManifestacaoEnv.Name = "tpManifestacaoEnv";
            this.tpManifestacaoEnv.Padding = new System.Windows.Forms.Padding(3);
            this.tpManifestacaoEnv.Size = new System.Drawing.Size(738, 317);
            this.tpManifestacaoEnv.TabIndex = 1;
            this.tpManifestacaoEnv.Text = "Manifestação";
            this.tpManifestacaoEnv.UseVisualStyleBackColor = true;
            this.tpManifestacaoEnv.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(3, 281);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 31);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grdChaveManifestacao);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 46);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(732, 184);
            this.panel5.TabIndex = 4;
            // 
            // grdChaveManifestacao
            // 
            this.grdChaveManifestacao.AllowUserToAddRows = false;
            this.grdChaveManifestacao.AllowUserToDeleteRows = false;
            this.grdChaveManifestacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChaveManifestacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTxChaveAcesso});
            this.grdChaveManifestacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdChaveManifestacao.Location = new System.Drawing.Point(0, 0);
            this.grdChaveManifestacao.Name = "grdChaveManifestacao";
            this.grdChaveManifestacao.ReadOnly = true;
            this.grdChaveManifestacao.RowHeadersVisible = false;
            this.grdChaveManifestacao.Size = new System.Drawing.Size(732, 184);
            this.grdChaveManifestacao.TabIndex = 0;
            // 
            // ColTxChaveAcesso
            // 
            this.ColTxChaveAcesso.HeaderText = "Chave de Acesso";
            this.ColTxChaveAcesso.Name = "ColTxChaveAcesso";
            this.ColTxChaveAcesso.ReadOnly = true;
            this.ColTxChaveAcesso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTxChaveAcesso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTxChaveAcesso.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione a Manifestação";
            // 
            // CboManifestacao
            // 
            this.CboManifestacao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboManifestacao.FormattingEnabled = true;
            this.CboManifestacao.Items.AddRange(new object[] {
            "210200 – Confirmação da Operação",
            "210210 – Ciência da Emissão",
            "210220 – Desconhecimento da Operação",
            "210240 – Operação não Realizada"});
            this.CboManifestacao.Location = new System.Drawing.Point(3, 250);
            this.CboManifestacao.Name = "CboManifestacao";
            this.CboManifestacao.Size = new System.Drawing.Size(285, 24);
            this.CboManifestacao.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.MskChDest);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 43);
            this.panel3.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(375, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MskChDest
            // 
            this.MskChDest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskChDest.Location = new System.Drawing.Point(6, 16);
            this.MskChDest.Mask = "9999 9999 9999 9999 9999 9999 9999 9999 9999 9999 9999";
            this.MskChDest.Name = "MskChDest";
            this.MskChDest.PromptChar = ' ';
            this.MskChDest.Size = new System.Drawing.Size(363, 23);
            this.MskChDest.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chave NFe";
            // 
            // trConsultaDest
            // 
            this.trConsultaDest.Interval = 300000;
            this.trConsultaDest.Tick += new System.EventHandler(this.trConsultaDest_Tick);
            // 
            // ColChkRetManifestacao
            // 
            this.ColChkRetManifestacao.HeaderText = "";
            this.ColChkRetManifestacao.Name = "ColChkRetManifestacao";
            this.ColChkRetManifestacao.ReadOnly = true;
            this.ColChkRetManifestacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColChkRetManifestacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColChkRetManifestacao.Width = 30;
            // 
            // ColEmitente
            // 
            this.ColEmitente.DataPropertyName = "nomeemitente";
            this.ColEmitente.HeaderText = "Emitente";
            this.ColEmitente.Name = "ColEmitente";
            this.ColEmitente.ReadOnly = true;
            this.ColEmitente.Width = 300;
            // 
            // ColDtEmissaoEmitente
            // 
            this.ColDtEmissaoEmitente.DataPropertyName = "dhautorizacao";
            dataGridViewCellStyle19.Format = "G";
            this.ColDtEmissaoEmitente.DefaultCellStyle = dataGridViewCellStyle19;
            this.ColDtEmissaoEmitente.HeaderText = "Dt. Aut.";
            this.ColDtEmissaoEmitente.Name = "ColDtEmissaoEmitente";
            this.ColDtEmissaoEmitente.ReadOnly = true;
            this.ColDtEmissaoEmitente.Width = 120;
            // 
            // ColChaveNFeRetMan
            // 
            this.ColChaveNFeRetMan.DataPropertyName = "chacessonfe";
            this.ColChaveNFeRetMan.HeaderText = "Chave NFe";
            this.ColChaveNFeRetMan.Name = "ColChaveNFeRetMan";
            this.ColChaveNFeRetMan.ReadOnly = true;
            this.ColChaveNFeRetMan.Width = 240;
            // 
            // ColValorNFe
            // 
            this.ColValorNFe.DataPropertyName = "vlnfe";
            dataGridViewCellStyle20.Format = "n2";
            this.ColValorNFe.DefaultCellStyle = dataGridViewCellStyle20;
            this.ColValorNFe.HeaderText = "Vl. NFe";
            this.ColValorNFe.Name = "ColValorNFe";
            this.ColValorNFe.ReadOnly = true;
            // 
            // ColRetornoMan
            // 
            this.ColRetornoMan.DataPropertyName = "codretorno";
            this.ColRetornoMan.HeaderText = "Retorno";
            this.ColRetornoMan.Name = "ColRetornoMan";
            this.ColRetornoMan.ReadOnly = true;
            this.ColRetornoMan.Width = 200;
            // 
            // FMT006Manifestacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(784, 399);
            this.Controls.Add(this.tbGeral);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FMT006Manifestacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manifestação Destinatario";
            this.Load += new System.EventHandler(this.FMT006Manifestacao_Load);
            this.tbGeral.ResumeLayout(false);
            this.tpConsulta.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNotaManifestacao)).EndInit();
            this.tbManifestacao.ResumeLayout(false);
            this.tabManifestacaoDest.ResumeLayout(false);
            this.tpLoteManifestacao.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdChaManRetorno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpManifestacaoEnv.ResumeLayout(false);
            this.tpManifestacaoEnv.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdChaveManifestacao)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbGeral;
        private System.Windows.Forms.TabPage tpConsulta;
        private System.Windows.Forms.TabPage tbManifestacao;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView grdNotaManifestacao;
        private System.Windows.Forms.Button btnManifestar;
        private System.Windows.Forms.TabControl tabManifestacaoDest;
        private System.Windows.Forms.TabPage tpLoteManifestacao;
        private System.Windows.Forms.TabPage tpManifestacaoEnv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbNaoRealizacao;
        private System.Windows.Forms.RadioButton RbDesconhecimento;
        private System.Windows.Forms.RadioButton RbCiencia;
        private System.Windows.Forms.RadioButton RbOperacao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboManifestacao;
        private System.Windows.Forms.DataGridView grdChaveManifestacao;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Timer trConsultaDest;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChAcesso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVlNf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSitNFe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskChDest;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTxChaveAcesso;
        private System.Windows.Forms.DataGridView grdChaManRetorno;
        private System.Windows.Forms.Button btnRetManifestacao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColChkRetManifestacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmitente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtEmissaoEmitente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChaveNFeRetMan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorNFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRetornoMan;
    }
}