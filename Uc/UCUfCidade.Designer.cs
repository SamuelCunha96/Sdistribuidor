namespace Sdistribuidor.View.UC
{
    partial class UCUfCidade
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboUF = new System.Windows.Forms.ComboBox();
            this.CboCidade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cidade";
            // 
            // CboUF
            // 
            this.CboUF.FormattingEnabled = true;
            this.CboUF.Location = new System.Drawing.Point(2, 14);
            this.CboUF.Name = "CboUF";
            this.CboUF.Size = new System.Drawing.Size(42, 21);
            this.CboUF.TabIndex = 2;
            this.CboUF.SelectionChangeCommitted += new System.EventHandler(this.CboUF_SelectionChangeCommitted);
            // 
            // CboCidade
            // 
            this.CboCidade.FormattingEnabled = true;
            this.CboCidade.Location = new System.Drawing.Point(49, 14);
            this.CboCidade.Name = "CboCidade";
            this.CboCidade.Size = new System.Drawing.Size(186, 21);
            this.CboCidade.TabIndex = 2;
            // 
            // UCUfCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CboCidade);
            this.Controls.Add(this.CboUF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCUfCidade";
            this.Size = new System.Drawing.Size(238, 36);
            this.Load += new System.EventHandler(this.UCUfCidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboUF;
        private System.Windows.Forms.ComboBox CboCidade;
    }
}
