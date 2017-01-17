namespace Sdistribuidor.Relatorio
{
    partial class FR003Venda
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.DtFim = new System.Windows.Forms.DateTimePicker();
            this.DtIni = new System.Windows.Forms.DateTimePicker();
            this.BtnVisualizar = new MetroFramework.Controls.MetroButton();
            this.CboTipoVenda = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.DtFim);
            this.metroPanel1.Controls.Add(this.DtIni);
            this.metroPanel1.Controls.Add(this.BtnVisualizar);
            this.metroPanel1.Controls.Add(this.CboTipoVenda);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(466, 229);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // DtFim
            // 
            this.DtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFim.Location = new System.Drawing.Point(153, 24);
            this.DtFim.Name = "DtFim";
            this.DtFim.Size = new System.Drawing.Size(108, 26);
            this.DtFim.TabIndex = 9;
            // 
            // DtIni
            // 
            this.DtIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtIni.Location = new System.Drawing.Point(6, 24);
            this.DtIni.Name = "DtIni";
            this.DtIni.Size = new System.Drawing.Size(108, 26);
            this.DtIni.TabIndex = 8;
            // 
            // BtnVisualizar
            // 
            this.BtnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.BtnVisualizar.ForeColor = System.Drawing.Color.White;
            this.BtnVisualizar.Location = new System.Drawing.Point(3, 195);
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(82, 31);
            this.BtnVisualizar.TabIndex = 7;
            this.BtnVisualizar.Text = "Visualizar";
            this.BtnVisualizar.UseCustomBackColor = true;
            this.BtnVisualizar.UseCustomForeColor = true;
            this.BtnVisualizar.UseSelectable = true;
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // CboTipoVenda
            // 
            this.CboTipoVenda.FormattingEnabled = true;
            this.CboTipoVenda.ItemHeight = 23;
            this.CboTipoVenda.Items.AddRange(new object[] {
            "Todos",
            "Recebidos",
            "Cancelados",
            "Nota Fiscal"});
            this.CboTipoVenda.Location = new System.Drawing.Point(6, 82);
            this.CboTipoVenda.Name = "CboTipoVenda";
            this.CboTipoVenda.Size = new System.Drawing.Size(238, 29);
            this.CboTipoVenda.TabIndex = 6;
            this.CboTipoVenda.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Selecione";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(120, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(27, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "até";
            // 
            // FR003Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 309);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FR003Venda";
            this.Text = "Relatório de Venda";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox CboTipoVenda;
        private MetroFramework.Controls.MetroButton BtnVisualizar;
        private System.Windows.Forms.DateTimePicker DtFim;
        private System.Windows.Forms.DateTimePicker DtIni;
    }
}