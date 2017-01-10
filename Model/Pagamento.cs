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
            return BancoDados.Consultar("SELECT * FROM listapedidopagamento WHERE StPedido = '" + StPedido + "' AND (flcartao= true OR flavista=true)");
        }
        /// <summary>
        /// Consulta de Pedidos Recebidos no caixa ou que a forma de pagamento é diferente de avista
        /// Obs: Recebimento, Dinheiro + Cartão e consiterado "A vista" passa pelo caixa
        /// </summary>
        /// <param name="StPedido">A-Em Aberto, R- Recebido, N-Nota Fiscal, C-Cancelado</param>
        /// <returns></returns>
        public DataTable ListaPedidoPagamentoNotaFiscal(string StPedido)
        {
            return BancoDados.Consultar(" SELECT * FROM listapedidopagamento WHERE StPedido = '" + StPedido + "'\n" +
                                        " UNION \n" +
                                        " SELECT * FROM listapedidopagamento WHERE StPedido = 'A' AND FlAvista=false");
        }
    }
}
