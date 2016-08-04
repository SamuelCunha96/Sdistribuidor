namespace Sdistribuidor.View
{
    partial class FC002Grupo
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
            this.TxtDescGrupo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tcBase.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            this.tpDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(171, 250);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(90, 250);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(9, 250);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(82, 252);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(3, 252);
            // 
            // tcBase
            // 
            this.tcBase.Size = new System.Drawing.Size(477, 307);
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Size = new System.Drawing.Size(469, 281);
            // 
            // tpDados
            // 
            this.tpDados.Controls.Add(this.txtID);
            this.tpDados.Controls.Add(this.TxtDescGrupo);
            this.tpDados.Controls.Add(this.label2);
            this.tpDados.Controls.SetChildIndex(this.BtnSalvar, 0);
            this.tpDados.Controls.SetChildIndex(this.BtnExcluir, 0);
            this.tpDados.Controls.SetChildIndex(this.BtnCancelar, 0);
            this.tpDados.Controls.SetChildIndex(this.label2, 0);
            this.tpDados.Controls.SetChildIndex(this.TxtDescGrupo, 0);
            this.tpDados.Controls.SetChildIndex(this.txtID, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(463, 181);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(463, 62);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(402, 34);
            // 
            // txtDesc
            // 
            this.txtDesc.Size = new System.Drawing.Size(390, 21);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grupo";
            // 
            // TxtDescGrupo
            // 
            this.TxtDescGrupo.Location = new System.Drawing.Point(11, 102);
            this.TxtDescGrupo.Name = "TxtDescGrupo";
            this.TxtDescGrupo.Size = new System.Drawing.Size(305, 21);
            this.TxtDescGrupo.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(138, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(87, 21);
            this.txtID.TabIndex = 2;
            this.txtID.Visible = false;
            // 
            // FC002Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(477, 307);
            this.Name = "FC002Grupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Grupo";
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
        private System.Windows.Forms.TextBox TxtDescGrupo;
        private System.Windows.Forms.TextBox txtID;
    }
}
