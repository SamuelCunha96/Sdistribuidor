using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_Loja
    {
        public Entidade_Loja()
        {

        }
        public int id { get; set; }
        public string nmloja { get; set; }
        public string razao_social { get; set; }
        public string nm_fantasia { get; set; }
        public string cnpj { get; set; }
        public string ie { get; set; }
        public string logradouro { get; set; }
        public string nro { get; set; }
        public string compl { get; set; }
        public string cep { get; set; }
        public int id_uf { get; set; }
        public int id_cidade { get; set; }
        public string fone { get; set; }
        public string tipo_regime { get; set; }
    }
}
