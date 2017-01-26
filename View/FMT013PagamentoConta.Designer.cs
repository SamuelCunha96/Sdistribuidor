namespace Sdistribuidor.View
{
    partial class FMT013PagamentoConta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbDados = new MetroFramework.Controls.MetroTabControl();
            this.tpLista = new MetroFramework.Controls.MetroTabPage();
            this.BtnSelecionar = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.grdConta = new MetroFramework.Controls.MetroGrid();
            this.ColIdConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGrupoFinanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVlParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colstconta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.DtpFim = new System.Windows.Forms.DateTimePicker();
            this.DtpIni = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TpPagamento = new MetroFramework.Controls.MetroTabPage();
            this.btnConfirmar = new MetroFramework.Controls.MetroButton();
            this.lblConta = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblDocumento = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblGruFinanceiro = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblVencimento = new MetroFramework.Controls.MetroLabel();
            this.lblFornecedor = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CboStPagamento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tbDados.SuspendLayout();
            this.tpLista.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConta)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.TpPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDados
            // 
            this.tbDados.Controls.Add(this.tpLista);
            this.tbDados.Controls.Add(this.TpPagamento);
            this.tbDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDados.Location = new System.Drawing.Point(20, 60);
            this.tbDados.Name = "tbDados";
            this.tbDados.SelectedIndex = 0;
            this.tbDados.Size = new System.Drawing.Size(831, 338);
            this.tbDados.TabIndex = 0;
            this.tbDados.UseSelectable = true;
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.BtnSelecionar);
            this.tpLista.Controls.Add(this.metroPanel2);
            this.tpLista.Controls.Add(this.metroPanel1);
            this.tpLista.HorizontalScrollbarBarColor = true;
            this.tpLista.HorizontalScrollbarHighlightOnWheel = false;
            this.tpLista.HorizontalScrollbarSize = 10;
            this.tpLista.Location = new System.Drawing.Point(4, 38);
            this.tpLista.Name = "tpLista";
            this.tpLista.Size = new System.Drawing.Size(823, 296);
            this.tpLista.TabIndex = 0;
            this.tpLista.Text = "Lista";
            this.tpLista.VerticalScrollbarBarColor = true;
            this.tpLista.VerticalScrollbarHighlightOnWheel = false;
            this.tpLista.VerticalScrollbarSize = 10;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Location = new System.Drawing.Point(3, 266);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(75, 29);
            this.BtnSelecionar.TabIndex = 5;
            this.BtnSelecionar.Text = "Selecionar";
            this.BtnSelecionar.UseSelectable = true;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.grdConta);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 55);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(823, 190);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // grdConta
            // 
            this.grdConta.AllowUserToAddRows = false;
            this.grdConta.AllowUserToDeleteRows = false;
            this.grdConta.AllowUserToResizeRows = false;
            this.grdConta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdConta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdConta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.grdConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdConta,
            this.ColDoc,
            this.ColFornecedor,
            this.ColDtEmissao,
            this.ColDtVenc,
            this.ColGrupoFinanc,
            this.ColVlParcela,
            this.Colstconta});
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConta.DefaultCellStyle = dataGridViewCellStyle48;
            this.grdConta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdConta.EnableHeadersVisualStyles = false;
            this.grdConta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdConta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdConta.Location = new System.Drawing.Point(0, 0);
            this.grdConta.Name = "grdConta";
            this.grdConta.ReadOnly = true;
            this.grdConta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdConta.RowHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.grdConta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdConta.Size = new System.Drawing.Size(823, 190);
            this.grdConta.TabIndex = 2;
            // 
            // ColIdConta
            // 
            this.ColIdConta.DataPropertyName = "id_contpag";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.Format = "N0";
            dataGridViewCellStyle44.NullValue = null;
            this.ColIdConta.DefaultCellStyle = dataGridViewCellStyle44;
            this.ColIdConta.HeaderText = "Conta";
            this.ColIdConta.Name = "ColIdConta";
            this.ColIdConta.ReadOnly = true;
            this.ColIdConta.Width = 70;
            // 
            // ColDoc
            // 
            this.ColDoc.DataPropertyName = "nrdoc";
            this.ColDoc.HeaderText = "Documento";
            this.ColDoc.Name = "ColDoc";
            this.ColDoc.ReadOnly = true;
            // 
            // ColFornecedor
            // 
            this.ColFornecedor.DataPropertyName = "partnome";
            this.ColFornecedor.HeaderText = "Fornecedor";
            this.ColFornecedor.Name = "ColFornecedor";
            this.ColFornecedor.ReadOnly = true;
            this.ColFornecedor.Width = 180;
            // 
            // ColDtEmissao
            // 
            this.ColDtEmissao.DataPropertyName = "dtemissao";
            dataGridViewCellStyle45.Format = "d";
            dataGridViewCellStyle45.NullValue = null;
            this.ColDtEmissao.DefaultCellStyle = dataGridViewCellStyle45;
            this.ColDtEmissao.HeaderText = "Dt. Emissão";
            this.ColDtEmissao.Name = "ColDtEmissao";
            this.ColDtEmissao.ReadOnly = true;
            this.ColDtEmissao.Width = 90;
            // 
            // ColDtVenc
            // 
            this.ColDtVenc.DataPropertyName = "dtvencimento";
            dataGridViewCellStyle46.Format = "d";
            dataGridViewCellStyle46.NullValue = null;
            this.ColDtVenc.DefaultCellStyle = dataGridViewCellStyle46;
            this.ColDtVenc.HeaderText = "Dt. Vencimento";
            this.ColDtVenc.Name = "ColDtVenc";
            this.ColDtVenc.ReadOnly = true;
            this.ColDtVenc.Width = 110;
            // 
            // ColGrupoFinanc
            // 
            this.ColGrupoFinanc.DataPropertyName = "desc_financeiro";
            this.ColGrupoFinanc.HeaderText = "Gru. Finac.";
            this.ColGrupoFinanc.Name = "ColGrupoFinanc";
            this.ColGrupoFinanc.ReadOnly = true;
            this.ColGrupoFinanc.Width = 140;
            // 
            // ColVlParcela
            // 
            this.ColVlParcela.DataPropertyName = "vlparcela";
            dataGridViewCellStyle47.Format = "n2";
            this.ColVlParcela.DefaultCellStyle = dataGridViewCellStyle47;
            this.ColVlParcela.HeaderText = "Vl. Parcela";
            this.ColVlParcela.Name = "ColVlParcela";
            this.ColVlParcela.ReadOnly = true;
            this.ColVlParcela.Width = 90;
            // 
            // Colstconta
            // 
            this.Colstconta.DataPropertyName = "stparcela";
            this.Colstconta.HeaderText = "stconta";
            this.Colstconta.Name = "Colstconta";
            this.Colstconta.ReadOnly = true;
            this.Colstconta.Visible = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.CboStPagamento);
            this.metroPanel1.Controls.Add(this.DtpFim);
            this.metroPanel1.Controls.Add(this.DtpIni);
            this.metroPanel1.Controls.Add(this.btnConsultar);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(823, 55);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // DtpFim
            // 
            this.DtpFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFim.Location = new System.Drawing.Point(143, 26);
            this.DtpFim.Name = "DtpFim";
            this.DtpFim.Size = new System.Drawing.Size(116, 26);
            this.DtpFim.TabIndex = 2;
            // 
            // DtpIni
            // 
            this.DtpIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpIni.Location = new System.Drawing.Point(3, 26);
            this.DtpIni.Name = "DtpIni";
            this.DtpIni.Size = new System.Drawing.Size(116, 26);
            this.DtpIni.TabIndex = 1;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(439, 24);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 29);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseSelectable = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 1);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Data de Vencimento";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(116, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(27, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "até";
            // 
            // TpPagamento
            // 
            this.TpPagamento.Controls.Add(this.metroLabel9);
            this.TpPagamento.Controls.Add(this.btnConfirmar);
            this.TpPagamento.Controls.Add(this.lblConta);
            this.TpPagamento.Controls.Add(this.metroLabel7);
            this.TpPagamento.Controls.Add(this.lblDocumento);
            this.TpPagamento.Controls.Add(this.metroLabel6);
            this.TpPagamento.Controls.Add(this.lblGruFinanceiro);
            this.TpPagamento.Controls.Add(this.metroLabel5);
            this.TpPagamento.Controls.Add(this.metroLabel4);
            this.TpPagamento.Controls.Add(this.lblVencimento);
            this.TpPagamento.Controls.Add(this.lblFornecedor);
            this.TpPagamento.Controls.Add(this.metroLabel3);
            this.TpPagamento.HorizontalScrollbarBarColor = true;
            this.TpPagamento.HorizontalScrollbarHighlightOnWheel = false;
            this.TpPagamento.HorizontalScrollbarSize = 10;
            this.TpPagamento.Location = new System.Drawing.Point(4, 38);
            this.TpPagamento.Name = "TpPagamento";
            this.TpPagamento.Size = new System.Drawing.Size(823, 296);
            this.TpPagamento.TabIndex = 1;
            this.TpPagamento.Text = "Pagamento";
            this.TpPagamento.VerticalScrollbarBarColor = true;
            this.TpPagamento.VerticalScrollbarHighlightOnWheel = false;
            this.TpPagamento.VerticalScrollbarSize = 10;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(5, 263);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 29);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseSelectable = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.lblConta.Location = new System.Drawing.Point(3, 31);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(33, 19);
            this.lblConta.TabIndex = 11;
            this.lblConta.Text = "----";
            this.lblConta.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(3, 12);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "N° Conta";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.lblDocumento.Location = new System.Drawing.Point(3, 122);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(153, 19);
            this.lblDocumento.TabIndex = 9;
            this.lblDocumento.Text = "------------------------";
            this.lblDocumento.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 101);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Documento";
            // 
            // lblGruFinanceiro
            // 
            this.lblGruFinanceiro.AutoSize = true;
            this.lblGruFinanceiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.lblGruFinanceiro.Location = new System.Drawing.Point(3, 220);
            this.lblGruFinanceiro.Name = "lblGruFinanceiro";
            this.lblGruFinanceiro.Size = new System.Drawing.Size(159, 19);
            this.lblGruFinanceiro.TabIndex = 7;
            this.lblGruFinanceiro.Text = "-------------------------";
            this.lblGruFinanceiro.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 198);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Grupo Financeiro";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 145);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(97, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Dt. Vencimento";
            // 
            // lblVencimento
            // 
            this.lblVencimento.AutoSize = true;
            this.lblVencimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.lblVencimento.Location = new System.Drawing.Point(2, 165);
            this.lblVencimento.Name = "lblVencimento";
            this.lblVencimento.Size = new System.Drawing.Size(75, 19);
            this.lblVencimento.TabIndex = 4;
            this.lblVencimento.Text = "00/00/0000";
            this.lblVencimento.UseCustomForeColor = true;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.lblFornecedor.Location = new System.Drawing.Point(3, 77);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(153, 19);
            this.lblFornecedor.TabIndex = 3;
            this.lblFornecedor.Text = "------------------------";
            this.lblFornecedor.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 56);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Fornecedor";
            // 
            // CboStPagamento
            // 
            this.CboStPagamento.FormattingEnabled = true;
            this.CboStPagamento.ItemHeight = 23;
            this.CboStPagamento.Items.AddRange(new object[] {
            "Em Aberto",
            "Pago"});
            this.CboStPagamento.Location = new System.Drawing.Point(265, 24);
            this.CboStPagamento.Name = "CboStPagamento";
            this.CboStPagamento.Size = new System.Drawing.Size(168, 29);
            this.CboStPagamento.TabIndex = 3;
            this.CboStPagamento.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(265, 2);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(114, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Status Pagamento";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.metroLabel9.Location = new System.Drawing.Point(332, 139);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(0, 0);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // FMT013PagamentoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 418);
            this.Controls.Add(this.tbDados);
            this.Name = "FMT013PagamentoConta";
            this.Text = "Pagamento - Conta";
            this.Load += new System.EventHandler(this.FMT013PagamentoConta_Load);
            this.tbDados.ResumeLayout(false);
            this.tpLista.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConta)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.TpPagamento.ResumeLayout(false);
            this.TpPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbDados;
        private MetroFramework.Controls.MetroTabPage tpLista;
        private MetroFramework.Controls.MetroTabPage TpPagamento;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnConsultar;
        private MetroFramework.Controls.MetroButton BtnSelecionar;
        private MetroFramework.Controls.MetroGrid grdConta;
        private System.Windows.Forms.DateTimePicker DtpIni;
        private System.Windows.Forms.DateTimePicker DtpFim;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblFornecedor;
        private MetroFramework.Controls.MetroLabel lblVencimento;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblGruFinanceiro;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblDocumento;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblConta;
        private MetroFramework.Controls.MetroButton btnConfirmar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGrupoFinanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVlParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colstconta;
        private MetroFramework.Controls.MetroComboBox CboStPagamento;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
    }
}