using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_VWSaida
    {
        public int cdloja{get;set;} 
           public int nrnf{get;set;}
        public int nmserienf {get;set;}
        public int naturezaoperacao{get;set;}
        public DateTime dtsaida{get;set;}
        public int nrlote{get;set;}
        public string nmrazaosocial_emitente{get;set;}
        public string cdcpfcgc_emitente{get;set;}
        public string nrcgf_emitente{get;set;}
        public string nmender_emitente{get;set;}
        public string nrender_emitente{get;set;}
        public string nmbairro_emitente{get;set;}
        public string cdcep_emitente{get;set;}
        public string cduf_emitente{get;set;}
        public string cdufcidadeibge_emitente{get;set;}
        public string nmcidadeibge_emitente{get;set;}
        public string nmcliente_destinatario{get;set;}
        public string cdcpfcgc_destinatario{get;set;}
        public string nrcgf_destinatario{get;set;}
        public string nmender_destinatario{get;set;}
        public string nrender_destinatario{get;set;}
        public bool isento_destinatario{get;set;}
        public string nmbairro_destinatario{get;set;}
        public string cdcep_destinatario{get;set;}
        public string cduf_destinatario{get;set;}
        public string cdufcidadeibge_destinatario{get;set;}
        public string nmcidade_destinatario{get;set;}
        public decimal vlbaseicms{get;set;}
        public decimal vlicms {get;set;}
        public decimal vlbaseicmssub{get;set;}
        public decimal vlicmssub{get;set;}
        public decimal vlfrete{get;set;}
        public decimal vlseguro{get;set;}
        public decimal vldesconto{get;set;}
        public decimal vloutrasdesp{get;set;}
        public decimal vlipi{get;set;}
        public decimal vlprodutos{get;set;}
        public decimal vltotal{get;set;}
        public decimal vlpis{get;set;}
        public decimal vlcofins{get;set;}
        public string localentrega_nmcidade{get;set;}
        public string localentrega_nmbairro{get;set;}
        public string localentrega_cduf{get;set;}
        public string localentrega_cdufcidadeibge{get;set;}
        public string localentrega_nmender{get;set;}
        public string localentrega_nrender{get;set;}
        public string localentrega_nmcomplender{get;set;}
        public int freteporconta{get;set;}
        public string flfinalidade{get;set;}
        public bool flcartao{get;set;}
        public bool flavista {get;set;}
        public string observacao{get;set;}
        public string mensagemfisco{get;set;}
        public string mensagemcontribuinte{get;set;}
        public string txchacessonfe{get;set;}
        public string cdnfe{get;set;}
        public int modnfe { get; set; }
    }
}
