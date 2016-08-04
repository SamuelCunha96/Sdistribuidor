using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SI.Entidade;
using SI.Model;

namespace SI.View
{
    public partial class FC005Unidade : SI.View.FBase
    {
        public FC005Unidade()
        {
            InitializeComponent();
        }
        Entidade_Unidade ObjEUnidade;
        Unidade ObjMUnidade;
        DataGridViewTextBoxColumn NewText;
        public override bool ValidaCampos()
        {
            if (TxtCodUnidade.Text == string.Empty)
            {
                MessageBox.Show("Unidade obrigatoria.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (TxtDescUnidade.Text == string.Empty)
            {
                MessageBox.Show("Descrição da Unidade necessaria.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }
        public override bool Salvar()
        {
            ObjEUnidade = new Entidade_Unidade();
            ObjMUnidade = new Unidade();

            ObjEUnidade.CdUnidade = TxtCodUnidade.Text;
            ObjEUnidade.Unidade = TxtDescUnidade.Text;

            ObjMUnidade.Incluir(ObjEUnidade);

            return true;
        }
        public override bool Editar()
        {
            ObjEUnidade = new Entidade_Unidade();
            ObjMUnidade = new Unidade();

            ObjEUnidade.CdUnidade = TxtCodUnidade.Text;
            ObjEUnidade.Unidade = TxtDescUnidade.Text;

            ObjMUnidade.Update(ObjEUnidade);

            return true;
        }
        public override void CarregarDados()
        {
            ObjMUnidade = new Unidade();

            var obj = ObjMUnidade.Pesquisa();
            grdBase.AutoGenerateColumns = false;
            grdBase.DataSource = ObjMUnidade.Pesquisa();
        }
        public override void PesquisarDados(string Pesquisar, object ID)
        {
            ObjMUnidade = new Unidade();

            var ObjRet = ObjMUnidade.Pesquisa(ID.ToString());

            TxtCodUnidade.Text = ObjRet.CdUnidade;
            TxtDescUnidade.Text = ObjRet.Unidade;
        }
        public override void CamposGrid()
        {

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Código";
            NewText.Name = "ColID";
            NewText.DataPropertyName = "CdUnidade";
            NewText.Width = 60;

            grdBase.Columns.Add(NewText);

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Descrição";
            NewText.Name = "ColDesc";
            NewText.DataPropertyName = "unidade";
            NewText.Width = 350;

            grdBase.Columns.Add(NewText);

        }
        public override void LimpaCampos()
        {
            TxtCodUnidade.Text = string.Empty;
            TxtDescUnidade.Text = string.Empty;
            base.LimpaCampos();
        }
    }
}
