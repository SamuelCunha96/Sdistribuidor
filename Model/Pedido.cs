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
        Entidade_Pedido EntPedido;
        Entidade_ItemPedido EntItemPedido;
        Entidade_Estoque ObjEntEstoque;
        List<Entidade_Estoque> ObjListEstoque;
        List<Entidade_ItemPedido> EntListItemPedido;
        Participante mParticipante;
        FormaPagtoItemFormaPagto mFormPagto;
        Vendedor mVendedor;
        Produtos mProdutos;
        Unidade mUnidade;
        MovimentacaoEstoque ObjMovEstoque;


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
            var Dt = BancoDados.Consultar("SELECT * FROM pedido p " +
                                          "INNER JOIN itempedido it ON p.id_pedido = it.id_pedido WHERE p.id_pedido =" + ID);

            EntPedido = new Entidade_Pedido();
            if (Dt.Rows.Count > 0)
            {
                mParticipante = new Participante();
                mFormPagto = new FormaPagtoItemFormaPagto();
                mVendedor = new Vendedor();
                mProdutos = new Produtos();
                mUnidade = new Unidade();
                EntListItemPedido = new List<Entidade_ItemPedido>();

                EntPedido.id_pedido = Convert.ToInt32(Dt.Rows[0]["id_pedido"]);
                EntPedido.id_participante = mParticipante.Pesquisa(Convert.ToInt32(Dt.Rows[0]["id_participante"]));
                EntPedido.id_formpagto = mFormPagto.Pesquisa(Convert.ToInt32(Dt.Rows[0]["id_formpagto"]));
                EntPedido.id_usuario = mVendedor.Pesquisar(Convert.ToInt32(Dt.Rows[0]["id_vendedor"]));

                EntPedido.vl_pedido = Convert.ToInt32(Dt.Rows[0]["vl_pedido"]);
                EntPedido.vl_desconto = Convert.ToInt32(Dt.Rows[0]["vl_desconto"]);
                EntPedido.stentrega = Dt.Rows[0]["stentrega"].ToString();
                EntPedido.obspedido = Dt.Rows[0]["obspedido"].ToString();
                EntPedido.dt_pedido = Convert.ToDateTime(Dt.Rows[0]["dt_pedido"]);
                EntPedido.id_localentrega = string.IsNullOrEmpty(Dt.Rows[0]["id_localentrega"].ToString()) == true ? 0 : Convert.ToInt32(Dt.Rows[0]["id_localentrega"]);

                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    EntItemPedido = new Entidade_ItemPedido();

                    EntItemPedido.id_item_pedido = Convert.ToInt32(Dt.Rows[i]["id_item_pedido"]);
                    EntItemPedido.id_pedido = EntPedido;
                    EntItemPedido.id_produto = mProdutos.Pesquisa(Convert.ToInt32(Dt.Rows[i]["id_produto"]));
                    EntItemPedido.Qt_Pedido = Convert.ToDouble(Dt.Rows[i]["qt_pedido"]);
                    EntItemPedido.Vl_Unitario = Convert.ToDouble(Dt.Rows[i]["vl_unitario"]);
                    EntItemPedido.CdUnidade = mUnidade.Pesquisa(Dt.Rows[i]["cdunidade"].ToString());
                    EntItemPedido.Vl_Desconto = Convert.ToDouble(Dt.Rows[i]["vl_desconto"]);
                    EntItemPedido.qt_pedido_conv = Convert.ToDouble(Dt.Rows[i]["qt_pedido_conv"]);
                    EntItemPedido.cdunidade_conv = Dt.Rows[i]["cdunidade_conv"].ToString();
                    EntListItemPedido.Add(EntItemPedido);
                }

                EntPedido.ItemPedidos = EntListItemPedido;

                return EntPedido;
            }
            else
                return EntPedido;
        }
        public ICollection<Entidade_Pedido> Pesquisa(string Nome)
        {
            return null;
        }

        #region INCLUIR PEDIDO
        public bool Incluir(Entidade_Pedido Obj)
        {
            BancoDados.OpenConection();
            BeginTrans = BancoDados.conexao.BeginTransaction();

            ObjListEstoque = new List<Entidade_Estoque>();
            ObjMovEstoque = new MovimentacaoEstoque();
            string ErroMsg;
            try
            {
                #region INCLUINDO PEDIDO
                command = new NpgsqlCommand("spincluirpedido", BancoDados.conexao);
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
                    ObjEntEstoque = new Entidade_Estoque();
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

                    ObjEntEstoque.id_Produto = Convert.ToInt32(item.id_produto.IdProduto.ToString());
                    ObjEntEstoque.qt_estoque = Convert.ToDecimal(item.Qt_Pedido);
                    ObjEntEstoque.obsestoque = "RESERVA DE ESTOQUE PEDIDO:" + Convert.ToString(Id);
                    ObjEntEstoque.tpmov = "R";
                    ObjEntEstoque.tpmovestoque = "+";
                    ObjEntEstoque.tptbmov = "F";
                    ObjListEstoque.Add(ObjEntEstoque);

                }


                BeginTrans.Commit();
                BancoDados.CloseConection();

                //Movimentar Estoque - Reservado
                ObjMovEstoque.MovimentarEstoque(ObjListEstoque, out ErroMsg);

                return true;
                #endregion
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
        #endregion

        public bool Update(Entidade_Pedido Obj)
        {
            return true;
        }
        public bool Delete(Entidade_Pedido Obj)
        {
            return true;
        }

        public DataTable View_ImpressaoPedido(int pedido)
        {
            return BancoDados.Consultar(" SELECT * FROM vw_impressao_pedido WHERE id_pedido=" + pedido);
        }
        public DataTable View_ImpressaoItemPedido(int pedido)
        {
            return BancoDados.Consultar(" SELECT * FROM vw_impressao_itempedido WHERE id_pedido=" + pedido);
        }

        public DataTable View_PesquisaPedido(int idpedido)
        {
            return BancoDados.Consultar(" SELECT * FROM vw_pesquisapedido WHERE id_participante=" + idpedido);
        }

        public DataTable View_PesquisaPedido(DateTime dtini, DateTime dtfim)
        {
            return BancoDados.Consultar(" SELECT * FROM vw_pesquisapedido WHERE dt_pedido between '" + string.Format("{0:dd/MM/yyyy}", dtini) + "' AND '" + string.Format("{0:dd/MM/yyyy} ", dtfim) + " 23:59:59'");
        }
        public DataTable View_PesquisaPedido(int idparticiapante, DateTime dtini, DateTime dtfim)
        {
            return BancoDados.Consultar(" SELECT * FROM vw_pesquisapedido WHERE id_participante = " + idparticiapante + " dt_pedido between '" + string.Format("{0:dd/MM/yyyy} ", dtini) + "' AND '" + string.Format("{0:dd/MM/yyyy} ", dtfim) + " 23:59:59'");
        }

        #region Cancelar Pedido
        public bool CancelarPedido(int idpedido, bool flrecebcaixa = false)
        {
            ObjMovEstoque = new MovimentacaoEstoque();
            ObjEntEstoque = new Entidade_Estoque();
            ObjListEstoque = new List<Entidade_Estoque>();
            string ErroMsg;
            var DtPedido = Pesquisa(idpedido);

            try
            {
                if(flrecebcaixa)
                {
                    BancoDados.InsertAlterarExcluir("DELETE FROM recebcaixa WHERE id_pedido=" + idpedido);
                }
                BancoDados.InsertAlterarExcluir("UPDATE pedido SET stpedido='C' WHERE id_pedido=" + idpedido);
                

                foreach (var item in DtPedido.ItemPedidos)
                {
                    ObjEntEstoque = new Entidade_Estoque();
                    ObjEntEstoque.id_Produto = Convert.ToInt32(item.id_produto.IdProduto.ToString());
                    ObjEntEstoque.qt_estoque = Convert.ToDecimal(item.Qt_Pedido);
                    ObjEntEstoque.obsestoque = "ESTORNO DE ESTOQUE, PEDIDO N°:" + Convert.ToString(DtPedido.id_pedido);
                    ObjEntEstoque.tpmov = "R";
                    ObjEntEstoque.tpmovestoque = "-";
                    ObjEntEstoque.tptbmov = "F";
                    ObjListEstoque.Add(ObjEntEstoque);
                }
                ObjMovEstoque.MovimentarEstoque(ObjListEstoque, out ErroMsg);

                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
        #endregion


        public DataTable RelatorioVenda(DateTime DtIni, DateTime DtFim, string TipoVenda)
        {
            if(TipoVenda == "T")
            {
                return BancoDados.Consultar("SELECT * FROM vw_relatoriovenda WHERE dt_pedido between '" + string.Format("{0:dd/MM/yyyy} ", DtIni) + "' AND '" + string.Format("{0:dd/MM/yyyy} ", DtFim) + " 23:59:59' ORDER BY dt_pedido");
            }
            else
            {
                return BancoDados.Consultar("SELECT * FROM vw_relatoriovenda WHERE stpedido ='"+ TipoVenda.Trim() +"' AND dt_pedido between '" + string.Format("{0:dd/MM/yyyy} ", DtIni) + "' AND '" + string.Format("{0:dd/MM/yyyy} ", DtFim) + " 23:59:59' ORDER BY dt_pedido");
            }
        }

        public DataTable RelatorioCurvaABC(DateTime DtIni, DateTime DtFim)
        {
            return BancoDados.Consultar("SELECT \n" +
                                        " it.id_produto,prod.descricao,sum(qt_pedido) as qtdvendido, it.vl_unitario, (it.vl_unitario * sum(qt_pedido))::numeric(12,2) as totalvendido,(((it.vl_unitario * sum(qt_pedido)) / sptotalgeralvendaporperiodo('" + string.Format("{0:dd/MM/yyyy} ", DtIni) + "','" + string.Format("{0:dd/MM/yyyy} ", DtFim) + " 23:59:59')) * 100)::numeric(12,2) as porcentagem " +
                                        " FROM pedido p \n" +
                                        " INNER JOIN itempedido it on p.id_pedido = it.id_pedido \n" +
                                        " INNER JOIN produto prod on prod.id_produto = it.id_produto \n" +
                                        " WHERE dt_pedido between '" + string.Format("{0:dd/MM/yyyy} ", DtIni) + "' AND '" + string.Format("{0:dd/MM/yyyy} ", DtFim) + " 23:59:59' AND stpedido not in('C','N') \n" +
                                        " GROUP BY it.id_produto,prod.descricao,it.vl_unitario \n" +
                                        " ORDER BY totalvendido desc ");

        }
    }
}