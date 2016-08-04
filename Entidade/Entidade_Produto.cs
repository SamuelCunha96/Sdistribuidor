using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdistribuidor.Control;


namespace Sdistribuidor.Entidade
{
    public class Entidade_Produto
    {
        public Entidade_Produto()
        {
        }

        public long IdProduto { get; set; }
        public string NmProduto { get; set; }
        public Entidade_Grupo IdGrupo { get; set; }
        public Entidade_Unidade Unidade { get; set; }
        public string NCM { get; set; }
        public double VlPreco { get; set; }
        public double VlPreco2 { get; set; }
        public double VlPreco3 { get; set; }
        public double pesoitem { get; set; }
        public string codigoreferencia { get; set; }
        public string icms { get; set; }
        public string ipi { get; set; }
        public string pis { get; set; }
        public string cofins { get; set; }
        public int cfop_int { get; set; }
        public int cfop_ext { get; set; }

        public string UnidadeProd
        {
            get
            {
                return Unidade.Unidade;
            }
        }

        public virtual string VlPrecoFormatado
        {
            get
            {
                return string.Format("{0:N2}", VlPreco);
            }
        }
    }
}