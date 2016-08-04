using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sdistribuidor.Entidade
{
    public class Entidade_TotaisNota
    {
        public Entidade_TotaisNota()
        {
        }
        public double TotaItem { get; set; }
        public double QtItem { get; set; }
        public double VlUnitario { get; set; }
        public double VlTotalBruto { get; set; }
        public double VlBaseIcms { get; set; }
        public double VlIcms { get; set; }
        public double VlBaseIcmsSub { get; set; }
        public double VlIcmsSub { get; set; }
        public double VlProdutos { get; set; }
        public double VlFrete { get; set; }
        public double VlSeguro { get; set; }
        public double VlOutrasDesp { get; set; }
        public double VlBaseIpi { get; set; }
        public double VlIpi { get; set; }
        public double VlNf { get; set; }
        public double VlDesconto { get; set; }
        public double VlAliqIpi { get; set; }
        public double VlAliqIcms { get; set; }
        public double VlAliqIcmsSub { get; set; }
        public double VlPesoTotal { get; set; }
        public double VlIcmsFrete { get; set; }
        public double VlFreteConhec { get; set; }
        public double VlBaseIcmsAnt { get; set; }
        public double VlIcmsAnt { get; set; }
    }
}
