namespace Sdistribuidor.View
{
    partial class FBasePesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdBase = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.rdDesc = new System.Windows.Forms.RadioButton();
            this.rdCodigo = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdBase);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 294);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // grdBase
            // 
            this.grdBase.AllowUserToAddRows = false;
            this.grdBase.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBase.Location = new System.Drawing.Point(3, 16);
            this.grdBase.Name = "grdBase";
            this.grdBase.ReadOnly = true;
            this.grdBase.RowHeadersVisible = false;
            this.grdBase.Size = new System.Drawing.Size(572, 275);
            this.grdBase.TabIndex = 0;
            this.grdBase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBase_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPesquisar);
            this.groupBox1.Controls.Add(this.TxtPesquisa);
            this.groupBox1.Controls.Add(this.rdDesc);
            this.groupBox1.Controls.Add(this.rdCodigo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 44);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(509, 15);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(58, 23);
            this.BtnPesquisar.TabIndex = 2;
            this.BtnPesquisar.Text = "...";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(154, 17);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(349, 20);
            this.TxtPesquisa.TabIndex = 1;
            // 
            // rdDesc
            // 
            this.rdDesc.AutoSize = true;
            this.rdDesc.Location = new System.Drawing.Point(77, 20);
            this.rdDesc.Name = "rdDesc";
            this.rdDesc.Size = new System.Drawing.Size(73, 17);
            this.rdDesc.TabIndex = 0;
            this.rdDesc.Text = "Descrição";
            this.rdDesc.UseVisualStyleBackColor = true;
            // 
            // rdCodigo
            // 
            this.rdCodigo.AutoSize = true;
            this.rdCodigo.Checked = true;
            this.rdCodigo.Location = new System.Drawing.Point(13, 21);
            this.rdCodigo.Name = "rdCodigo";
            this.rdCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdCodigo.TabIndex = 0;
            this.rdCodigo.TabStop = true;
            this.rdCodigo.Text = "Código";
            this.rdCodigo.UseVisualStyleBackColor = true;
            // 
            // FBasePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 338);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FBasePesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FBasePesquisa_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.RadioButton rdDesc;
        private System.Windows.Forms.RadioButton rdCodigo;
        public System.Windows.Forms.DataGridView grdBase;
    }
}