using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_RecebCaixa
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public double ValorReceb { get; set; }
        public int IdCartaoCredito { get; set; }
        public DateTime DtReceb { get; set; }
    }
}