using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;

namespace Sdistribuidor.Model
{
    class UF
    {
        Entidade_UF EntUf;
        public List<Entidade_UF> Pesquisa()
        {
            List<Entidade_UF> ListUf = new List<Entidade_UF>();
            var Dt = BancoDados.Consultar("SELECT *  FROM uf ORDER BY desc_uf");

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntUf = new Entidade_UF();
                EntUf.id_uf = Convert.ToInt32(Dt.Rows[i][0]);
                EntUf.desc_uf = Dt.Rows[i][1].ToString();

                ListUf.Add(EntUf);
            }
            return ListUf;
        }
        public Entidade_UF Pesquisa(int ID)
        {
            EntUf = new Entidade_UF();

            var Dt = BancoDados.Consultar("SELECT *  FROM uf WHERE id_uf =" + ID);

            if (Dt.Rows.Count > 0)
            {
                EntUf.id_uf = Convert.ToInt32(Dt.Rows[0][0]);
                EntUf.desc_uf = Dt.Rows[0][1].ToString();
            }

            return EntUf;
        }
        public Entidade_UF Uf(string descUf)
        {
            EntUf = new Entidade_UF();

            var Dt = BancoDados.Consultar("SELECT *  FROM uf WHERE desc_uf ='" + descUf + "'");

            if (Dt.Rows.Count > 0)
            {
                EntUf.id_uf = Convert.ToInt32(Dt.Rows[0][0]);
                EntUf.desc_uf = Dt.Rows[0][1].ToString();
            }

            return EntUf;
        }
        public List<Entidade_UF> Pesquisa(string Nome)
        {
            var Dt = BancoDados.Consultar("SELECT *  FROM uf WHERE desc_uf like '%" + Nome + "%'");
            EntUf = new Entidade_UF();

            List<Entidade_UF> ListUf = new List<Entidade_UF>();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                EntUf.id_uf = Convert.ToInt32(Dt.Rows[0][0]);
                EntUf.desc_uf = Dt.Rows[0][1].ToString();

                ListUf.Add(EntUf);
            }

            return ListUf;
        }
    }
}
