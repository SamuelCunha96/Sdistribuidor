﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    
    public class Entidade_ItemPedido
    {
        public int id_item_pedido { get; set; }
        public double Qt_Pedido { get; set; }
        public double qt_pedido_conv { get; set; }
        public double Vl_Unitario { get; set; }
        public double Vl_Desconto { get; set; }
        public string cdunidade_conv { get; set; }
        public Entidade_Unidade CdUnidade { get; set; }
        public Entidade_Pedido id_pedido { get; set; }
        public Entidade_Produto id_produto { get; set; }
    }
}
