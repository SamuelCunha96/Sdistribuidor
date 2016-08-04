namespace SI.View
{
    partial class FC005Unidade
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodUnidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDescUnidade = new System.Windows.Forms.TextBox();
            this.tcBase.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            this.tpDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(168, 291);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(87, 291);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(6, 291);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(79, 293);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(0, 293);
            // 
            // tcBase
            // 
            this.tcBase.Size = new System.Drawing.Size(653, 348);
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Size = new System.Drawing.Size(645, 322);
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.TxtDescUnidade);
            this.tpDados.Controls.Add(this.label3);
            this.tpDados.Controls.Add(this.TxtCodUnidade);
            this.tpDados.Controls.Add(this.label2);
            this.tpDados.Size = new System.Drawing.Size(645, 322);
            this.tpDados.Controls.SetChildIndex(this.BtnSalvar, 0);
            this.tpDados.Controls.SetChildIndex(this.BtnExcluir, 0);
            this.tpDados.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.tpDados.Controls.SetChildIndex(this.label2, 0);
            this.tpDados.Controls.SetChildIndex(this.TxtCodUnidade, 0);
            this.tpDados.Controls.SetChildIndex(this.label3, 0);
            this.tpDados.Controls.SetChildIndex(this.TxtDescUnidade, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(639, 209);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unidade";
            // 
            // TxtCodUnidade
            // 
            this.TxtCodUnidade.Location = new System.Drawing.Point(22, 62);
            this.TxtCodUnidade.MaxLength = 5;
            this.TxtCodUnidade.Name = "TxtCodUnidade";
            this.TxtCodUnidade.Size = new System.Drawing.Size(59, 21);
            this.TxtCodUnidade.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descrição";
            // 
            // TxtDescUnidade
            // 
            this.TxtDescUnidade.Location = new System.Drawing.Point(22, 105);
            this.TxtDescUnidade.MaxLength = 30;
            this.TxtDescUnidade.Name = "TxtDescUnidade";
            this.TxtDescUnidade.Size = new System.Drawing.Size(393, 21);
            this.TxtDescUnidade.TabIndex = 2;
            // 
            // FC005Unidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(653, 348);
            this.Name = "FC005Unidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Unidade";
            this.tcBase.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            this.tpDados.ResumeLayout(false);
            this.tpDados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescUnidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodUnidade;
    }
}
