using System;
using System.Reflection;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Npgsql;

namespace Sdistribuidor.DAO
{
    public static class BancoDados
    {
        //CONEXÃO LOCAL
        //public static SqlConnection conexao = new SqlConnection(@"Data Source=192.168.4.3;Initial Catalog=AcoCe;User ID=sa;Password=v83ay74");

        public static NpgsqlConnection conexao = new NpgsqlConnection();
        
        static NpgsqlCommand command;
        static NpgsqlDataAdapter adapter;
        static NpgsqlDataReader Reader;
        static NpgsqlTransaction Trans;

        static int maxrows;
        static decimal valorEmpresa;
        static bool FlExiste;

        static string coluna;
        static string valor;

        public static void OpenConection()
        {            
            //conexao.ConnectionString = @"Data Source=192.168.4.3;Initial Catalog=AcoCe;User ID=sa;Password=v83ay74";

            if (conexao.State == ConnectionState.Closed)
            {
                try
                {
                    conexao.ConnectionString = ConfigurationManager.ConnectionStrings["BancoDados"].ToString();
                    conexao.Open();
                    //Host=192.168.3.7;Username=postgres;Password=v83ay74;Database=comercio
                }
                catch (Exception Ex)
                {
                    throw new Exception(Ex.Message.ToString());
                }
            }
        }
        public static void CloseConection()
        {
            if (conexao.State == ConnectionState.Open)
                conexao.Close();
        }

        public static void InsertAlterarExcluir(string qryStr)
        {
            
            OpenConection();
            try
            {
                Trans = conexao.BeginTransaction();
                command = new NpgsqlCommand(qryStr, conexao);
                command.Transaction = Trans;
                command.ExecuteNonQuery();
                Trans.Commit();
                CloseConection();


            }
            catch (Exception ex)
            {
                Trans.Rollback();
                throw new Exception(ex.Message.ToString());
            }
        }
       
        public static void InsertAlterarStoredProcedure (string NomeStoredProcedure,Object objProc)
        {
            OpenConection();
            command = new NpgsqlCommand(NomeStoredProcedure, conexao);
            command.CommandType = CommandType.StoredProcedure;

            foreach (PropertyInfo fInfo in objProc.GetType().GetProperties())
            {
                coluna = fInfo.Name;
                valor =  objProc.GetType().GetProperty(fInfo.Name).GetValue(objProc, null).ToString();
                if ((valor != string.Empty) && (valor != "0")) 
                    command.Parameters.AddWithValue(coluna, valor);
            }

            command.ExecuteNonQuery();
            CloseConection();
        }
        public static void StoredProcedure(string NomeStoredProcedure, string QryString)
        {
            OpenConection();
            command = new NpgsqlCommand();
            command.Connection = conexao;
            command.CommandText = NomeStoredProcedure + " " + QryString;
            command.ExecuteNonQuery();
            CloseConection();
        }
        public static DataTable Consultar(string QrySql)
        {
            DataTable Table = new DataTable();
            OpenConection();
            adapter = new NpgsqlDataAdapter(QrySql, conexao);

            adapter.SelectCommand.CommandTimeout = 840000;

            adapter.Fill(Table);

            CloseConection();

            return Table;
        }
        public static int maxId(string qryStr)
        {
            try
            {
                OpenConection();
                command = new NpgsqlCommand(qryStr, conexao);
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    if (!Reader.IsDBNull(0))
                        maxrows = Convert.ToInt32(Reader[0]) + 1;
                    else
                        maxrows = 1;
                }
                Reader.Close();

                CloseConection();

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                CloseConection();
            }
            return maxrows;
        }
        public static int maxIdAberta(string qryStr)
        {
            try
            {
                command = new NpgsqlCommand(qryStr, conexao);
                command.Transaction = Trans;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    if (!Reader.IsDBNull(0))
                        maxrows = Convert.ToInt32(Reader[0]);
                    else
                        maxrows = 0;
                }
                Reader.Close();

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                CloseConection();
            }
            return maxrows;
        }
        public static int IdAberta(string qryStr)
        {
            try
            {
                command = new NpgsqlCommand(qryStr, conexao);
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    if (!Reader.IsDBNull(0))
                        maxrows = Convert.ToInt32(Reader[0]);
                    else
                        maxrows = 0;
                }
                Reader.Close();

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                CloseConection();
            }
            return maxrows;
        }
        public static int Id(string qryStr)
        {
            try
            {
                OpenConection();
                command = new NpgsqlCommand(qryStr, conexao);
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    if (!Reader.IsDBNull(0))
                        maxrows = Convert.ToInt32(Reader[0]);
                    else
                        maxrows = 0;
                }
                Reader.Close();
                CloseConection();

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                CloseConection();
            }
            return maxrows;
        }
        public static decimal valorTabela(string qryStr)
        {

            try
            {
                OpenConection();
                command = new NpgsqlCommand(qryStr, conexao);
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    if (!Reader.IsDBNull(0))
                        valorEmpresa = Convert.ToDecimal(Reader[0]);
                    else
                        valorEmpresa = 0;
                }
                Reader.Close();

                CloseConection();

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                CloseConection();
            }
            return valorEmpresa;
        }
        public static bool CodigoExiste(string qryStr)
        {
            try
            {
                OpenConection();
                command = new NpgsqlCommand(qryStr, conexao);
                Reader = command.ExecuteReader();

                if(Reader.HasRows)
                    FlExiste= true;
                else
                    FlExiste= false;

                Reader.Close();

                CloseConection();

            }
            catch (Exception Ex)
            {
                throw new Exception(Ex.Message.ToString());
            }
            finally
            {
                CloseConection();
            }
            return FlExiste;
        }
    }
}
