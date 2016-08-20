using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sdistribuidor.Entidade;
using Sdistribuidor.DAO;
using Npgsql;
using System.Data;

namespace Sdistribuidor.Model
{
    public class NotaFiscal
    {
        NpgsqlCommand command;
        NpgsqlTransaction BeginTrans;

        public bool Salvar(Entidade_NotaFiscal EntNotaFiscal)
        {
            BancoDados.OpenConection();
            BeginTrans = BancoDados.conexao.BeginTransaction();
            try
            {
                
                command = new NpgsqlCommand("spincluirnfe", BancoDados.conexao);
                command.Transaction = BeginTrans;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("id_loja", EntNotaFiscal.id_loja);
                command.Parameters.AddWithValue("serienf", EntNotaFiscal.serienf);
                command.Parameters.AddWithValue("nrnf", EntNotaFiscal.nrnf);
                command.Parameters.AddWithValue("id_participante", EntNotaFiscal.id_participante);
                command.Parameters.AddWithValue("dtemissao", EntNotaFiscal.dtemissao);
                command.Parameters.AddWithValue("dtsaida", EntNotaFiscal.dtsaida);
                command.Parameters.AddWithValue("vltotal", EntNotaFiscal.vltotal);
                command.Parameters.AddWithValue("vlbaseicms", EntNotaFiscal.vlbaseicms);
                command.Parameters.AddWithValue("vlicms ", EntNotaFiscal.vlicms);
                command.Parameters.AddWithValue("vlbaseicmssub", EntNotaFiscal.vlbaseicmssub);
                command.Parameters.AddWithValue("vlicmssub", EntNotaFiscal.vlicmssub);
                command.Parameters.AddWithValue("vloutras", EntNotaFiscal.vloutras);
                command.Parameters.AddWithValue("vlfrete", EntNotaFiscal.vlfrete);
                command.Parameters.AddWithValue("vlseguro", EntNotaFiscal.vlseguro);
                command.Parameters.AddWithValue("txobsfisco", EntNotaFiscal.txobsfisco);
                command.Parameters.AddWithValue("txobscontribuinte", EntNotaFiscal.txobscontribuinte);
                command.Parameters.AddWithValue("id_pedido", EntNotaFiscal.id_pedido);
                command.Parameters.AddWithValue("flfinalidade", EntNotaFiscal.flfinalidade);





            }
            catch(Exception Ex)
            {

            }

            }
    }
}
