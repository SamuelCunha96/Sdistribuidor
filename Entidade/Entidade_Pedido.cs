using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Entidade
{
    public class Entidade_Pedido
    {
        public int id_pedido { get; set; }
        public Entidade_Loja Loja { get; set; }
        public Entidade_Participante id_participante { get; set; }
        public Entidade_FormaPagto id_formpagto { get; set; }
        public Entidade_Vendedor id_usuario { get; set; }
        public DateTime dt_pedido { get; set; }
        public DateTime dt_preventrega { get; set; }
        public double vl_pedido { get; set; }
        public double vl_desconto { get; set; }
        public string stpedido { get; set; }
        public string stentrega { get; set; }
        public string obspedido { get; set; }
        public int id_localentrega { get; set; }
        public List<Entidade_ItemPedido> ItemPedidos { get; set; }



        public string LojaNomeFantasia
        {
            get
            {
                return Loja.nm_fantasia;
            }
        }
        public string LojaCnpj
        {
            get
            {
                return Loja.cnpj;
            }
        }
        public string LojaCep
        {
            get
            {
                return Loja.cep;
            }
        }
        public string LojaTelefone
        {
            get
            {
                return Loja.fone;
            }
        }

        public string ParticipanteNome
        {
            get
            {
                return id_participante.nome;
            }
        }
        public string ParticipanteCpfCnpj
        {
            get
            {
                return id_participante.cnpjcpf;
            }
        }
        public string ParticipanteEnderecoCompleto
        {
            get
            {
                return "Endereço" + id_participante.lagradouro + "," + id_participante.numero_end + " Bairro:" + id_participante.bairro + " Cidade:" + id_participante.id_cidade.desc_municipio + " UF:" + id_participante.id_uf.desc_uf;
            }
        }
    }
}
