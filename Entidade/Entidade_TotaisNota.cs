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
        public decimal TotaItem { get; set; }
        public decimal QtItem { get; set; }
        public decimal VlUnitario { get; set; }
        public decimal VlTotalBruto { get; set; }
        public decimal VlBaseIcms { get; set; }
        public decimal VlIcms { get; set; }
        public decimal VlBaseIcmsSub { get; set; }
        public decimal VlIcmsSub { get; set; }
        public decimal VlProdutos { get; set; }
        public decimal VlFrete { get; set; }
        public decimal VlSeguro { get; set; }
        public decimal VlOutrasDesp { get; set; }
        public decimal VlBaseIpi { get; set; }
        public decimal VlIpi { get; set; }
        public decimal VlNf { get; set; }
        public decimal VlDesconto { get; set; }
        public decimal VlAliqIpi { get; set; }
        public decimal VlAliqIcms { get; set; }
        public decimal VlAliqIcmsSub { get; set; }
        public decimal VlPesoTotal { get; set; }
        public decimal VlIcmsFrete { get; set; }
        public decimal VlFreteConhec { get; set; }
        public decimal VlBaseIcmsAnt { get; set; }
        public decimal VlIcmsAnt { get; set; }
        public decimal VlPis { get; set; }
        public decimal VlCofins { get; set; }
        public decimal VlTrib { get; set; }
    }
}
