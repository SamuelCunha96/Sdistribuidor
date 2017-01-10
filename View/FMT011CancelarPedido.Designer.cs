namespace Sdistribuidor.View
{
    partial class FMT011CancelarPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMT011CancelarPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConsultar = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtpFim = new MetroFramework.Controls.MetroDateTime();
            this.dtpIni = new MetroFramework.Controls.MetroDateTime();
            this.lblNmCliente = new MetroFramework.Controls.MetroLabel();
            this.btnPesqCliente = new MetroFramework.Controls.MetroButton();
            this.TxtCodCliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.grdPedido = new MetroFramework.Controls.MetroGrid();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ColIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConsultar);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.dtpFim);
            this.groupBox1.Controls.Add(this.dtpIni);
            this.groupBox1.Controls.Add(this.lblNmCliente);
            this.groupBox1.Controls.Add(this.btnPesqCliente);
            this.groupBox1.Controls.Add(this.TxtCodCliente);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione";
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(387, 30);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(80, 30);
            this.BtnConsultar.TabIndex = 7;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseSelectable = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(246, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(27, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "até";
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(279, 30);
            this.dtpFim.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(102, 29);
            this.dtpFim.TabIndex = 5;
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(131, 31);
            this.dtpIni.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(109, 29);
            this.dtpIni.TabIndex = 4;
            // 
            // lblNmCliente
            // 
            this.lblNmCliente.AutoSize = true;
            this.lblNmCliente.Location = new System.Drawing.Point(96, 15);
            this.lblNmCliente.Name = "lblNmCliente";
            this.lblNmCliente.Size = new System.Drawing.Size(0, 0);
            this.lblNmCliente.TabIndex = 3;
            // 
            // btnPesqCliente
            // 
            this.btnPesqCliente.Location = new System.Drawing.Point(96, 37);
            this.btnPesqCliente.Name = "btnPesqCliente";
            this.btnPesqCliente.Size = new System.Drawing.Size(29, 23);
            this.btnPesqCliente.TabIndex = 2;
            this.btnPesqCliente.Text = "...";
            this.btnPesqCliente.UseSelectable = true;
            this.btnPesqCliente.Click += new System.EventHandler(this.btnPesqCliente_Click);
            // 
            // TxtCodCliente
            // 
            // 
            // 
            // 
            this.TxtCodCliente.CustomButton.Image = null;
            this.TxtCodCliente.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.TxtCodCliente.CustomButton.Name = "";
            this.TxtCodCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtCodCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtCodCliente.CustomButton.TabIndex = 1;
            this.TxtCodCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtCodCliente.CustomButton.UseSelectable = true;
            this.TxtCodCliente.CustomButton.Visible = false;
            this.TxtCodCliente.Lines = new string[0];
            this.TxtCodCliente.Location = new System.Drawing.Point(10, 37);
            this.TxtCodCliente.MaxLength = 32767;
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.PasswordChar = '\0';
            this.TxtCodCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtCodCliente.SelectedText = "";
            this.TxtCodCliente.SelectionLength = 0;
            this.TxtCodCliente.SelectionStart = 0;
            this.TxtCodCliente.ShortcutsEnabled = true;
            this.TxtCodCliente.Size = new System.Drawing.Size(80, 23);
            this.TxtCodCliente.TabIndex = 1;
            this.TxtCodCliente.UseSelectable = true;
            this.TxtCodCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtCodCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodCliente_KeyPress);
            this.TxtCodCliente.Leave += new System.EventHandler(this.TxtCodCliente_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Cliente";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.grdPedido);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 131);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(807, 234);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // grdPedido
            // 
            this.grdPedido.AllowUserToAddRows = false;
            this.grdPedido.AllowUserToDeleteRows = false;
            this.grdPedido.AllowUserToResizeRows = false;
            this.grdPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdPedido,
            this.ColCliente,
            this.ColDtPedido,
            this.ColStatus,
            this.ColValor,
            this.ColCodStatus});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPedido.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPedido.EnableHeadersVisualStyles = false;
            this.grdPedido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdPedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdPedido.Location = new System.Drawing.Point(0, 0);
            this.grdPedido.Name = "grdPedido";
            this.grdPedido.ReadOnly = true;
            this.grdPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdPedido.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPedido.Size = new System.Drawing.Size(807, 234);
            this.grdPedido.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(17, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 33);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "F9-Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ColIdPedido
            // 
            this.ColIdPedido.DataPropertyName = "id_pedido";
            this.ColIdPedido.HeaderText = "Pedido";
            this.ColIdPedido.Name = "ColIdPedido";
            this.ColIdPedido.ReadOnly = true;
            this.ColIdPedido.Width = 80;
            // 
            // ColCliente
            // 
            this.ColCliente.DataPropertyName = "partnome";
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            this.ColCliente.Width = 250;
            // 
            // ColDtPedido
            // 
            this.ColDtPedido.DataPropertyName = "dt_pedido";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.ColDtPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColDtPedido.HeaderText = "DtPedido";
            this.ColDtPedido.Name = "ColDtPedido";
            this.ColDtPedido.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "statuspedido";
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Width = 200;
            // 
            // ColValor
            // 
            this.ColValor.DataPropertyName = "vl_pedido";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.ColValor.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            // 
            // ColCodStatus
            // 
            this.ColCodStatus.DataPropertyName = "stpedido";
            this.ColCodStatus.HeaderText = "CodStatus";
            this.ColCodStatus.Name = "ColCodStatus";
            this.ColCodStatus.ReadOnly = true;
            this.ColCodStatus.Visible = false;
            // 
            // FMT011CancelarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 416);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "FMT011CancelarPedido";
            this.Text = "Cancelar Pedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid grdPedido;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtCodCliente;
        private MetroFramework.Controls.MetroButton btnPesqCliente;
        private MetroFramework.Controls.MetroLabel lblNmCliente;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtpFim;
        private MetroFramework.Controls.MetroDateTime dtpIni;
        private MetroFramework.Controls.MetroButton BtnConsultar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodStatus;
    }
}