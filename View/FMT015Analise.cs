using MetroFramework.Forms;
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

        Pedido ObjPedido;
        Pagamento ObjPagamento;

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
        }

        private void FMT015Analise_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
            CboAnalise.SelectedIndex = 0;
        }
    }
}
