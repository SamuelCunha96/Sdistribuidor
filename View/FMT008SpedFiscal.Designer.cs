namespace Sdistribuidor.View
{
    partial class FMT008SpedFiscal
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
            this.DtIni = new MetroFramework.Controls.MetroDateTime();
            this.DtFim = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CboTipoImportacao = new MetroFramework.Controls.MetroComboBox();
            this.btnGerar = new MetroFramework.Controls.MetroButton();
            this.psProgress = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblArquivoGerado = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // DtIni
            // 
            this.DtIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtIni.Location = new System.Drawing.Point(23, 91);
            this.DtIni.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtIni.Name = "DtIni";
            this.DtIni.Size = new System.Drawing.Size(126, 29);
            this.DtIni.TabIndex = 0;
            // 
            // DtFim
            // 
            this.DtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFim.Location = new System.Drawing.Point(190, 91);
            this.DtFim.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtFim.Name = "DtFim";
            this.DtFim.Size = new System.Drawing.Size(111, 29);
            this.DtFim.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(155, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(25, 15);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Até";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(23, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(106, 15);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Selecione o périodo";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(23, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 15);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Tipo de Importação";
            // 
            // CboTipoImportacao
            // 
            this.CboTipoImportacao.FormattingEnabled = true;
            this.CboTipoImportacao.ItemHeight = 23;
            this.CboTipoImportacao.Items.AddRange(new object[] {
            "0-Original",
            "1-Retificadora"});
            this.CboTipoImportacao.Location = new System.Drawing.Point(23, 155);
            this.CboTipoImportacao.Name = "CboTipoImportacao";
            this.CboTipoImportacao.Size = new System.Drawing.Size(189, 29);
            this.CboTipoImportacao.TabIndex = 5;
            this.CboTipoImportacao.UseSelectable = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(23, 234);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 35);
            this.btnGerar.TabIndex = 6;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseSelectable = true;
            // 
            // psProgress
            // 
            this.psProgress.Location = new System.Drawing.Point(382, 69);
            this.psProgress.Maximum = 100;
            this.psProgress.Name = "psProgress";
            this.psProgress.Size = new System.Drawing.Size(157, 131);
            this.psProgress.TabIndex = 8;
            this.psProgress.UseSelectable = true;
            // 
            // lblArquivoGerado
            // 
            this.lblArquivoGerado.AutoSize = true;
            this.lblArquivoGerado.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblArquivoGerado.Location = new System.Drawing.Point(382, 212);
            this.lblArquivoGerado.Name = "lblArquivoGerado";
            this.lblArquivoGerado.Size = new System.Drawing.Size(10, 15);
            this.lblArquivoGerado.TabIndex = 9;
            this.lblArquivoGerado.Text = " ";
            // 
            // FMT008SpedFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 282);
            this.Controls.Add(this.lblArquivoGerado);
            this.Controls.Add(this.psProgress);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.CboTipoImportacao);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DtFim);
            this.Controls.Add(this.DtIni);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FMT008SpedFiscal";
            this.Text = "Sped Fiscal - EFC";
            this.Load += new System.EventHandler(this.FMT008SpedFiscal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime DtIni;
        private MetroFramework.Controls.MetroDateTime DtFim;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox CboTipoImportacao;
        private MetroFramework.Controls.MetroButton btnGerar;
        private MetroFramework.Controls.MetroProgressSpinner psProgress;
        private MetroFramework.Controls.MetroLabel lblArquivoGerado;
    }
}