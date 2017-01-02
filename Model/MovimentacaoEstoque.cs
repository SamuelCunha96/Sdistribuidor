using Sdistribuidor.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Model
{
    public class MovimentacaoEstoque
    {
        /// <summary>
        /// Pesquisa por ID
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        public DataTable Pesquisa(int produto)
        {
            return BancoDados.Consultar("SELECT * FROM vwmovimentacaoestoque WHERE id_produto =" + produto);
        }
        public DataTable Pesquisa(DateTime DtIni, DateTime DtFim)
        {
            return BancoDados.Consultar("SELECT * FROM vw_movimentacaoestoque WHERE dtmovimentacao between '" + string.Format("{0:dd/MM/yyyy}",DtIni.Date) +"' AND '"+ string.Format("{0:dd/MM/yyyy}", DtFim.Date) + " 23:59:59'");
        }
    }
}
