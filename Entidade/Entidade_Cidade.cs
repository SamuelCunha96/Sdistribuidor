using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_Cidade
    {
        public int id { get; set; }
        public string desc_municipio { get; set; }
        public string id_ibge { get; set; }
        public Entidade_UF id_uf { get; set; }
    }
}
