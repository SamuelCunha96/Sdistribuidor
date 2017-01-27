using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.EntidadeView
{
    public class Entidade_VwListaCarne
    {
        public int id { get; set; }
        public int id_pedido { get; set; }
        public string partnome { get; set; }
        public string desc_formapagto { get; set; }
        public DateTime dtemissao { get; set; }
        public DateTime dtvencimento { get; set; }
        public decimal VlParcela { get; set; }
    }
}
