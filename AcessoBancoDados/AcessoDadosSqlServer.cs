using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;





namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //Cria a conexão
        public SqlConnection CriarConexao()
        {

            return new SqlConnection("Server=localhost\\SQLEXPRESS;Database=JuniorMendesSist;User Id=sa;Password=123456;TrustServerCertificate=True;");
        }


        //Parâmetros que vão para banco

        private List<SqlParameter> listaParametros = new List<SqlParameter>();

        public void LimparParametros()
        {
            listaParametros.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro, bool parametroSaida = false)
        {
            SqlParameter parametro;

            if (parametroSaida)
            {
                parametro = new SqlParameter(nomeParametro, SqlDbType.Int); // ou outro tipo, se necessário
                parametro.Direction = ParameterDirection.Output;
            }
            else
            {
                parametro = new SqlParameter(nomeParametro, valorParametro);
            }

            listaParametros.Add(parametro);
        }
        //Persistência - Inserir, Alterar, Excluir
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                using (SqlConnection sqlConnection = CriarConexao())
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = commandType;
                    sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                    sqlCommand.CommandTimeout = 7200;

                    // adiciona os parâmetros já montados na sua classe
                    foreach (SqlParameter p in listaParametros)
                        sqlCommand.Parameters.Add(p);

                    sqlConnection.Open();

                    // Se há qualquer parâmetro de saída, mantemos ExecuteNonQuery (compatível com o resto do sistema)
                    bool temParametroSaida = sqlCommand.Parameters.Cast<SqlParameter>()
                        .Any(par =>
                            par.Direction == ParameterDirection.Output ||
                            par.Direction == ParameterDirection.InputOutput ||
                            par.Direction == ParameterDirection.ReturnValue);

                    if (temParametroSaida)
                    {
                        sqlCommand.ExecuteNonQuery();

                        // Prioriza ReturnValue, depois OUTPUT/INPUTOUTPUT
                        var retParam = sqlCommand.Parameters.Cast<SqlParameter>()
                            .FirstOrDefault(par => par.Direction == ParameterDirection.ReturnValue);
                        if (retParam != null) return retParam.Value;

                        var outParam = sqlCommand.Parameters.Cast<SqlParameter>()
                            .FirstOrDefault(par =>
                                par.Direction == ParameterDirection.Output ||
                                par.Direction == ParameterDirection.InputOutput);

                        return outParam?.Value;
                    }
                    else
                    {
                        // Sem parâmetro de saída: capturamos o primeiro valor retornado (ex.: SCOPE_IDENTITY())
                        object scalar = sqlCommand.ExecuteScalar();
                        return (scalar == DBNull.Value) ? null : scalar;
                    }
                }
            }
            catch (Exception ex)
            {
                // Propaga com contexto
                throw new Exception("Erro ao executar comando SQL: " + ex.Message, ex);
            }
        }


        //Consultar registros do banco de dados
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //Criar Conexão
                SqlConnection sqlConnection = CriarConexao();
                //Abrir Conecão
                sqlConnection.Open();
                //Criar o comando que vai levar a informação para o banco.
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                // Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão)
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200; //Em Segundos

                //Adicionar os parâmetros no comando
                foreach (SqlParameter sqlParameter in listaParametros)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Criar um adaptador.
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //DataTable = Tabela de Dados vazia onde vou colocar os dados que vem do banco
                DataTable dataTable = new DataTable();

                //Mandar o comando ir até o banco buscar os dados e o adaptador preencher o datatable
                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public object ExecutarScalar(CommandType commandType, string nomeProcedureOuTexto)
        {
            using (SqlConnection conexao = CriarConexao())
            {
                conexao.Open();
                SqlCommand comando = conexao.CreateCommand();
                comando.CommandType = commandType;
                comando.CommandText = nomeProcedureOuTexto;
                comando.CommandTimeout = 7200;

                // usa a lista correta!
                foreach (SqlParameter p in listaParametros)
                {
                    comando.Parameters.Add(new SqlParameter(p.ParameterName, p.Value));
                }

                return comando.ExecuteScalar();
            }
        }
        public object ExecutarManipulacaoComRetorno(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                using (SqlConnection sqlConnection = CriarConexao())
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandType = commandType;
                        sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                        sqlCommand.CommandTimeout = 7200;

                        foreach (SqlParameter sqlParameter in listaParametros)
                        {
                            sqlCommand.Parameters.Add(sqlParameter);
                        }

                        // Agora usamos ExecuteScalar corretamente
                        object retorno = sqlCommand.ExecuteScalar();

                        return retorno;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar manipulação com retorno: " + ex.Message);
            }
        }
        public void ExecutarComando(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            using (SqlConnection sqlConnection = CriarConexao())
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = commandType;
                    sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                    sqlCommand.CommandTimeout = 7200;

                    foreach (SqlParameter parametro in listaParametros)
                    {
                        sqlCommand.Parameters.Add(parametro);
                    }

                    sqlCommand.ExecuteNonQuery(); // Executa sem esperar retorno
                }
            }
        }
    }
}

    