using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;

namespace Sdistribuidor.Model
{
    public class SerieNotaFiscal
    {
        /// <summary>
        /// Retorna um número acrescido de +1
        /// </summary>
        /// <param name="Loja"></param>
        /// <returns></returns>
        public int NfAtual(int Loja, string modelo)
        {
            var nrnf = BancoDados.maxId("SELECT nrnf FROM serienfe WHERE id_loja=" + 1 + "AND modelo='" + modelo + "'");
            BancoDados.InsertAlterarExcluir("UPDATE serienfe SET nrnf=" + nrnf + " WHERE id_loja=" + 1 + "AND modelo='" + modelo + "'");
            return nrnf;
        }
        public string Serie(int Loja, string modelo)
        {
            var DtSerie = BancoDados.Consultar("SELECT serie FROM serienfe WHERE id_loja=" + 1 + "AND modelo='" + modelo + "'");
            if (DtSerie.Rows[0][0].ToString() != string.Empty)
                return DtSerie.Rows[0][0].ToString();
            else
                throw new Exception("NÃO EXISTE SÉRIE CADASTRADA PARA ESSA EMPRESA");
        }
    }
}
