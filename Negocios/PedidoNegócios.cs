using AcessoBancoDados;
using ObjetoTrasnferencia;
using System;
using System.ComponentModel;
using System.Data;

namespace Negócios
{
    public class PedidoNegócios
    {
        public Pedido ObterPedidoPorId(int idPedido)
        {
            PedidoDal dal = new PedidoDal();
            return dal.ObterPorId(idPedido); // este método deverá ser criado no DAL também
        }
        public void Excluir(Pedido pedido)
        {
            {
                PedidoDal pedidoDal = new PedidoDal();
                pedidoDal.Excluir(pedido.IdPedido);
            }
        }
        public PedidoItemColecao ConsultarItensPorIdPedido(int idPedido)
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
            acessoDados.AdicionarParametros("@IdPedido", idPedido);

            DataTable tabela = acessoDados.ExecutarConsulta(
                CommandType.StoredProcedure, "uspPedidoItemConsultarPorIdPedido");

            PedidoItemColecao colecao = new PedidoItemColecao();

            foreach (DataRow linha in tabela.Rows)
            {
                PedidoItem item = new PedidoItem();

                item.IdProduto = Convert.ToInt32(linha["IdProduto"]);
                item.NomeProduto = linha["NomeProduto"].ToString();
                item.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                item.ValorUnitario = Convert.ToDecimal(linha["PrecoUnitario"]);


                colecao.Add(item);
            }

            return colecao;
        }
        public PedidoColeção ConsultarPorCliente(string nomeCliente)
        {
            AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
            acessoDados.AdicionarParametros("@NomeCliente", nomeCliente);

            DataTable tabela = acessoDados.ExecutarConsulta(
                CommandType.StoredProcedure, "uspPedidoConsultarPorCliente");

            PedidoColeção colecao = new PedidoColeção();

            foreach (DataRow linha in tabela.Rows)
            {
                Pedido pedido = new Pedido();
                pedido.IdPedido = Convert.ToInt32(linha["IdPedido"]);
                pedido.DataPedido = Convert.ToDateTime(linha["DataPedido"]);
                pedido.TotalPedido = Convert.ToDecimal(linha["ValorTotal"]); // Está certo!
                pedido.Cliente = new Cliente() { Nome = linha["Nome"].ToString() }; // Correto!

                Cliente cliente = new Cliente();
                cliente.Nome = linha["Nome"].ToString();
                pedido.Cliente = cliente;

                colecao.Add(pedido);
            }

            return colecao;
        }
    }
}