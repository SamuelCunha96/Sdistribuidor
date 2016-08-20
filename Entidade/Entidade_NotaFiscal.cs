using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_NotaFiscal
    {
        public int id_loja { get; set; }
        public string serienf { get; set; }
        public int nrnf { get; set; }
        public int id_participante { get; set; }
        public DateTime dtemissao { get; set; }
        public DateTime dtsaida { get; set; }
        public double vltotal { get; set; }
        public double vlbaseicms { get; set; }
        public double vlicms { get; set; }
        public double vlbaseicmssub { get; set; }
        public double vlicmssub { get; set; }
        public double vloutras { get; set; }
        public double vlfrete { get; set; }
        public double vlseguro { get; set; }
        public string txobsfisco { get; set; }
        public string txobscontribuinte { get; set; }
        public string txchacessonfe { get; set; }
        public string cnf { get; set; }
        public string tpemis { get; set; }
        public string cdv { get; set; }
        public string tpamb { get; set; }
        public string dhcontingencia { get; set; }
        public string xjust { get; set; }
        public int id_pedido { get; set; }
        public string flfinalidade { get; set; }
        public List<Entidade_ItemNFe> ItemNFe { get; set; }
    }
}
