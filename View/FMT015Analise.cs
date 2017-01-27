using MetroFramework.Forms;
using Sdistribuidor.Entidade;
using Sdistribuidor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sdistribuidor.View
{
    public partial class FMT015Analise : MetroForm
    {
        public FMT015Analise()
        {
            InitializeComponent();
        }

        Duplicata ObjDuplicata;
        Pedido ObjPedido;
        Pagamento ObjPagamento;
        Participante ObjParticipante;
        FormaPagtoItemFormaPagto ObjFormaPagtoItemFormaPagto;

        List<Entidade_Duplicata> ObjListDuplicata;
        Entidade_Duplicata ObjEntDuplicata;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        void CarregarPedidos()
        {
            ObjPedido = new Pedido();
            ObjPagamento = new Pagamento();
            grdPedidoAnalise.AutoGenerateColumns = false;
            grdPedidoAnalise.DataSource = ObjPagamento.ListaPedidoEmAnalise(dtpIni.Value, dtpFim.Value, "A", "N");

            if (grdPedidoAnalise.Rows.Count > 0)
            {
                PrimeiraParcela(0);//Primeira Linha
            }
        }

        private void FMT015Analise_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
            CboAnalise.SelectedIndex = 0;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (grdPedidoAnalise.Rows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpIni.Focus();
            }
            else
            {
                try
                {
                    ObjDuplicata = new Duplicata();
                    ObjPagamento = new Pagamento();
                    if (CboAnalise.SelectedIndex == 0)
                    {
                        if (ObjDuplicata.Incluir(GerarDuplicata()))
                        {
                            ObjPagamento.ResultadoAnalise(Convert.ToInt32(grdPedidoAnalise.Rows[grdPedidoAnalise.CurrentRow.Index].Cells[0].Value), CboAnalise.SelectedIndex == 0 ? "P" : "R");
                        }
                    }
                    else
                    {
                        ObjPagamento.ResultadoAnalise(Convert.ToInt32(grdPedidoAnalise.Rows[grdPedidoAnalise.CurrentRow.Index].Cells[0].Value), CboAnalise.SelectedIndex == 0 ? "P" : "R");
                    }

                    CarregarPedidos();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        List<Entidade_Duplicata> GerarDuplicata()
        {
            ObjFormaPagtoItemFormaPagto = new FormaPagtoItemFormaPagto();
            ObjParticipante = new Participante();
            ObjListDuplicata = new List<Entidade_Duplicata>();

            var DtParcelas = ObjFormaPagtoItemFormaPagto.FormaPagtoParcelas(Convert.ToInt32(grdPedidoAnalise.Rows[grdPedidoAnalise.CurrentRow.Index].Cells[5].Value));

            DateTime DtEmissao = dtpPrimeira.Value;

            for (int i = 0; i < DtParcelas.Rows.Count; i++)
            {
                ObjEntDuplicata = new Entidade_Duplicata();
                ObjEntDuplicata.idpedido = Convert.ToInt32(grdPedidoAnalise.Rows[grdPedidoAnalise.CurrentRow.Index].Cells[0].Value);
                ObjEntDuplicata.participante = ObjParticipante.Pesquisa(Convert.ToInt32(grdPedidoAnalise.Rows[grdPedidoAnalise.CurrentRow.Index].Cells[6].Value));
                ObjEntDuplicata.formapagto = ObjFormaPagtoItemFormaPagto.Pesquisa(Convert.ToInt32(grdPedidoAnalise.Rows[grdPedidoAnalise.CurrentRow.Index].Cells[5].Value));
                ObjEntDuplicata.DtEmissao = Convert.ToDateTime(grdPedidoAnalise.Rows[grdPedidoAnalise.CurrentRow.Index].Cells[3].Value);
                //if (i != 0)
                ObjEntDuplicata.DtVencto = DtEmissao.AddMonths(i);
                //else
                //    ObjEntDuplicata.DtVencto = DtEmissao;
                ObjEntDuplicata.StParcela = "A";
                ObjEntDuplicata.VlParcela = Convert.ToDecimal(string.Format("{0:n2}", Convert.ToDecimal(grdPedidoAnalise.Rows[grdPedidoAnalise.CurrentRow.Index].Cells[4].Value) / DtParcelas.Rows.Count));
                ObjListDuplicata.Add(ObjEntDuplicata);
            }

            decimal valorParcelas = 0;
            decimal vltotal = Convert.ToDecimal(grdPedidoAnalise.Rows[grdPedidoAnalise.CurrentRow.Index].Cells[4].Value);
            foreach (var item in ObjListDuplicata)
            {
                valorParcelas += item.VlParcela;
            }

            if (vltotal != valorParcelas)
            {
                ObjListDuplicata[0].VlParcela = ObjListDuplicata[0].VlParcela + (vltotal - valorParcelas);
            }

            return ObjListDuplicata;
        }

        private void grdPedidoAnalise_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                PrimeiraParcela(e.RowIndex);
            }
        }

        void PrimeiraParcela(int index)
        {
            ObjFormaPagtoItemFormaPagto = new FormaPagtoItemFormaPagto();
            var DtParcelas = ObjFormaPagtoItemFormaPagto.FormaPagtoParcelas(Convert.ToInt32(grdPedidoAnalise.Rows[index].Cells[5].Value));

            DateTime DtVencto = Convert.ToDateTime(grdPedidoAnalise.Rows[index].Cells[3].Value);

            dtpPrimeira.Value = DtVencto.AddDays(Convert.ToInt32(DtParcelas.Rows[0]["qtdias"]));
        }
    }
}
