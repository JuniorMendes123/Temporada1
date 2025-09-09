using AcessoBancoDados;
using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocios
{
    public class PedidoItemNegocios
    {
        public List<PedidoItem> ConsultarPorPedido(int idPedido)
        {
            try
            {
                AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdPedido", idPedido);

                DataTable tabela = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoItemConsultarPorPedido");

                List<PedidoItem> lista = new List<PedidoItem>();

                foreach (DataRow row in tabela.Rows)
                {
                    PedidoItem item = new PedidoItem()
                    {
                        IdPedidoItem = row["IdPedidoItem"] != DBNull.Value ? Convert.ToInt32(row["IdPedidoItem"]) : 0,
                        IdPedido = row["IdPedido"] != DBNull.Value ? Convert.ToInt32(row["IdPedido"]) : 0,
                        IdProduto = row["IdProduto"] != DBNull.Value ? Convert.ToInt32(row["IdProduto"]) : 0,
                        Quantidade = row["Quantidade"] != DBNull.Value ? Convert.ToInt32(row["Quantidade"]) : 0,
                        ValorUnitario = row["PrecoUnitario"] != DBNull.Value ? Convert.ToDecimal(row["PrecoUnitario"]) : 0,
                        NomeProduto = row.Table.Columns.Contains("NomeProduto") && row["NomeProduto"] != DBNull.Value
                                      ? row["NomeProduto"].ToString()
                                      : string.Empty
                    };

                    lista.Add(item);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar itens do pedido. Detalhes: " + ex.Message);
            }
        }
    }
}
