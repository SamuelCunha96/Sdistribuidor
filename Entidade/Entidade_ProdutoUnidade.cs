using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_ProdutoUnidade
    {
        public Entidade_ProdutoUnidade()
        {

        }
        public int id_produto { get; set; }
        public string Unidade { get; set; }
        public double vlfatorconv { get; set; }

        public string UndProd
        {
            get
            {
                return Unidade;
            }
        }
    }
}
