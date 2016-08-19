using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Sdistribuidor.DAO;
using Npgsql;

namespace Sdistribuidor.Model
{
    public class FuncoesGerais
    {
        public FuncoesGerais()
        {
        }

        static DataTable dtReturn;
        static NpgsqlDataReader dtReader;

        public enum TipoTramitacao
        {
            EnvioNotFiscalSaida,
            EnvioNotFiscalEntrada,
            ReenvioLote,
            Cancelamento,
            Inutilizacao
        }

        public TipoTramitacao EnumTipoTramitacaoNfe;

        public bool TramitacaoNfe(TipoTramitacao TramitacaoNfe)
        {
            return false;
        }
        public static string TipoAmbiente()
        {
            var result = BancoDados.Consultar("SELECT VALOR FROM ConfiguracaoNfe WHERE Chave='AMBIENTE'");

            return result.Rows[0][0].ToString().ToUpper();
        }
        public static DataTable ConsultarUnidade()
        {
            return BancoDados.Consultar("SELECT CdUnidade FROM unidade WHERE NmUnidade <> ''");
        }
        public static string CertificadoEmpresa()
        {
            try
            {
                dtReturn = new DataTable();

                BancoDados.OpenConection();

                NpgsqlCommand command = new NpgsqlCommand("SpNfeConsultaLojasEmitentes", BancoDados.conexao);
                command.CommandType = CommandType.StoredProcedure;
                dtReader = command.ExecuteReader();

                dtReturn.Load(dtReader);

                BancoDados.CloseConection();

                return dtReturn.Rows[0]["NmCertificadoDigital"].ToString();

                //return "‎‎‎58cc2ec0da36a5d9";

            }
            catch (Exception ex)
            {
                BancoDados.CloseConection();
                throw new Exception(ex.Message.ToString());
            }
        }
        public static string UfIbgeEmpresa()
        {
            try
            {
                dtReturn = new DataTable();

                BancoDados.OpenConection();

                NpgsqlCommand command = new NpgsqlCommand("SpNfeConsultaLojasEmitentes", BancoDados.conexao);
                command.CommandType = CommandType.StoredProcedure;
                dtReader = command.ExecuteReader();

                dtReturn.Load(dtReader);

                BancoDados.CloseConection();

                return dtReturn.Rows[0]["UF_IBGE"].ToString().ToUpper();

            }
            catch (Exception ex)
            {
                BancoDados.CloseConection();
                throw new Exception(ex.Message.ToString());
            }
        }

        #region ----- # IMPOSTOS # -----
        public static DataTable ConsultaIcms()
        {
            try
            {
               return BancoDados.Consultar("SELECT CdImposto,DsImposto FROM ImpostoNfe WHERE TpImposto=1 ORDER BY CdImposto");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public static DataTable ConsultaIpi()
        {
            try
            {
                return BancoDados.Consultar("SELECT CdImposto,DsImposto FROM ImpostoNfe WHERE TpImposto=2 ORDER BY CdImposto");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public static DataTable ConsultaPis()
        {
            try
            {
                return BancoDados.Consultar("SELECT CdImposto,DsImposto FROM ImpostoNfe WHERE TpImposto=3 ORDER BY CdImposto");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public static DataTable ConsultaCofins()
        {
            try
            {
                return BancoDados.Consultar("SELECT CdImposto,DsImposto FROM ImpostoNfe WHERE TpImposto=4 ORDER BY CdImposto");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        #endregion
    }
}
