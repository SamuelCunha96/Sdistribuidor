using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_Duplicata
    {
        public int id { get; set; }
        public Entidade_Participante participante { get; set; }
        public Entidade_FormaPagto formapagto { get; set; }
        public int idpedido { get; set; }
        public DateTime DtEmissao { get; set; }
        public DateTime DtVencto { get; set; }
        public decimal VlParcela { get; set; }
        public string StParcela { get; set; }
    }
}
