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
    public class NotaFiscalEntrada
    {
        NpgsqlCommand command;
        NpgsqlTransaction BeginTrans;

        public DataTable ConsultaNFeSemEntrada()
        {
            return BancoDados.Consultar(" SELECT itc.nomeemitente,SUBSTR(itc.chacessonfe,23,3) as serienf,SUBSTR(itc.chacessonfe,26,9)::integer as nrnf,itc.chacessonfe,itc.vlnfe " +
                                        " FROM downloadnfe d " +
                                        " INNER JOIN itemconsultanfdest itc on d.txchacessonfe = itc.chacessonfe " +
                                        " WHERE not exists(select * from nfentrada nf where d.txchacessonfe = nf.txchacessonfe) and xmlnfe is not null");
        }
        public DataTable ConsultaNFeSemEntrada(DateTime DtAutorizacaoIni, DateTime DtAutorizacaoFim)
        {
            return BancoDados.Consultar(" SELECT itc.nomeemitente,SUBSTR(itc.chacessonfe,23,3) as serienf,SUBSTR(itc.chacessonfe,26,9)::integer as nrnf,itc.chacessonfe,itc.vlnfe " +
                                        " FROM downloadnfe d " +
                                        " INNER JOIN itemconsultanfdest itc on d.txchacessonfe = itc.chacessonfe " +
                                        " WHERE not exists(select * from nfentrada nf where d.txchacessonfe = nf.txchacessonfe) and xmlnfe is not null" +
                                        " AND itc.dhautorizacao BETWEEN '" + string.Format("{0:dd/MM/yyyy}", DtAutorizacaoIni) +"' AND '" + string.Format("{0:dd/MM/yyyy}", DtAutorizacaoFim) + " 23:59:59'");
        }


        public bool IncluirNFEntrada(Entidade_NotaFiscal NfEntrada, Entidade_TotaisNota TotaisNF, List<Entidade_Fatura> ListFatura, out string MsgErro)
        {
            BancoDados.OpenConection();
            BeginTrans = BancoDados.conexao.BeginTransaction();
            try
            {

                command = new NpgsqlCommand("spincluirnfeentrada", BancoDados.conexao);
                command.Transaction = BeginTrans;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id_loja", NfEntrada.id_loja);
                command.Parameters.AddWithValue("serienf", NfEntrada.serienf);
                command.Parameters.AddWithValue("nrnf", NfEntrada.nrnf);
                command.Parameters.AddWithValue("id_participante", NfEntrada.id_participante.id);
                command.Parameters.AddWithValue("dtemissao", NfEntrada.dtemissao);
                command.Parameters.AddWithValue("dtsaida", NfEntrada.dtsaida);
                command.Parameters.AddWithValue("dtentrada", Convert.ToDateTime(NfEntrada.dtentrada.ToShortDateString()));
                command.Parameters.AddWithValue("vltotal", TotaisNF.VlNf);
                command.Parameters.AddWithValue("vlbaseicms", TotaisNF.VlBaseIcms);
                command.Parameters.AddWithValue("vlicms ", TotaisNF.VlIcms);
                command.Parameters.AddWithValue("vlbaseicmssub", TotaisNF.VlBaseIcmsSub);
                command.Parameters.AddWithValue("vlicmssub", TotaisNF.VlIcmsSub);
                command.Parameters.AddWithValue("vloutras", TotaisNF.VlOutrasDesp);
                command.Parameters.AddWithValue("vlfrete", TotaisNF.VlFrete);
                command.Parameters.AddWithValue("vlseguro", TotaisNF.VlSeguro);
                command.Parameters.AddWithValue("vltributos", TotaisNF.VlTrib);
                command.Parameters.AddWithValue("txobsfisco", NfEntrada.txobsfisco);
                command.Parameters.AddWithValue("txobscontribuinte", NfEntrada.txobscontribuinte);
                command.Parameters.AddWithValue("txchacessonfe", NfEntrada.txchacessonfe); 
                command.Parameters.AddWithValue("flfinalidade", NfEntrada.flfinalidade.ToString());
                command.Parameters.AddWithValue("id_localentrega", NfEntrada.id_localentrega);
                command.Parameters.AddWithValue("id_formapagto", NfEntrada.id_formapagto);

                command.ExecuteNonQuery();

                foreach (var item in NfEntrada.ItemNFe)
                {
                    command = new NpgsqlCommand("spincluiritemnfentrada", BancoDados.conexao);
                    command.Transaction = BeginTrans;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_loja", NfEntrada.id_loja);
                    command.Parameters.AddWithValue("serienf", NfEntrada.serienf);
                    command.Parameters.AddWithValue("nrnf", NfEntrada.nrnf);
                    command.Parameters.AddWithValue("id_produto", Convert.ToInt32(item.IdProduto));
                    command.Parameters.AddWithValue("id_produto_emit", item.IdProdutoEmit);
                    command.Parameters.AddWithValue("unidnf", item.UnidFornecedor);
                    command.Parameters.AddWithValue("qt_entrada_compra", Convert.ToDecimal(item.qt_venda)); 
                    command.Parameters.AddWithValue("qt_entrada", Convert.ToDecimal(item.qt_entrada_fornec));
                    command.Parameters.AddWithValue("vlunitario", Convert.ToDecimal(item.VlPreco));
                    command.Parameters.AddWithValue("vlbaseicms", item.vlbaseicms);
                    command.Parameters.AddWithValue("vlicms", item.vlicms);
                    command.Parameters.AddWithValue("vlbaseicmssub", item.vlbaseicmssub);
                    command.Parameters.AddWithValue("vlicmssub", item.vlicmssub);
                    command.Parameters.AddWithValue("vlseguro", item.vlSeguro);
                    command.Parameters.AddWithValue("vloutras", item.vloutras);
                    command.Parameters.AddWithValue("vltrib", item.vlTotTrib);
                    command.Parameters.AddWithValue("cfop", item.cfop);
                    command.Parameters.AddWithValue("csticms", item.icms);
                    command.Parameters.AddWithValue("cstipi", item.ipi);
                    command.Parameters.AddWithValue("cstpis", item.pis);
                    command.Parameters.AddWithValue("cstcofins", item.cofins);
                    command.Parameters.AddWithValue("vlaliqicms", item.vlAliqIcms);
                    command.Parameters.AddWithValue("vlaliqipi", item.vlAliqIpi);
                    command.Parameters.AddWithValue("vlaliqpis", item.vlAliqPis);
                    command.Parameters.AddWithValue("vlaliqcofins", item.vlAliqCofins);
                    command.Parameters.AddWithValue("vlpis", item.vlPis);
                    command.Parameters.AddWithValue("vlcofins", item.vlCofins);
                    command.Parameters.AddWithValue("vlipi", item.vlIpi);
                    command.Parameters.AddWithValue("vldesconto", item.vlDesconto);
                    command.ExecuteNonQuery();

                    command = new NpgsqlCommand("spmovimentacaoestoque", BancoDados.conexao);
                    command.Transaction = BeginTrans;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("idloja", NfEntrada.id_loja);
                    command.Parameters.AddWithValue("idproduto", Convert.ToInt32(item.IdProduto));
                    command.Parameters.AddWithValue("qtmovimentada", Convert.ToDecimal(item.qt_entrada_fornec));
                    command.Parameters.AddWithValue("qtreservada", Convert.ToDecimal(item.qt_entrada_fornec));
                    command.Parameters.AddWithValue("tpmov", "E");
                    command.Parameters.AddWithValue("dtmovimentacao", NfEntrada.dtentrada);
                    command.Parameters.AddWithValue("obsmovimentacao", "FORNECEDOR: " + NfEntrada.id_participante.nome + " NOTA FISCAL:" + NfEntrada.serienf + " - " + NfEntrada.nrnf);
                    command.Parameters.AddWithValue("tptbmov", "F");

                    command.ExecuteNonQuery();

                    command = new NpgsqlCommand("spmovimentacaoestoque", BancoDados.conexao);
                    command.Transaction = BeginTrans;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("idloja", NfEntrada.id_loja);
                    command.Parameters.AddWithValue("idproduto", Convert.ToInt32(item.IdProduto));
                    command.Parameters.AddWithValue("qtmovimentada", Convert.ToDecimal(item.qt_entrada_fornec));
                    command.Parameters.AddWithValue("qtreservada", Convert.ToDecimal(item.qt_entrada_fornec));
                    command.Parameters.AddWithValue("tpmov", "E");
                    command.Parameters.AddWithValue("dtmovimentacao", NfEntrada.dtentrada);
                    command.Parameters.AddWithValue("obsmovimentacao", "FORNECEDOR: " + NfEntrada.id_participante.nome + " NOTA FISCAL:" + NfEntrada.serienf + " - " + NfEntrada.nrnf);
                    command.Parameters.AddWithValue("tptbmov", "E");

                    command.ExecuteNonQuery();

                }

                foreach (var Fatura in ListFatura)
                {
                    command = new NpgsqlCommand("spincluirfaturanfe", BancoDados.conexao);
                    command.Transaction = BeginTrans;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_loja", NfEntrada.id_loja);
                    command.Parameters.AddWithValue("serienf", NfEntrada.serienf);
                    command.Parameters.AddWithValue("nrnf", NfEntrada.nrnf);
                    command.Parameters.AddWithValue("id_participante", NfEntrada.id_participante.id);
                    command.Parameters.AddWithValue("dtvencimento", Fatura.DataFatura.Date);
                    command.Parameters.AddWithValue("valor", Convert.ToDecimal(Fatura.Valor));
                    command.Parameters.AddWithValue("stfatura", "A"); //A - ABERTA, C-CANCELADA, L-LIQUIDADA
                    command.Parameters.AddWithValue("stpagto", "A"); // A-ABERTA, P-PAGO
                    command.ExecuteNonQuery();
                }

                BeginTrans.Commit();

                BancoDados.CloseConection();

                MsgErro = string.Empty;
                return true;

            }
            catch (Exception Ex)
            {
                BeginTrans.Rollback();
                MsgErro = Ex.Message.ToString();
                return false;
            }
        }

        public bool NotaFiscalExiste(int loja, string serienf, int nrnfe, int idparticipante)
        {
            return BancoDados.CodigoExiste("select * from  nfentrada where id_loja = "+ loja +" and serienf ='"+ serienf +"' and nrnf = " + nrnfe +" and id_participante=" + idparticipante);
        }

    }
}
