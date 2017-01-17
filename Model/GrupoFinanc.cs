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
    public class GrupoFinanc
    {
        public bool Incluir(Entidade_GrupoFinanc ObjEntGrupoFinac, out string MsgErro)
        {
            try
            {
                BancoDados.Consultar("INSERT INTO grupofinanc (desc_financeiro) VALUES('" + ObjEntGrupoFinac.desc_financeiro.Trim() +"')");
                MsgErro = string.Empty;
                return true;
            }
            catch(Exception Ex)
            {
                MsgErro = Ex.Message.ToString();
                return false;
            }
        }
        public bool Update(Entidade_GrupoFinanc ObjEntGrupoFinac, out string MsgErro)
        {
            try
            {
                BancoDados.Consultar("UPDATE grupofinanc  SET desc_financeiro ='" + ObjEntGrupoFinac.desc_financeiro.Replace("'","").Trim() + "' WHERE id_grupocontpag=" + ObjEntGrupoFinac.id_grupocontpag);
                MsgErro = string.Empty;
                return true;
            }
            catch (Exception Ex)
            {
                MsgErro = Ex.Message.ToString();
                return false;
            }
        }
        public bool Delete(Entidade_GrupoFinanc ObjEntGrupoFinac, out string MsgErro)
        {
            try
            {
                BancoDados.Consultar("DELETE FROM grupofinanc WHERE id_grupocontpag=" + ObjEntGrupoFinac.id_grupocontpag);
                MsgErro = string.Empty;
                return true;
            }
            catch (Exception Ex)
            {
                MsgErro = Ex.Message.ToString();
                return false;
            }
        }

        public DataTable Pesquisa()
        {
            return BancoDados.Consultar("SELECT * FROM grupofinanc ORDER by desc_financeiro");
        }
        public DataTable Pesquisa(int id)
        {
            return BancoDados.Consultar("SELECT * FROM grupofinanc WHERE id_grupocontpag=" + id);
        }
        public DataTable Contenha(string descricao)
        {
            return BancoDados.Consultar("SELECT * FROM grupofinanc WHERE desc_financeiro like '%" + descricao.Trim() +"%'");
        }
    }
}
