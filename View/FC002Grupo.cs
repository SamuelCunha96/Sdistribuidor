using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sdistribuidor.Model;
using Sdistribuidor.Entidade;

namespace Sdistribuidor.View
{
    public partial class FC002Grupo : Sdistribuidor.View.FBase
    {
        public FC002Grupo()
        {
            InitializeComponent();
        }

        Entidade_Grupo eGrupo;
        Grupo mGrupo;
        DataGridViewTextBoxColumn NewText;
        public override bool Salvar()
        {
            eGrupo = new Entidade_Grupo();
            mGrupo = new Grupo();

            eGrupo.nmgrupo = TxtDescGrupo.Text;

            mGrupo.Incluir(eGrupo);

            return true;
        }

        public override bool Editar()
        {
            eGrupo = new Entidade_Grupo();
            mGrupo = new Grupo();

            eGrupo.idgrupo = int.Parse(txtID.Text);

            eGrupo.nmgrupo = TxtDescGrupo.Text;

            mGrupo.Update(eGrupo);

            return true;
        }
        public override bool Excluir()
        {
            eGrupo = new Entidade_Grupo();
            mGrupo = new Grupo();

            eGrupo.idgrupo = int.Parse(txtID.Text);

            mGrupo.Delete(eGrupo.idgrupo);

            return true;
        }
        public override void CarregarDados()
        {
            mGrupo = new Grupo();

            //var obj = mGrupo.Pesquisa();
            grdBase.AutoGenerateColumns = false;
            grdBase.DataSource = mGrupo.Lista();
        }
        public override void PesquisarDados(string Pesquisar, object ID)
        { 
            mGrupo = new Grupo();

            var ObjRet = mGrupo.Pesquisa(Convert.ToInt32(ID));

            txtID.Text = ObjRet.idgrupo.ToString();
            TxtDescGrupo.Text = ObjRet.nmgrupo;
        }
        public override void CamposGrid()
        {

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Código";
            NewText.Name = "ColID";
            NewText.DataPropertyName = "id_grupo";
            NewText.Width = 60;

            grdBase.Columns.Add(NewText);

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Descrição";
            NewText.Name = "ColDesc";
            NewText.DataPropertyName = "nmgrupo";
            NewText.Width = 350;

            grdBase.Columns.Add(NewText);

        }
        public override void LimpaCampos()
        {
            TxtDescGrupo.Text = string.Empty;
            txtID.Text = string.Empty;
        }
        private void tbDados_Click(object sender, EventArgs e)
        {

        }
    }
}
