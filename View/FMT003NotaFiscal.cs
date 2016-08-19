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
        Entidade_ItemNFe EntItemNFe = new Entidade_ItemNFe();
        Entidade_TotaisNota _totnotafiscal;
        Entidade_LojaSimples EntLojaSimples;

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
                var RetEntLS = mLSimples.Pesquisa(1);
                var DtPedido = MPedido.Pesquisa(Convert.ToInt32(grdListaPedidos.Rows[e.RowIndex].Cells[0].Value));


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
                    var produto = MProdutos.Pesquisa(item.id_produto.IdProduto);
                    if (produto.icms == "00" || produto.icms == "10" || produto.icms == "20" || produto.icms == "70")
                    {
                        grdProdutoNF.Rows.Add(produto.IdProduto, produto.NmProduto, produto.NCM, produto.icms, produto.ipi, produto.pis, Entidade_GeralInformcoes.uf == lblEstado.Text ? produto.cfop_int : produto.cfop_ext, produto.Unidade.CdUnidade, item.Vl_Desconto, item.Qt_Pedido, item.Vl_Unitario, RetEntLS.VlAliqImcs, item.Qt_Pedido * item.Vl_Unitario, item.Qt_Pedido * item.Vl_Unitario);
                    }
                    else
                    {
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
    }
}

