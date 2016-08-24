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
    public partial class FMT003NotaFiscal : Form
    {
        public FMT003NotaFiscal()
        {
            InitializeComponent();
        }


        Pagamento Mpagamento;
        Pedido MPedido;
        Participante MParticipante;
        Produtos MProdutos;
        LojaSimples mLSimples;
        Entidade_ItemNFe EntItemNFe;
        Entidade_TotaisNota _totnotafiscal;
        Entidade_LojaSimples EntLojaSimples;
        Entidade_NotaFiscal EntNotaFiscal;
        Entidade_Participante EntParticipante;
        List<Entidade_ItemNFe> ListItemNF = new List<Entidade_ItemNFe>();

        // TODO: FALTANDO PEGAR O NÚMERO DA NF E A SÉRIE E LIMPAR OS CAMPOS APÓS A INSERÇÃO

        private void FMT003NotaFiscal_Load(object sender, EventArgs e)
        {
            CarregarListaPedidoRecebido();
        }

        void CarregarListaPedidoRecebido()
        {
            Mpagamento = new Pagamento();

            var Dt = Mpagamento.ListaPedidoPagamento("R");

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                grdListaPedidos.Rows.Add(Dt.Rows[i]["id_pedido"].ToString(), Dt.Rows[i]["cliente"].ToString(), Dt.Rows[i]["dt_pedido"].ToString(), Dt.Rows[i]["desc_formapagto"].ToString(), Dt.Rows[i]["vl_pedido"]);
            }
        }

        private void tbNotaFiscal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbPgDados_Click(object sender, EventArgs e)
        {

        }

        private void grdListaPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                MPedido = new Pedido();
                MProdutos = new Produtos();
                MParticipante = new Participante();
                mLSimples = new LojaSimples();

                EntParticipante = new Entidade_Participante();
                var RetEntLS = mLSimples.Pesquisa(1);
                var DtPedido = MPedido.Pesquisa(Convert.ToInt32(grdListaPedidos.Rows[e.RowIndex].Cells[0].Value));

                EntParticipante = DtPedido.id_participante;

                lblCliente.Text = DtPedido.id_participante.razaosocial;
                lblEndereco.Text = DtPedido.id_participante.lagradouro;
                lblBairro.Text = DtPedido.id_participante.bairro;
                lblCidade.Text = DtPedido.id_participante.id_cidade.desc_municipio;
                lblEstado.Text = DtPedido.id_participante.id_uf.desc_uf;

                lblNumeroPedido.Text = string.Format("{0:N0}", Convert.ToDecimal(DtPedido.id_pedido));
                lblData.Text = string.Format("{0:dd/MM/yyyy HH:mm:ss}", DtPedido.dt_pedido);
                lblFormPagto.Text = DtPedido.id_formpagto.desc_formapagto;
                lblValorPedido.Text = string.Format("{0:N2}", Convert.ToDecimal(DtPedido.vl_pedido));

                if (DtPedido.id_localentrega != 0)
                {
                    var LocalEnt = DtPedido.id_participante.ListLocalEntrega.Find(x => x.id == DtPedido.id_localentrega);

                    lblEntregaCliente.Text = DtPedido.id_participante.nomefantasia;
                    lblLocalEnd.Text = LocalEnt.lagradouro;
                    LblLocalBairro.Text = LocalEnt.bairro;
                    LblLocalEstado.Text = LocalEnt.id_uf.desc_uf;
                    LblLocalCidade.Text = LocalEnt.id_cidade.desc_municipio;
                }

                foreach (var item in DtPedido.ItemPedidos)
                {
                    EntItemNFe = new Entidade_ItemNFe();
                    var produto = MProdutos.Pesquisa(item.id_produto.IdProduto);
                    EntItemNFe.IdProduto = produto.IdProduto;
                    EntItemNFe.qt_venda = item.Qt_Pedido;
                    EntItemNFe.VlPreco = produto.VlPreco;
                    EntItemNFe.icms = produto.icms;
                    EntItemNFe.ipi = produto.ipi;
                    EntItemNFe.pis = produto.pis;
                    EntItemNFe.cofins = produto.cofins;
                    EntItemNFe.cfop = Entidade_GeralInformcoes.uf == lblEstado.Text ? produto.cfop_int : produto.cfop_ext;


                    if (produto.icms == "00" || produto.icms == "10" || produto.icms == "20" || produto.icms == "70")
                    {
                        EntItemNFe.vlbaseicms = item.Qt_Pedido * item.Vl_Unitario;
                        EntItemNFe.vlicms = item.Qt_Pedido * item.Vl_Unitario * (RetEntLS.VlAliqImcs / 100);
                        EntItemNFe.vlbaseicmssub = 0;
                        EntItemNFe.vlicms = 0;
                        EntItemNFe.vloutras = 0;
                        grdProdutoNF.Rows.Add(produto.IdProduto, produto.NmProduto, produto.NCM, produto.icms, produto.ipi, produto.pis, Entidade_GeralInformcoes.uf == lblEstado.Text ? produto.cfop_int : produto.cfop_ext, produto.Unidade.CdUnidade, item.Vl_Desconto, item.Qt_Pedido, item.Vl_Unitario, RetEntLS.VlAliqImcs, item.Qt_Pedido * item.Vl_Unitario, item.Qt_Pedido * item.Vl_Unitario);
                    }
                    else
                    {
                        EntItemNFe.vlbaseicms = 0;
                        EntItemNFe.vlicms = 0;
                        EntItemNFe.vlbaseicmssub = 0;
                        EntItemNFe.vlicms = 0;
                        EntItemNFe.vloutras = 0;
                        grdProdutoNF.Rows.Add(produto.IdProduto, produto.NmProduto, produto.NCM, produto.icms, produto.ipi, produto.pis, Entidade_GeralInformcoes.uf == lblEstado.Text ? produto.cfop_int : produto.cfop_ext, produto.Unidade.CdUnidade, item.Vl_Desconto, item.Qt_Pedido, item.Vl_Unitario, 0, 0, item.Qt_Pedido * item.Vl_Unitario);
                    }
                }
                CalcularTributos();
                tbNotaFiscal.SelectedTab = tbPgDados;
            }
        }

        void CalcularTributos()
        {
            _totnotafiscal = new Entidade_TotaisNota();
            mLSimples = new LojaSimples();

            double vlproduto = 0;
            double vlbaseicms = 0;
            double vldesconto = 0;
            double vlicms = 0;
            double vlipi = 0;
            double vlpis = 0;
            double vlcofins = 0;
            double vltotal = 0;

            // TODO: Trocar um numero 1 pela variavel que guarda a loja

            var RetEntLS = mLSimples.Pesquisa(1);


            for (int i = 0; i < grdProdutoNF.Rows.Count; i++)
            {
                vlproduto += Convert.ToDouble(grdProdutoNF.Rows[i].Cells[9].Value) * Convert.ToDouble(grdProdutoNF.Rows[i].Cells[10].Value);
                if (grdProdutoNF.Rows[i].Cells[3].Value.ToString() == "00" || grdProdutoNF.Rows[i].Cells[3].Value.ToString() == "10" || grdProdutoNF.Rows[i].Cells[3].Value.ToString() == "20" || grdProdutoNF.Rows[i].Cells[3].Value.ToString() == "70")
                {
                    vlbaseicms += Convert.ToDouble(grdProdutoNF.Rows[i].Cells["ColVlBaseIcms"].Value);
                    vlicms += vlbaseicms * (RetEntLS.VlAliqImcs / 100);
                }
                else
                {
                    vlbaseicms += 0;
                    vlicms += 0;
                }
                vldesconto += Convert.ToDouble(grdProdutoNF.Rows[i].Cells["ColDesconto"].Value);
            }
            vltotal = vlproduto - vldesconto;

            lblVlBaseICms.Text = string.Format("{0:N2}", vlbaseicms);
            lblVlIcms.Text = string.Format("{0:N2}", vlicms);
            lblVlDesc.Text = string.Format("{0:N2}", vldesconto);
            lblVlTotal.Text = string.Format("{0:N2}", vltotal);
        }

        private void grdListaPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void BtnConfObs_Click(object sender, EventArgs e)
        {
            pnlInformacoes.Visible = false;
        }

        private void FMT003NotaFiscal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)12)
            {

            }
        }

        private void FMT003NotaFiscal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                if(pnlInformacoes.Visible == true)
                    pnlInformacoes.Visible = false;
                else
                    pnlInformacoes.Visible = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaSalvar())
            {
                if (Salvar())
                {
                    MessageBox.Show("Nota Fiscal gerada com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        bool Salvar()
        {
            EntNotaFiscal = new Entidade_NotaFiscal();
            try
            {
                EntNotaFiscal.id_loja = Entidade_GeralInformcoes.idloja;
                EntNotaFiscal.id_participante = EntParticipante;
                EntNotaFiscal.serienf = string.Empty;
                EntNotaFiscal.nrnf = 0;
                EntNotaFiscal.dtemissao = DateTime.Now;
                EntNotaFiscal.vltotal = Convert.ToDouble(lblVlTotal.Text.Replace(".", ""));
                EntNotaFiscal.vlbaseicms = Convert.ToDouble(lblVlBaseICms.Text.Replace(".", ""));
                EntNotaFiscal.vlicms = Convert.ToDouble(lblVlIcms.Text.Replace(".", ""));
                EntNotaFiscal.vlbaseicmssub = Convert.ToDouble(lblVlBaseIcmsSub.Text.Replace(".", ""));
                EntNotaFiscal.vlicmssub = Convert.ToDouble(lblVlIcmsSub.Text.Replace(".", ""));
                EntNotaFiscal.vloutras = Convert.ToDouble(lblVlOutDesp.Text.Replace(".", ""));
                EntNotaFiscal.vlfrete = Convert.ToDouble(lblVlFrete.Text.Replace(".", ""));
                EntNotaFiscal.vlseguro = Convert.ToDouble(lblVlSeguro.Text.Replace(".", ""));
                EntNotaFiscal.txobsfisco = TxtInfFisco.Text;
                EntNotaFiscal.txobscontribuinte = TxtInfContribuinte.Text;
                EntNotaFiscal.id_pedido = Convert.ToInt32(lblNumeroPedido.Text);
                EntNotaFiscal.flfinalidade = 1;
                EntNotaFiscal.ItemNFe = ListItemNF;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool ValidaSalvar()
        {
            if (lblNumeroPedido.Text == string.Empty)
            {
                MessageBox.Show("Informe um pedido para gerar a nota fiscal", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (grdProdutoNF.Rows.Count == 0)
            {
                MessageBox.Show("Pedido sem produto, não será possivel gerar a nota fiscal!", "Aténção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }
    }
}

