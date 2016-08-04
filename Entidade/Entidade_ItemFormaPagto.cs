using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_ItemFormaPagto
    {
        public int id_itemformapagto { get; set; }
        public int nrseqparc { get; set; }
        public int qtdias { get; set; }
        public Entidade_FormaPagto id_formapagto { get; set; }
    }


}
