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
        public decimal qt_venda { get; set; }
        public decimal vlbaseicms { get; set; }
        public decimal vlicms { get; set; }
        public decimal vlbaseicmssub { get; set; }
        public decimal vlicmssub { get; set; }
        public decimal vloutras { get; set; }
        public int cfop { get; set; }
    }
}
