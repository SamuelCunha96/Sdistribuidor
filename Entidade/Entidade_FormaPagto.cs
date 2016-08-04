using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_FormaPagto
    {
        public int idformapagto { get; set; }
        public string desc_formapagto { get; set; }
        public Boolean flprazo { get; set; }
        public Boolean flcartao { get; set; }
        public List<Entidade_ItemFormaPagto> ItemFormaPagtos { get; set; }
        //public virtual IList<Entidade_Pedido> Pedidos { get; set; }
    }
}
