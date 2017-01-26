using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_ContaPagar
    {
        public int id_contpag { get; set; }
        public Entidade_Participante participante { get; set; }
        public int id_grupocontpag { get; set; }
        public string nrdoc { get; set; }
        public DateTime dtemissao { get; set; }
        public DateTime dtvencimento { get; set; }
        public DateTime dtpagto { get; set; }
        public decimal vlparcela { get; set; }
        public string stparcela { get; set; }
    }
}
