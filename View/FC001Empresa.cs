using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sdistribuidor.Entidade;
using Sdistribuidor.Model;

namespace Sdistribuidor.View
{
    public partial class FC001Empresa : Sdistribuidor.View.FBase
    {
        public FC001Empresa()
        {
            InitializeComponent();
        }

        Entidade_Loja EntLoja;
        Loja mLoja;

        DataGridViewTextBoxColumn NewText;

        public override void CamposGrid()
        {

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Código";
            NewText.Name = "ColID";
            NewText.DataPropertyName = "id";
            NewText.Width = 40;

            grdBase.Columns.Add(NewText);

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Descrição";
            NewText.Name = "ColDesc";
            NewText.DataPropertyName = "nmloja";
            NewText.Width = 100;

            grdBase.Columns.Add(NewText);

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Fantasia";
            NewText.Name = "ColFant";
            NewText.DataPropertyName = "nm_fantasia";
            NewText.Width = 400;

            grdBase.Columns.Add(NewText);

        }

        public override bool Salvar()
        {
            EntLoja = new Entidade_Loja();
            mLoja = new Loja();

            EntLoja.cnpj = MskCpfCnpj.Text.Replace(".", "").Replace("-", "");
            EntLoja.ie = txtIE.Text;
            EntLoja.nmloja = TxtDescricaoNome.Text;
            EntLoja.nm_fantasia = TxtFantasia.Text;
            EntLoja.razao_social = TxtNome.Text;
            EntLoja.logradouro = TxtLogradouro.Text;
            EntLoja.nro = TxtNrEnder.Text;
            EntLoja.cep = mskCep.Text.Replace(".", "").Replace("-", "");
            EntLoja.fone = mskTelefone.Text.Replace(".", "").Replace("-", "").Replace("(", "").Replace(")", "");
            EntLoja.id_uf = ucUfCidade1.IdUf;
            EntLoja.id_cidade = ucUfCidade1.IdCidade;
            EntLoja.tipo_regime = CboRegime.SelectedIndex.ToString();

            if (mLoja.Salvar(EntLoja))
                return true;
            else
                return false;

        }

        public override void CarregarDados()
        {
            ucUfCidade1.CarregarCombos();

            mLoja = new Loja();

            grdBase.AutoGenerateColumns = false;
            grdBase.DataSource = mLoja.Pesquisa();
        }

        public override bool ValidaCampos()
        {
            if (MskCpfCnpj.Text.Replace(".","").Replace("-","") == string.Empty)
            {
                MessageBox.Show("Informe o Cnpj!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtIE.Text == string.Empty)
            {
                MessageBox.Show("Informe a IE!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (TxtDescricaoNome.Text == string.Empty)
            {
                MessageBox.Show("Informe o Nome da Empresa. Ex: Matriz, Filial!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (TxtNome.Text == string.Empty)
            {
                MessageBox.Show("Informe a Razão Social!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (TxtFantasia.Text == string.Empty)
            {
                MessageBox.Show("Informe a Razão Social!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (TxtLogradouro.Text == string.Empty)
            {
                MessageBox.Show("Informe o logradouro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (TxtNrEnder.Text == string.Empty)
            {
                MessageBox.Show("Informe o número!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (TxtBairro.Text == string.Empty)
            {
                MessageBox.Show("Informe o bairro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (mskCep.Text.Replace(".", "").Replace("-", "") == string.Empty)
            {
                MessageBox.Show("Informe o CEP!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (mskTelefone.Text.Replace(".", "").Replace("-", "").Replace("()", "") == string.Empty)
            {
                MessageBox.Show("Informe o Telefone!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (CboRegime.SelectedIndex == -1)
            {
                MessageBox.Show("Informe o Regime Tributário!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (ucUfCidade1.ValidarCampos() == false)
            {
                return false;
            }
            else
                return true;
        }
    }
}
