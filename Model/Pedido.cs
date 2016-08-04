using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;
using Npgsql;
using NpgsqlTypes;

namespace Sdistribuidor.Model
{
    public class Pedido
    {

        NpgsqlCommand command;
        NpgsqlTransaction BeginTrans;

        public ICollection<Entidade_Pedido> Pesquisa()
        {
            return null;
        }
        public ICollection<Entidade_Pedido> PesquisaPorStatusPedido(string StPedido)
        {
            return null;
        }
        public int MaxID()
        {
            //var id = BancoDados.maxId("SELECT CASE WHEN MAX(ID) IS NULL THEN 0 ELSE MAX(ID) END AS ID FROM Mapa");
            return 0;
        }
        public Entidade_Pedido Pesquisa(int ID)
        {
            return null;
        }
        public ICollection<Entidade_Pedido> Pesquisa(string Nome)
        {
            return null;
        }
        public bool Incluir(Entidade_Pedido Obj)
        {
            BancoDados.OpenConection();
            BeginTrans = BancoDados.conexao.BeginTransaction();
            try
            {
                #region INCLUINDO PEDIDO
                command = new NpgsqlCommand("spincluirpedido", BancoDados.conexao);
                //command = new NpgsqlCommand();
                //command.Connection = BancoDados.conexao;
                //command.CommandText = "spincluirpedido";
                command.Transaction = BeginTrans;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id_participante", Obj.id_participante.id);
                command.Parameters.AddWithValue("id_formpagto", Obj.id_formpagto.idformapagto);
                command.Parameters.AddWithValue("id_vendedor", 2);
                command.Parameters.AddWithValue("vl_pedido", Convert.ToDecimal(Obj.vl_pedido));
                command.Parameters.AddWithValue("vl_desconto", Convert.ToDecimal(Obj.vl_desconto));
                command.Parameters.AddWithValue("stpedido", Obj.stpedido);
                command.Parameters.AddWithValue("stentrega", Obj.stentrega);
                command.Parameters.AddWithValue("obspedido", Obj.obspedido);
                command.Parameters.AddWithValue("dt_pedido", Obj.dt_pedido);

                var Id = command.ExecuteScalar();

                #endregion

                #region INCLUINDO ITEM PEDIDO

                foreach (var item in Obj.ItemPedidos)
                {
                    command = new NpgsqlCommand("SpIncluirItemPedido", BancoDados.conexao);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Transaction = BeginTrans;
                    command.Parameters.AddWithValue("id_pedido", Convert.ToInt32(Id));
                    command.Parameters.AddWithValue("id_produto", Convert.ToInt32(item.id_produto.IdProduto.ToString()));
                    command.Parameters.AddWithValue("qt_pedido", Convert.ToDecimal(item.Qt_Pedido));
                    command.Parameters.AddWithValue("vl_unitario", Convert.ToDecimal(item.Vl_Unitario));
                    command.Parameters.AddWithValue("cdunidade", item.CdUnidade.CdUnidade);
                    command.Parameters.AddWithValue("vl_desconto", Convert.ToDecimal(item.Vl_Desconto));
                    command.Parameters.AddWithValue("qt_pedido_conv", Convert.ToDecimal(item.qt_pedido_conv)); 
                    command.Parameters.AddWithValue("cdunidade_conv", item.cdunidade_conv);
                    command.ExecuteNonQuery();
                }
                BeginTrans.Commit();
                BancoDados.CloseConection();
                return true;
                #endregion
            }
            catch(NpgsqlException ex)
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
        public bool Update(Entidade_Pedido Obj)
        {
            return true;
        }
        public bool Delete(Entidade_Pedido Obj)
        {
            return true;
        }
    }
}