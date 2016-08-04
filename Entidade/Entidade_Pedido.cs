using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_Pedido
    {
        public virtual int id_pedido { get; set; }
        public virtual Entidade_Participante id_participante { get; set; }
        public virtual Entidade_FormaPagto id_formpagto { get; set; }
        public virtual Entidade_Usuario id_usuario { get; set; }
        public virtual DateTime dt_pedido { get; set; }
        public virtual DateTime dt_preventrega { get; set; }
        public virtual double vl_pedido { get; set; }
        public virtual double vl_desconto { get; set; }
        public virtual string stpedido { get; set; }
        public virtual string stentrega { get; set; }
        public virtual string obspedido { get; set; }
        public virtual IList<Entidade_ItemPedido> ItemPedidos { get; set; }
    }
}
