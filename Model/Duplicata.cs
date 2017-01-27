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
    public class Duplicata
    {
        NpgsqlCommand command;
        NpgsqlTransaction BeginTrans;

        public bool Incluir(List<Entidade_Duplicata> ListDuplicata)
        {
            BancoDados.OpenConection();
            BeginTrans = BancoDados.conexao.BeginTransaction();

            string ErroMsg;
            try
            {
                #region INCLUINDO Duplicata

                foreach (var dulicata in ListDuplicata)
                {
                    command = new NpgsqlCommand("spincluirduplicata", BancoDados.conexao);
                    command.Transaction = BeginTrans;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id_participante", dulicata.participante.id);
                    command.Parameters.AddWithValue("id_formapagto", dulicata.formapagto.idformapagto);
                    command.Parameters.AddWithValue("id_pedido", dulicata.idpedido);
                    command.Parameters.AddWithValue("dtemissao", dulicata.DtEmissao);
                    command.Parameters.AddWithValue("dtvencimento", dulicata.DtVencto);
                    command.Parameters.AddWithValue("vlparcela", dulicata.VlParcela);
                    command.Parameters.AddWithValue("stparcela", dulicata.StParcela);
                    command.ExecuteNonQuery();
                }

                #endregion
                BeginTrans.Commit();
                BancoDados.CloseConection();

                return true;
            }
            catch (NpgsqlException ex)
            {
                BeginTrans.Rollback();
                return false;
            }
            catch (Exception ex)
            {
                BeginTrans.Rollback();
                return false;
            }
        }

        public DataTable Carne(int idpedido)
        {
            return BancoDados.Consultar("SELECT * FROM vw_listaduplicata WHERE id_pedido=" + idpedido);
        }
    }
}
