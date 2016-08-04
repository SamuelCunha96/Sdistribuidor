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

        public virtual int id { get; set; }
        public virtual string nome { get; set; }
        public virtual string cnpjcpf { get; set; }
        public virtual string ie { get; set; }
        public virtual string razaosocial { get; set; }
        public virtual string nomefantasia { get; set; }
        public virtual string lagradouro { get; set; }
        public virtual string numero_end { get; set; }
        public virtual string bairro { get; set; }
        public virtual Entidade_Cidade id_cidade { get; set; }
        public virtual Entidade_UF id_uf { get; set; }
        public virtual string telefone { get; set; }
        public virtual bool flcomercio { get; set; }

        public virtual string ParticipanteNomeCpfCnpj
        {
            get
            {
                return nome + " [" + cnpjcpf + "]";
            }
        }
    }
}
