using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.EntidadeView
{
    public class Entidade_CurvaABC
    {
        public int Id_produto { get; set; }
        public string Descricao { get; set; }
        public decimal Qtdvendido { get; set; }
        public decimal Vl_unitario { get; set; }
        public decimal TotalVendido { get; set; }
        public decimal Porcentagem { get; set; }
        public decimal PorcentagemAcumulada { get; set; }
        public string Classeabc { get; set; }
    }
}
