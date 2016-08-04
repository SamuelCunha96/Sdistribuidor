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
    }
}
