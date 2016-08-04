using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;

namespace Sdistribuidor.Model
{
    public class Unidade
    {
        Entidade_Unidade entUnid;

        public List<Entidade_Unidade> Pesquisa()
        {
            try
            {
                List<Entidade_Unidade> ListUnidade = new List<Entidade_Unidade>();

                var Dt = BancoDados.Consultar("SELECT * FROM unidade ORDER BY unidade");
                if (Dt.Rows.Count > 0)
                {
                    for (int i = 0; i < Dt.Rows.Count; i++)
                    {
                        entUnid = new Entidade_Unidade();

                        entUnid.CdUnidade = Dt.Rows[i][0].ToString();

                        entUnid.Unidade = Dt.Rows[i][1].ToString();

                        ListUnidade.Add(entUnid);
                    }

                    return ListUnidade;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public int MaxID()
        {
            return 0;
        }
        public Entidade_Unidade Pesquisa(string unidade)
        {
            try
            {
                var Dt = BancoDados.Consultar("SELECT * FROM unidade WHERE cdunidade='" + unidade + "'");
                if (Dt.Rows.Count > 0)
                {
                    entUnid = new Entidade_Unidade();

                    entUnid.CdUnidade = Dt.Rows[0][0].ToString();

                    entUnid.Unidade = Dt.Rows[0][1].ToString();

                    return entUnid;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public bool Incluir(Entidade_Unidade Obj)
        {
            try
            {
                //var id = BancoDados.maxId("SELECT CASE WHEN MAX(ID) IS NULL THEN 0 ELSE MAX(ID) END AS ID FROM Mapa");
                BancoDados.InsertAlterarExcluir("INSERT INTO unidade (cdunidade,unidade) VALUES('" + Obj.CdUnidade + "','"+ Obj.CdUnidade +"')");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update(Entidade_Unidade Obj)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("UPDATE unidade SET unidade='" + Obj.Unidade + "' WHERE cdunidade = " + Obj.CdUnidade);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Delete(Entidade_Unidade Obj)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("DELETE FROM unidade WHERE cdunidade = " + Obj.CdUnidade);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
