using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_UF
    {
        public int id_uf { get; set; }
        public string desc_uf { get; set; }
        public string nome_uf { get; set; }
        public IList<Entidade_Cidade> Cidades { get; set; }
    }
}
