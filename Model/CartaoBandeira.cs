using System;
using System.Collections.Generic;
using System.Text;
using Sdistribuidor.Entidade;
using System.Data;
using Sdistribuidor.DAO;

namespace Sdistribuidor.Model
{
    public class CartaoBandeira
    {
        public CartaoBandeira() { }

        public DataTable Lista()
        {
            try
            {
                return BancoDados.Consultar("SELECT * FROM cartaobandeira ORDER BY nmbandeira");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        //public Entidade_Grupo Pesquisa(int id)
        //{
        //    try
        //    {
        //        var Dt = BancoDados.Consultar("SELECT * FROM grupo WHERE id_grupo=" + id);
        //        if (Dt.Rows.Count > 0)
        //        {
        //            entGrupo = new Entidade_Grupo();

        //            entGrupo.idgrupo = Convert.ToInt32(Dt.Rows[0][0].ToString());

        //            entGrupo.nmgrupo = Dt.Rows[0][1].ToString();

        //            return entGrupo;
        //        }
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}
    }
}
