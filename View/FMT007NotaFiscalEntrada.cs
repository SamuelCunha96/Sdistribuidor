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
using Sdistribuidor.Gerais;
using Sdistribuidor.Entidade;

namespace Sdistribuidor.View
{
    public partial class FMT007NotaFiscalEntrada : Form
    {
        public FMT007NotaFiscalEntrada()
        {
            InitializeComponent();
        }

        NotaFiscalEntrada ObjNFEntada;
        Participante ObjParticipante;
        Cidade ObjModCidade;
        UF ObjModUf;
        Produtos ObjModProduto;
        ProdutoUnidade ObjModProdUnid;

        Loja ObjLoja;

        DownloadNFe ObjDownloadNFe;
        XmlNFeEntrada ObjXmlNFeEntrada;
        Entidade_TotaisNota ObjTotaisNF;
        Entidade_NotaFiscal ObjNotaFiscal;
        Entidade_ProdutoUnidade ObjEntProdUnid;
        List<Entidade_Fatura> ObjListFatura;
        List<Entidade_ItemNFe> ObjListItemNFe;
        List<Entidade_Produto> ListProduto = new List<Entidade_Produto>();
        List<Entidade_ProdutoUnidade> ListUnidProd = new List<Entidade_ProdutoUnidade>();

        int CodigoProdutoUnidade = 0;
        string DescProduto;
        string UnidProduto;

        private void FMT007NotaFiscalEntrada_Load(object sender, EventArgs e)
        {
            ObjNFEntada = new NotaFiscalEntrada();
            ObjDownloadNFe = new DownloadNFe();
            ObjXmlNFeEntrada = new XmlNFeEntrada();
            ObjTotaisNF = new Entidade_TotaisNota();
            ObjNotaFiscal = new Entidade_NotaFiscal();
            ObjListFatura = new List<Entidade_Fatura>();
            ObjListItemNFe = new List<Entidade_ItemNFe>();

            grdNFSemEntrada.DataSource = ObjNFEntada.ConsultaNFeSemEntrada(dtpIni.Value, dtpFim.Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarNotaFiscaPendentes();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            int RowSelect = grdNFSemEntrada.Rows.GetRowCount(DataGridViewElementStates.Selected);


            if (RowSelect > 0)
            {
                if (RowSelect == 1)
                {
                    bool FlRetNFe;
                    ObjDownloadNFe = new DownloadNFe();
                    ObjXmlNFeEntrada = new XmlNFeEntrada();
                    ObjTotaisNF = new Entidade_TotaisNota();
                    ObjNotaFiscal = new Entidade_NotaFiscal();
                    ObjListFatura = new List<Entidade_Fatura>();
                    ObjListItemNFe = new List<Entidade_ItemNFe>();

                    var XmlNFeRet = ObjDownloadNFe.ConsultaXml(grdNFSemEntrada.Rows[grdNFSemEntrada.CurrentRow.Index].Cells["ColChave"].Value.ToString(), out FlRetNFe);

                    if (FlRetNFe)
                    {
                        LimpaCampos();
                        CarregarDadosXml(string.Empty,XmlNFeRet);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione apenas uma nota fiscal!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma nota fiscal!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void CarregarDadosXml(string PathXml,string XmlNFe)
        {
            ObjNFEntada = new NotaFiscalEntrada();
            ObjParticipante = new Participante();
            ObjXmlNFeEntrada.LerXml(PathXml, XmlNFe, out ObjTotaisNF, out ObjNotaFiscal, out ObjListFatura, out ObjListItemNFe);

            bool FlParticipanteExiste = false;
            bool FlNfExiste = false;


            if (ObjParticipante.ParticipanteExiste(ObjNotaFiscal.id_participante.cnpjcpf))
            {
                var ObjEntParticipante = ObjParticipante.PesquisaCnpj(ObjNotaFiscal.id_participante.cnpjcpf);
                ObjNotaFiscal.id_participante.id = ObjEntParticipante.id;
                FlParticipanteExiste = true;
            }

            if (FlParticipanteExiste)
            {
                if (ObjNFEntada.NotaFiscalExiste(1, ObjNotaFiscal.serienf, ObjNotaFiscal.nrnf, ObjNotaFiscal.id_participante.id))
                {
                    MessageBox.Show("Nota Fiscal já existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampos();
                    FlNfExiste = true;
                }
            }

            if (!FlNfExiste)
            {
                #region --- TAG NFE ----
                //NFe
                lblModeloNFe.Text = ObjNotaFiscal.modeloNFe.ToString();
                lblSerie.Text = ObjNotaFiscal.serienf;
                lblDocumento.Text = ObjNotaFiscal.nrnf.ToString();
                lblDtEmissao.Text = ObjNotaFiscal.dtemissao.ToShortDateString();
                lblVlNFe.Text = string.Format("{0:n2}", ObjTotaisNF.VlNf);
                #endregion

                #region --- TAG EMITENTE ---
                lblEmitNomeRazao.Text = ObjNotaFiscal.id_participante.nome;
                lblEmitCnpjCpf.Text = ObjNotaFiscal.id_participante.cnpjcpf;
                lblEmitIE.Text = ObjNotaFiscal.id_participante.ie;
                lblEmitUf.Text = ObjNotaFiscal.id_participante.id_uf.nome_uf;
                #endregion

                #region  --- TAG FATURAS ---

                if (ObjListFatura != null)
                {
                    foreach (var fatura in ObjListFatura)
                    {
                        lblFaturas.Text += fatura.DataFatura.ToShortDateString() + " - Valor:" + string.Format("{0:n2}", fatura.Valor) + " | ";
                    }
                }

                #endregion

                #region --- TAG ITEM NFE ---

                ObjNotaFiscal.ItemNFe = ObjListItemNFe;
                foreach (var item in ObjListItemNFe)
                {
                    grdProdutoNFe.Rows.Add(0, item.IdProdutoEmit, item.NmProduto, item.Unidade.Unidade, string.Empty, item.qt_venda, 0.00, item.VlPreco, item.cfop, item.icms, item.vlAliqIcms, item.vlbaseicms, item.vlicms, item.vlbaseicmssub, item.vlicmssub, item.ipi, item.vlAliqIpi, item.vlIpi, item.pis, item.vlAliqPis, item.vlPis, item.cofins, item.vlAliqCofins, item.vlCofins, item.vloutras, item.vlFrete, item.vlSeguro, item.vlDesconto, item.vlTotTrib, item.Total);
                }
                #endregion

                #region --- TAG INFORMAÇÕES NFE ---
                if (!string.IsNullOrEmpty(ObjNotaFiscal.txobscontribuinte))
                {
                    txtObs.Text = "Complementares: \n" + ObjNotaFiscal.txobscontribuinte;
                }
                else
                {
                    ObjNotaFiscal.txobscontribuinte = string.Empty;
                }
                if (!string.IsNullOrEmpty(ObjNotaFiscal.txobsfisco))
                {
                    txtObs.Text += "\nFisco: \n" + ObjNotaFiscal.txobsfisco;
                }
                else
                {
                    ObjNotaFiscal.txobsfisco = string.Empty;
                }
                #endregion

                #region --- TAG TOTAL NFE ---

                lblTotVlBcIcms.Text = string.Format("{0:n2}", ObjTotaisNF.VlBaseIcms);
                lblTotVlIcms.Text = string.Format("{0:n2}", ObjTotaisNF.VlIcms);
                lblTotVlBcSub.Text = string.Format("{0:n2}", ObjTotaisNF.VlBaseIcmsSub);
                lblTotVlIcmsSub.Text = string.Format("{0:n2}", ObjTotaisNF.VlIcmsSub);
                lblTotVlIcmsSub.Text = string.Format("{0:n2}", ObjTotaisNF.VlIcmsSub);
                lblTotFrete.Text = string.Format("{0:n2}", ObjTotaisNF.VlFrete);
                lblTotOutras.Text = string.Format("{0:n2}", ObjTotaisNF.VlOutrasDesp);
                lblTotSeguro.Text = string.Format("{0:n2}", ObjTotaisNF.VlSeguro);
                lblTotVlIpi.Text = string.Format("{0:n2}", ObjTotaisNF.VlIpi);
                lblTotPis.Text = string.Format("{0:n2}", ObjTotaisNF.VlPis);
                lblTotCofins.Text = string.Format("{0:n2}", ObjTotaisNF.VlCofins);
                lblTotVlTrib.Text = string.Format("{0:n2}", ObjTotaisNF.VlTrib);
                lblTotProdutos.Text = string.Format("{0:n2}", ObjTotaisNF.VlProdutos);
                lblTotNFe.Text = string.Format("{0:n2}", ObjTotaisNF.VlNf);
                #endregion

                tcNFEntrada.SelectTab(tpEntrada);
            }

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        void LimpaCampos()
        {
            //NFe
            lblModeloNFe.Text = string.Empty;
            lblSerie.Text = string.Empty;
            lblDocumento.Text = string.Empty;
            lblDtEmissao.Text = string.Empty;
            //Emitente
            lblEmitCnpjCpf.Text = string.Empty;
            lblEmitNomeRazao.Text = string.Empty;
            lblEmitIE.Text = string.Empty;
            lblEmitUf.Text = string.Empty;
            lblFaturas.Text = string.Empty;
            //Produtos
            grdProdutoNFe.Rows.Clear();

            //Totais
            lblTotVlBcIcms.Text = "0,00";
            lblTotVlIcms.Text = "0,00";
            lblTotVlBcSub.Text = "0,00";
            lblTotVlIcmsSub.Text = "0,00";
            lblTotFrete.Text = "0,00";
            lblTotVlIpi.Text = "0,00";
            lblTotOutras.Text = "0,00";
            lblTotSeguro.Text = "0,00";
            lblTotCofins.Text = "0,00";
            lblTotPis.Text = "0,00";
            lblTotVlTrib.Text = "0,00";
            lblTotProdutos.Text = "0,00";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaDados())
            {
                ObjNFEntada = new NotaFiscalEntrada();
                string MsgErro;

                ObjNotaFiscal.id_loja = 1;
                ObjNotaFiscal.dtsaida = Convert.ToDateTime(lblDtEmissao.Text);
                ObjNotaFiscal.dtentrada = Convert.ToDateTime(dtpEntrada.Value);

                for (int i = 0; i < grdProdutoNFe.Rows.Count; i++)
                {
                    ObjNotaFiscal.ItemNFe[i].IdProduto = long.Parse(grdProdutoNFe.Rows[i].Cells[0].Value.ToString());
                    ObjNotaFiscal.ItemNFe[i].UnidFornecedor = grdProdutoNFe.Rows[i].Cells[3].Value.ToString();
                    ObjNotaFiscal.ItemNFe[i].qt_entrada_fornec = Convert.ToDecimal(grdProdutoNFe.Rows[i].Cells[6].Value.ToString().Replace(".", ""));
                    ObjNotaFiscal.ItemNFe[i].cfop = Convert.ToInt32(grdProdutoNFe.Rows[i].Cells[8].Value);
                }

                if (ObjNFEntada.IncluirNFEntrada(ObjNotaFiscal, ObjTotaisNF, ObjListFatura, out MsgErro))
                {
                    MessageBox.Show("Nota Fiscal Incluida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LimpaCampos();
                    tcNFEntrada.SelectTab(tpPendentes);
                }
                else
                {
                    MessageBox.Show("Erro ao incluir a nota fiscal!\nErro:" + MsgErro, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        bool ValidaDados()
        {
            ObjParticipante = new Participante();
            ObjModCidade = new Cidade();
            ObjModUf = new UF();
            ObjLoja = new Loja();
            string MsgRetCidade;
            bool FlErroCodigoProduto = false;
            bool FlErroCfop = false;
            List<string> ErroArrayCodigo = new List<string>();
            List<string> ErroArrayCfop = new List<string>();


            var RetLoja = ObjLoja.Pesquisa(1);

            if (!ObjParticipante.ParticipanteExiste(ObjNotaFiscal.id_participante.cnpjcpf))
            {
                ObjNotaFiscal.id_participante.id_uf = ObjModUf.Uf(ObjNotaFiscal.id_participante.id_uf.nome_uf);

                var RetCidadeIbge = ObjModCidade.PesquisaCidadeIbge(ObjNotaFiscal.id_participante.id_cidade.id_ibge, out MsgRetCidade);
                if (MsgRetCidade != string.Empty)
                {
                    MessageBox.Show("A Cidade do Emitente da NFe não existe, contate ao administrador!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    ObjNotaFiscal.id_participante.id_cidade = RetCidadeIbge;
                    if (!ObjParticipante.Incluir(ObjNotaFiscal.id_participante, null))
                    {
                        MessageBox.Show("Erro ao incluir o Emitente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                }
            }
            else
            {
                var RetParticipante = ObjParticipante.PesquisaCnpj(ObjNotaFiscal.id_participante.cnpjcpf);
                ObjNotaFiscal.id_participante.id = RetParticipante.id;
            }

            //Valida Codigo do produto
            for (int i = 0; i < grdProdutoNFe.Rows.Count; i++)
            {
                if (grdProdutoNFe.Rows[i].Cells[0].Value.ToString() == "0" || grdProdutoNFe.Rows[i].Cells[0].Value.ToString() == string.Empty)
                {
                    FlErroCodigoProduto = true;
                    ErroArrayCodigo.Add("Linha " + i + 1 + "- Produto Emitente: " + grdProdutoNFe.Rows[i].Cells[1].Value.ToString());
                }
            }

            //Valida Cfop
            for (int i = 0; i < grdProdutoNFe.Rows.Count; i++)
            {
                if(RetLoja.Rows[0]["desc_uf"].ToString().Trim().ToUpper() == ObjNotaFiscal.id_participante.id_uf.nome_uf)
                {
                    if (grdProdutoNFe.Rows[i].Cells[8].Value.ToString() == "0" || grdProdutoNFe.Rows[i].Cells[8].Value.ToString().Substring(0, 1) == "5" || grdProdutoNFe.Rows[i].Cells[8].Value.ToString() == string.Empty)
                    {
                        FlErroCfop = true;
                        ErroArrayCfop.Add("Item " + grdProdutoNFe.Rows[i].Cells[1].Value.ToString() + "- Cfop: " + grdProdutoNFe.Rows[i].Cells[8].Value.ToString() + ", \nO Cfop deve iniciar com Número (1)");
                    }
                }
                else
                {
                    if (grdProdutoNFe.Rows[i].Cells[8].Value.ToString() == "0" || grdProdutoNFe.Rows[i].Cells[8].Value.ToString().Substring(0, 1) == "6" || grdProdutoNFe.Rows[i].Cells[8].Value.ToString() == string.Empty)
                    {
                        FlErroCfop = true;
                        ErroArrayCfop.Add("Item " + grdProdutoNFe.Rows[i].Cells[1].Value.ToString() + "- Cfop: " + grdProdutoNFe.Rows[i].Cells[8].Value.ToString() + ", \nO Cfop deve iniciar com Número (2)");
                    }
                }
            }

            if (grdProdutoNFe.Rows.Count == 0)
            {
                MessageBox.Show("Informe um xml, com produtos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else if (FlErroCodigoProduto)
            {
                string ErroMsg = string.Empty;

                foreach (var item in ErroArrayCodigo)
                {
                    ErroMsg += item + "\n";
                }

                MessageBox.Show("Erro no código do produto \n" + ErroMsg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return false;
            }
            else if (FlErroCfop)
            {
                string ErroMsg = string.Empty;

                foreach (var item in ErroArrayCfop)
                {
                    ErroMsg += item + "\n";
                }

                MessageBox.Show("Erro no código do produto \n" + ErroMsg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return false;
            }
            else
                return true;
        }

        void CarregarTxProduto()
        {
            ObjModProduto = new Produtos();

            AutoCompleteStringCollection ProdutoList = new AutoCompleteStringCollection();

            ListProduto = ObjModProduto.Pesquisa();

            foreach (var item in ListProduto)
            {
                ProdutoList.Add(item.NmProduto);
            }

            txtDescPro.AutoCompleteCustomSource = ProdutoList;
        }

        private void FMT007NotaFiscalEntrada_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                CarregarTxProduto();

                if (gbPesqProdConv.Visible == true)
                    gbPesqProdConv.Visible = false;
                else
                    gbPesqProdConv.Visible = true;

            }
        }

        private void txtDescPro_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    ObjModProduto = new Produtos();
            //    ObjModProdUnid = new ProdutoUnidade();

            //    var EntProd = ListProduto.Where(p => p.NmProduto.Contains(txtDescPro.Text)).FirstOrDefault();

            //    ListUnidProd = ObjModProdUnid.Pesquisa(EntProd.IdProduto);
            //}
        }

        private void CboUnidConv_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtDescPro.Text != string.Empty)
            {
                var EntProd = ListProduto.Where(p => p.NmProduto.Contains(txtDescPro.Text)).FirstOrDefault();

                grdProdutoNFe.Rows[grdProdutoNFe.CurrentRow.Index].Cells[0].Value = EntProd.IdProduto;
                LimpaProdutoConversao();

                gbPesqProdConv.Visible = false;
                PreecherDadosPorCodigo(grdProdutoNFe.CurrentRow.Index);

            }
        }

        public void LimpaProdutoConversao()
        {
            txtDescPro.Text = string.Empty;
        }

        private void grdProdutoNFe_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                PreecherDadosPorCodigo(e.RowIndex);
            }
            else if (e.ColumnIndex == 8)
            {
                if (grdProdutoNFe.Rows[e.RowIndex].Cells[8].Value.ToString().Length == 4)
                {

                    if (grdProdutoNFe.Rows.Count > 0)
                    {
                        if (MessageBox.Show("Deseja replicar o cfop para os outros produtos?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            for (int i = grdProdutoNFe.CurrentRow.Index; i < grdProdutoNFe.Rows.Count; i++)
                            {
                                grdProdutoNFe.Rows[i].Cells[8].Value = grdProdutoNFe.Rows[e.RowIndex].Cells[8].Value;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("O Cfop está incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        void PreecherDadosPorCodigo(int index)
        {
            int bCodValid;

            ObjModProduto = new Produtos();


            if (int.TryParse(grdProdutoNFe.Rows[index].Cells[0].Value.ToString(), out bCodValid))
            {

                var RetProd = ObjModProduto.Pesquisa(long.Parse(grdProdutoNFe.Rows[index].Cells[0].Value.ToString()));

                //Produto Existe?
                if (RetProd != null)
                {
                    DescProduto = RetProd.NmProduto;
                    UnidProduto = RetProd.Unidade.CdUnidade;
                    UnidEmitenteCadastrada(RetProd.IdProduto, grdProdutoNFe.Rows[index].Cells[3].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Produto não existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Produto Digitado é invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        /// <summary>
        /// Verifica se a unidade do emit existe, Unidade informa a do Emitente.
        /// </summary>
        /// <param name="CodigProduto"></param>
        /// <param name="unidade"></param>
        void UnidEmitenteCadastrada(long CodigProduto, string unidade)
        {
            ObjModProdUnid = new ProdutoUnidade();
            List<Entidade_ProdutoUnidade> RetListUnidProd = new List<Entidade_ProdutoUnidade>();
            CodigoProdutoUnidade = Convert.ToInt32(CodigProduto.ToString());
            RetListUnidProd = ObjModProdUnid.Pesquisa(CodigProduto);



            bool FlUnidadeExiste = false;
            if (RetListUnidProd != null)
            {
                foreach (var item in RetListUnidProd)
                {
                    if (unidade.ToUpper() == item.Unidade.ToUpper())
                    {
                        ConverterUnidQtdEmitparaUnidEmp(Convert.ToDecimal(item.vlfatorconv));
                        grdProdutoNFe.Rows[grdProdutoNFe.CurrentRow.Index].Cells[4].Value = UnidProduto;
                        FlUnidadeExiste = true;
                        break;
                    }
                }
            }

            if (!FlUnidadeExiste)
            {
                TxtUndConvDesc.Text = DescProduto;
                TxtUndConvPadrao.Text = UnidProduto;
                TxtUndConvEmit.Text = grdProdutoNFe.Rows[grdProdutoNFe.CurrentRow.Index].Cells[3].Value.ToString();
                gbCadUnidConversao.Visible = true;

            }
        }

        void ConverterUnidQtdEmitparaUnidEmp(decimal Fator)
        {
            var VlConvertido = Convert.ToDecimal(grdProdutoNFe.Rows[grdProdutoNFe.CurrentRow.Index].Cells[5].Value.ToString().Replace(".", "")) * Fator;
            grdProdutoNFe.Rows[grdProdutoNFe.CurrentRow.Index].Cells[6].Value = VlConvertido;
        }

        private void TxtUndConvFator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TxtUndConvFator.Text.Contains(e.KeyChar.ToString()))
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar.ToString().Trim() == ",")
                e.Handled = true;
        }

        private void btnConfirmaFator_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cadastrar a seguinte Unidade\n" + TxtUndConvEmit.Text + "\nFator de Conversão\n" + TxtUndConvFator.Text, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ObjModProdUnid = new ProdutoUnidade();
                ObjEntProdUnid = new Entidade_ProdutoUnidade();
                ObjEntProdUnid.id_produto = CodigoProdutoUnidade;
                ObjEntProdUnid.Unidade = TxtUndConvEmit.Text;
                ObjEntProdUnid.vlfatorconv = Convert.ToDouble(TxtUndConvFator.Text);

                if (ObjModProdUnid.Incluir(ObjEntProdUnid))
                {
                    UnidEmitenteCadastrada(long.Parse(CodigoProdutoUnidade.ToString()), TxtUndConvEmit.Text);
                    gbCadUnidConversao.Visible = false;
                }
                else
                {
                    MessageBox.Show("Erro ao incluir a Unidade de conversão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void tpPendentes_Enter(object sender, EventArgs e)
        {
            ConsultarNotaFiscaPendentes();
        }

        void ConsultarNotaFiscaPendentes()
        {
            ObjNFEntada = new NotaFiscalEntrada();
            grdNFSemEntrada.DataSource = ObjNFEntada.ConsultaNFeSemEntrada(dtpIni.Value, dtpFim.Value);
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            if (OFDxml.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                CarregarDadosXml(OFDxml.FileName,string.Empty);
            }
        }
    }
}
