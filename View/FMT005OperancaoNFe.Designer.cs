namespace Sdistribuidor.View
{
    partial class FMT005OperancaoNFe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbNFe = new System.Windows.Forms.TabControl();
            this.tpNFeConsulta = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdNFe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkInutilizada = new System.Windows.Forms.CheckBox();
            this.chkCancelada = new System.Windows.Forms.CheckBox();
            this.ChkAprovada = new System.Windows.Forms.CheckBox();
            this.chkAnalise = new System.Windows.Forms.CheckBox();
            this.rbDtEmissao = new System.Windows.Forms.RadioButton();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.tmNFe = new System.Windows.Forms.Timer(this.components);
            this.pnlData = new System.Windows.Forms.Panel();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ColSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataEmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorNf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTxChAcessoNfe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodRet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColCancelar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColInutilizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbNFe.SuspendLayout();
            this.tpNFeConsulta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdNFe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNFe
            // 
            this.tbNFe.Controls.Add(this.tpNFeConsulta);
            this.tbNFe.Location = new System.Drawing.Point(12, 12);
            this.tbNFe.Name = "tbNFe";
            this.tbNFe.SelectedIndex = 0;
            this.tbNFe.Size = new System.Drawing.Size(860, 439);
            this.tbNFe.TabIndex = 0;
            // 
            // tpNFeConsulta
            // 
            this.tpNFeConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.tpNFeConsulta.Controls.Add(this.groupBox2);
            this.tpNFeConsulta.Controls.Add(this.groupBox1);
            this.tpNFeConsulta.Location = new System.Drawing.Point(4, 22);
            this.tpNFeConsulta.Name = "tpNFeConsulta";
            this.tpNFeConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpNFeConsulta.Size = new System.Drawing.Size(852, 413);
            this.tpNFeConsulta.TabIndex = 0;
            this.tpNFeConsulta.Text = "Notas Fiscais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdNFe);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 338);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // grdNFe
            // 
            this.grdNFe.AllowUserToAddRows = false;
            this.grdNFe.AllowUserToDeleteRows = false;
            this.grdNFe.AllowUserToOrderColumns = true;
            this.grdNFe.BackgroundColor = System.Drawing.Color.DimGray;
            this.grdNFe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdNFe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.grdNFe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSerie,
            this.ColNf,
            this.ColCliente,
            this.ColDataEmissao,
            this.ColValorNf,
            this.ColTxChAcessoNfe,
            this.ColCodRet,
            this.ColImprimir,
            this.ColCancelar,
            this.ColInutilizar});
            this.grdNFe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdNFe.EnableHeadersVisualStyles = false;
            this.grdNFe.GridColor = System.Drawing.Color.White;
            this.grdNFe.Location = new System.Drawing.Point(3, 17);
            this.grdNFe.Name = "grdNFe";
            this.grdNFe.ReadOnly = true;
            this.grdNFe.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdNFe.Size = new System.Drawing.Size(840, 318);
            this.grdNFe.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.pnlData);
            this.groupBox1.Controls.Add(this.chkInutilizada);
            this.groupBox1.Controls.Add(this.chkCancelada);
            this.groupBox1.Controls.Add(this.ChkAprovada);
            this.groupBox1.Controls.Add(this.chkAnalise);
            this.groupBox1.Controls.Add(this.rbDtEmissao);
            this.groupBox1.Controls.Add(this.TxtPesquisa);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // chkInutilizada
            // 
            this.chkInutilizada.AutoSize = true;
            this.chkInutilizada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(127)))), ((int)(((byte)(23)))));
            this.chkInutilizada.Location = new System.Drawing.Point(402, 22);
            this.chkInutilizada.Name = "chkInutilizada";
            this.chkInutilizada.Size = new System.Drawing.Size(75, 17);
            this.chkInutilizada.TabIndex = 5;
            this.chkInutilizada.Text = "Inutilizada";
            this.chkInutilizada.UseVisualStyleBackColor = true;
            // 
            // chkCancelada
            // 
            this.chkCancelada.AutoSize = true;
            this.chkCancelada.ForeColor = System.Drawing.Color.Red;
            this.chkCancelada.Location = new System.Drawing.Point(329, 22);
            this.chkCancelada.Name = "chkCancelada";
            this.chkCancelada.Size = new System.Drawing.Size(76, 17);
            this.chkCancelada.TabIndex = 4;
            this.chkCancelada.Text = "Cancelada";
            this.chkCancelada.UseVisualStyleBackColor = true;
            // 
            // ChkAprovada
            // 
            this.ChkAprovada.AutoSize = true;
            this.ChkAprovada.Checked = true;
            this.ChkAprovada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAprovada.ForeColor = System.Drawing.Color.Lime;
            this.ChkAprovada.Location = new System.Drawing.Point(255, 22);
            this.ChkAprovada.Name = "ChkAprovada";
            this.ChkAprovada.Size = new System.Drawing.Size(73, 17);
            this.ChkAprovada.TabIndex = 3;
            this.ChkAprovada.Text = "Aprovada";
            this.ChkAprovada.UseVisualStyleBackColor = true;
            // 
            // chkAnalise
            // 
            this.chkAnalise.AutoSize = true;
            this.chkAnalise.Checked = true;
            this.chkAnalise.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAnalise.Enabled = false;
            this.chkAnalise.ForeColor = System.Drawing.Color.White;
            this.chkAnalise.Location = new System.Drawing.Point(181, 22);
            this.chkAnalise.Name = "chkAnalise";
            this.chkAnalise.Size = new System.Drawing.Size(77, 17);
            this.chkAnalise.TabIndex = 2;
            this.chkAnalise.Text = "Em Análise";
            this.chkAnalise.UseVisualStyleBackColor = true;
            // 
            // rbDtEmissao
            // 
            this.rbDtEmissao.AutoSize = true;
            this.rbDtEmissao.Checked = true;
            this.rbDtEmissao.Location = new System.Drawing.Point(6, 22);
            this.rbDtEmissao.Name = "rbDtEmissao";
            this.rbDtEmissao.Size = new System.Drawing.Size(89, 17);
            this.rbDtEmissao.TabIndex = 0;
            this.rbDtEmissao.TabStop = true;
            this.rbDtEmissao.Text = "Data Emissão";
            this.rbDtEmissao.UseVisualStyleBackColor = true;
            this.rbDtEmissao.Click += new System.EventHandler(this.rbDtEmissao_Click);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(8, 41);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(510, 21);
            this.TxtPesquisa.TabIndex = 6;
            this.TxtPesquisa.Visible = false;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(96, 22);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(58, 17);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.Click += new System.EventHandler(this.rbCliente_Click);
            // 
            // tmNFe
            // 
            this.tmNFe.Enabled = true;
            this.tmNFe.Interval = 60000;
            this.tmNFe.Tick += new System.EventHandler(this.tmNFe_Tick);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Controls.Add(this.dtpIni);
            this.pnlData.Controls.Add(this.dtpFim);
            this.pnlData.Location = new System.Drawing.Point(5, 37);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(236, 29);
            this.pnlData.TabIndex = 10;
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(4, 5);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(102, 21);
            this.dtpIni.TabIndex = 12;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(128, 5);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(102, 21);
            this.dtpFim.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "até";
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(127)))), ((int)(((byte)(23)))));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAdd.FlatAppearance.BorderSize = 2;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(245, 40);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(70, 24);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Buscar";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ColSerie
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSerie.DefaultCellStyle = dataGridViewCellStyle26;
            this.ColSerie.HeaderText = "Série";
            this.ColSerie.Name = "ColSerie";
            this.ColSerie.ReadOnly = true;
            this.ColSerie.Width = 50;
            // 
            // ColNf
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Format = "n0";
            this.ColNf.DefaultCellStyle = dataGridViewCellStyle27;
            this.ColNf.HeaderText = "Documento";
            this.ColNf.Name = "ColNf";
            this.ColNf.ReadOnly = true;
            this.ColNf.Width = 80;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.Width = 250;
            // 
            // ColDataEmissao
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDataEmissao.DefaultCellStyle = dataGridViewCellStyle28;
            this.ColDataEmissao.HeaderText = "Data Emissão";
            this.ColDataEmissao.Name = "ColDataEmissao";
            this.ColDataEmissao.ReadOnly = true;
            this.ColDataEmissao.Width = 140;
            // 
            // ColValorNf
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle29.Format = "N2";
            this.ColValorNf.DefaultCellStyle = dataGridViewCellStyle29;
            this.ColValorNf.HeaderText = "Valor NFe";
            this.ColValorNf.Name = "ColValorNf";
            this.ColValorNf.ReadOnly = true;
            // 
            // ColTxChAcessoNfe
            // 
            this.ColTxChAcessoNfe.HeaderText = "TxChAcessoNfe";
            this.ColTxChAcessoNfe.Name = "ColTxChAcessoNfe";
            this.ColTxChAcessoNfe.ReadOnly = true;
            this.ColTxChAcessoNfe.Width = 250;
            // 
            // ColCodRet
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCodRet.DefaultCellStyle = dataGridViewCellStyle30;
            this.ColCodRet.HeaderText = "Retorno NFe";
            this.ColCodRet.Name = "ColCodRet";
            this.ColCodRet.ReadOnly = true;
            // 
            // ColImprimir
            // 
            this.ColImprimir.HeaderText = "";
            this.ColImprimir.Name = "ColImprimir";
            this.ColImprimir.ReadOnly = true;
            this.ColImprimir.Text = "Imprimir";
            this.ColImprimir.UseColumnTextForButtonValue = true;
            // 
            // ColCancelar
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            this.ColCancelar.DefaultCellStyle = dataGridViewCellStyle31;
            this.ColCancelar.HeaderText = "";
            this.ColCancelar.Name = "ColCancelar";
            this.ColCancelar.ReadOnly = true;
            this.ColCancelar.Text = "Cancelar";
            this.ColCancelar.UseColumnTextForButtonValue = true;
            // 
            // ColInutilizar
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(87)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            this.ColInutilizar.DefaultCellStyle = dataGridViewCellStyle32;
            this.ColInutilizar.HeaderText = "";
            this.ColInutilizar.Name = "ColInutilizar";
            this.ColInutilizar.ReadOnly = true;
            this.ColInutilizar.Text = "Inutilizar";
            this.ColInutilizar.UseColumnTextForButtonValue = true;
            // 
            // FMT005OperancaoNFe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(883, 473);
            this.Controls.Add(this.tbNFe);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FMT005OperancaoNFe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFe";
            this.tbNFe.ResumeLayout(false);
            this.tpNFeConsulta.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdNFe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbNFe;
        private System.Windows.Forms.TabPage tpNFeConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.RadioButton rbDtEmissao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdNFe;
        private System.Windows.Forms.CheckBox ChkAprovada;
        private System.Windows.Forms.CheckBox chkAnalise;
        private System.Windows.Forms.CheckBox chkCancelada;
        private System.Windows.Forms.CheckBox chkInutilizada;
        private System.Windows.Forms.Timer tmNFe;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataEmissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorNf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTxChAcessoNfe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodRet;
        private System.Windows.Forms.DataGridViewButtonColumn ColImprimir;
        private System.Windows.Forms.DataGridViewButtonColumn ColCancelar;
        private System.Windows.Forms.DataGridViewButtonColumn ColInutilizar;
    }
}