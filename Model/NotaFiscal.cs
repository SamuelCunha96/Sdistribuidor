using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;
using Npgsql;
using System.Data;

namespace Sdistribuidor.Model
{
    public class NotaFiscal
    {
        NpgsqlCommand command;
        NpgsqlTransaction BeginTrans;


        #region SALVAR
        public bool Salvar(Entidade_NotaFiscal EntNotaFiscal)
        {
            BancoDados.OpenConection();
            BeginTrans = BancoDados.conexao.BeginTransaction();
            try
            {

                command = new NpgsqlCommand("spincluirnfe", BancoDados.conexao);
                command.Transaction = BeginTrans;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id_loja", EntNotaFiscal.id_loja);
                command.Parameters.AddWithValue("serienf", EntNotaFiscal.serienf);
                command.Parameters.AddWithValue("nrnf", EntNotaFiscal.nrnf);
                command.Parameters.AddWithValue("id_participante", EntNotaFiscal.id_participante.id);
                command.Parameters.AddWithValue("dtemissao", EntNotaFiscal.dtemissao);
                command.Parameters.AddWithValue("dtsaida", EntNotaFiscal.dtsaida);
                command.Parameters.AddWithValue("vltotal", EntNotaFiscal.vltotal);
                command.Parameters.AddWithValue("vlbaseicms", EntNotaFiscal.vlbaseicms);
                command.Parameters.AddWithValue("vlicms ", EntNotaFiscal.vlicms);
                command.Parameters.AddWithValue("vlbaseicmssub", EntNotaFiscal.vlbaseicmssub);
                command.Parameters.AddWithValue("vlicmssub", EntNotaFiscal.vlicmssub);
                command.Parameters.AddWithValue("vloutras", EntNotaFiscal.vloutras);
                command.Parameters.AddWithValue("vlfrete", EntNotaFiscal.vlfrete);
                command.Parameters.AddWithValue("vlseguro", EntNotaFiscal.vlseguro);
                command.Parameters.AddWithValue("txobsfisco", EntNotaFiscal.txobsfisco);
                command.Parameters.AddWithValue("txobscontribuinte", EntNotaFiscal.txobscontribuinte);
                command.Parameters.AddWithValue("id_pedido", EntNotaFiscal.id_pedido);
                command.Parameters.AddWithValue("flfinalidade", EntNotaFiscal.flfinalidade.ToString());
                command.Parameters.AddWithValue("id_localentrega", EntNotaFiscal.id_localentrega);
                command.Parameters.AddWithValue("id_formapagto", EntNotaFiscal.id_formapagto);

                command.ExecuteNonQuery();

                foreach (var item in EntNotaFiscal.ItemNFe)
                {
                    command = new NpgsqlCommand("spincluiritemnfsaida", BancoDados.conexao);
                    command.Transaction = BeginTrans;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_loja", EntNotaFiscal.id_loja);
                    command.Parameters.AddWithValue("serienf", EntNotaFiscal.serienf);
                    command.Parameters.AddWithValue("nrnf", EntNotaFiscal.nrnf);
                    command.Parameters.AddWithValue("id_produto", Convert.ToInt32(item.IdProduto));
                    command.Parameters.AddWithValue("qt_venda", Convert.ToDecimal(item.qt_venda));
                    command.Parameters.AddWithValue("vlunitario", Convert.ToDecimal(item.VlPreco));
                    command.Parameters.AddWithValue("vlbaseicms", item.vlbaseicms);
                    command.Parameters.AddWithValue("vlicms", item.vlicms);
                    command.Parameters.AddWithValue("vlbaseicmssub", item.vlbaseicmssub);
                    command.Parameters.AddWithValue("vlicmssub", item.vlicmssub);
                    command.Parameters.AddWithValue("vloutras", item.vloutras);
                    command.Parameters.AddWithValue("cfop", item.cfop);
                    command.Parameters.AddWithValue("csticms", item.icms);
                    command.Parameters.AddWithValue("cstipi", item.ipi);
                    command.Parameters.AddWithValue("cstpis", item.pis);
                    command.Parameters.AddWithValue("cstcofins", item.cofins);
                    command.Parameters.AddWithValue("vlaliqicms", item.vlAliqIcms);
                    command.Parameters.AddWithValue("vlaliqipi", item.vlAliqIpi);
                    command.Parameters.AddWithValue("vlpis", item.vlPis);
                    command.Parameters.AddWithValue("vlcofins", item.vlCofins);
                    command.Parameters.AddWithValue("vlipi", item.vlIpi);
                    command.Parameters.AddWithValue("vldesconto", item.vlDesconto);
                    command.ExecuteNonQuery();


                    command = new NpgsqlCommand("spmovimentacaoestoque", BancoDados.conexao);
                    command.Transaction = BeginTrans;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_loja", EntNotaFiscal.id_loja);
                    command.Parameters.AddWithValue("id_produto", Convert.ToInt32(item.IdProduto));
                    command.Parameters.AddWithValue("qtmovimentada", Convert.ToDecimal(item.qt_venda));
                    command.Parameters.AddWithValue("tpmov", "S");
                    command.Parameters.AddWithValue("dtmovimentacao", EntNotaFiscal.dtemissao);
                    command.Parameters.AddWithValue("obsmovimentacao", "NOTA FISCAL:" + EntNotaFiscal.serienf + " - " + EntNotaFiscal.nrnf); 

                    command.ExecuteNonQuery();
                }

                BeginTrans.Commit();

                BancoDados.CloseConection();

                BancoDados.InsertAlterarExcluir("UPDATE pedido set stpedido='N' WHERE id_pedido=" + EntNotaFiscal.id_pedido + "");
                
                return true;

            }
            catch (Exception Ex)
            {
                BeginTrans.Rollback();
                return false;
            }
        }
        #endregion

        public DataTable PesquisaNFe(string sVrSql)
        {
            return BancoDados.Consultar(" SELECT id_loja,serienf,nrnf, p.nome,n.txchacessonfe,n.cdretorno,dtemissao,n.vltotal,n.cdretorno " +
                                        " FROM nfsaida N " +
                                        " INNER JOIN participante p on n.id_participante = p.id_participante " +
                                        " WHERE "+ sVrSql);
        }

        public DataTable PesquisaNFe(string serienf,int nrnf)
        {
            return BancoDados.Consultar(" SELECT * " +
                                        " FROM vw_nfesaida" +
                                        " WHERE nmserienf ='" + serienf + "' AND nrnf =" + nrnf);
        }

        public DataTable PesquisaItemNFe(string serienf, int nrnf)
        {
            return BancoDados.Consultar(" SELECT codigodoproduto as IdProduto,descricaodoproduto as nmproduto,ncm,csticms as icms,cfop,und as Unidade,quantidade as qt_venda,valorunitario as VlPreco,valortotalicms as VlBaseIcms,valoricms as vlicms,valoripi as vlipi,icms as vlAliqicms,ipi as vlAliqipi " +
                                        " FROM vw_itemnfesaida" +
                                        " WHERE nmserienf ='" + serienf + "' AND nrnf =" + nrnf);
        }


        public bool CancelarNFe(int idloja,int nrnf, string nmserienf, out string msgerro)
        {
            try
            {

                var DtResult = BancoDados.Consultar("select dtresultprocsefaz from nfsaida n inner join lotenfe l on n.nrlote = l.nrlote where n.nrnf = " + nrnf + " and n.serienf = '"+ nmserienf +"'");

                if (DtResult.Rows.Count > 0)
                {
                    BancoDados.InsertAlterarExcluir("INSERT INTO CANCELAMENTONFE (id_loja,nrnf,serienf,dtoperacao) VALUES (" + idloja + "," + nrnf + ",'" + nmserienf + "','" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", Convert.ToDateTime(DtResult.Rows[0][0])) + "')");
                    msgerro = string.Empty;
                    return true;
                }
                else
                {
                    msgerro = "Não existe processamento com a SEFAZ, contate ao Administrador";
                    return false;
                }
            }
            catch(Exception ex)
            {
                msgerro = ex.Message.ToString();
                return false;
            }
        }
        public bool InutilizacaoNFe(int idloja, int nrnf, string nmserienf,int modNfe, out string msgerro)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("INSERT INTO INUTILIZACAONFE (id_loja,numero_ini,numero_fim,dtsolicitacao,modnfe,serienf) VALUES (" + idloja + "," + nrnf + "," + nrnf + ",'" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now) + "',"+ modNfe + ",'" + nmserienf + "')");
                msgerro = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                msgerro = ex.Message.ToString();
                return false;
            }
        }

        public bool ConsultarEnvioCancelamento(int idloja, int nrnf, string nmserienf)
        {
            return BancoDados.CodigoExiste("SELECT * FROM CancelamentoNfe WHERE id_loja= " + idloja + " AND NrNf = " + nrnf + " AND SerieNf='" + nmserienf + "'");
        }
        public bool ConsultarEnvioInutilizacao(int idloja, int nrnf, string nmserienf)
        {
            return BancoDados.CodigoExiste("SELECT * FROM InutilizacaoNFe WHERE id_loja= " + idloja + " AND NrNf = " + nrnf + " AND SerieNf='" + nmserienf + "'");
        }

        public int ConsultarRetornoCancelamento(int idloja, int nrnf, string nmserienf)
        {
            var DtRetCan = BancoDados.Consultar("SELECT cdretorno FROM CancelamentoNfe WHERE id_loja= " + idloja + " AND NrNf = " + nrnf + " AND SerieNf='" + nmserienf + "'");

            if (!string.IsNullOrEmpty(DtRetCan.Rows[0][0].ToString()))
            {
                return Convert.ToInt32(DtRetCan.Rows[0][0].ToString());
            }
            else
                return 0;
        }

        public DataTable ConsultarCancelamento(int idloja, int nrnf, string nmserienf)
        {
            return BancoDados.Consultar("SELECT dtoperacao,cdretorno FROM CancelamentoNfe WHERE id_loja= " + idloja + " AND NrNf = " + nrnf + " AND SerieNf='" + nmserienf + "'");
        }

        public bool CancelamentoAlteraDataProcessamento(int loja,string serienf, int notafiscal, DateTime DtProcCanc, out string ErroMsg)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("UPDATE CancelamentoNfe SET dtOperacao ='" + string.Format("{0:dd/MM/yyyy HH:mm:ss}", DtProcCanc)+"', cdretorno=null WHERE id_loja= " + loja+" AND serienf ='" + serienf+"' AND NrNf= " + notafiscal );
                ErroMsg = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                ErroMsg = ex.Message.ToString();
                return false;
            }
        }
    }
}
