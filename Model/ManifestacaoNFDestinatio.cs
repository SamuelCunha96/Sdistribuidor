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
    public class ManifestacaoNFDestinatio
    {
        NpgsqlTransaction BeginTrans;
        /// <summary>
        /// Confirmar Operação, para notas sem manifestação
        /// </summary>
        /// <returns></returns>
        public DataTable ConsultarNFDestinarioSemManifestação()
        {
            return BancoDados.Consultar(" SELECT *, formatachaveacessonfe(chacessonfe) as chacessonfeformatada," +
                                        " case "+
                                             " when sitnfe = '1' then " +
                                             " 'Uso autorizado no momento da consulta' " +
                                             " when sitnfe = '2' then " +
                                             " 'Uso denegado' " +
                                             " when sitnfe = '3' then " +
                                             " 'NF-e cancelada' " +
                                             " else " +
                                             " '' " +
                                        " end as descsitnfe " +
                                        " FROM itemconsultanfdest ic WHERE NOT EXISTS (SELECT * FROM itemmanifestacao im WHERE ic.chacessonfe = im.txchacessonfe)");
        }
        public DataTable ConsultarNFDestinarioCiencieEmissao()
        {
            return BancoDados.Consultar("SELECT * FROM itemmanifestacao im WHERE ic.chacessonfe = im.txchacessonfe AND ic.codmanifestacao=210210");
        }
        public DataTable ConsultarNFDestinarioDesconhecimentoOperacao()
        {
            return BancoDados.Consultar("SELECT * FROM itemmanifestacao im WHERE ic.chacessonfe = im.txchacessonfe AND ic.codmanifestacao=210220");
        }
        public DataTable ConsultarNFDestinarioOperacaoNaoRealizada()
        {
            return BancoDados.Consultar("SELECT * FROM itemmanifestacao im WHERE ic.chacessonfe = im.txchacessonfe AND ic.codmanifestacao=210240");
        }

        public bool IncluirManifestacao(Entidade_Manifestacao ObjManifestacao, out string messagemerro)
        {
            try
            {
                BancoDados.OpenConection();
                NpgsqlCommand command;
                BeginTrans = BancoDados.conexao.BeginTransaction();

                command = new NpgsqlCommand("spincluirmanifestacaodestinatario", BancoDados.conexao);
                command.Transaction = BeginTrans;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id_loja", ObjManifestacao.id_loja);
                command.Parameters.AddWithValue("dtmanifestacao", ObjManifestacao.dtManifestacao);
                command.Parameters.AddWithValue("tipo_ambiente", ObjManifestacao.tipo_ambiente);

                var Id = command.ExecuteScalar();

                foreach (var item in ObjManifestacao.ListNfeManifestacao)
                {
                    command = new NpgsqlCommand("spincluiritemmanifestacao", BancoDados.conexao);
                    command.Transaction = BeginTrans;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("idmanifestacao", Convert.ToInt32(Id));
                    command.Parameters.AddWithValue("idseq", item.idseq);
                    command.Parameters.AddWithValue("txchacessonfe", item.chaveacesso);
                    command.Parameters.AddWithValue("codmanifestacao", item.codmanifestacao);
                    command.ExecuteNonQuery();
                }

                BeginTrans.Commit();

                BancoDados.CloseConection();

                messagemerro = string.Empty;
                return true;
            }
            catch(Exception Ex)
            {
                BeginTrans.Rollback();
                messagemerro = Ex.Message.ToString();
                return false;
            }
        }
    }
}
