using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;
using Npgsql;
using NpgsqlTypes;

namespace Sdistribuidor.Model
{
    public class Produtos
    {
        public Produtos()
        {

        }

        Entidade_Produto entProduto;

        Grupo mGrupo;
        Unidade mUnidade;

        NpgsqlCommand command;
        NpgsqlTransaction BeginTrans;

        public List<Entidade_Produto> Pesquisa()
        {
            try
            {
                mGrupo = new Grupo();
                mUnidade = new Unidade();

                List<Entidade_Produto> ListProduto = new List<Entidade_Produto>();

                var Dt = BancoDados.Consultar("SELECT * FROM produto Order By descricao");

                if (Dt.Rows.Count > 0)
                {
                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {
                        entProduto = new Entidade_Produto();
                        entProduto.IdProduto = Convert.ToInt32(Dt.Rows[i]["Id_Produto"].ToString());
                        entProduto.NmProduto = Dt.Rows[i]["descricao"].ToString();
                        entProduto.VlPreco = Convert.ToDouble(Dt.Rows[i]["vlunitario"]);
                        entProduto.NCM = Dt.Rows[i]["ncm"].ToString();
                        entProduto.pesoitem = Convert.ToDouble(Dt.Rows[i]["pesoitem"]);
                        entProduto.codigoreferencia = Dt.Rows[i]["codigoreferencia"].ToString();
                        entProduto.IdGrupo = mGrupo.Pesquisa(Convert.ToInt32(Dt.Rows[i]["id_grupo"]));
                        entProduto.Unidade = mUnidade.Pesquisa(Dt.Rows[i]["cdunidade"].ToString());
                        entProduto.VlPreco2 = Convert.ToDouble(Dt.Rows[i]["vlunitario2"]);
                        entProduto.VlPreco3 = Convert.ToDouble(Dt.Rows[i]["vlunitario3"]);
                        ListProduto.Add(entProduto);
                    }
                    return ListProduto;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public Entidade_Produto Pesquisa(long id)
        {
            try
            {
                mGrupo = new Grupo();
                mUnidade = new Unidade();

                var Dt = BancoDados.Consultar("SELECT * FROM produto WHERE id_produto=" + id);

                if (Dt.Rows.Count > 0)
                {
                    entProduto = new Entidade_Produto();
                    entProduto.IdProduto = Convert.ToInt32(Dt.Rows[0]["Id_Produto"].ToString());
                    entProduto.NmProduto = Dt.Rows[0]["descricao"].ToString();
                    entProduto.VlPreco = Convert.ToDouble(Dt.Rows[0]["vlunitario"]);
                    entProduto.NCM = Dt.Rows[0]["ncm"].ToString();
                    entProduto.pesoitem = Convert.ToDouble(Dt.Rows[0]["pesoitem"]);
                    entProduto.codigoreferencia = Dt.Rows[0]["codigoreferencia"].ToString();
                    entProduto.IdGrupo = mGrupo.Pesquisa(Convert.ToInt32(Dt.Rows[0]["id_grupo"]));
                    entProduto.Unidade = mUnidade.Pesquisa(Dt.Rows[0]["cdunidade"].ToString());
                    entProduto.VlPreco2 = Convert.ToDouble(Dt.Rows[0]["vlunitario2"]);
                    entProduto.VlPreco3 = Convert.ToDouble(Dt.Rows[0]["vlunitario3"]);
                    entProduto.icms = Dt.Rows[0]["cst_icms"].ToString();
                    entProduto.ipi = Dt.Rows[0]["cst_ipi"].ToString();
                    entProduto.pis = Dt.Rows[0]["cst_pis"].ToString();
                    entProduto.cofins = Dt.Rows[0]["cst_cofins"].ToString();
                    entProduto.cfop_int = Dt.Rows[0]["cfop_int"].ToString() == string.Empty ? 0 : Convert.ToInt32(Dt.Rows[0]["cfop_int"].ToString());
                    entProduto.cfop_ext = Dt.Rows[0]["cfop_ext"].ToString() == string.Empty ? 0 :  Convert.ToInt32(Dt.Rows[0]["cfop_ext"].ToString());

                    return entProduto;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public List<Entidade_Produto> Pesquisa(string Desc)
        {
            try
            {
                mGrupo = new Grupo();
                mUnidade = new Unidade();

                List<Entidade_Produto> ListProduto = new List<Entidade_Produto>();

                var Dt = BancoDados.Consultar("SELECT * FROM produto WHERE descricao like '%" + Desc + "%'");

                if (Dt.Rows.Count > 0)
                {
                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {
                        entProduto = new Entidade_Produto();
                        entProduto.IdProduto = Convert.ToInt32(Dt.Rows[i]["Id_Produto"].ToString());
                        entProduto.NmProduto = Dt.Rows[i]["descricao"].ToString();
                        entProduto.VlPreco = Convert.ToDouble(Dt.Rows[i]["vlunitario"]);
                        entProduto.NCM = Dt.Rows[i]["ncm"].ToString();
                        entProduto.pesoitem = Convert.ToDouble(Dt.Rows[i]["pesoitem"]);
                        entProduto.codigoreferencia = Dt.Rows[i]["codigoreferencia"].ToString();
                        entProduto.IdGrupo = mGrupo.Pesquisa(Convert.ToInt32(Dt.Rows[i]["id_grupo"]));
                        entProduto.Unidade = mUnidade.Pesquisa(Dt.Rows[i]["cdunidade"].ToString());
                        entProduto.VlPreco2 = Convert.ToDouble(Dt.Rows[i]["vlunitario2"]);
                        entProduto.VlPreco3 = Convert.ToDouble(Dt.Rows[i]["vlunitario3"]);
                        ListProduto.Add(entProduto);
                    }
                    return ListProduto;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public bool AtualizarEstoqueFisico()
        {
            try
            {
                var Dt = BancoDados.Consultar("SELECT FlAtualizaFisico FROM Empresa");
                return Convert.ToBoolean(Dt.Rows[0][0]);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public bool Incluir(Entidade_Produto Obj)
        {
            try
            {
                BancoDados.OpenConection();
                BeginTrans = BancoDados.conexao.BeginTransaction();
                #region INCLUINDO PRODUTO
                command = new NpgsqlCommand("spincluirproduto", BancoDados.conexao);
                command.Transaction = BeginTrans;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id_produto", Convert.ToInt32(Obj.IdProduto));
                command.Parameters.AddWithValue("descricao", Obj.NmProduto);
                command.Parameters.AddWithValue("vlunitario", Convert.ToDecimal(Obj.VlPreco));
                command.Parameters.AddWithValue("ncm", Obj.NCM);
                command.Parameters.AddWithValue("pesoitem", Convert.ToDecimal(Obj.pesoitem));
                command.Parameters.AddWithValue("codigoreferencia", Obj.codigoreferencia);
                command.Parameters.AddWithValue("id_grupo", Obj.IdGrupo.idgrupo);
                command.Parameters.AddWithValue("cdunidade", Obj.Unidade.CdUnidade);
                command.Parameters.AddWithValue("vlunitario2", Convert.ToDecimal(Obj.VlPreco2));
                command.Parameters.AddWithValue("vlunitario3", Convert.ToDecimal(Obj.VlPreco3));
                command.Parameters.AddWithValue("cst_icms", Obj.icms);
                command.Parameters.AddWithValue("cst_ipi", Obj.ipi);
                command.Parameters.AddWithValue("cst_pis", Obj.pis);
                command.Parameters.AddWithValue("cst_cofins", Obj.cofins);
                command.Parameters.AddWithValue("cfop_int", Obj.cfop_int);
                command.Parameters.AddWithValue("cfop_ext", Obj.cfop_ext);
                command.ExecuteNonQuery();

                #endregion

                BeginTrans.Commit();
                BancoDados.CloseConection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Entidade_Produto Obj)
        {
            try
            {
                BancoDados.OpenConection();
                BeginTrans = BancoDados.conexao.BeginTransaction();
                #region INCLUINDO PRODUTO
                command = new NpgsqlCommand("spalterarproduto", BancoDados.conexao);
                command.Transaction = BeginTrans;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id_produto", Convert.ToInt32(Obj.IdProduto));
                command.Parameters.AddWithValue("descricao", Obj.NmProduto);
                command.Parameters.AddWithValue("vlunitario", Convert.ToDecimal(Obj.VlPreco));
                command.Parameters.AddWithValue("ncm", Obj.NCM);
                command.Parameters.AddWithValue("pesoitem", Convert.ToDecimal(Obj.pesoitem));
                command.Parameters.AddWithValue("codigoreferencia", Obj.codigoreferencia);
                command.Parameters.AddWithValue("id_grupo", Obj.IdGrupo.idgrupo);
                command.Parameters.AddWithValue("cdunidade", Obj.Unidade.CdUnidade);
                command.Parameters.AddWithValue("vlunitario2", Convert.ToDecimal(Obj.VlPreco2));
                command.Parameters.AddWithValue("vlunitario3", Convert.ToDecimal(Obj.VlPreco3));
                command.Parameters.AddWithValue("cst_icms", Obj.icms);
                command.Parameters.AddWithValue("cst_ipi", Obj.ipi);
                command.Parameters.AddWithValue("cst_pis", Obj.pis);
                command.Parameters.AddWithValue("cst_cofins", Obj.cofins);
                command.Parameters.AddWithValue("cfop_int", Obj.cfop_int);
                command.Parameters.AddWithValue("cfop_ext", Obj.cfop_ext);
                command.ExecuteNonQuery();

                #endregion

                BeginTrans.Commit();
                BancoDados.CloseConection();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("DELETE FROM grupo WHERE id_grupo = " + Id);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
