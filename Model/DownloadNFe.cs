using Sdistribuidor.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sdistribuidor.Model
{
    public class DownloadNFe
    {
        /// <summary>
        /// Consulta Xml com a Chave de Acesso, se existir retorna True
        /// </summary>
        /// <param name="chaveacesso"></param>
        /// <returns></returns>
        public string ConsultaXml(string chaveacesso, out bool FlExiste)
        {
            var Dt = BancoDados.Consultar("SELECT xmlnfe FROM DownloadNFe WHERE TxChAcessoNFe='" + chaveacesso.Trim() + "'");

            if(Dt.Rows.Count > 0)
            {
                FlExiste = true;
                return Dt.Rows[0][0].ToString();
            }
            else
            {
                FlExiste = false;
                return string.Empty;
            }
        }
    }
}
