namespace Sdistribuidor.View
{
    partial class FUTabelasAux
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
            this.ChkListAux = new System.Windows.Forms.CheckedListBox();
            this.pbAux = new System.Windows.Forms.ProgressBar();
            this.btIncluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChkListAux
            // 
            this.ChkListAux.FormattingEnabled = true;
            this.ChkListAux.Items.AddRange(new object[] {
            "UF",
            "Cidade",
            "Pais",
            "Cfop",
            "Cst"});
            this.ChkListAux.Location = new System.Drawing.Point(3, 12);
            this.ChkListAux.Name = "ChkListAux";
            this.ChkListAux.Size = new System.Drawing.Size(286, 124);
            this.ChkListAux.TabIndex = 0;
            // 
            // pbAux
            // 
            this.pbAux.Location = new System.Drawing.Point(3, 142);
            this.pbAux.Name = "pbAux";
            this.pbAux.Size = new System.Drawing.Size(286, 10);
            this.pbAux.TabIndex = 1;
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(3, 156);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.TabIndex = 2;
            this.btIncluir.Text = "Iniciar";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // FUTabelasAux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 182);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.pbAux);
            this.Controls.Add(this.ChkListAux);
            this.MaximizeBox = false;
            this.Name = "FUTabelasAux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ChkListAux;
        private System.Windows.Forms.ProgressBar pbAux;
        private System.Windows.Forms.Button btIncluir;
    }
}