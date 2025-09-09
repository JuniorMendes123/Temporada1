using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AcessoBancoDados
{
    public class RelatorioDal
    {
        private readonly AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public DataTable ConsultarRelatorioMensal(int ano, int mes, int? idCliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@Ano", ano);
                acessoDadosSqlServer.AdicionarParametros("@Mes", mes);

                if (idCliente.HasValue)
                    acessoDadosSqlServer.AdicionarParametros("@IdCliente", idCliente.Value);
                else
                    acessoDadosSqlServer.AdicionarParametros("@IdCliente", DBNull.Value);

                return acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspRelatorioMensalPedidos");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar relatório mensal de pedidos. Detalhes: " + ex.Message);
            }
        }
    }
}
