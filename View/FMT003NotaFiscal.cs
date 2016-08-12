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
                var DtPedido = MPedido.Pesquisa(Convert.ToInt32(grdListaPedidos.Rows[e.RowIndex].Cells[0].Value));

                lblCliente.Text = DtPedido.id_participante.razaosocial;
                lblEndereco.Text = DtPedido.id_participante.lagradouro;
                lblBairro.Text = DtPedido.id_participante.bairro;
                lblCidade.Text = DtPedido.id_participante.id_cidade.desc_municipio;
                lblEstado.Text = DtPedido.id_participante.id_uf.desc_uf;

                lblNumeroPedido.Text = string.Format("{0:N0}",Convert.ToDecimal(DtPedido.id_pedido));
                lblData.Text = string.Format("{0:dd/MM/yyyy HH:mm:ss}", DtPedido.dt_pedido);
                lblFormPagto.Text = DtPedido.id_formpagto.desc_formapagto;
                lblValorPedido.Text = string.Format("{0:N2}", Convert.ToDecimal(DtPedido.vl_pedido));

                foreach (var item in DtPedido.ItemPedidos)
                {
                    var produto = MProdutos.Pesquisa(item.id_produto.IdProduto);

                    grdProdutoNF.Rows.Add(produto.IdProduto, produto.NmProduto, produto.NCM, produto.icms, produto.ipi, produto.pis, produto.cfop_int, produto.Unidade.CdUnidade,item.Vl_Desconto, item.Qt_Pedido,item.Vl_Unitario,0,0,item.Qt_Pedido * item.Vl_Unitario);
                }                
            }
        }
    }
}
