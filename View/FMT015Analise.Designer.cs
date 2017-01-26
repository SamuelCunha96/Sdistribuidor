namespace Sdistribuidor.View
{
    partial class FMT015Analise
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbControAnalise = new MetroFramework.Controls.MetroTabControl();
            this.tpPedidos = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.CboAnalise = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnConfirmar = new MetroFramework.Controls.MetroButton();
            this.dtpIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.grdPedidoAnalise = new MetroFramework.Controls.MetroGrid();
            this.ColPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFormPagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colvlpagto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbControAnalise.SuspendLayout();
            this.tpPedidos.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidoAnalise)).BeginInit();
            this.SuspendLayout();
            // 
            // tbControAnalise
            // 
            this.tbControAnalise.Controls.Add(this.tpPedidos);
            this.tbControAnalise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControAnalise.Location = new System.Drawing.Point(20, 60);
            this.tbControAnalise.Name = "tbControAnalise";
            this.tbControAnalise.SelectedIndex = 0;
            this.tbControAnalise.Size = new System.Drawing.Size(766, 425);
            this.tbControAnalise.TabIndex = 0;
            this.tbControAnalise.UseSelectable = true;
            // 
            // tpPedidos
            // 
            this.tpPedidos.Controls.Add(this.btnConfirmar);
            this.tpPedidos.Controls.Add(this.metroLabel1);
            this.tpPedidos.Controls.Add(this.CboAnalise);
            this.tpPedidos.Controls.Add(this.metroPanel2);
            this.tpPedidos.Controls.Add(this.metroPanel1);
            this.tpPedidos.HorizontalScrollbarBarColor = true;
            this.tpPedidos.HorizontalScrollbarHighlightOnWheel = false;
            this.tpPedidos.HorizontalScrollbarSize = 10;
            this.tpPedidos.Location = new System.Drawing.Point(4, 38);
            this.tpPedidos.Name = "tpPedidos";
            this.tpPedidos.Size = new System.Drawing.Size(758, 383);
            this.tpPedidos.TabIndex = 0;
            this.tpPedidos.Text = "Pedidos";
            this.tpPedidos.VerticalScrollbarBarColor = true;
            this.tpPedidos.VerticalScrollbarHighlightOnWheel = false;
            this.tpPedidos.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnBuscar);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.dtpFim);
            this.metroPanel1.Controls.Add(this.dtpIni);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(758, 56);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.grdPedidoAnalise);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 56);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(758, 219);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // CboAnalise
            // 
            this.CboAnalise.FormattingEnabled = true;
            this.CboAnalise.ItemHeight = 23;
            this.CboAnalise.Items.AddRange(new object[] {
            "Aprova",
            "Cancelar"});
            this.CboAnalise.Location = new System.Drawing.Point(3, 300);
            this.CboAnalise.Name = "CboAnalise";
            this.CboAnalise.Size = new System.Drawing.Size(139, 29);
            this.CboAnalise.TabIndex = 4;
            this.CboAnalise.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(-1, 278);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Análise";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(3, 348);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(113, 35);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseSelectable = true;
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(3, 30);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(101, 20);
            this.dtpIni.TabIndex = 2;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(145, 30);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(101, 20);
            this.dtpFim.TabIndex = 3;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(110, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(29, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Até";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 8);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Dt. Pedido";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(252, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 20);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grdPedidoAnalise
            // 
            this.grdPedidoAnalise.AllowUserToAddRows = false;
            this.grdPedidoAnalise.AllowUserToDeleteRows = false;
            this.grdPedidoAnalise.AllowUserToResizeRows = false;
            this.grdPedidoAnalise.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPedidoAnalise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPedidoAnalise.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPedidoAnalise.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPedidoAnalise.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grdPedidoAnalise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedidoAnalise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPedido,
            this.ColCliente,
            this.ColFormPagto,
            this.ColDtPedido,
            this.Colvlpagto});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPedidoAnalise.DefaultCellStyle = dataGridViewCellStyle14;
            this.grdPedidoAnalise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPedidoAnalise.EnableHeadersVisualStyles = false;
            this.grdPedidoAnalise.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPedidoAnalise.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPedidoAnalise.Location = new System.Drawing.Point(0, 0);
            this.grdPedidoAnalise.Name = "grdPedidoAnalise";
            this.grdPedidoAnalise.ReadOnly = true;
            this.grdPedidoAnalise.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPedidoAnalise.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grdPedidoAnalise.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPedidoAnalise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPedidoAnalise.Size = new System.Drawing.Size(758, 219);
            this.grdPedidoAnalise.TabIndex = 2;
            // 
            // ColPedido
            // 
            this.ColPedido.DataPropertyName = "id_pedido";
            this.ColPedido.HeaderText = "Pedido";
            this.ColPedido.Name = "ColPedido";
            this.ColPedido.ReadOnly = true;
            this.ColPedido.Width = 90;
            // 
            // ColCliente
            // 
            this.ColCliente.DataPropertyName = "cliente";
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.Width = 300;
            // 
            // ColFormPagto
            // 
            this.ColFormPagto.DataPropertyName = "desc_formapagto";
            this.ColFormPagto.HeaderText = "Form. Pagto.";
            this.ColFormPagto.Name = "ColFormPagto";
            this.ColFormPagto.ReadOnly = true;
            // 
            // ColDtPedido
            // 
            this.ColDtPedido.DataPropertyName = "dt_pedido";
            dataGridViewCellStyle12.Format = "g";
            dataGridViewCellStyle12.NullValue = null;
            this.ColDtPedido.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColDtPedido.HeaderText = "Dt. Pedido";
            this.ColDtPedido.Name = "ColDtPedido";
            this.ColDtPedido.ReadOnly = true;
            // 
            // Colvlpagto
            // 
            this.Colvlpagto.DataPropertyName = "vl_pedido";
            dataGridViewCellStyle13.Format = "n2";
            this.Colvlpagto.DefaultCellStyle = dataGridViewCellStyle13;
            this.Colvlpagto.HeaderText = "Vl. Pedido";
            this.Colvlpagto.Name = "Colvlpagto";
            this.Colvlpagto.ReadOnly = true;
            // 
            // FMT015Analise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 505);
            this.Controls.Add(this.tbControAnalise);
            this.Name = "FMT015Analise";
            this.Text = "Análise de Crédito";
            this.Load += new System.EventHandler(this.FMT015Analise_Load);
            this.tbControAnalise.ResumeLayout(false);
            this.tpPedidos.ResumeLayout(false);
            this.tpPedidos.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedidoAnalise)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tbControAnalise;
        private MetroFramework.Controls.MetroTabPage tpPedidos;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox CboAnalise;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnConfirmar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpIni;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnBuscar;
        private MetroFramework.Controls.MetroGrid grdPedidoAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFormPagto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colvlpagto;
    }
}