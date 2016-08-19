using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_LocalEntrega
    {
        public int id { get; set; }
        public int id_participante { get; set; }
        public string lagradouro { get; set; }
        public string end_numero { get; set; }
        public string bairro { get; set; }
        public Entidade_UF id_uf { get; set; }
        public Entidade_Cidade id_cidade { get; set; }
        public string telefone { get; set; }
        public string obs { get; set; }
        public bool FlExcluirLocalEntrega { get; set; }
    }
}
