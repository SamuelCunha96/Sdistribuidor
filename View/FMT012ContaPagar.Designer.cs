namespace Sdistribuidor.View
{
    partial class FMT012ContaPagar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BtnSalvar = new MetroFramework.Controls.MetroButton();
            this.grdparcelas = new MetroFramework.Controls.MetroGrid();
            this.ColDtPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVlPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TxtTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TxtQtParcelas = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TxtDoc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.DtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.DtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtFornecedor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdparcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BtnSalvar);
            this.metroPanel1.Controls.Add(this.grdparcelas);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.TxtTotal);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.TxtQtParcelas);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.TxtDoc);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.DtpVencimento);
            this.metroPanel1.Controls.Add(this.DtpEmissao);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.TxtFornecedor);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(594, 382);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(7, 350);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 29);
            this.BtnSalvar.TabIndex = 18;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseSelectable = true;
            // 
            // grdparcelas
            // 
            this.grdparcelas.AllowUserToAddRows = false;
            this.grdparcelas.AllowUserToDeleteRows = false;
            this.grdparcelas.AllowUserToResizeRows = false;
            this.grdparcelas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdparcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdparcelas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdparcelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdparcelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdparcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdparcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDtPagamento,
            this.ColVlPagamento});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdparcelas.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdparcelas.EnableHeadersVisualStyles = false;
            this.grdparcelas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdparcelas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdparcelas.Location = new System.Drawing.Point(7, 170);
            this.grdparcelas.Name = "grdparcelas";
            this.grdparcelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdparcelas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdparcelas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdparcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdparcelas.Size = new System.Drawing.Size(584, 155);
            this.grdparcelas.TabIndex = 17;
            // 
            // ColDtPagamento
            // 
            this.ColDtPagamento.HeaderText = "Dt. Pagamento";
            this.ColDtPagamento.Name = "ColDtPagamento";
            this.ColDtPagamento.Width = 150;
            // 
            // ColVlPagamento
            // 
            dataGridViewCellStyle6.Format = "n2";
            this.ColVlPagamento.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColVlPagamento.HeaderText = "Vl. A Pagar";
            this.ColVlPagamento.Name = "ColVlPagamento";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(7, 148);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(56, 19);
            this.metroLabel8.TabIndex = 16;
            this.metroLabel8.Text = "Parcelas";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(7, 116);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(584, 29);
            this.metroComboBox1.TabIndex = 15;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(4, 94);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(158, 19);
            this.metroLabel7.TabIndex = 14;
            this.metroLabel7.Text = "Grupo de Contas a Pagar";
            // 
            // TxtTotal
            // 
            // 
            // 
            // 
            this.TxtTotal.CustomButton.Image = null;
            this.TxtTotal.CustomButton.Location = new System.Drawing.Point(63, 1);
            this.TxtTotal.CustomButton.Name = "";
            this.TxtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTotal.CustomButton.TabIndex = 1;
            this.TxtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTotal.CustomButton.UseSelectable = true;
            this.TxtTotal.CustomButton.Visible = false;
            this.TxtTotal.Lines = new string[] {
        "0,00"};
            this.TxtTotal.Location = new System.Drawing.Point(374, 68);
            this.TxtTotal.MaxLength = 32767;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.PasswordChar = '\0';
            this.TxtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTotal.SelectedText = "";
            this.TxtTotal.SelectionLength = 0;
            this.TxtTotal.SelectionStart = 0;
            this.TxtTotal.ShortcutsEnabled = true;
            this.TxtTotal.Size = new System.Drawing.Size(85, 23);
            this.TxtTotal.TabIndex = 13;
            this.TxtTotal.Text = "0,00";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTotal.UseSelectable = true;
            this.TxtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTotal_KeyPress);
            this.TxtTotal.Leave += new System.EventHandler(this.TxtTotal_Leave);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(369, 50);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(85, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Total a Pagar";
            // 
            // TxtQtParcelas
            // 
            // 
            // 
            // 
            this.TxtQtParcelas.CustomButton.Image = null;
            this.TxtQtParcelas.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.TxtQtParcelas.CustomButton.Name = "";
            this.TxtQtParcelas.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtQtParcelas.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtQtParcelas.CustomButton.TabIndex = 1;
            this.TxtQtParcelas.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtQtParcelas.CustomButton.UseSelectable = true;
            this.TxtQtParcelas.CustomButton.Visible = false;
            this.TxtQtParcelas.Lines = new string[0];
            this.TxtQtParcelas.Location = new System.Drawing.Point(292, 68);
            this.TxtQtParcelas.MaxLength = 32767;
            this.TxtQtParcelas.Name = "TxtQtParcelas";
            this.TxtQtParcelas.PasswordChar = '\0';
            this.TxtQtParcelas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtQtParcelas.SelectedText = "";
            this.TxtQtParcelas.SelectionLength = 0;
            this.TxtQtParcelas.SelectionStart = 0;
            this.TxtQtParcelas.ShortcutsEnabled = true;
            this.TxtQtParcelas.Size = new System.Drawing.Size(76, 23);
            this.TxtQtParcelas.TabIndex = 11;
            this.TxtQtParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtQtParcelas.UseSelectable = true;
            this.TxtQtParcelas.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtQtParcelas.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtQtParcelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtParcelas_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(287, 50);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Qt. Parcelas";
            // 
            // TxtDoc
            // 
            // 
            // 
            // 
            this.TxtDoc.CustomButton.Image = null;
            this.TxtDoc.CustomButton.Location = new System.Drawing.Point(54, 1);
            this.TxtDoc.CustomButton.Name = "";
            this.TxtDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDoc.CustomButton.TabIndex = 1;
            this.TxtDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDoc.CustomButton.UseSelectable = true;
            this.TxtDoc.CustomButton.Visible = false;
            this.TxtDoc.Lines = new string[0];
            this.TxtDoc.Location = new System.Drawing.Point(7, 68);
            this.TxtDoc.MaxLength = 32767;
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.PasswordChar = '\0';
            this.TxtDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDoc.SelectedText = "";
            this.TxtDoc.SelectionLength = 0;
            this.TxtDoc.SelectionStart = 0;
            this.TxtDoc.ShortcutsEnabled = true;
            this.TxtDoc.Size = new System.Drawing.Size(76, 23);
            this.TxtDoc.TabIndex = 9;
            this.TxtDoc.UseSelectable = true;
            this.TxtDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 50);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Documento";
            // 
            // DtpVencimento
            // 
            this.DtpVencimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpVencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpVencimento.Location = new System.Drawing.Point(189, 69);
            this.DtpVencimento.Name = "DtpVencimento";
            this.DtpVencimento.Size = new System.Drawing.Size(95, 22);
            this.DtpVencimento.TabIndex = 7;
            // 
            // DtpEmissao
            // 
            this.DtpEmissao.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpEmissao.Location = new System.Drawing.Point(91, 69);
            this.DtpEmissao.Name = "DtpEmissao";
            this.DtpEmissao.Size = new System.Drawing.Size(95, 22);
            this.DtpEmissao.TabIndex = 6;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(185, 50);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Dt. Vencimento";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(89, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Dt. Emissão";
            // 
            // TxtFornecedor
            // 
            this.TxtFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.TxtFornecedor.CustomButton.Image = null;
            this.TxtFornecedor.CustomButton.Location = new System.Drawing.Point(564, 1);
            this.TxtFornecedor.CustomButton.Name = "";
            this.TxtFornecedor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtFornecedor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtFornecedor.CustomButton.TabIndex = 1;
            this.TxtFornecedor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtFornecedor.CustomButton.UseSelectable = true;
            this.TxtFornecedor.CustomButton.Visible = false;
            this.TxtFornecedor.Lines = new string[0];
            this.TxtFornecedor.Location = new System.Drawing.Point(5, 24);
            this.TxtFornecedor.MaxLength = 32767;
            this.TxtFornecedor.Name = "TxtFornecedor";
            this.TxtFornecedor.PasswordChar = '\0';
            this.TxtFornecedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtFornecedor.SelectedText = "";
            this.TxtFornecedor.SelectionLength = 0;
            this.TxtFornecedor.SelectionStart = 0;
            this.TxtFornecedor.ShortcutsEnabled = true;
            this.TxtFornecedor.Size = new System.Drawing.Size(586, 23);
            this.TxtFornecedor.TabIndex = 3;
            this.TxtFornecedor.UseSelectable = true;
            this.TxtFornecedor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtFornecedor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Fornecedor";
            // 
            // FMT012ContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.metroPanel1);
            this.KeyPreview = true;
            this.Name = "FMT012ContaPagar";
            this.Text = "Contas a Pagar";
            this.Load += new System.EventHandler(this.FMT012ContaPagar_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdparcelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtFornecedor;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker DtpVencimento;
        private System.Windows.Forms.DateTimePicker DtpEmissao;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TxtDoc;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TxtQtParcelas;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox TxtTotal;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroGrid grdparcelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDtPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVlPagamento;
        private MetroFramework.Controls.MetroButton BtnSalvar;
    }
}