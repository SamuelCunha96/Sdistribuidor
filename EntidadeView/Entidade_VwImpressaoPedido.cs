using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.EntidadeView
{
    public class Entidade_VwImpressaoPedido
    {
        public string lojanomefantasia { get; set; }
        public string lojacnpj { get; set; }
        public string lojacep { get; set; }
        public string lojatelefone { get; set; }
        public string partcnpjcpf { get; set; }
        public string partnome { get; set; }
        public string partlagradouro { get; set; }
        public string partnumero { get; set; }
        public string partbairro { get; set; }
        public string partuf { get; set; }
        public string parttelefone { get; set; }
        public string partcep { get; set; }
        public int id_pedido { get; set; }
        public string desc_formapagto { get; set; }
        public string obspedido { get; set; }
        public decimal vl_pedido { get; set; }
        public decimal vl_desconto { get; set; }
        public DateTime dt_pedido { get; set; }
    }
}
