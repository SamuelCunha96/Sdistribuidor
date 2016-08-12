using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_Pedido
    {
        public int id_pedido { get; set; }
        public Entidade_Participante id_participante { get; set; }
        public Entidade_FormaPagto id_formpagto { get; set; }
        public Entidade_Vendedor id_usuario { get; set; }
        public DateTime dt_pedido { get; set; }
        public DateTime dt_preventrega { get; set; }
        public double vl_pedido { get; set; }
        public double vl_desconto { get; set; }
        public string stpedido { get; set; }
        public string stentrega { get; set; }
        public string obspedido { get; set; }
        public int id_localentrega { get; set; }
        public IList<Entidade_ItemPedido> ItemPedidos { get; set; }
    }
}
