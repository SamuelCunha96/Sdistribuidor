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
        C_ModuloGeral cModGeral = new C_ModuloGeral();
        DataGridViewTextBoxColumn NewText;
        DataGridView DGV;
        List<Entidade_LocalEntrega> ListEntLocalEntrega = new List<Entidade_LocalEntrega>();
        private void rbCPF_Click(object sender, EventArgs e)
        {
            MskCpfCnpj.Mask = "999,999,999-99";
            lblCnpjCpf.Text = "CPF";
            lblIE.Visible = false;
            txtIE.Visible = false;
            TxtFantasia.Visible = false;
            LblNomeFantasia.Visible = false;
        }

        private void rbCNPJ_Click(object sender, EventArgs e)
        {
            MskCpfCnpj.Mask = "99,999,999/0000-00";
            lblCnpjCpf.Text = "CNPJ";
            lblIE.Visible = true;
            txtIE.Visible = true;
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
            EntParticipante.ie = txtIE.Text;
            EntParticipante.nome = TxtNome.Text.Trim();
            EntParticipante.nomefantasia = TxtFantasia.Text.Trim();
            EntParticipante.razaosocial = TxtNome.Text.Trim();
            EntParticipante.lagradouro = TxtLogradouro.Text.Trim();
            EntParticipante.bairro = TxtBairro.Text.Trim();
            EntParticipante.numero_end = TxtNrEnder.Text.Trim();
            EntParticipante.telefone = cModGeral.TiraCampos(mskTelefone.Text).Trim();
            EntParticipante.flcomercio = chkComercial.Checked;

            modPart.Incluir(EntParticipante, ListEntLocalEntrega);

            return true;
        }
        public override bool Editar()
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

            modPart.Update(EntParticipante, ListEntLocalEntrega);

            return true;
        }
        public override void PesquisarDados(string Pesquisar, object ID)
        {
            if(Convert.ToInt32(ID) > 0)
            {
                modPart = new Participante();
                modUf = new UF();
                modCidade = new Cidade();

                var DtPart = modPart.Pesquisa(Convert.ToInt32(ID));
                if(DtPart.cnpjcpf.Length == 14)
                {
                    MskCpfCnpj.Mask = "99,999,999/0000-00";
                    MskCpfCnpj.Text = DtPart.cnpjcpf;
                    lblCnpjCpf.Text = "CNPJ";
                    TxtFantasia.Visible = true;
                    LblNomeFantasia.Visible = true;
                    rbCNPJ.Enabled = true;
                    rbCPF.Enabled = false;
                }
                else
                {
                    MskCpfCnpj.Mask = "999,999,999-99";
                    MskCpfCnpj.Text = DtPart.cnpjcpf;
                    lblCnpjCpf.Text = "CPF";
                    TxtFantasia.Visible = false;
                    LblNomeFantasia.Visible = false;
                    rbCNPJ.Enabled = false;
                    rbCPF.Enabled = true;
                }
                TxtNome.Text = DtPart.nome;
                TxtFantasia.Text = DtPart.nomefantasia;
                TxtLogradouro.Text = DtPart.lagradouro;
                TxtBairro.Text = DtPart.bairro;
                TxtNrEnder.Text = DtPart.numero_end;
                mskTelefone.Text = DtPart.telefone;
                chkComercial.Checked = DtPart.flcomercio;
                ucUfCidade1.IdUf = DtPart.id_uf.id_uf;
                ucUfCidade1.IdCidade = DtPart.id_cidade.id;
                lblIdParticipante.Text = DtPart.id.ToString();

                if (DtPart.ListLocalEntrega.Count > 0)
                {
                    foreach (var item in DtPart.ListLocalEntrega)
                    {
                        var uf = modUf.Pesquisa(item.id_uf);
                        var cidade = modCidade.Pesquisa(item.id_cidade);
                        grdListaLocalEntrega.Rows.Add(uf.desc_uf, cidade.desc_municipio, item.bairro, item.lagradouro, item.end_numero, item.telefone, item.id_participante, item.id);
                    }
                }
            }
        }
        public override void CarregarDados()
        {
            modPart = new Participante();

            var obj = modPart.Pesquisa();
            grdBase.AutoGenerateColumns = false;
            grdBase.DataSource = modPart.Pesquisa();

            ucUfCidade1.CarregarCombos();
            ucUfCidadeLocalEntrega.CarregarCombos();

            rbCNPJ.Enabled = true;
            rbCPF.Enabled = true;
            lblIdParticipante.Text = string.Empty;
        }
        public override void CamposGrid()
        {

            DGV = new DataGridView();
            
            NewText = new DataGridViewTextBoxColumn();
            NewText.HeaderText = "Código";
            NewText.Name = "ColIDPartipante";
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
            EntLocalEntrega.telefone = cModGeral.TiraCampos(MskTelefoneEntrega.Text).Trim(); 
            EntLocalEntrega.obs = TxtObs.Text;
            EntLocalEntrega.FlExcluirLocalEntrega = false;
            EntLocalEntrega.id_participante = lblIdParticipante.Text == string.Empty ? 0 : Convert.ToInt32(lblIdParticipante.Text);
            ListEntLocalEntrega.Add(EntLocalEntrega);

            grdListaLocalEntrega.Rows.Add(ucUfCidadeLocalEntrega.GetUF.desc_uf, ucUfCidadeLocalEntrega.GetCidade.desc_municipio,TxtBairroEntrega.Text,TxtLogEntrega.Text,TxtEndEntrega.Text,MskTelefoneEntrega.Text,EntLocalEntrega.id_participante);
        }

        private void grdListaPedidos_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void grdListaLocalEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Deseja excluir o local de entrega," + grdListaLocalEntrega.Rows[grdListaLocalEntrega.CurrentRow.Index].Cells[0].Value.ToString() + "?", "Aténção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (Convert.ToInt32(grdListaLocalEntrega.Rows[grdListaLocalEntrega.CurrentRow.Index].Cells["ColParticipante"].Value) > 0)
                    {
                        EntLocalEntrega.id = Convert.ToInt32(grdListaLocalEntrega.Rows[grdListaLocalEntrega.CurrentRow.Index].Cells["ColID"].Value);
                        EntLocalEntrega.id_participante = Convert.ToInt32(grdListaLocalEntrega.Rows[grdListaLocalEntrega.CurrentRow.Index].Cells["ColParticipante"].Value);
                        EntLocalEntrega.FlExcluirLocalEntrega = true;
                        ListEntLocalEntrega.Add(EntLocalEntrega);
                    }
                    grdListaLocalEntrega.Rows.RemoveAt(grdListaLocalEntrega.CurrentRow.Index);
                }
            }
        }
        public override void LimpaCampos()
        {
            MskCpfCnpj.Mask = "999,999,999-99";
            MskCpfCnpj.Text = string.Empty;
            lblCnpjCpf.Text = "CPF";
            TxtFantasia.Visible = false;
            LblNomeFantasia.Visible = false;
            rbCNPJ.Enabled = false;
            rbCPF.Enabled = true;
            TxtNome.Text = string.Empty;
            TxtFantasia.Text = string.Empty;
            TxtLogradouro.Text = string.Empty;
            TxtBairro.Text = string.Empty;
            TxtNrEnder.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            chkComercial.Checked = false;
            ucUfCidade1.IdUf = 0;
            ucUfCidade1.IdCidade =0;
            lblIdParticipante.Text = string.Empty;
            //Local Entrega
            TxtBairroEntrega.Text = string.Empty;
            TxtLogEntrega.Text = string.Empty;
            TxtEndEntrega.Text = string.Empty;
            TxtObs.Text = string.Empty;
            ucUfCidadeLocalEntrega.IdUf = 0;
            ucUfCidadeLocalEntrega.IdCidade = 0;
            MskTelefoneEntrega.Text = string.Empty;
            grdListaLocalEntrega.Rows.Clear();
        }
    }
}
