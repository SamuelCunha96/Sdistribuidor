using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_Unidade
    {
        public Entidade_Unidade()
        { }

        public string CdUnidade { get; set; }
        public string Unidade { get; set; }

        public string UnidadeDesc
        {
            get
            {
                return CdUnidade + " - " + Unidade;
            }
        }
    }
}
