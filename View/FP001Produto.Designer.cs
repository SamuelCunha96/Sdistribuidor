namespace Sdistribuidor.View
{
    partial class FP001Produto
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
            this.grdProduto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.rdDesc = new System.Windows.Forms.RadioButton();
            this.rdCodigo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNCM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProduto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdProduto
            // 
            this.grdProduto.AllowUserToAddRows = false;
            this.grdProduto.AllowUserToDeleteRows = false;
            this.grdProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColDesc,
            this.ColUnidade,
            this.ColValorUnitario,
            this.ColNCM});
            this.grdProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProduto.Location = new System.Drawing.Point(3, 17);
            this.grdProduto.Name = "grdProduto";
            this.grdProduto.ReadOnly = true;
            this.grdProduto.RowHeadersVisible = false;
            this.grdProduto.Size = new System.Drawing.Size(669, 264);
            this.grdProduto.TabIndex = 0;
            this.grdProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProduto_CellDoubleClick);
            this.grdProduto.DoubleClick += new System.EventHandler(this.grdProduto_DoubleClick);
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
            this.groupBox1.Size = new System.Drawing.Size(675, 44);
            this.groupBox1.TabIndex = 0;
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
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.Location = new System.Drawing.Point(154, 17);
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(349, 21);
            this.TxtPesquisa.TabIndex = 1;
            // 
            // rdDesc
            // 
            this.rdDesc.AutoSize = true;
            this.rdDesc.Location = new System.Drawing.Point(77, 20);
            this.rdDesc.Name = "rdDesc";
            this.rdDesc.Size = new System.Drawing.Size(71, 17);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdProduto);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "Código";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 80;
            // 
            // ColDesc
            // 
            this.ColDesc.HeaderText = "Descrição";
            this.ColDesc.Name = "ColDesc";
            this.ColDesc.ReadOnly = true;
            this.ColDesc.Width = 300;
            // 
            // ColUnidade
            // 
            this.ColUnidade.HeaderText = "Unidade";
            this.ColUnidade.Name = "ColUnidade";
            this.ColUnidade.ReadOnly = true;
            this.ColUnidade.Width = 80;
            // 
            // ColValorUnitario
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "N2";
            this.ColValorUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColValorUnitario.HeaderText = "V. Unitario";
            this.ColValorUnitario.Name = "ColValorUnitario";
            this.ColValorUnitario.ReadOnly = true;
            // 
            // ColNCM
            // 
            this.ColNCM.HeaderText = "NCM";
            this.ColNCM.Name = "ColNCM";
            this.ColNCM.ReadOnly = true;
            // 
            // FP001Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 328);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FP001Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Produto";
            this.Load += new System.EventHandler(this.FP001Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProduto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdDesc;
        private System.Windows.Forms.RadioButton rdCodigo;
        private System.Windows.Forms.DataGridView grdProduto;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNCM;
    }
}