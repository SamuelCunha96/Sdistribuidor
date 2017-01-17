namespace Sdistribuidor.Relatorio
{
    partial class FR004NfEmitidas
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
            this.BtnVisualizar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ChkListStNFe = new System.Windows.Forms.CheckedListBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DtFim = new System.Windows.Forms.DateTimePicker();
            this.DtIni = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BtnVisualizar);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.ChkListStNFe);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.DtFim);
            this.metroPanel1.Controls.Add(this.DtIni);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(503, 224);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnVisualizar
            // 
            this.BtnVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.BtnVisualizar.ForeColor = System.Drawing.Color.White;
            this.BtnVisualizar.Location = new System.Drawing.Point(3, 189);
            this.BtnVisualizar.Name = "BtnVisualizar";
            this.BtnVisualizar.Size = new System.Drawing.Size(82, 31);
            this.BtnVisualizar.TabIndex = 8;
            this.BtnVisualizar.Text = "Visualizar";
            this.BtnVisualizar.UseCustomBackColor = true;
            this.BtnVisualizar.UseCustomForeColor = true;
            this.BtnVisualizar.UseSelectable = true;
            this.BtnVisualizar.Click += new System.EventHandler(this.BtnVisualizar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 47);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Selecione";
            // 
            // ChkListStNFe
            // 
            this.ChkListStNFe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChkListStNFe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkListStNFe.FormattingEnabled = true;
            this.ChkListStNFe.Items.AddRange(new object[] {
            "Esperando Aprovação",
            "Rejeitadas",
            "Autorizadas",
            "Canceladas",
            "Inutilizadas",
            "Denegada"});
            this.ChkListStNFe.Location = new System.Drawing.Point(4, 70);
            this.ChkListStNFe.Name = "ChkListStNFe";
            this.ChkListStNFe.Size = new System.Drawing.Size(179, 108);
            this.ChkListStNFe.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(109, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(27, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "até";
            // 
            // DtFim
            // 
            this.DtFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFim.Location = new System.Drawing.Point(142, 21);
            this.DtFim.Name = "DtFim";
            this.DtFim.Size = new System.Drawing.Size(103, 23);
            this.DtFim.TabIndex = 4;
            // 
            // DtIni
            // 
            this.DtIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtIni.Location = new System.Drawing.Point(3, 21);
            this.DtIni.Name = "DtIni";
            this.DtIni.Size = new System.Drawing.Size(103, 23);
            this.DtIni.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Data de Emissão";
            // 
            // FR004NfEmitidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 304);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FR004NfEmitidas";
            this.Text = "Notas Emitidas";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker DtFim;
        private System.Windows.Forms.DateTimePicker DtIni;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.CheckedListBox ChkListStNFe;
        private MetroFramework.Controls.MetroButton BtnVisualizar;
    }
}