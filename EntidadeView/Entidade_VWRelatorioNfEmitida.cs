using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.EntidadeView
{
    public class Entidade_VWRelatorioNfEmitida
    {
        public int id_loja { get; set; }
        public string serienf { get; set; }
        public decimal nrnf { get; set; }
        public decimal partnome { get; set; }
        public decimal dtemissao { get; set; }
        public decimal dtsaida { get; set; }
        public decimal vltotal { get; set; }
        public decimal vlbaseicms { get; set; }
        public decimal vlicms { get; set; }
        public decimal vlbaseicmssub { get; set; }
        public decimal vlicmssub { get; set; }
        public decimal vloutras { get; set; }
        public decimal vlfrete { get; set; }
        public decimal vlseguro { get; set; }
        public string txchacessonfe { get; set; }
        public string flfinalidade { get; set; }
        public int cdretorno { get; set; }

    }
}
