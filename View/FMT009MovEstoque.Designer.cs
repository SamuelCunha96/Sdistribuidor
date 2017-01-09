namespace Sdistribuidor.View
{
    partial class FMT009MovEstoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnConsultar = new MetroFramework.Controls.MetroButton();
            this.pnlData = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpIni = new MetroFramework.Controls.MetroDateTime();
            this.dtpFim = new MetroFramework.Controls.MetroDateTime();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.grdMovEstoque = new MetroFramework.Controls.MetroGrid();
            this.txtProduto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ColProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTransacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnConsultar);
            this.metroPanel1.Controls.Add(this.pnlData);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(775, 61);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(434, 19);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 30);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseSelectable = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.metroLabel2);
            this.pnlData.Controls.Add(this.txtProduto);
            this.pnlData.Controls.Add(this.metroLabel1);
            this.pnlData.Controls.Add(this.dtpIni);
            this.pnlData.Controls.Add(this.dtpFim);
            this.pnlData.HorizontalScrollbarBarColor = true;
            this.pnlData.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlData.HorizontalScrollbarSize = 10;
            this.pnlData.Location = new System.Drawing.Point(5, 3);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(423, 51);
            this.pnlData.TabIndex = 5;
            this.pnlData.VerticalScrollbarBarColor = true;
            this.pnlData.VerticalScrollbarHighlightOnWheel = false;
            this.pnlData.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(278, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(27, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "ate";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(167, 17);
            this.dtpIni.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(105, 29);
            this.dtpIni.TabIndex = 7;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(311, 17);
            this.dtpFim.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(107, 29);
            this.dtpFim.TabIndex = 8;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.grdMovEstoque);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 121);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(775, 309);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // grdMovEstoque
            // 
            this.grdMovEstoque.AllowUserToAddRows = false;
            this.grdMovEstoque.AllowUserToDeleteRows = false;
            this.grdMovEstoque.AllowUserToResizeRows = false;
            this.grdMovEstoque.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMovEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdMovEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdMovEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMovEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMovEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProduto,
            this.ColDtMov,
            this.ColTransacao,
            this.ColTipoMovimentacao,
            this.ColQtMov,
            this.ColObs});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMovEstoque.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdMovEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMovEstoque.EnableHeadersVisualStyles = false;
            this.grdMovEstoque.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdMovEstoque.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMovEstoque.Location = new System.Drawing.Point(0, 0);
            this.grdMovEstoque.Name = "grdMovEstoque";
            this.grdMovEstoque.ReadOnly = true;
            this.grdMovEstoque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMovEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdMovEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMovEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMovEstoque.Size = new System.Drawing.Size(775, 309);
            this.grdMovEstoque.TabIndex = 2;
            // 
            // txtProduto
            // 
            // 
            // 
            // 
            this.txtProduto.CustomButton.Image = null;
            this.txtProduto.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtProduto.CustomButton.Name = "";
            this.txtProduto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProduto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProduto.CustomButton.TabIndex = 1;
            this.txtProduto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProduto.CustomButton.UseSelectable = true;
            this.txtProduto.CustomButton.Visible = false;
            this.txtProduto.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProduto.Lines = new string[0];
            this.txtProduto.Location = new System.Drawing.Point(6, 22);
            this.txtProduto.MaxLength = 32767;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.PasswordChar = '\0';
            this.txtProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProduto.SelectedText = "";
            this.txtProduto.SelectionLength = 0;
            this.txtProduto.SelectionStart = 0;
            this.txtProduto.ShortcutsEnabled = true;
            this.txtProduto.Size = new System.Drawing.Size(155, 23);
            this.txtProduto.TabIndex = 10;
            this.txtProduto.UseSelectable = true;
            this.txtProduto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProduto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 2);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Produto";
            // 
            // ColProduto
            // 
            this.ColProduto.DataPropertyName = "produto";
            this.ColProduto.HeaderText = "Produto";
            this.ColProduto.Name = "ColProduto";
            this.ColProduto.ReadOnly = true;
            this.ColProduto.Width = 280;
            // 
            // ColDtMov
            // 
            this.ColDtMov.DataPropertyName = "dtmovimentacao";
            this.ColDtMov.HeaderText = "Dt. Mov.";
            this.ColDtMov.Name = "ColDtMov";
            this.ColDtMov.ReadOnly = true;
            // 
            // ColTransacao
            // 
            this.ColTransacao.DataPropertyName = "tptabela";
            this.ColTransacao.HeaderText = "Transação";
            this.ColTransacao.Name = "ColTransacao";
            this.ColTransacao.ReadOnly = true;
            // 
            // ColTipoMovimentacao
            // 
            this.ColTipoMovimentacao.DataPropertyName = "tipmov";
            this.ColTipoMovimentacao.HeaderText = "Tipo";
            this.ColTipoMovimentacao.Name = "ColTipoMovimentacao";
            this.ColTipoMovimentacao.ReadOnly = true;
            // 
            // ColQtMov
            // 
            this.ColQtMov.DataPropertyName = "qtmovimentada";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "n2";
            this.ColQtMov.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColQtMov.HeaderText = "Qt. Mov.";
            this.ColQtMov.Name = "ColQtMov";
            this.ColQtMov.ReadOnly = true;
            // 
            // ColObs
            // 
            this.ColObs.DataPropertyName = "obsmovimentacao";
            this.ColObs.HeaderText = "Obs.";
            this.ColObs.Name = "ColObs";
            this.ColObs.ReadOnly = true;
            this.ColObs.Width = 400;
            // 
            // FMT009MovEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FMT009MovEstoque";
            this.Text = "Consulta  de Estoque";
            this.metroPanel1.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMovEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel pnlData;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtpIni;
        private MetroFramework.Controls.MetroDateTime dtpFim;
        private MetroFramework.Controls.MetroButton btnConsultar;
        private MetroFramework.Controls.MetroGrid grdMovEstoque;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTransacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColObs;
    }
}