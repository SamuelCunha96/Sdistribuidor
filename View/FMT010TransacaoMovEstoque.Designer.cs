namespace Sdistribuidor.View
{
    partial class FMT010TransacaoMovEstoque
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
            this.a = new MetroFramework.Controls.MetroPanel();
            this.chkEstoque = new System.Windows.Forms.CheckBox();
            this.chkFisico = new System.Windows.Forms.CheckBox();
            this.lblDesc = new MetroFramework.Controls.MetroLabel();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtObs = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtQtMov = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CboTipoMovEstoque = new MetroFramework.Controls.MetroComboBox();
            this.btnConsultar = new MetroFramework.Controls.MetroButton();
            this.txtCodProduto = new MetroFramework.Controls.MetroTextBox();
            this.a.SuspendLayout();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Controls.Add(this.chkEstoque);
            this.a.Controls.Add(this.chkFisico);
            this.a.Controls.Add(this.lblDesc);
            this.a.Controls.Add(this.btnSalvar);
            this.a.Controls.Add(this.metroLabel3);
            this.a.Controls.Add(this.txtObs);
            this.a.Controls.Add(this.metroLabel2);
            this.a.Controls.Add(this.TxtQtMov);
            this.a.Controls.Add(this.metroLabel1);
            this.a.Controls.Add(this.CboTipoMovEstoque);
            this.a.Controls.Add(this.btnConsultar);
            this.a.Controls.Add(this.txtCodProduto);
            this.a.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a.HorizontalScrollbarBarColor = true;
            this.a.HorizontalScrollbarHighlightOnWheel = false;
            this.a.HorizontalScrollbarSize = 10;
            this.a.Location = new System.Drawing.Point(20, 60);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(601, 258);
            this.a.TabIndex = 0;
            this.a.VerticalScrollbarBarColor = true;
            this.a.VerticalScrollbarHighlightOnWheel = false;
            this.a.VerticalScrollbarSize = 10;
            // 
            // chkEstoque
            // 
            this.chkEstoque.AutoSize = true;
            this.chkEstoque.Location = new System.Drawing.Point(63, 3);
            this.chkEstoque.Name = "chkEstoque";
            this.chkEstoque.Size = new System.Drawing.Size(65, 17);
            this.chkEstoque.TabIndex = 15;
            this.chkEstoque.Text = "Estoque";
            this.chkEstoque.UseVisualStyleBackColor = true;
            // 
            // chkFisico
            // 
            this.chkFisico.AutoSize = true;
            this.chkFisico.Location = new System.Drawing.Point(5, 3);
            this.chkFisico.Name = "chkFisico";
            this.chkFisico.Size = new System.Drawing.Size(55, 17);
            this.chkFisico.TabIndex = 0;
            this.chkFisico.Text = "Físico";
            this.chkFisico.UseVisualStyleBackColor = true;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(155, 29);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(0, 0);
            this.lblDesc.TabIndex = 13;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(3, 220);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 32);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(5, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Observação";
            // 
            // txtObs
            // 
            // 
            // 
            // 
            this.txtObs.CustomButton.Image = null;
            this.txtObs.CustomButton.Location = new System.Drawing.Point(419, 1);
            this.txtObs.CustomButton.Name = "";
            this.txtObs.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtObs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObs.CustomButton.TabIndex = 1;
            this.txtObs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObs.CustomButton.UseSelectable = true;
            this.txtObs.CustomButton.Visible = false;
            this.txtObs.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtObs.Lines = new string[0];
            this.txtObs.Location = new System.Drawing.Point(5, 176);
            this.txtObs.MaxLength = 32767;
            this.txtObs.Name = "txtObs";
            this.txtObs.PasswordChar = '\0';
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObs.SelectedText = "";
            this.txtObs.SelectionLength = 0;
            this.txtObs.SelectionStart = 0;
            this.txtObs.ShortcutsEnabled = true;
            this.txtObs.Size = new System.Drawing.Size(441, 23);
            this.txtObs.TabIndex = 4;
            this.txtObs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtObs.UseSelectable = true;
            this.txtObs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(5, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Qtd. Mov.";
            // 
            // TxtQtMov
            // 
            // 
            // 
            // 
            this.TxtQtMov.CustomButton.Image = null;
            this.TxtQtMov.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.TxtQtMov.CustomButton.Name = "";
            this.TxtQtMov.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtQtMov.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtQtMov.CustomButton.TabIndex = 1;
            this.TxtQtMov.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtQtMov.CustomButton.UseSelectable = true;
            this.TxtQtMov.CustomButton.Visible = false;
            this.TxtQtMov.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtQtMov.Lines = new string[] {
        "0,00"};
            this.TxtQtMov.Location = new System.Drawing.Point(4, 128);
            this.TxtQtMov.MaxLength = 32767;
            this.TxtQtMov.Name = "TxtQtMov";
            this.TxtQtMov.PasswordChar = '\0';
            this.TxtQtMov.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtQtMov.SelectedText = "";
            this.TxtQtMov.SelectionLength = 0;
            this.TxtQtMov.SelectionStart = 0;
            this.TxtQtMov.ShortcutsEnabled = true;
            this.TxtQtMov.Size = new System.Drawing.Size(104, 23);
            this.TxtQtMov.TabIndex = 3;
            this.TxtQtMov.Text = "0,00";
            this.TxtQtMov.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtQtMov.UseSelectable = true;
            this.TxtQtMov.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtQtMov.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtQtMov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQtMov_KeyPress);
            this.TxtQtMov.Layout += new System.Windows.Forms.LayoutEventHandler(this.TxtQtMov_Layout);
            this.TxtQtMov.Leave += new System.EventHandler(this.TxtQtMov_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Tipo de Movimentação";
            // 
            // CboTipoMovEstoque
            // 
            this.CboTipoMovEstoque.FormattingEnabled = true;
            this.CboTipoMovEstoque.ItemHeight = 23;
            this.CboTipoMovEstoque.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.CboTipoMovEstoque.Location = new System.Drawing.Point(4, 73);
            this.CboTipoMovEstoque.Name = "CboTipoMovEstoque";
            this.CboTipoMovEstoque.Size = new System.Drawing.Size(145, 29);
            this.CboTipoMovEstoque.TabIndex = 2;
            this.CboTipoMovEstoque.UseSelectable = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(112, 25);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(27, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "...";
            this.btnConsultar.UseSelectable = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtCodProduto
            // 
            // 
            // 
            // 
            this.txtCodProduto.CustomButton.Image = null;
            this.txtCodProduto.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtCodProduto.CustomButton.Name = "";
            this.txtCodProduto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodProduto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodProduto.CustomButton.TabIndex = 1;
            this.txtCodProduto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodProduto.CustomButton.UseSelectable = true;
            this.txtCodProduto.CustomButton.Visible = false;
            this.txtCodProduto.Lines = new string[0];
            this.txtCodProduto.Location = new System.Drawing.Point(4, 25);
            this.txtCodProduto.MaxLength = 32767;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.PasswordChar = '\0';
            this.txtCodProduto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodProduto.SelectedText = "";
            this.txtCodProduto.SelectionLength = 0;
            this.txtCodProduto.SelectionStart = 0;
            this.txtCodProduto.ShortcutsEnabled = true;
            this.txtCodProduto.Size = new System.Drawing.Size(104, 23);
            this.txtCodProduto.TabIndex = 0;
            this.txtCodProduto.UseSelectable = true;
            this.txtCodProduto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodProduto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FMT010TransacaoMovEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 338);
            this.Controls.Add(this.a);
            this.KeyPreview = true;
            this.Name = "FMT010TransacaoMovEstoque";
            this.Text = "Movimentação de Estoque";
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel a;
        private MetroFramework.Controls.MetroButton btnConsultar;
        private MetroFramework.Controls.MetroTextBox txtCodProduto;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox CboTipoMovEstoque;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtQtMov;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtObs;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroLabel lblDesc;
        private System.Windows.Forms.CheckBox chkEstoque;
        private System.Windows.Forms.CheckBox chkFisico;
    }
}