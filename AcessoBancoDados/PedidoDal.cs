using ObjetoTrasnferencia;
using System;
using System.Data;

namespace AcessoBancoDados
{
    public class PedidoDal
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public int Inserir(Pedido pedido)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@IdCliente", pedido.IdCliente);
                acessoDadosSqlServer.AdicionarParametros("@DataPedido", pedido.DataPedido);
                acessoDadosSqlServer.AdicionarParametros("@ValorTotal", pedido.TotalPedido);

                // ⚠️ Agora usando o novo método que usa ExecuteScalar
                object retorno = acessoDadosSqlServer.ExecutarManipulacaoComRetorno(
                    CommandType.StoredProcedure, "uspPedidoInserir");

                return Convert.ToInt32(retorno);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir o pedido. Detalhes: " + ex.Message);
            }
        }

        public int InserirViaOrcamento(int idOrcamento)
        {
            try
            {
                AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
                acessoDadosSqlServer.LimparParametros(); // limpar anteriores
                acessoDadosSqlServer.AdicionarParametros("@IdOrcamento", idOrcamento); // ADICIONA O PARAMETRO CERTO

                object retorno = acessoDadosSqlServer.ExecutarScalar(
                    CommandType.StoredProcedure,
                    "uspPedidoInserirViaOrcamento"
                );

                return Convert.ToInt32(retorno); // retorna o ID gerado
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gerar pedido via orçamento. Detalhes: " + ex.Message);
            }
        }
        public DataTable ConsultaPorNomeCliente(string nomeCliente)
        {
            try
            {
                AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NomeCliente", nomeCliente);

                return acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoConsultarPorCliente");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar pedidos por nome. Detalhes: " + ex.Message);
            }
        }
        public DataTable ConsultarItensPedido(int idPedido)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdPedido", idPedido);

                return acessoDadosSqlServer.ExecutarConsulta(
                    CommandType.StoredProcedure, "uspPedidoItemConsultarPorIdPedido"
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar itens do pedido. Detalhes: " + ex.Message);
            }
        }
        public void Excluir(int idPedido)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IdPedido", idPedido);

            acessoDadosSqlServer.ExecutarComando(CommandType.StoredProcedure, "uspPedidoExcluir");
        }

        public Pedido ObterPorId(int idPedido)
        {
            AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdPedido", idPedido);

            DataTable dt = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoPorId");

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];

            Pedido pedido = new Pedido
            {
                IdPedido = row["IdPedido"] != DBNull.Value ? Convert.ToInt32(row["IdPedido"]) : 0,
                DataPedido = row["DataPedido"] != DBNull.Value ? Convert.ToDateTime(row["DataPedido"]) : DateTime.MinValue,
                TotalPedido = row["Total"] != DBNull.Value ? Convert.ToDecimal(row["Total"]) : 0,
                Cliente = new Cliente
                {
                    Nome = row["NomeCliente"] != DBNull.Value ? row["NomeCliente"].ToString() : string.Empty
                }
            };

            return pedido;
        }
    }
}