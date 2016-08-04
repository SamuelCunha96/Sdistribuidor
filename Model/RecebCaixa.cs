using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.DAO;
using Sdistribuidor.Entidade;

namespace Sdistribuidor.Model
{
    public class RecebCaixa
    {
        public bool ReceberPagamento(List<Entidade_RecebCaixa> ListReceb)
        {
            try
            {
                foreach (var item in ListReceb)
                {
                    BancoDados.InsertAlterarExcluir("INSERT INTO recebcaixa (id_pedido, dt_receb, id_bandeira, vl_receb) " +
                                                    "VALUES(" + item.IdPedido + ",'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", item.DtReceb) + "'," + item.IdCartaoCredito + "," + item.ValorReceb.ToString().Replace(".", "").Replace(",", ".") + ")");

                    BancoDados.InsertAlterarExcluir("UPDATE Pedido SET stpedido = 'R' WHERE id_pedido = " + item.IdPedido);
                }

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
    }
}
