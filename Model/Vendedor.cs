using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;

namespace Sdistribuidor.Model
{
    public class Vendedor
    {
        public Vendedor()
        {

        }

        Entidade_Vendedor EntVendedor;
        public Entidade_Vendedor Pesquisar(int Id)
        {
            EntVendedor = new Entidade_Vendedor();
            try
            {
                var Dt = BancoDados.Consultar("SELECT * FROM Vendedor where id_vendedor=" + Id);

                if (Dt.Rows.Count > 0)
                {
                    EntVendedor.id_vendedor = Convert.ToInt32(Dt.Rows[0]["id_vendedor"]);
                    EntVendedor.nome = Dt.Rows[0]["nome"].ToString();
                    EntVendedor.email = Dt.Rows[0]["email"].ToString();
                    EntVendedor.telefone = Dt.Rows[0]["fone"].ToString();
                    EntVendedor.perc_comissao = Convert.ToDecimal(Dt.Rows[0]["perc_comissao"]);

                    return EntVendedor;
                }
                else
                    return EntVendedor;
            }
            catch (Exception)
            {
                return EntVendedor;
            }
        }
    }
}
