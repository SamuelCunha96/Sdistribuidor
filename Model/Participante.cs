using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using System.Data;
using Sdistribuidor.DAO;

namespace Sdistribuidor.Model
{
    public class Participante
    {
        Entidade_Participante entPart;
        public DataTable Pesquisa()
        {
            return BancoDados.Consultar("SELECT * FROM participante order by Nome");
        }
        public int MaxID()
        {
            return 0;
        }
        public Entidade_Participante Pesquisa(int ID)
        {
            entPart = new Entidade_Participante();

            var Dt = BancoDados.Consultar("SELECT * FROM participante WHERE id_participante = " + ID);

            if (Dt.Rows.Count > 0)
            {
                entPart.id = Convert.ToInt32(Dt.Rows[0]["id_participante"]);
                entPart.nome = Dt.Rows[0]["nome"].ToString();
                entPart.cnpjcpf = Dt.Rows[0]["cnpjcpf"].ToString();
                entPart.ie = Dt.Rows[0]["ie"].ToString();
                entPart.razaosocial = Dt.Rows[0]["razaosocial"].ToString();
                entPart.nomefantasia = Dt.Rows[0]["nomefantasia"].ToString();
                entPart.lagradouro = Dt.Rows[0]["lagradouro"].ToString();
                entPart.numero_end = Dt.Rows[0]["numero_end"].ToString();
                entPart.bairro = Dt.Rows[0]["bairro"].ToString();
                //entPart.id_uf = Dt.Rows[0]["id_uf"].ToString();
                //entPart.id_cidade = Dt.Rows[0]["cidade"].ToString();
                entPart.telefone = Dt.Rows[0]["telefone"].ToString();
                entPart.flcomercio = Convert.ToBoolean(Dt.Rows[0]["flcomercio"]);
                return entPart;
            }
            return null;
        }
        public List<Entidade_Participante> Pesquisa(string Nome)
        {
            List<Entidade_Participante> ListParticipante = new List<Entidade_Participante>();

            var Dt = BancoDados.Consultar("SELECT * FROM participante WHERE nome like '%" + Nome + "%'");

            if (Dt.Rows.Count > 0)
            {
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    entPart = new Entidade_Participante();

                    entPart.id = Convert.ToInt32(Dt.Rows[i]["id_participante"]);
                    entPart.nome = Dt.Rows[i]["nome"].ToString();
                    entPart.cnpjcpf = Dt.Rows[i]["cnpjcpf"].ToString();
                    entPart.ie = Dt.Rows[i]["ie"].ToString();
                    entPart.razaosocial = Dt.Rows[i]["razaosocial"].ToString();
                    entPart.nomefantasia = Dt.Rows[i]["nomefantasia"].ToString();
                    entPart.lagradouro = Dt.Rows[i]["lagradouro"].ToString();
                    entPart.numero_end = Dt.Rows[i]["numero_end"].ToString();
                    entPart.bairro = Dt.Rows[i]["bairro"].ToString();
                    //entPart.id_uf = Dt.Rows[i]["id_uf"].ToString();
                    //entPart.id_cidade = Dt.Rows[i]["cidade"].ToString();
                    entPart.telefone = Dt.Rows[i]["telefone"].ToString();
                    entPart.flcomercio = Convert.ToBoolean(Dt.Rows[i]["flcomercio"]);

                    ListParticipante.Add(entPart);
                }
            }
            return ListParticipante;
        }
        public bool Incluir(Entidade_Participante Obj)
        {
            return true;
        }
        public bool Update(Entidade_Participante Obj)
        {
            return true;
        }
        public bool Delete(Entidade_Participante Obj)
        {
            return true;
        }
    }
}
