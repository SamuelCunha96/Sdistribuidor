﻿namespace Sdistribuidor.Relatorio
{
    partial class FRImpPedido
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
            this.rvPedido = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvPedido
            // 
            this.rvPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvPedido.LocalReport.ReportEmbeddedResource = "Sdistribuidor.Relatorio.ImpressaoPedido.rdlc";
            this.rvPedido.Location = new System.Drawing.Point(0, 0);
            this.rvPedido.Name = "rvPedido";
            this.rvPedido.Size = new System.Drawing.Size(812, 513);
            this.rvPedido.TabIndex = 0;
            this.rvPedido.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FRImpPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 513);
            this.Controls.Add(this.rvPedido);
            this.Name = "FRImpPedido";
            this.Text = "Imprimir Pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRImpPedido_FormClosing);
            this.Load += new System.EventHandler(this.FRImpPedido_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPedido;
    }
}