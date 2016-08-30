using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_Participante
    {
        public Entidade_Participante()
        { }

        public int id { get; set; }
        public string nome { get; set; }
        public string cnpjcpf { get; set; }
        public string ie { get; set; }
        public string razaosocial { get; set; }
        public string nomefantasia { get; set; }
        public string lagradouro { get; set; }
        public string numero_end { get; set; }
        public string bairro { get; set; }
        public Entidade_Cidade id_cidade { get; set; }
        public Entidade_UF id_uf { get; set; }
        public string telefone { get; set; }
        public bool flcomercio { get; set; }
        public bool flisento { get; set; }
        public string cep { get; set; }

        public List<Entidade_LocalEntrega> ListLocalEntrega { get; set; }
        
        public string ParticipanteNomeCpfCnpj
        {
            get
            {
                return nome + " [" + cnpjcpf + "]";
            }
        }
    }
}
