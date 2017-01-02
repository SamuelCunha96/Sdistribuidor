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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.rbProduto = new MetroFramework.Controls.MetroRadioButton();
            this.rbData = new MetroFramework.Controls.MetroRadioButton();
            this.pnlData = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpIni = new MetroFramework.Controls.MetroDateTime();
            this.dtpFim = new MetroFramework.Controls.MetroDateTime();
            this.pnlProduto = new MetroFramework.Controls.MetroPanel();
            this.txtProduto = new MetroFramework.Controls.MetroTextBox();
            this.btnConsultar = new MetroFramework.Controls.MetroButton();
            this.grdMovEstoque = new MetroFramework.Controls.MetroGrid();
            this.ColProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDtMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipoMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnConsultar);
            this.metroPanel1.Controls.Add(this.pnlProduto);
            this.metroPanel1.Controls.Add(this.pnlData);
            this.metroPanel1.Controls.Add(this.rbData);
            this.metroPanel1.Controls.Add(this.rbProduto);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(641, 61);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            this.metroPanel2.Size = new System.Drawing.Size(641, 309);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // rbProduto
            // 
            this.rbProduto.AutoSize = true;
            this.rbProduto.Checked = true;
            this.rbProduto.Location = new System.Drawing.Point(3, 3);
            this.rbProduto.Name = "rbProduto";
            this.rbProduto.Size = new System.Drawing.Size(66, 15);
            this.rbProduto.TabIndex = 2;
            this.rbProduto.TabStop = true;
            this.rbProduto.Text = "Produto";
            this.rbProduto.UseSelectable = true;
            this.rbProduto.Click += new System.EventHandler(this.rbProduto_Click);
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.Location = new System.Drawing.Point(75, 3);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(47, 15);
            this.rbData.TabIndex = 3;
            this.rbData.Text = "Data";
            this.rbData.UseSelectable = true;
            this.rbData.Click += new System.EventHandler(this.rbData_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.metroLabel1);
            this.pnlData.Controls.Add(this.dtpIni);
            this.pnlData.Controls.Add(this.dtpFim);
            this.pnlData.HorizontalScrollbarBarColor = true;
            this.pnlData.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlData.HorizontalScrollbarSize = 10;
            this.pnlData.Location = new System.Drawing.Point(5, 20);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(267, 36);
            this.pnlData.TabIndex = 5;
            this.pnlData.VerticalScrollbarBarColor = true;
            this.pnlData.VerticalScrollbarHighlightOnWheel = false;
            this.pnlData.VerticalScrollbarSize = 10;
            this.pnlData.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(117, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(27, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "ate";
            // 
            // dtpIni
            // 
            this.dtpIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIni.Location = new System.Drawing.Point(6, 4);
            this.dtpIni.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpIni.Name = "dtpIni";
            this.dtpIni.Size = new System.Drawing.Size(105, 29);
            this.dtpIni.TabIndex = 7;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(150, 4);
            this.dtpFim.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(107, 29);
            this.dtpFim.TabIndex = 8;
            // 
            // pnlProduto
            // 
            this.pnlProduto.Controls.Add(this.txtProduto);
            this.pnlProduto.HorizontalScrollbarBarColor = true;
            this.pnlProduto.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlProduto.HorizontalScrollbarSize = 10;
            this.pnlProduto.Location = new System.Drawing.Point(3, 21);
            this.pnlProduto.Name = "pnlProduto";
            this.pnlProduto.Size = new System.Drawing.Size(163, 32);
            this.pnlProduto.TabIndex = 6;
            this.pnlProduto.VerticalScrollbarBarColor = true;
            this.pnlProduto.VerticalScrollbarHighlightOnWheel = false;
            this.pnlProduto.VerticalScrollbarSize = 10;
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
            this.txtProduto.Location = new System.Drawing.Point(1, 5);
            this.txtProduto.MaxLength = 32767;
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.PasswordChar = '\0';
            this.txtProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProduto.SelectedText = "";
            this.txtProduto.SelectionLength = 0;
            this.txtProduto.SelectionStart = 0;
            this.txtProduto.ShortcutsEnabled = true;
            this.txtProduto.Size = new System.Drawing.Size(155, 23);
            this.txtProduto.TabIndex = 5;
            this.txtProduto.UseSelectable = true;
            this.txtProduto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProduto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(553, 25);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(85, 31);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseSelectable = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMovEstoque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdMovEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMovEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProduto,
            this.ColDtMov,
            this.ColTipoMovimentacao,
            this.ColQtMov});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMovEstoque.DefaultCellStyle = dataGridViewCellStyle11;
            this.grdMovEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMovEstoque.EnableHeadersVisualStyles = false;
            this.grdMovEstoque.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdMovEstoque.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMovEstoque.Location = new System.Drawing.Point(0, 0);
            this.grdMovEstoque.Name = "grdMovEstoque";
            this.grdMovEstoque.ReadOnly = true;
            this.grdMovEstoque.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMovEstoque.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.grdMovEstoque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMovEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMovEstoque.Size = new System.Drawing.Size(641, 309);
            this.grdMovEstoque.TabIndex = 2;
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
            this.ColDtMov.DataPropertyName = "qtmovimentada";
            this.ColDtMov.HeaderText = "Dt. Mov.";
            this.ColDtMov.Name = "ColDtMov";
            this.ColDtMov.ReadOnly = true;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "n2";
            this.ColQtMov.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColQtMov.HeaderText = "Qt. Mov.";
            this.ColQtMov.Name = "ColQtMov";
            this.ColQtMov.ReadOnly = true;
            // 
            // FMT009MovEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FMT009MovEstoque";
            this.Text = "Movimentação  de Estoque";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMovEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroRadioButton rbProduto;
        private MetroFramework.Controls.MetroRadioButton rbData;
        private MetroFramework.Controls.MetroPanel pnlData;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtpIni;
        private MetroFramework.Controls.MetroDateTime dtpFim;
        private MetroFramework.Controls.MetroPanel pnlProduto;
        private MetroFramework.Controls.MetroTextBox txtProduto;
        private MetroFramework.Controls.MetroButton btnConsultar;
        private MetroFramework.Controls.MetroGrid grdMovEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipoMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtMov;
    }
}