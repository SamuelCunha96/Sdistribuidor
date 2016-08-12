using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Control;

namespace Sdistribuidor.Entidade
{
    public class Entidade_Vendedor
    {
        C_ModuloGeral cMod = new C_ModuloGeral();
        public int id_vendedor { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string telefoneFormatado
        {
            get
            {
                return cMod.FormatFONE(telefone);
            }
        }
        public decimal perc_comissao { get; set; }
    }
}
