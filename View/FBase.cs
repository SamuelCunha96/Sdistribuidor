using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sdistribuidor.Control;

namespace Sdistribuidor.View
{
    public partial class FBase : Form
    {
        public FBase()
        {
            InitializeComponent();
        }

        C_ModuloGeral cModGeral;

        public enum TipoAcao
        {
            Salvar,
            Editar
        }

        public TipoAcao TpAcao { get; set; }

        private void FBase_Load(object sender, EventArgs e)
        {
            PreencherCamposDados();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (TpAcao == TipoAcao.Salvar)
            {
                if (MessageBox.Show("Deseja salvar os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    if (ValidaCampos())
                    {
                        if (Salvar())
                        {
                            MessageBox.Show("Dados Salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpaCampos();
                            tcBase.SelectedTab = tpPesquisa;
                            PreencherCamposDados();
                        }
                    }
            }
            else
            {
                if (MessageBox.Show("Deseja alterar os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    if (Editar())
                    {
                        MessageBox.Show("Dados Salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimpaCampos();
                        tcBase.SelectedTab = tpPesquisa;
                        PreencherCamposDados();
                    }
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir os dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (Excluir())
                {
                    MessageBox.Show("Dados excluidos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimpaCampos();
                    tcBase.SelectedTab = tpPesquisa;
                    PreencherCamposDados();
                }
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            CarregarDados();
            tcBase.SelectedTab = tpPesquisa;
        }
        public virtual bool Salvar()
        {
            return false;
        }
        public virtual bool Editar()
        {
            return false;
        }
        public virtual bool Excluir()
        {
            return false;
        }
        public virtual void Cancelar()
        {
            LimpaCampos();
            CarregarDados();

        }
        public virtual void LimpaCampos()
        {
            grdBase.Columns.Clear();
        }
        public virtual void LimpaCamposDados()
        {
            
        }
        public virtual void CamposGrid()
        {
        }
        public virtual void CarregarDados()
        {
        }
        public virtual void CarregarOutrosDados()
        {
        }
        public virtual void PesquisarDados(string Pesquisar, object ID)
        {
        }
        public virtual bool ValidaCampos()
        {
            return true;
        }
        public void PreencherCamposDados()
        {
            CamposGrid();
            CarregarDados();
            CarregarOutrosDados();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            cModGeral = new C_ModuloGeral();
            DataGridViewRow Row = grdBase.CurrentRow;

            LimpaCampos();
            TpAcao = TipoAcao.Editar;
            PesquisarDados(string.Empty, cModGeral.TiraCampos(Row.Cells[0].Value.ToString()));

            tcBase.SelectedTab = tpDados;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tcBase.SelectedTab = tpDados;
            TpAcao = TipoAcao.Salvar;
            LimpaCamposDados();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PesquisarDados(txtDesc.Text, 0);
        }

        private void BtnCancelar_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
