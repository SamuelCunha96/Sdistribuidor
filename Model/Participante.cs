using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using System.Data;
using Sdistribuidor.DAO;
using Npgsql;

namespace Sdistribuidor.Model
{
    public class Participante
    {

        NpgsqlCommand command;
        NpgsqlTransaction BeginTrans;

        UF modUF;
        Cidade modCidade;

        Entidade_Participante entPart;
        Entidade_LocalEntrega entLocEnt;

        List<Entidade_LocalEntrega> ListLocalEnt = new List<Entidade_LocalEntrega>();

        public DataTable Pesquisa()
        {
            return BancoDados.Consultar("SELECT *,spretornodescuf(id_uf) as uf FROM participante order by Nome");
        }
        public int MaxID()
        {
            return 0;
        }
        public Entidade_Participante Pesquisa(int ID)
        {
            entPart = new Entidade_Participante();


            modUF = new UF();
            modCidade = new Cidade();

            var Dt = BancoDados.Consultar("SELECT * FROM participante WHERE id_participante = " + ID);

            var DtEnt = BancoDados.Consultar("SELECT * FROM localentrega WHERE id_participante = " + ID);

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
                entPart.id_uf = modUF.Pesquisa(Convert.ToInt32(Dt.Rows[0]["id_uf"].ToString()));
                entPart.id_cidade = modCidade.Pesquisa(Convert.ToInt32(Dt.Rows[0]["cidade"]));
                entPart.telefone = Dt.Rows[0]["telefone"].ToString();
                entPart.flcomercio = Convert.ToBoolean(Dt.Rows[0]["flcomercio"]);
            }

            if (DtEnt.Rows.Count > 0)
            {
                for (int i = 0; i < DtEnt.Rows.Count; i++)
                {
                    entLocEnt = new Entidade_LocalEntrega();
                    entLocEnt.id = Convert.ToInt32(DtEnt.Rows[i]["id"]);
                    entLocEnt.id_participante = Convert.ToInt32(DtEnt.Rows[i]["id_participante"]);
                    entLocEnt.lagradouro = DtEnt.Rows[i]["lagradouro"].ToString();
                    entLocEnt.end_numero = DtEnt.Rows[i]["end_numero"].ToString();
                    entLocEnt.bairro = DtEnt.Rows[i]["bairro"].ToString();
                    if(DtEnt.Rows[i]["id_uf"] != null)
                        entLocEnt.id_uf = modUF.Pesquisa(Convert.ToInt32(DtEnt.Rows[i]["id_uf"].ToString()));
                    if(DtEnt.Rows[i]["id_cidade"] != null)
                        entLocEnt.id_cidade = modCidade.Pesquisa(Convert.ToInt32(DtEnt.Rows[i]["id_cidade"]));
                    entLocEnt.telefone = DtEnt.Rows[i]["telefone"].ToString();
                    entLocEnt.obs = DtEnt.Rows[i]["obs"].ToString();
                    ListLocalEnt.Add(entLocEnt);
                }
            }

            if (DtEnt.Rows.Count > 0)
            {
                entPart.ListLocalEntrega = ListLocalEnt;
                return entPart;
            }
            else
            {
                if (Dt.Rows.Count > 0)
                {
                    entPart.ListLocalEntrega = ListLocalEnt;
                    return entPart;
                }
                else
                    return null;
            }

        }
        public Entidade_Participante PesquisaCnpj(string cnpjcpf)
        {
            entPart = new Entidade_Participante();


            modUF = new UF();
            modCidade = new Cidade();
            
            var Dt = BancoDados.Consultar("SELECT * FROM participante WHERE cnpjcpf = '" + cnpjcpf + "'");

            var DtEnt = BancoDados.Consultar("SELECT * FROM localentrega WHERE id_participante = " + Dt.Rows[0]["id_participante"].ToString());

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
                entPart.id_uf = modUF.Pesquisa(Convert.ToInt32(Dt.Rows[0]["id_uf"].ToString()));
                entPart.id_cidade = modCidade.Pesquisa(Convert.ToInt32(Dt.Rows[0]["cidade"]));
                entPart.telefone = Dt.Rows[0]["telefone"].ToString();
                entPart.flcomercio = Convert.ToBoolean(Dt.Rows[0]["flcomercio"]);
            }

            if (DtEnt.Rows.Count > 0)
            {
                for (int i = 0; i < DtEnt.Rows.Count; i++)
                {
                    entLocEnt = new Entidade_LocalEntrega();
                    entLocEnt.id = Convert.ToInt32(DtEnt.Rows[i]["id"]);
                    entLocEnt.id_participante = Convert.ToInt32(DtEnt.Rows[i]["id_participante"]);
                    entLocEnt.lagradouro = DtEnt.Rows[i]["lagradouro"].ToString();
                    entLocEnt.end_numero = DtEnt.Rows[i]["end_numero"].ToString();
                    entLocEnt.bairro = DtEnt.Rows[i]["bairro"].ToString();
                    if (DtEnt.Rows[i]["id_uf"] != null)
                        entLocEnt.id_uf = modUF.Pesquisa(Convert.ToInt32(DtEnt.Rows[i]["id_uf"].ToString()));
                    if (DtEnt.Rows[i]["id_cidade"] != null)
                        entLocEnt.id_cidade = modCidade.Pesquisa(Convert.ToInt32(DtEnt.Rows[i]["id_cidade"]));
                    entLocEnt.telefone = DtEnt.Rows[i]["telefone"].ToString();
                    entLocEnt.obs = DtEnt.Rows[i]["obs"].ToString();
                    ListLocalEnt.Add(entLocEnt);
                }
            }

            if (DtEnt.Rows.Count > 0)
            {
                entPart.ListLocalEntrega = ListLocalEnt;
                return entPart;
            }
            else
            {
                if (Dt.Rows.Count > 0)
                {
                    entPart.ListLocalEntrega = ListLocalEnt;
                    return entPart;
                }
                else
                    return null;
            }

        }
        public List<Entidade_Participante> Pesquisa(string Nome)
        {
            List<Entidade_Participante> ListParticipante = new List<Entidade_Participante>();

            modUF = new UF();
            modCidade = new Cidade();

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
                    entPart.id_uf = modUF.Uf(Dt.Rows[0]["id_uf"].ToString());
                    entPart.id_cidade = modCidade.Pesquisa(Convert.ToInt32(Dt.Rows[0]["cidade"]));
                    entPart.telefone = Dt.Rows[i]["telefone"].ToString();
                    entPart.flcomercio = Convert.ToBoolean(Dt.Rows[i]["flcomercio"]);

                    ListParticipante.Add(entPart);
                }
            }
            return ListParticipante;
        }
        public bool Incluir(Entidade_Participante Obj, List<Entidade_LocalEntrega> LsLocalEntrega)
        {
            StringBuilder sb;
            BancoDados.OpenConection();
            BeginTrans = BancoDados.conexao.BeginTransaction();
            try
            {
                #region INCLUINDO PARTICIPANTE
                command = new NpgsqlCommand("spincluirparticipante", BancoDados.conexao);
                command.Transaction = BeginTrans;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("nome", Obj.nome);
                command.Parameters.AddWithValue("cnpjcpf", Obj.cnpjcpf);
                command.Parameters.AddWithValue("ie", Obj.ie);
                command.Parameters.AddWithValue("razaosocial", Obj.razaosocial.Substring(0,39));
                command.Parameters.AddWithValue("nomefantasia", Obj.nomefantasia);
                command.Parameters.AddWithValue("lagradouro", Obj.lagradouro);
                command.Parameters.AddWithValue("numero_end", Obj.numero_end);
                command.Parameters.AddWithValue("bairro", Obj.bairro);
                command.Parameters.AddWithValue("id_uf", Obj.id_uf.id_uf);
                command.Parameters.AddWithValue("cidade", Obj.id_cidade.id);
                command.Parameters.AddWithValue("telefone", Obj.telefone);
                command.Parameters.AddWithValue("flcomercio", Obj.flcomercio);
                command.Parameters.AddWithValue("flisento", Obj.flisento);
                command.Parameters.AddWithValue("cep", Obj.cep);

                var Id = command.ExecuteScalar();

                #endregion

                if (LsLocalEntrega != null)
                {
                    foreach (var item in LsLocalEntrega)
                    {
                        sb = new StringBuilder();
                        if (item.FlExcluirLocalEntrega == false)
                        {
                            sb.Append(" INSERT INTO localentrega (id_participante,lagradouro,end_numero,bairro,id_uf,id_cidade,telefone,obs) " +
                                      " VALUES " +
                                      " (@id_participante,@lagradouro,@end_numero,@bairro,@id_uf,@id_cidade,@telefone,@obs)");


                            command = new NpgsqlCommand(sb.ToString(), BancoDados.conexao);
                            command.Transaction = BeginTrans;
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@id_participante", Convert.ToInt32(Id));
                            command.Parameters.AddWithValue("@lagradouro", item.lagradouro);
                            command.Parameters.AddWithValue("@end_numero", item.end_numero);
                            command.Parameters.AddWithValue("@bairro", item.bairro);
                            command.Parameters.AddWithValue("@id_uf", item.id_uf);
                            command.Parameters.AddWithValue("@id_cidade", item.id_cidade);
                            command.Parameters.AddWithValue("@telefone", item.telefone);
                            command.Parameters.AddWithValue("@obs", item.obs);

                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            sb.Append("DELETE FROM localentrega WHERE id = @id AND id_participante = @id_participante");

                            command = new NpgsqlCommand(sb.ToString(), BancoDados.conexao);
                            command.Transaction = BeginTrans;
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@id", Convert.ToInt32(item.id));
                            command.Parameters.AddWithValue("@id_participante", Convert.ToInt32(item.id_participante));

                            command.ExecuteNonQuery();
                        }
                    }
                }
                BeginTrans.Commit();
                return true;
            }
            catch (Exception Ex)
            {
                BeginTrans.Rollback();
                return false;
            }
        }
        public bool Update(Entidade_Participante Obj, List<Entidade_LocalEntrega> LsLocalEntrega)
        {
            StringBuilder sb;
            BancoDados.OpenConection();
            BeginTrans = BancoDados.conexao.BeginTransaction();
            try
            {

                #region ALTERAR PARTICIPANTE

                command = new NpgsqlCommand("spalterarparticipante", BancoDados.conexao);
                command.Transaction = BeginTrans;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id", Obj.id);
                command.Parameters.AddWithValue("nome", Obj.nome);
                command.Parameters.AddWithValue("cnpjcpf", Obj.cnpjcpf);
                command.Parameters.AddWithValue("ie", Obj.ie);
                command.Parameters.AddWithValue("razaosocial", Obj.razaosocial);
                command.Parameters.AddWithValue("nomefantasia", Obj.nomefantasia);
                command.Parameters.AddWithValue("lagradouro", Obj.lagradouro);
                command.Parameters.AddWithValue("numero_end", Obj.lagradouro);
                command.Parameters.AddWithValue("bairro", Obj.bairro);
                command.Parameters.AddWithValue("id_uf", Obj.id_uf.id_uf);
                command.Parameters.AddWithValue("cidade", Obj.id_cidade.id);
                command.Parameters.AddWithValue("telefone", Obj.telefone);
                command.Parameters.AddWithValue("flcomercio", Obj.flcomercio);
                command.Parameters.AddWithValue("flisento", Obj.flisento);
                command.Parameters.AddWithValue("cep", Obj.cep);

                command.ExecuteNonQuery();

                #endregion

                foreach (var item in LsLocalEntrega)
                {
                    sb = new StringBuilder();
                    if (item.FlExcluirLocalEntrega == false)
                    {
                        sb.Append(" INSERT INTO localentrega (id_participante,lagradouro,end_numero,bairro,id_uf,id_cidade,telefone,obs) " +
                                  " VALUES " +
                                  " (@id_participante,@lagradouro,@end_numero,@bairro,@id_uf,@id_cidade,@telefone,@obs)");


                        command = new NpgsqlCommand(sb.ToString(), BancoDados.conexao);
                        command.Transaction = BeginTrans;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id_participante", Obj.id);
                        command.Parameters.AddWithValue("@lagradouro", item.lagradouro);
                        command.Parameters.AddWithValue("@end_numero", item.end_numero);
                        command.Parameters.AddWithValue("@bairro", item.bairro);
                        command.Parameters.AddWithValue("@id_uf", item.id_uf.id_uf);
                        command.Parameters.AddWithValue("@id_cidade", item.id_cidade.id);
                        command.Parameters.AddWithValue("@telefone", item.telefone);
                        command.Parameters.AddWithValue("@obs", item.obs);

                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        sb.Append("DELETE FROM localentrega WHERE id = @id");

                        command = new NpgsqlCommand(sb.ToString(), BancoDados.conexao);
                        command.Transaction = BeginTrans;
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id", Convert.ToInt32(item.id));

                        command.ExecuteNonQuery();
                    }
                }
                BeginTrans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                BeginTrans.Rollback();
                return false;
            }
        }
        public bool Delete(Entidade_Participante Obj)
        {
            return true;
        }

        public bool ParticipanteExiste(string cnpj)
        {
            return BancoDados.CodigoExiste("SELECT id_participante FROM participante where cnpjcpf = '"+ cnpj +"'");
        }
    }
}

