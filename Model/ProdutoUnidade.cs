using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;
using System.Data;

namespace Sdistribuidor.Model
{
    class ProdutoUnidade
    {
        public DataTable Pesquisa()
        {
            var Dt = BancoDados.Consultar("SELECT * FROM produtounidade");

            if (Dt.Rows.Count > 0)
            {
                return Dt;
            }
            else
                return null;
        }
        public int MaxID()
        {
            return 1;
        }
        public List<Entidade_ProdutoUnidade> Pesquisa(long ID)
        {
            List<Entidade_ProdutoUnidade> lsProdUnid = new List<Entidade_ProdutoUnidade>();
            Entidade_ProdutoUnidade EntProd;

            var Dt = BancoDados.Consultar("SELECT * FROM produtounidade where id_produto =" + ID);

            if (Dt.Rows.Count > 0)
            {
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    EntProd = new Entidade_ProdutoUnidade();
                    EntProd.Unidade = Dt.Rows[i]["CdUnidade"].ToString();
                    EntProd.vlfatorconv = Convert.ToDouble(Dt.Rows[i]["vlfatorconv"].ToString());

                    lsProdUnid.Add(EntProd);
                }

                return lsProdUnid;
            }
            else
                return null;
        }
        public Entidade_ProdutoUnidade Pesquisa(long ID, string Unidade)
        {
            List<Entidade_ProdutoUnidade> lsProdUnid = new List<Entidade_ProdutoUnidade>();
            Entidade_ProdutoUnidade EntProd;

            var Dt = BancoDados.Consultar("SELECT * FROM produtounidade where id_produto =" + ID + "AND CdUnidade = '" + Unidade.Trim() + "'");

            if (Dt.Rows.Count > 0)
            {

                EntProd = new Entidade_ProdutoUnidade();
                
                EntProd.Unidade = Dt.Rows[0]["CdUnidade"].ToString();
                EntProd.vlfatorconv = Convert.ToDouble(Dt.Rows[0]["vlfatorconv"].ToString());
                return EntProd;
            }
            else
                return null;
        }
        
        public bool Incluir(Entidade_ProdutoUnidade Obj)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("INSERT INTO produtounidade (id_produto,cdunidade,vlfatorconv) VALUES(" + Obj.id_produto + ",'" + Obj.Unidade + "'," + Obj.vlfatorconv.ToString().Replace(".", "").Replace(",", ".") + ")");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(Entidade_ProdutoUnidade Obj)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("UPDATE produtounidade set cdunidade = '"+ Obj.Unidade + "',vlfatorconv = '" + Obj.vlfatorconv.ToString().Replace(".", "").Replace(",", ".") + "' WHERE id_produto = " + Obj.id_produto + "");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(Entidade_ProdutoUnidade Obj)
        {
            return false;
        }
        public bool DeleteAll(Entidade_ProdutoUnidade Obj)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("DELETE FROM produtounidade WHERE id_produto=" + Obj.id_produto);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
