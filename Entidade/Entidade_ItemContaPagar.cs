using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_ItemContaPagar
    {
        public int id_itemcontpag { get; set; }
        public int id_contpag { get; set; }
        public DateTime dtvencimento { get; set; }
        public decimal vlparcela { get; set; }
        public string stparcela { get; set; }
        public DateTime dtpagto { get; set; }
    }
}
