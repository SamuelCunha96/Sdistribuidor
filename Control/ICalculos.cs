using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdistribuidor.Entidade;

namespace Sdistribuidor.Control
{
    interface ICalculos
    {
        decimal SomarGeral(Entidade_TotaisNota _Totais);
        decimal SomarGeralItem(Entidade_TotaisNota _Totais);
        decimal BaseIcms(Entidade_TotaisNota _Totais);
        decimal BaseIcmsReduzida(Entidade_TotaisNota _Totais);
        decimal Icms(Entidade_TotaisNota _Totais);
        decimal BaseSubTriIcms(Entidade_TotaisNota _Totais);
        decimal IcmsSubTrib(Entidade_TotaisNota _Totais);
        decimal TotalProdutos(Entidade_TotaisNota _Totais);
        decimal ValorIpi(Entidade_TotaisNota _Totais);
        decimal ValorPis(Entidade_TotaisNota _Totais);
        decimal ValorCofins(Entidade_TotaisNota _Totais);

    }
}
