using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_Fatura
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataFatura { get; set; }
        public int QtDias { get; set; }
        public double Valor { get; set; }
    }
}
