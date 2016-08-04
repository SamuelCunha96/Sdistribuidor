using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sdistribuidor.DAO;
using Sdistribuidor.Entidade;

namespace Sdistribuidor.Model
{
    public class Grupo
    {
        public Grupo()
        {

        }
        Entidade_Grupo entGrupo;
        public DataTable Lista()
        {
            try
            {
                return BancoDados.Consultar("SELECT * FROM grupo");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        public Entidade_Grupo Pesquisa(int id)
        {
            try
            {
                var Dt = BancoDados.Consultar("SELECT * FROM grupo WHERE id_grupo=" + id);
                if (Dt.Rows.Count > 0)
                {
                    entGrupo = new Entidade_Grupo();

                    entGrupo.idgrupo = Convert.ToInt32(Dt.Rows[0][0].ToString());

                    entGrupo.nmgrupo = Dt.Rows[0][1].ToString();

                    return entGrupo;
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
        public bool Incluir(Entidade_Grupo ObjGrupo)
        {
            try
            {
                //var id = BancoDados.maxId("SELECT CASE WHEN MAX(ID) IS NULL THEN 0 ELSE MAX(ID) END AS ID FROM Mapa");
                BancoDados.InsertAlterarExcluir("INSERT INTO grupo (nmgrupo) VALUES('" + ObjGrupo.nmgrupo + "')");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Entidade_Grupo ObjGrupo)
        {
            try
            {
                BancoDados.InsertAlterarExcluir("UPDATE grupo SET nmgrupo='" + ObjGrupo.nmgrupo + "' WHERE id_grupo = " + ObjGrupo.idgrupo);
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
