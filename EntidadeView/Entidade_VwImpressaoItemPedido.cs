using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.EntidadeView
{
    public class Entidade_VwImpressaoItemPedido
    {
        public string id_produto { get; set; }
        public string descricao { get; set; }
        public string cdunidade { get; set; }
        public decimal qt_pedido { get; set; }
        public decimal vl_unitario { get; set; }
        public decimal vl_desconto { get; set; }
        public decimal total { get; set; }
    }
}
