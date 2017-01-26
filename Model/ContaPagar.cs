using Npgsql;
using Sdistribuidor.DAO;
using Sdistribuidor.Entidade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Model
{
    public class ContaPagar
    {
        NpgsqlCommand command;
        NpgsqlTransaction BeginTrans;
        public bool Incluir(List<Entidade_ContaPagar> ObjContaPagar, out string MsgErro)
        {
            BancoDados.OpenConection();
            BeginTrans = BancoDados.conexao.BeginTransaction();

            try
            {
                foreach (var conta in ObjContaPagar)
                {
                    command = new NpgsqlCommand("spincluircontapagar", BancoDados.conexao);
                    command.Transaction = BeginTrans;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_participante", conta.participante.id);
                    command.Parameters.AddWithValue("id_grupocontpag", conta.id_grupocontpag);
                    command.Parameters.AddWithValue("nrdoc", conta.nrdoc);
                    command.Parameters.AddWithValue("dtemissao", conta.dtemissao);
                    command.Parameters.AddWithValue("dtvencimento", conta.dtvencimento);
                    command.Parameters.AddWithValue("vlparcela", conta.vlparcela);
                    command.Parameters.AddWithValue("stparcela", conta.stparcela);

                    command.ExecuteNonQuery();
                }

                BeginTrans.Commit();
                BancoDados.CloseConection();

                MsgErro = string.Empty;
                return true;
            }
            catch (NpgsqlException ex)
            {
                MsgErro = ex.Message.ToString();
                BeginTrans.Rollback();
                return false;
            }
            catch (Exception ex)
            {
                MsgErro = ex.Message.ToString();
                BeginTrans.Rollback();
                return false;
            }
        }

        public bool ContaExiste(int idparticipante, string nrdoc)
        {
            return BancoDados.CodigoExiste("SELECT * FROM contapagar where nrdoc='" + nrdoc + "' AND id_participante=" + idparticipante);
        }

        public bool Cancelar(int idparticipante, string nrdoc, out string MsgErro)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("UPDATE contapagar SET stparcela = 'C' WHERE nrdoc='" + nrdoc + "' AND id_participante=" + idparticipante);
                MsgErro = string.Empty;
                return true;
            }
            catch(Exception ex)
            {
                MsgErro = ex.Message.ToString();
                return false;
            }
        }

        public bool Pagamento(int idconta, out string MsgErro)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("UPDATE contapagar SET stparcela = 'P' WHERE id_contpag=" + idconta);
                MsgErro = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                MsgErro = ex.Message.ToString();
                return false;
            }
        }
        public bool Estornar(int idconta, out string MsgErro)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("UPDATE contapagar SET stparcela = 'A' WHERE id_contpag=" + idconta);
                MsgErro = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                MsgErro = ex.Message.ToString();
                return false;
            }
        }
        /// <summary>
        /// Retorna apenas parcelas em Aberto
        /// </summary>
        /// <param name="DtIni"></param>
        /// <param name="DtFim"></param>
        /// <returns></returns>
        public DataTable Pesquisa(DateTime DtIni, DateTime DtFim, string stparcela = "A")
        {

            return BancoDados.Consultar(" SELECT C.*, \n" +
                                        " CASE \n" +
                                        "   WHEN length(btrim(P.cnpjcpf::text)) = 11 THEN P.nome \n" +
                                        "   WHEN length(btrim(P.cnpjcpf::text)) = 14 THEN P.nomefantasia \n" +
                                        "   ELSE NULL::character varying \n" +
                                        " END AS partnome, \n" +
                                        " G.desc_financeiro \n" +
                                        " FROM \n" +
                                        " contapagar C \n" +
                                        " INNER JOIN participante P ON C.id_participante = p.id_participante \n" +
                                        " INNER JOIN grupofinanc G ON G.id_grupocontpag = C.id_grupocontpag \n" +
                                        " WHERE dtvencimento between '" + string.Format("{0:dd/MM/yyyy}", DtIni) + "' AND  '" + string.Format("{0:dd/MM/yyyy}", DtFim) + "'\n" +
                                        " AND stparcela = '"+ stparcela +"'");
        }
        /// <summary>
        /// Documentos em Aberto - Usando o Disctinct
        /// </summary>
        /// <param name="DtIni"></param>
        /// <param name="DtFim"></param>
        /// <returns></returns>
        public DataTable DocumentosEmAberto(DateTime DtIni, DateTime DtFim)
        {
            return BancoDados.Consultar(" SELECT Distinct C.nrdoc, C.id_participante,\n" +
                                        " CASE \n"+
                                        "    WHEN length(btrim(P.cnpjcpf::text)) = 11 THEN P.nome \n" +
                                        "    WHEN length(btrim(P.cnpjcpf::text)) = 14 THEN P.nomefantasia \n" +
                                        "    ELSE NULL::character varying \n" +
                                        " END AS partnome, \n" +
                                        " G.desc_financeiro \n" +
                                        " FROM \n" +
                                        " contapagar C \n" +
                                        " INNER JOIN participante P ON C.id_participante = p.id_participante \n" +
                                        " INNER JOIN grupofinanc G ON G.id_grupocontpag = C.id_grupocontpag \n " +
                                        " WHERE dtvencimento between '" + string.Format("{0:dd/MM/yyyy}", DtIni) + "' AND  '" + string.Format("{0:dd/MM/yyyy}", DtFim) + "'\n" +
                                        " AND StParcela = 'A'");
        }

        public bool ExistePagamento(string NrDoc)
        {
            return BancoDados.CodigoExiste("SELECT * FROM  contapagar WHERE nrdoc='" + NrDoc.Trim() + "' AND StParcela = 'P'");
        }
    }
}
