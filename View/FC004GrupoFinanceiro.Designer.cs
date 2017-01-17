namespace Sdistribuidor.View
{
    partial class FC004GrupoFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FC004GrupoFinanceiro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tcDados = new MetroFramework.Controls.MetroTabControl();
            this.tpLista = new MetroFramework.Controls.MetroTabPage();
            this.tpNovo = new MetroFramework.Controls.MetroTabPage();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.TxtGrupo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.GrdFinanc = new MetroFramework.Controls.MetroGrid();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            this.tcDados.SuspendLayout();
            this.tpLista.SuspendLayout();
            this.tpNovo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFinanc)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tcDados);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(607, 313);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tcDados
            // 
            this.tcDados.Controls.Add(this.tpLista);
            this.tcDados.Controls.Add(this.tpNovo);
            this.tcDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDados.Location = new System.Drawing.Point(0, 0);
            this.tcDados.Name = "tcDados";
            this.tcDados.SelectedIndex = 0;
            this.tcDados.Size = new System.Drawing.Size(607, 313);
            this.tcDados.TabIndex = 2;
            this.tcDados.UseSelectable = true;
            // 
            // tpLista
            // 
            this.tpLista.Controls.Add(this.GrdFinanc);
            this.tpLista.HorizontalScrollbarBarColor = true;
            this.tpLista.HorizontalScrollbarHighlightOnWheel = false;
            this.tpLista.HorizontalScrollbarSize = 10;
            this.tpLista.Location = new System.Drawing.Point(4, 38);
            this.tpLista.Name = "tpLista";
            this.tpLista.Size = new System.Drawing.Size(599, 271);
            this.tpLista.TabIndex = 0;
            this.tpLista.Text = "Pesquisar";
            this.tpLista.VerticalScrollbarBarColor = true;
            this.tpLista.VerticalScrollbarHighlightOnWheel = false;
            this.tpLista.VerticalScrollbarSize = 10;
            // 
            // tpNovo
            // 
            this.tpNovo.Controls.Add(this.BtnSalvar);
            this.tpNovo.Controls.Add(this.BtnExcluir);
            this.tpNovo.Controls.Add(this.btnCancelar);
            this.tpNovo.Controls.Add(this.TxtGrupo);
            this.tpNovo.Controls.Add(this.metroLabel1);
            this.tpNovo.HorizontalScrollbarBarColor = true;
            this.tpNovo.HorizontalScrollbarHighlightOnWheel = false;
            this.tpNovo.HorizontalScrollbarSize = 10;
            this.tpNovo.Location = new System.Drawing.Point(4, 38);
            this.tpNovo.Name = "tpNovo";
            this.tpNovo.Size = new System.Drawing.Size(599, 271);
            this.tpNovo.TabIndex = 1;
            this.tpNovo.Text = "Novo Grupo";
            this.tpNovo.VerticalScrollbarBarColor = true;
            this.tpNovo.VerticalScrollbarHighlightOnWheel = false;
            this.tpNovo.VerticalScrollbarSize = 10;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.BtnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnSalvar.FlatAppearance.BorderSize = 0;
            this.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalvar.Location = new System.Drawing.Point(10, 223);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(93, 33);
            this.BtnSalvar.TabIndex = 8;
            this.BtnSalvar.Text = "F9-Salvar";
            this.BtnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExcluir.FlatAppearance.BorderSize = 0;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(109, 223);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(93, 33);
            this.BtnExcluir.TabIndex = 7;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(208, 223);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 33);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // TxtGrupo
            // 
            // 
            // 
            // 
            this.TxtGrupo.CustomButton.Image = null;
            this.TxtGrupo.CustomButton.Location = new System.Drawing.Point(382, 1);
            this.TxtGrupo.CustomButton.Name = "";
            this.TxtGrupo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtGrupo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtGrupo.CustomButton.TabIndex = 1;
            this.TxtGrupo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtGrupo.CustomButton.UseSelectable = true;
            this.TxtGrupo.CustomButton.Visible = false;
            this.TxtGrupo.Lines = new string[0];
            this.TxtGrupo.Location = new System.Drawing.Point(3, 89);
            this.TxtGrupo.MaxLength = 32767;
            this.TxtGrupo.Name = "TxtGrupo";
            this.TxtGrupo.PasswordChar = '\0';
            this.TxtGrupo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtGrupo.SelectedText = "";
            this.TxtGrupo.SelectionLength = 0;
            this.TxtGrupo.SelectionStart = 0;
            this.TxtGrupo.ShortcutsEnabled = true;
            this.TxtGrupo.Size = new System.Drawing.Size(404, 23);
            this.TxtGrupo.TabIndex = 3;
            this.TxtGrupo.UseSelectable = true;
            this.TxtGrupo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtGrupo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(46, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Grupo";
            // 
            // GrdFinanc
            // 
            this.GrdFinanc.AllowUserToAddRows = false;
            this.GrdFinanc.AllowUserToDeleteRows = false;
            this.GrdFinanc.AllowUserToResizeRows = false;
            this.GrdFinanc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdFinanc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdFinanc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdFinanc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdFinanc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdFinanc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdFinanc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColDescrição});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GrdFinanc.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdFinanc.EnableHeadersVisualStyles = false;
            this.GrdFinanc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdFinanc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdFinanc.Location = new System.Drawing.Point(0, 14);
            this.GrdFinanc.Name = "GrdFinanc";
            this.GrdFinanc.ReadOnly = true;
            this.GrdFinanc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdFinanc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdFinanc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdFinanc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdFinanc.Size = new System.Drawing.Size(599, 219);
            this.GrdFinanc.TabIndex = 7;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "id_grupocontpag";
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColDescrição
            // 
            this.ColDescrição.DataPropertyName = "desc_financeiro";
            this.ColDescrição.HeaderText = "Descrição";
            this.ColDescrição.Name = "ColDescrição";
            this.ColDescrição.ReadOnly = true;
            this.ColDescrição.Width = 300;
            // 
            // FC004GrupoFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 393);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FC004GrupoFinanceiro";
            this.Text = "Grupo Financeiro";
            this.Load += new System.EventHandler(this.FC004GrupoFinanceiro_Load);
            this.metroPanel1.ResumeLayout(false);
            this.tcDados.ResumeLayout(false);
            this.tpLista.ResumeLayout(false);
            this.tpNovo.ResumeLayout(false);
            this.tpNovo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFinanc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl tcDados;
        private MetroFramework.Controls.MetroTabPage tpLista;
        private MetroFramework.Controls.MetroTabPage tpNovo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtGrupo;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private MetroFramework.Controls.MetroGrid GrdFinanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescrição;
    }
}