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
    class FormaPagtoItemFormaPagto
    {
        Entidade_FormaPagto EntForm;
        public List<Entidade_FormaPagto> Pesquisa()
        {
            List<Entidade_FormaPagto> ListFormaPagto = new List<Entidade_FormaPagto>();
            
            var Dt = BancoDados.Consultar("SELECT * FROM FormaPagto ORDER BY desc_formapagto, id_formapagto");

            if(Dt.Rows.Count > 0)
            {
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    EntForm = new Entidade_FormaPagto();
                    EntForm.idformapagto = Convert.ToInt32(Dt.Rows[i]["id_formapagto"]);
                    EntForm.desc_formapagto = Dt.Rows[i]["desc_formapagto"].ToString();
                    EntForm.flprazo = Convert.ToBoolean(Dt.Rows[i]["flprazo"]);
                    EntForm.flcartao = Convert.ToBoolean(Dt.Rows[i]["flcartao"]);
                    ListFormaPagto.Add(EntForm);
                }

                return ListFormaPagto;
            }
            return null;
        }
        public int MaxID()
        {
            return BancoDados.maxId("SELECT CASE WHEN MAX(id_formapagto) IS NULL THEN 0 ELSE MAX(id_formapagto) END AS ID FROM formapagto");
        }
        public Entidade_FormaPagto Pesquisa(int ID)
        {
            var Dt = BancoDados.Consultar("SELECT * FROM FormaPagto WHERE id_formapagto = " + ID);

            if (Dt.Rows.Count > 0)
            {
                EntForm = new Entidade_FormaPagto();
                EntForm.idformapagto = Convert.ToInt32(Dt.Rows[0]["id_formapagto"]);
                EntForm.desc_formapagto = Dt.Rows[0]["desc_formapagto"].ToString();
                EntForm.flprazo = Convert.ToBoolean(Dt.Rows[0]["flprazo"]);
                EntForm.flcartao = Convert.ToBoolean(Dt.Rows[0]["flcartao"]);

                return EntForm;
            }

            return null;
        }
        public List<Entidade_FormaPagto> Pesquisa(string Nome)
        {
            List<Entidade_FormaPagto> ListFormaPagto = new List<Entidade_FormaPagto>();
            
            var Dt = BancoDados.Consultar("SELECT * FROM FormaPagto WHERE desc_formapagto likke '%" + Nome +"%'");

            if (Dt.Rows.Count > 0)
            {
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    EntForm = new Entidade_FormaPagto();
                    EntForm.idformapagto = Convert.ToInt32(Dt.Rows[i]["id_formapagto"]);
                    EntForm.desc_formapagto = Dt.Rows[i]["desc_formapagto"].ToString();
                    EntForm.flprazo = Convert.ToBoolean(Dt.Rows[i]["flprazo"]);
                    EntForm.flcartao = Convert.ToBoolean(Dt.Rows[i]["flcartao"]);
                    ListFormaPagto.Add(EntForm);
                }
                return ListFormaPagto;
            }
            return null;
        }
        
        public bool Incluir(Entidade_FormaPagto ObjFormaPagto)
        {
            return true;
        }
        public bool Update(Entidade_FormaPagto ObjFormaPagto)
        {
            return true;
        }
        public bool Delete(Entidade_FormaPagto ObjFormaPagto)
        {
            return true;
        }

        public DataTable FormaPagtoParcelas(int idformpagto)
        {
            try
            {
                var dtret = BancoDados.Consultar(" SELECT * FROM itemformapagto WHERE id_formapagto=" + idformpagto);

                return dtret;
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
