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
        DownloadNFe ObjDownloadNFe;
        XmlNFeEntrada ObjXmlNFeEntrada;
        Entidade_TotaisNota ObjTotaisNF;
        Entidade_NotaFiscal ObjNotaFiscal;
        List<Entidade_Fatura> ObjListFatura;
        List<Entidade_ItemNFe> ObjListItemNFe;
        
        private void FMT007NotaFiscalEntrada_Load(object sender, EventArgs e)
        {
            ObjNFEntada = new NotaFiscalEntrada();
            grdNFSemEntrada.DataSource = ObjNFEntada.ConsultaNFeSemEntrada(dtpIni.Value, dtpFim.Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ObjNFEntada = new NotaFiscalEntrada();
            grdNFSemEntrada.DataSource = ObjNFEntada.ConsultaNFeSemEntrada(dtpIni.Value, dtpFim.Value);
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

                    var XmlNFeRet =  ObjDownloadNFe.ConsultaXml(grdNFSemEntrada.Rows[grdNFSemEntrada.CurrentRow.Index].Cells["ColChave"].Value.ToString(), out FlRetNFe);

                    if (FlRetNFe)
                    {
                        LimpaCampos();
                        CarregarDadosXml(XmlNFeRet);
                        tcNFEntrada.SelectTab(tpEntrada);
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

        void CarregarDadosXml(string XmlNFe)
        {
            ObjXmlNFeEntrada.LerXml(XmlNFe, out ObjTotaisNF, out ObjNotaFiscal, out ObjListFatura, out ObjListItemNFe);

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

            foreach (var fatura in ObjListFatura)
            {
                lblFaturas.Text += fatura.DataFatura.ToShortDateString() + " - Valor:" + string.Format("{0:n2}", fatura.Valor) + " | ";
            }

            #endregion

            #region --- TAG ITEM NFE ---
            foreach (var item in ObjListItemNFe)
            {
                grdProdutoNFe.Rows.Add(0, item.IdProdutoEmit, item.NmProduto, item.Unidade.Unidade, string.Empty, item.qt_venda, 0.00, item.VlPreco, item.cfop, item.icms, item.vlAliqIcms, item.vlbaseicms, item.vlicms, item.vlbaseicmssub, item.vlicmssub, item.ipi, item.vlAliqIpi, item.vlIpi, item.pis, item.vlAliqPis, item.vlPis, item.cofins, item.vlAliqCofins, item.vlCofins, item.vloutras, item.vlFrete, item.vlSeguro, item.vlDesconto, item.vlTotTrib, item.Total);
            }
            #endregion

            #region --- TAG INFORMAÇÕES NFE ---
            if(!string.IsNullOrEmpty(ObjNotaFiscal.txobscontribuinte))
            {
                txtObs.Text = "Complementares: \n" + ObjNotaFiscal.txobscontribuinte;
            }
            if (!string.IsNullOrEmpty(ObjNotaFiscal.txobsfisco))
            {
                txtObs.Text += "\nFisco: \n" + ObjNotaFiscal.txobsfisco;
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
    }
}
