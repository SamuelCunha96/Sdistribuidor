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
        public double qt_estoque { get; set; }
        public double qt_reservado { get; set; }
    }
}
