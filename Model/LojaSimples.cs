using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;

namespace Sdistribuidor.Model
{
    public class LojaSimples
    {
        List<Entidade_LojaSimples> LsLojaSimples;
        Entidade_LojaSimples EntLojaSimples;
        public Entidade_LojaSimples Pesquisa(int Loja)
        {
            EntLojaSimples = new Entidade_LojaSimples();
            var Dt = BancoDados.Consultar("SELECT * FROM LojaSimples WHERE idloja=" + Loja);

            if(Dt.Rows.Count > 0)
            {
                EntLojaSimples.VlAliqImcs = Convert.ToDouble(Dt.Rows[0][1]);
            }

            return EntLojaSimples;
        }
    }
}
