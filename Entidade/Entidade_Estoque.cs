using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_Estoque
    {
        public int id_Produto { get; set; }
        public decimal qt_estoque { get; set; }
        public decimal qt_reservado { get; set; }
        public string tpmov { get; set; }
        public string tpmovestoque { get; set; }
        public string obsestoque { get; set; }
        public string tptbmov { get; set; }
        
    }
}
