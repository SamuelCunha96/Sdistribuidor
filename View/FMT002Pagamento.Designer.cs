namespace Sdistribuidor.View
{
    partial class FMT002Pagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdPedidosPagamento = new System.Windows.Forms.DataGridView();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVlPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFlCartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFormaPagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFlAvista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.pnlPgMixto = new System.Windows.Forms.Panel();
            this.OptCartao = new System.Windows.Forms.RadioButton();
            this.OptDinheiro = new System.Windows.Forms.RadioButton();
            this.lblID = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblNmBandeiras = new System.Windows.Forms.Label();
            this.cboBandeiras = new System.Windows.Forms.ComboBox();
            this.lblDescFormaPagto = new System.Windows.Forms.Label();
            this.BtnReceber = new System.Windows.Forms.Button();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grdrecebido = new System.Windows.Forms.DataGridView();
            this.ColPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TmPedido = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosPagamento)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlPgMixto.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdrecebido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdPedidosPagamento);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Pedidos";
            // 
            // grdPedidosPagamento
            // 
            this.grdPedidosPagamento.AllowUserToAddRows = false;
            this.grdPedidosPagamento.AllowUserToDeleteRows = false;
            this.grdPedidosPagamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPedidosPagamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPedidosPagamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPedidosPagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedidosPagamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNome,
            this.ColDtPedido,
            this.ColVlPedido,
            this.ColFlCartao,
            this.ColFormaPagto,
            this.ColFlAvista,
            this.ColID});
            this.grdPedidosPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPedidosPagamento.EnableHeadersVisualStyles = false;
            this.grdPedidosPagamento.Location = new System.Drawing.Point(3, 17);
            this.grdPedidosPagamento.Name = "grdPedidosPagamento";
            this.grdPedidosPagamento.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPedidosPagamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdPedidosPagamento.RowHeadersVisible = false;
            this.grdPedidosPagamento.Size = new System.Drawing.Size(835, 182);
            this.grdPedidosPagamento.TabIndex = 0;
            this.toolTip1.SetToolTip(this.grdPedidosPagamento, "Click duas vezes no pedido para receber");
            this.grdPedidosPagamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPedidosPagamento_CellDoubleClick);
            // 
            // ColNome
            // 
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.ReadOnly = true;
            this.ColNome.Width = 300;
            // 
            // ColDtPedido
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.ColDtPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColDtPedido.HeaderText = "Dt. Pedido";
            this.ColDtPedido.Name = "ColDtPedido";
            this.ColDtPedido.ReadOnly = true;
            this.ColDtPedido.Width = 140;
            // 
            // ColVlPedido
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.ColVlPedido.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColVlPedido.HeaderText = "Vl. Pedido";
            this.ColVlPedido.Name = "ColVlPedido";
            this.ColVlPedido.ReadOnly = true;
            // 
            // ColFlCartao
            // 
            this.ColFlCartao.HeaderText = "FlCartao";
            this.ColFlCartao.Name = "ColFlCartao";
            this.ColFlCartao.ReadOnly = true;
            this.ColFlCartao.Visible = false;
            // 
            // ColFormaPagto
            // 
            this.ColFormaPagto.HeaderText = "Forma Pagto";
            this.ColFormaPagto.Name = "ColFormaPagto";
            this.ColFormaPagto.ReadOnly = true;
            this.ColFormaPagto.Width = 120;
            // 
            // ColFlAvista
            // 
            this.ColFlAvista.HeaderText = "ColFlAvista";
            this.ColFlAvista.Name = "ColFlAvista";
            this.ColFlAvista.ReadOnly = true;
            this.ColFlAvista.Visible = false;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ColID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblCliente);
            this.groupBox2.Controls.Add(this.pnlPgMixto);
            this.groupBox2.Controls.Add(this.lblID);
            this.groupBox2.Controls.Add(this.lbltotal);
            this.groupBox2.Controls.Add(this.lblNmBandeiras);
            this.groupBox2.Controls.Add(this.cboBandeiras);
            this.groupBox2.Controls.Add(this.lblDescFormaPagto);
            this.groupBox2.Controls.Add(this.BtnReceber);
            this.groupBox2.Controls.Add(this.txtPagamento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagamento";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(727, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "Total:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(455, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 12);
            this.lblCliente.TabIndex = 25;
            // 
            // pnlPgMixto
            // 
            this.pnlPgMixto.Controls.Add(this.OptCartao);
            this.pnlPgMixto.Controls.Add(this.OptDinheiro);
            this.pnlPgMixto.Location = new System.Drawing.Point(308, 51);
            this.pnlPgMixto.Name = "pnlPgMixto";
            this.pnlPgMixto.Size = new System.Drawing.Size(124, 22);
            this.pnlPgMixto.TabIndex = 24;
            this.pnlPgMixto.Visible = false;
            // 
            // OptCartao
            // 
            this.OptCartao.AutoSize = true;
            this.OptCartao.Location = new System.Drawing.Point(66, 4);
            this.OptCartao.Name = "OptCartao";
            this.OptCartao.Size = new System.Drawing.Size(56, 16);
            this.OptCartao.TabIndex = 27;
            this.OptCartao.Text = "Cartão";
            this.OptCartao.UseVisualStyleBackColor = true;
            this.OptCartao.Click += new System.EventHandler(this.OptCartao_Click);
            // 
            // OptDinheiro
            // 
            this.OptDinheiro.AutoSize = true;
            this.OptDinheiro.Checked = true;
            this.OptDinheiro.Location = new System.Drawing.Point(1, 5);
            this.OptDinheiro.Name = "OptDinheiro";
            this.OptDinheiro.Size = new System.Drawing.Size(64, 16);
            this.OptDinheiro.TabIndex = 26;
            this.OptDinheiro.TabStop = true;
            this.OptDinheiro.Text = "Dinheiro";
            this.OptDinheiro.UseVisualStyleBackColor = true;
            this.OptDinheiro.Click += new System.EventHandler(this.OptDinheiro_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(321, 29);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 12);
            this.lblID.TabIndex = 23;
            this.lblID.Visible = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(777, 9);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(26, 12);
            this.lbltotal.TabIndex = 22;
            this.lbltotal.Text = "0,00";
            // 
            // lblNmBandeiras
            // 
            this.lblNmBandeiras.AutoSize = true;
            this.lblNmBandeiras.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmBandeiras.Location = new System.Drawing.Point(434, 30);
            this.lblNmBandeiras.Name = "lblNmBandeiras";
            this.lblNmBandeiras.Size = new System.Drawing.Size(54, 12);
            this.lblNmBandeiras.TabIndex = 21;
            this.lblNmBandeiras.Text = "Bandeiras";
            this.lblNmBandeiras.Visible = false;
            // 
            // cboBandeiras
            // 
            this.cboBandeiras.DisplayMember = "nmbandeira";
            this.cboBandeiras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBandeiras.FormattingEnabled = true;
            this.cboBandeiras.Location = new System.Drawing.Point(436, 46);
            this.cboBandeiras.Name = "cboBandeiras";
            this.cboBandeiras.Size = new System.Drawing.Size(162, 26);
            this.cboBandeiras.TabIndex = 20;
            this.cboBandeiras.ValueMember = "id";
            this.cboBandeiras.Visible = false;
            // 
            // lblDescFormaPagto
            // 
            this.lblDescFormaPagto.AutoSize = true;
            this.lblDescFormaPagto.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescFormaPagto.ForeColor = System.Drawing.Color.White;
            this.lblDescFormaPagto.Location = new System.Drawing.Point(12, 35);
            this.lblDescFormaPagto.Name = "lblDescFormaPagto";
            this.lblDescFormaPagto.Size = new System.Drawing.Size(0, 29);
            this.lblDescFormaPagto.TabIndex = 19;
            // 
            // BtnReceber
            // 
            this.BtnReceber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.BtnReceber.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnReceber.FlatAppearance.BorderSize = 2;
            this.BtnReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReceber.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReceber.ForeColor = System.Drawing.Color.White;
            this.BtnReceber.Location = new System.Drawing.Point(707, 41);
            this.BtnReceber.Name = "BtnReceber";
            this.BtnReceber.Size = new System.Drawing.Size(122, 34);
            this.BtnReceber.TabIndex = 18;
            this.BtnReceber.Text = "Receber";
            this.BtnReceber.UseVisualStyleBackColor = false;
            this.BtnReceber.Click += new System.EventHandler(this.BtnReceber_Click);
            // 
            // txtPagamento
            // 
            this.txtPagamento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagamento.Location = new System.Drawing.Point(602, 45);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(91, 27);
            this.txtPagamento.TabIndex = 3;
            this.txtPagamento.Text = "0,00";
            this.txtPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagamento_KeyPress);
            this.txtPagamento.Leave += new System.EventHandler(this.txtPagamento_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.groupBox3.Controls.Add(this.grdrecebido);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(0, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(841, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recebido";
            // 
            // grdrecebido
            // 
            this.grdrecebido.AllowUserToAddRows = false;
            this.grdrecebido.AllowUserToDeleteRows = false;
            this.grdrecebido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdrecebido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdrecebido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdrecebido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPagamento,
            this.ColValor});
            this.grdrecebido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdrecebido.EnableHeadersVisualStyles = false;
            this.grdrecebido.Location = new System.Drawing.Point(3, 14);
            this.grdrecebido.Name = "grdrecebido";
            this.grdrecebido.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdrecebido.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdrecebido.RowHeadersVisible = false;
            this.grdrecebido.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.grdrecebido.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdrecebido.Size = new System.Drawing.Size(835, 109);
            this.grdrecebido.TabIndex = 1;
            this.grdrecebido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdrecebido_KeyDown);
            // 
            // ColPagamento
            // 
            this.ColPagamento.HeaderText = "Pagamento";
            this.ColPagamento.Name = "ColPagamento";
            this.ColPagamento.ReadOnly = true;
            this.ColPagamento.Width = 140;
            // 
            // ColValor
            // 
            dataGridViewCellStyle6.Format = "N2";
            this.ColValor.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            // 
            // TmPedido
            // 
            this.TmPedido.Enabled = true;
            this.TmPedido.Interval = 15000;
            this.TmPedido.Tick += new System.EventHandler(this.TmPedido_Tick);
            // 
            // FMT002Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 410);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "FMT002Pagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FMT002Pagamento_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidosPagamento)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlPgMixto.ResumeLayout(false);
            this.pnlPgMixto.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdrecebido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grdPedidosPagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.Button BtnReceber;
        private System.Windows.Forms.DataGridView grdrecebido;
        private System.Windows.Forms.Label lblDescFormaPagto;
        private System.Windows.Forms.Label lblNmBandeiras;
        private System.Windows.Forms.ComboBox cboBandeiras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel pnlPgMixto;
        private System.Windows.Forms.RadioButton OptCartao;
        private System.Windows.Forms.RadioButton OptDinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVlPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFlCartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFormaPagto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFlAvista;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer TmPedido;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}