using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sdistribuidor.Model;
using Sdistribuidor.Entidade;

namespace Sdistribuidor.View
{
    public partial class FMT006Manifestacao : Form
    {
        public FMT006Manifestacao()
        {
            InitializeComponent();
        }

        ManifestacaoNFDestinatio ObjManDest;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaNFeManifestacaoRetorno();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FMT006Manifestacao_Load(object sender, EventArgs e)
        {

            ConsultaChaveNfeDestinatario();

        }

        private void ConsultaChaveNfeDestinatario()
        {
            ObjManDest = new ManifestacaoNFDestinatio();
            grdNotaManifestacao.AutoGenerateColumns = false;
            grdNotaManifestacao.DataSource = ObjManDest.ConsultarNFDestinarioSemManifestação();
        }

        private void trConsultaDest_Tick(object sender, EventArgs e)
        {

            ConsultaChaveNfeDestinatario();
        }

        private void grdNotaManifestacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(grdNotaManifestacao.Rows[e.RowIndex].Cells[0].Value) == false)
                {
                    grdNotaManifestacao.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    grdNotaManifestacao.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
        }

        private void btnManifestar_Click(object sender, EventArgs e)
        {
            grdChaveManifestacao.Rows.Clear();

            for (int i = 0; i < grdNotaManifestacao.Rows.Count; i++)
            {
                if (Convert.ToBoolean(grdNotaManifestacao.Rows[i].Cells[0].Value) == true)
                    grdChaveManifestacao.Rows.Add(grdNotaManifestacao.Rows[i].Cells[1].Value.ToString());
            }

            tbGeral.SelectTab(tbManifestacao);
            tabManifestacaoDest.SelectTab(tpManifestacaoEnv);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MskChDest.Text.Length == 54)
            {
                grdChaveManifestacao.Rows.Add(MskChDest.Text);
                MskChDest.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("A chave deve conter 44 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Entidade_Manifestacao ObjManifestacao = new Entidade_Manifestacao();
            Entidade_ItemManifestacao ObjItemManifestacao = new Entidade_ItemManifestacao();
            string MensagemErro;

            List<Entidade_ItemManifestacao> ObjListItemManifestacao = new List<Entidade_ItemManifestacao>();

            if (ValidaDados())
            {
                ObjManifestacao.id_loja = 1;
                ObjManifestacao.dtManifestacao = DateTime.Now;
                ObjManifestacao.tipo_ambiente = string.Empty;

                for (int i = 0; i < grdChaveManifestacao.Rows.Count; i++)
                {
                    ObjItemManifestacao = new Entidade_ItemManifestacao();
                    ObjItemManifestacao.idseq = i + 1;
                    if (CboManifestacao.SelectedIndex == 0)
                        ObjItemManifestacao.codmanifestacao = 210200;
                    else if (CboManifestacao.SelectedIndex == 1)
                        ObjItemManifestacao.codmanifestacao = 210210;
                    else if (CboManifestacao.SelectedIndex == 2)
                        ObjItemManifestacao.codmanifestacao = 210220;
                    else if (CboManifestacao.SelectedIndex == 3)
                        ObjItemManifestacao.codmanifestacao = 210240;

                    ObjItemManifestacao.chaveacesso = grdChaveManifestacao.Rows[i].Cells[0].Value.ToString().Replace(" ", string.Empty);
                    ObjListItemManifestacao.Add(ObjItemManifestacao);
                }

                ObjManifestacao.ListNfeManifestacao = ObjListItemManifestacao;

                if (ObjManDest.IncluirManifestacao(ObjManifestacao, out MensagemErro))
                {
                    MessageBox.Show("Manifestação enviada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimpaCampos();
                    tabManifestacaoDest.SelectTab(tpLoteManifestacao);
                }
                else
                    MessageBox.Show("Erro ao enviar Manifestação:\n" + MensagemErro + ". \nComunique ao Administrador.");
            }
        }


        bool ValidaDados()
        {
            if (CboManifestacao.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma manifestação.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                CboManifestacao.Focus();
                return false;
            }
            else
                return true;
        }

        void LimpaCampos()
        {
            grdChaveManifestacao.Rows.Clear();
            MskChDest.Text = string.Empty;
        }

        void ConsultaNFeManifestacaoRetorno()
        {
            //grdChaManRetorno.Rows.Clear();
            if (RbOperacao.Checked)
            {
                grdChaManRetorno.DataSource = ObjManDest.ConsultarNFDestinarioConfirmaOperacao();
            }
            else if (RbCiencia.Checked)
            {
                grdChaManRetorno.DataSource = ObjManDest.ConsultarNFDestinarioCiencieEmissao();
            }
            else if (RbDesconhecimento.Checked)
            {
                grdChaManRetorno.DataSource = ObjManDest.ConsultarNFDestinarioDesconhecimentoOperacao();
            }
            else if (RbNaoRealizacao.Checked)
            {
                grdChaManRetorno.DataSource = ObjManDest.ConsultarNFDestinarioOperacaoNaoRealizada();
            }
        }

        private void grdChaManRetorno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(grdChaManRetorno.Rows[e.RowIndex].Cells[0].Value) == false)
                {
                    grdChaManRetorno.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    grdChaManRetorno.Rows[e.RowIndex].Cells[0].Value = false;
                }
            }
        }

        private void btnRetManifestacao_Click(object sender, EventArgs e)
        {
            int contNfe = 0;
            for (int i = 0; i < grdChaManRetorno.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(grdChaManRetorno.Rows[i].Cells[5].Value.ToString()))
                {
                    if (Convert.ToInt32(grdChaManRetorno.Rows[i].Cells[5].Value) != 135)
                    {
                        if (Convert.ToBoolean(grdChaManRetorno.Rows[i].Cells[0].Value) == true)
                        {
                            contNfe += 1;
                            grdChaveManifestacao.Rows.Add(grdChaManRetorno.Rows[i].Cells[3].Value.ToString());
                        }
                    }
                }
            }

            if (contNfe > 0)
            {
                tbGeral.SelectTab(tbManifestacao);
                tabManifestacaoDest.SelectTab(tpManifestacaoEnv);
            }
        }
    }
}
