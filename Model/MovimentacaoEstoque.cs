using Sdistribuidor.DAO;
using System;
using System.Data;
using Sdistribuidor.Entidade;
using Npgsql;
using System.Collections.Generic;

namespace Sdistribuidor.Model
{
    public class MovimentacaoEstoque
    {
        NpgsqlCommand command;
        NpgsqlTransaction BeginTrans;
        /// <summary>
        /// Pesquisa por ID
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        public DataTable Pesquisa(int produto)
        {
            return BancoDados.Consultar("SELECT * FROM vw_movimentacaoestoque WHERE id_produto =" + produto);
        }
        public DataTable Pesquisa(DateTime DtIni, DateTime DtFim, int produto)
        {
            if(produto == 0)
                return BancoDados.Consultar("SELECT * FROM vw_movimentacaoestoque WHERE dtmovimentacao between '" + string.Format("{0:dd/MM/yyyy}",DtIni.Date) +"' AND '"+ string.Format("{0:dd/MM/yyyy}", DtFim.Date) + " 23:59:59'");
            else
                return BancoDados.Consultar("SELECT * FROM vw_movimentacaoestoque WHERE dtmovimentacao between '" + string.Format("{0:dd/MM/yyyy}", DtIni.Date) + "' AND '" + string.Format("{0:dd/MM/yyyy}", DtFim.Date) + " 23:59:59' AND id_produto = " + produto); 
        }


        public decimal EstoqueQuantidade(int idproduto)
        {
            var DtRetEstoque = BancoDados.Consultar("SELECT qt_fisico -qt_reservado as estoque FROM fisico WHERE id_produto = " + idproduto);

            if(DtRetEstoque != null)
            {
                return Convert.ToDecimal(DtRetEstoque.Rows[0][0].ToString());
            }
            else
            {
                return -1;
            }
        }

        public bool MovimentarEstoque(List<Entidade_Estoque> ObjListMovEstoque, out string ErroMsg)
        {
            try
            {
                BancoDados.OpenConection();
                BeginTrans = BancoDados.conexao.BeginTransaction();
                #region INCLUIR MOV ESTOQUE

                foreach (var ObjEntMovEstoque in ObjListMovEstoque)
                {
                    command = new NpgsqlCommand("spmovimentacaoestoque", BancoDados.conexao);
                    command.Transaction = BeginTrans;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("idloja", 1);
                    command.Parameters.AddWithValue("idproduto", ObjEntMovEstoque.id_Produto);
                    command.Parameters.AddWithValue("qtmovimentada", ObjEntMovEstoque.qt_estoque);
                    command.Parameters.AddWithValue("qtreservada", ObjEntMovEstoque.qt_reservado);
                    command.Parameters.AddWithValue("tpmov", ObjEntMovEstoque.tpmov);
                    command.Parameters.AddWithValue("dtmovimentacao", DateTime.Now);
                    command.Parameters.AddWithValue("obsmovimentacao", ObjEntMovEstoque.obsestoque);
                    command.Parameters.AddWithValue("tptbmov", ObjEntMovEstoque.tptbmov);
                    command.ExecuteNonQuery();
                }

                #endregion

                ErroMsg = string.Empty;
                BeginTrans.Commit();
                BancoDados.CloseConection();
                return true;
            }
            catch (Exception ex)
            {
                ErroMsg = ex.Message.ToString();
                BeginTrans.Rollback();
                return false;
            }
        }
    }
}
