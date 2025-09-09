using ObjetoTrasnferencia;
using System;
using System.Data;

namespace AcessoBancoDados
{
    public class PedidoItemDal
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public void Inserir(PedidoItem item)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParametros("@IdPedido", item.IdPedido);
                acessoDadosSqlServer.AdicionarParametros("@IdProduto", item.IdProduto);
                acessoDadosSqlServer.AdicionarParametros("@Quantidade", item.Quantidade);
                acessoDadosSqlServer.AdicionarParametros("@Subtotal", item.Subtotal);
                acessoDadosSqlServer.AdicionarParametros("@PrecoUnitario", item.ValorUnitario);

                acessoDadosSqlServer.ExecutarManipulacao(
                    CommandType.StoredProcedure, "uspPedidoItemInserir");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir item do pedido. Detalhes: " + ex.Message);
            }
        }
    }
}