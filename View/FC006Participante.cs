using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sdistribuidor.Entidade;
using Sdistribuidor.Model;
using Sdistribuidor.Control;

namespace Sdistribuidor.View
{
    public partial class FC006Participante : Sdistribuidor.View.FBase
    {
        public FC006Participante()
        {
            InitializeComponent();
        }

        Entidade_Cidade EntCidade;
        Entidade_LocalEntrega EntLocalEntrega = new Entidade_LocalEntrega();
        Entidade_UF EntUF;
        Participante modPart;
        UF modUf;
        Cidade modCidade;
        C_ModuloGeral cModGeral;
        DataGridViewTextBoxColumn NewText;
        DataGridView DGV;
        List<Entidade_LocalEntrega> ListEntLocalEntrega = new List<Entidade_LocalEntrega>();
        private void rbCPF_Click(object sender, EventArgs e)
        {
            MskCpfCnpj.Mask = "999,999,999-99";
            lblCnpjCpf.Text = "CPF";
            TxtFantasia.Visible = false;
            LblNomeFantasia.Visible = false;
        }

        private void rbCNPJ_Click(object sender, EventArgs e)
        {
            MskCpfCnpj.Mask = "99,999,999/0000-00";
            lblCnpjCpf.Text = "CNPJ";
            TxtFantasia.Visible = true;
            LblNomeFantasia.Visible = true;
        }

        public override bool ValidaCampos()
        {
            if (MskCpfCnpj.Text == string.Empty)
            {
                if (rbCPF.Checked == true)
                {
                    MessageBox.Show("Cpf do participante obrigatorio.");
                }
                else
                {
                    MessageBox.Show("Cnpj do participante obrigatorio.");
                }
                return false;
            }
            else if (!ucUfCidade1.ValidarCampos())
            {
                return false;
            }
            else if (TxtBairro.Text == string.Empty)
            {
                MessageBox.Show("Bairro do participante obrigatorio.");
                return false;
            }
            else if (TxtNrEnder.Text == string.Empty)
            {
                MessageBox.Show("Número do Endereço do participante obrigatorio.");
                return false;
            }
            else if (mskTelefone.Text == string.Empty)
            {
                MessageBox.Show("Telefone do participante obrigatorio.");
                return false;
            }
            else if (rbCPF.Checked == true)
            {
                if (TxtNome.Text == string.Empty)
                {
                    MessageBox.Show("Nome do participante e necessario.");
                    return false;
                }
                else
                    return true;
            }
            else
            {
                if (TxtFantasia.Text == string.Empty)
                {
                    MessageBox.Show("Nome Fantasia e obrigatorio.");
                    return false;
                }
                else
                    return true;
            }
        }

        public override bool Salvar()
        {
            modPart = new Participante();
            modCidade = new Cidade();
            modUf = new UF();
            cModGeral = new C_ModuloGeral();
            Entidade_Participante EntParticipante = new Entidade_Participante();

            EntParticipante.id_uf = modUf.Pesquisa(ucUfCidade1.IdUf);
            EntParticipante.id_cidade = modCidade.Pesquisa(ucUfCidade1.IdCidade);

            EntParticipante.cnpjcpf = cModGeral.TiraCampos(MskCpfCnpj.Text);
            EntParticipante.nome = TxtNome.Text.Trim();
            EntParticipante.nomefantasia = TxtFantasia.Text.Trim();
            EntParticipante.razaosocial = TxtNome.Text.Trim();
            EntParticipante.lagradouro = TxtLogradouro.Text.Trim();
            EntParticipante.bairro = TxtBairro.Text.Trim();
            EntParticipante.numero_end = TxtNrEnder.Text.Trim();
            EntParticipante.telefone = cModGeral.TiraCampos(mskTelefone.Text).Trim();
            EntParticipante.flcomercio = chkComercial.Checked;

            modPart.Incluir(EntParticipante);

            return true;
        }
        public override void CarregarDados()
        {
            modPart = new Participante();

            var obj = modPart.Pesquisa();
            grdBase.AutoGenerateColumns = false;
            grdBase.DataSource = modPart.Pesquisa();

            ucUfCidade1.CarregarCombos();
            ucUfCidadeLocalEntrega.CarregarCombos();
        }
        public override void CamposGrid()
        {
            DGV = new DataGridView();
            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Código";
            NewText.Name = "ColID";
            NewText.DataPropertyName = "id_participante";
            NewText.Width = 40;

            grdBase.Columns.Add(NewText);

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Cpf/Cnpj";
            NewText.Name = "ColCpfCnpj";
            NewText.DataPropertyName = "cnpjcpf";
            NewText.Width = 120;

            grdBase.Columns.Add(NewText);

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Nome";
            NewText.Name = "ColNome";
            NewText.DataPropertyName = "Nome";
            NewText.Width = 300;

            grdBase.Columns.Add(NewText);

            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Telefone";
            NewText.Name = "ColTelefone";
            NewText.DataPropertyName = "telefone";
            NewText.Width = 100;

            grdBase.Columns.Add(NewText);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EntLocalEntrega.lagradouro = TxtLogEntrega.Text;
            EntLocalEntrega.bairro = TxtBairroEntrega.Text;
            EntLocalEntrega.end_numero = TxtEndEntrega.Text;
            EntLocalEntrega.id_uf = ucUfCidadeLocalEntrega.IdUf;
            EntLocalEntrega.id_cidade = ucUfCidadeLocalEntrega.IdCidade;
            EntLocalEntrega.telefone = MskTelefoneEntrega.Text;
            EntLocalEntrega.obs = TxtObs.Text;
            EntLocalEntrega.FlExcluirLocalEntrega = false;

            ListEntLocalEntrega.Add(EntLocalEntrega);

            grdListaPedidos.Rows.Add(ucUfCidadeLocalEntrega.GetUF.desc_uf, ucUfCidadeLocalEntrega.GetCidade.desc_municipio,TxtBairroEntrega.Text,TxtLogEntrega.Text,TxtEndEntrega.Text,MskTelefoneEntrega.Text);
        }
    }
}
