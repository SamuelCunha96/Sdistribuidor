using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_ItemNFe : Entidade_Produto
    {
        public int id_loja { get; set; }
        public string serienf { get; set; }
        public int nrnf { get; set; }
        public double qt_venda { get; set; }
        public double vlbaseicms { get; set; }
        public double vlicms { get; set; }
        public double vlbaseicmssub { get; set; }
        public double vlicmssub { get; set; }
        public double vloutras { get; set; }
        public double cfop { get; set; }
    }
}
