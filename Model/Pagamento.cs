using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.DAO;
using System.Data;

namespace Sdistribuidor.Model
{
    public class Pagamento
    {
        public DataTable ListaPedidoPagamento(string StPedido)
        {
            return BancoDados.Consultar("SELECT * FROM listapedidopagamento WHERE StPedido = '" + StPedido + "' ORDER BY dt_pedido");
        }
    }
}
