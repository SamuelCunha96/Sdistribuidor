namespace Sdistribuidor.Relatorio
{
    partial class FRDanfe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RVDanfeNFe = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Entidade_NotaFiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Entidade_NotaFiscalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RVDanfeNFe
            // 
            this.RVDanfeNFe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RVDanfeNFe.Font = new System.Drawing.Font("Courier New", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RVDanfeNFe.IsDocumentMapWidthFixed = true;
            reportDataSource2.Name = "DSNFSaida";
            reportDataSource2.Value = this.Entidade_NotaFiscalBindingSource;
            this.RVDanfeNFe.LocalReport.DataSources.Add(reportDataSource2);
            this.RVDanfeNFe.LocalReport.ReportEmbeddedResource = "Sdistribuidor.Relatorio.DanfeNFe.rdlc";
            this.RVDanfeNFe.Location = new System.Drawing.Point(0, 0);
            this.RVDanfeNFe.Name = "RVDanfeNFe";
            this.RVDanfeNFe.PromptAreaCollapsed = true;
            this.RVDanfeNFe.Size = new System.Drawing.Size(785, 520);
            this.RVDanfeNFe.TabIndex = 0;
            this.RVDanfeNFe.Load += new System.EventHandler(this.RVDanfeNFe_Load);
            // 
            // Entidade_NotaFiscalBindingSource
            // 
            this.Entidade_NotaFiscalBindingSource.DataSource = typeof(Sdistribuidor.Entidade.Entidade_NotaFiscal);
            // 
            // FRDanfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 520);
            this.Controls.Add(this.RVDanfeNFe);
            this.Name = "FRDanfe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danfe NF-e";
            this.Load += new System.EventHandler(this.FRDanfe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Entidade_NotaFiscalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVDanfeNFe;
        private System.Windows.Forms.BindingSource Entidade_NotaFiscalBindingSource;
    }
}