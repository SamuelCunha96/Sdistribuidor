using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;

namespace Sdistribuidor.Model
{
    public class Usuario
    {
        Entidade_Usuario EntUsuario;
        public Entidade_Usuario Pesquisa(int id)
        {
            try
            {
                var Dt = BancoDados.Consultar("SELECT * FROM usuario WHERE id_usuario=" + id);

                if (Dt.Rows.Count > 0)
                {
                    EntUsuario = new Entidade_Usuario();

                    EntUsuario.id_usuario = Convert.ToInt32(Dt.Rows[0][0].ToString());
                    EntUsuario.nome = Dt.Rows[0][1].ToString();

                    return EntUsuario;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
