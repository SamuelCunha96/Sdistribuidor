namespace Sdistribuidor.View
{
    partial class FMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPagamento = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.TbCadastro = new System.Windows.Forms.TabPage();
            this.btnParticipante = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnGrupo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPgNotaFiscal = new System.Windows.Forms.TabPage();
            this.btnNotaFiscal = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoja = new System.Windows.Forms.Button();
            this.btnAux = new System.Windows.Forms.Button();
            this.btnNFeOutras = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            this.TbCadastro.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPgNotaFiscal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(755, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPagamento);
            this.tabPage2.Controls.Add(this.btnPedido);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(747, 100);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Faturamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPagamento
            // 
            this.btnPagamento.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPagamento.FlatAppearance.BorderSize = 0;
            this.btnPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPagamento.Image")));
            this.btnPagamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagamento.Location = new System.Drawing.Point(78, 3);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(75, 94);
            this.btnPagamento.TabIndex = 2;
            this.btnPagamento.Text = "Pagamento";
            this.btnPagamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPedido.FlatAppearance.BorderSize = 0;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPedido.Image")));
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPedido.Location = new System.Drawing.Point(3, 3);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(75, 94);
            this.btnPedido.TabIndex = 1;
            this.btnPedido.Text = "Pedido";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // TbCadastro
            // 
            this.TbCadastro.BackColor = System.Drawing.Color.White;
            this.TbCadastro.Controls.Add(this.btnParticipante);
            this.TbCadastro.Controls.Add(this.btnProduto);
            this.TbCadastro.Controls.Add(this.btnGrupo);
            this.TbCadastro.Location = new System.Drawing.Point(4, 21);
            this.TbCadastro.Name = "TbCadastro";
            this.TbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.TbCadastro.Size = new System.Drawing.Size(747, 100);
            this.TbCadastro.TabIndex = 0;
            this.TbCadastro.Text = "Cadastro";
            // 
            // btnParticipante
            // 
            this.btnParticipante.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnParticipante.FlatAppearance.BorderSize = 0;
            this.btnParticipante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParticipante.Image = ((System.Drawing.Image)(resources.GetObject("btnParticipante.Image")));
            this.btnParticipante.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnParticipante.Location = new System.Drawing.Point(153, 3);
            this.btnParticipante.Name = "btnParticipante";
            this.btnParticipante.Size = new System.Drawing.Size(80, 94);
            this.btnParticipante.TabIndex = 2;
            this.btnParticipante.Text = "Participantes";
            this.btnParticipante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnParticipante.UseVisualStyleBackColor = true;
            this.btnParticipante.Click += new System.EventHandler(this.btnParticipante_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
            this.btnProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProduto.Location = new System.Drawing.Point(78, 3);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(75, 94);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnGrupo
            // 
            this.btnGrupo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGrupo.FlatAppearance.BorderSize = 0;
            this.btnGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupo.Image")));
            this.btnGrupo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrupo.Location = new System.Drawing.Point(3, 3);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(75, 94);
            this.btnGrupo.TabIndex = 0;
            this.btnGrupo.Text = "Grupo";
            this.btnGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TbCadastro);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tbPgNotaFiscal);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 125);
            this.tabControl1.TabIndex = 2;
            // 
            // tbPgNotaFiscal
            // 
            this.tbPgNotaFiscal.Controls.Add(this.btnNFeOutras);
            this.tbPgNotaFiscal.Controls.Add(this.btnNotaFiscal);
            this.tbPgNotaFiscal.Location = new System.Drawing.Point(4, 21);
            this.tbPgNotaFiscal.Name = "tbPgNotaFiscal";
            this.tbPgNotaFiscal.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgNotaFiscal.Size = new System.Drawing.Size(747, 100);
            this.tbPgNotaFiscal.TabIndex = 2;
            this.tbPgNotaFiscal.Text = "Nota Fiscal";
            this.tbPgNotaFiscal.UseVisualStyleBackColor = true;
            // 
            // btnNotaFiscal
            // 
            this.btnNotaFiscal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNotaFiscal.FlatAppearance.BorderSize = 0;
            this.btnNotaFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btnNotaFiscal.Image")));
            this.btnNotaFiscal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNotaFiscal.Location = new System.Drawing.Point(3, 3);
            this.btnNotaFiscal.Name = "btnNotaFiscal";
            this.btnNotaFiscal.Size = new System.Drawing.Size(75, 94);
            this.btnNotaFiscal.TabIndex = 2;
            this.btnNotaFiscal.Text = "NFe";
            this.btnNotaFiscal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNotaFiscal.UseVisualStyleBackColor = true;
            this.btnNotaFiscal.Click += new System.EventHandler(this.btnNotaFiscal_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLoja);
            this.tabPage1.Controls.Add(this.btnAux);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(747, 100);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Configurações";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLoja
            // 
            this.btnLoja.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoja.FlatAppearance.BorderSize = 0;
            this.btnLoja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoja.Image = ((System.Drawing.Image)(resources.GetObject("btnLoja.Image")));
            this.btnLoja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLoja.Location = new System.Drawing.Point(78, 3);
            this.btnLoja.Name = "btnLoja";
            this.btnLoja.Size = new System.Drawing.Size(75, 94);
            this.btnLoja.TabIndex = 4;
            this.btnLoja.Text = "Lojas";
            this.btnLoja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoja.UseVisualStyleBackColor = true;
            this.btnLoja.Click += new System.EventHandler(this.btnLoja_Click);
            // 
            // btnAux
            // 
            this.btnAux.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAux.FlatAppearance.BorderSize = 0;
            this.btnAux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAux.Image = ((System.Drawing.Image)(resources.GetObject("btnAux.Image")));
            this.btnAux.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAux.Location = new System.Drawing.Point(3, 3);
            this.btnAux.Name = "btnAux";
            this.btnAux.Size = new System.Drawing.Size(75, 94);
            this.btnAux.TabIndex = 3;
            this.btnAux.Text = "Tabelas Auxiliares";
            this.btnAux.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAux.UseVisualStyleBackColor = true;
            this.btnAux.Click += new System.EventHandler(this.btnAux_Click);
            // 
            // btnNFeOutras
            // 
            this.btnNFeOutras.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNFeOutras.FlatAppearance.BorderSize = 0;
            this.btnNFeOutras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNFeOutras.Image = ((System.Drawing.Image)(resources.GetObject("btnNFeOutras.Image")));
            this.btnNFeOutras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNFeOutras.Location = new System.Drawing.Point(78, 3);
            this.btnNFeOutras.Name = "btnNFeOutras";
            this.btnNFeOutras.Size = new System.Drawing.Size(75, 94);
            this.btnNFeOutras.TabIndex = 3;
            this.btnNFeOutras.Text = "NFe Outras";
            this.btnNFeOutras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNFeOutras.UseVisualStyleBackColor = true;
            this.btnNFeOutras.Click += new System.EventHandler(this.btnNFeOutras_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(755, 377);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FMenu_Load);
            this.tabPage2.ResumeLayout(false);
            this.TbCadastro.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbPgNotaFiscal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.TabPage TbCadastro;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnGrupo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPgNotaFiscal;
        private System.Windows.Forms.Button btnNotaFiscal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAux;
        private System.Windows.Forms.Button btnLoja;
        private System.Windows.Forms.Button btnParticipante;
        private System.Windows.Forms.Button btnNFeOutras;
    }
}