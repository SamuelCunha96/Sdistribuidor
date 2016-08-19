using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdistribuidor.Entidade;

namespace Sdistribuidor.Control
{
    interface ICalculos
    {
        double SomarGeral(Entidade_TotaisNota _Totais);
        double SomarGeralItem(Entidade_TotaisNota _Totais);
        double BaseIcms(Entidade_TotaisNota _Totais);
        double BaseIcmsReduzida(Entidade_TotaisNota _Totais);
        double Icms(Entidade_TotaisNota _Totais);
        double BaseSubTriIcms(Entidade_TotaisNota _Totais);
        double IcmsSubTrib(Entidade_TotaisNota _Totais);
        double TotalProdutos(Entidade_TotaisNota _Totais);
        double ValorIpi(Entidade_TotaisNota _Totais);
        double ValorPis(Entidade_TotaisNota _Totais);
        double ValorCofins(Entidade_TotaisNota _Totais);

    }
}
