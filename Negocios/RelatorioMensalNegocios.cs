using AcessoBancoDados;
using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negócios
{
    public class RelatorioMensalNegocios
    {
        private readonly AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public List<RelatorioMensalItem> Consultar(int mes, int ano, int? idCliente)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Mes", mes);
            acessoDados.AdicionarParametros("@Ano", ano);
            acessoDados.AdicionarParametros("@IdCliente", idCliente);

            DataTable tabela = acessoDados.ExecutarConsulta(
                CommandType.StoredProcedure,
                "uspRelatorioMensalPedidos");

            List<RelatorioMensalItem> lista = new List<RelatorioMensalItem>();

            foreach (DataRow row in tabela.Rows)
            {
                RelatorioMensalItem item = new RelatorioMensalItem
                {
                    DataPedido = Convert.ToDateTime(row["DataPedido"]),
                    NomeCliente = row["NomeCliente"].ToString(),
                    DescricaoProduto = row["DescricaoProduto"].ToString(),
                    Quantidade = Convert.ToInt32(row["Quantidade"]),
                    ValorUnitario = Convert.ToDecimal(row["PrecoUnitario"]),
                    ValorVenda = Convert.ToDecimal(row["ValorVenda"]),
                    CustoProduto = Convert.ToDecimal(row["ValorCusto"]),
                    Lucro = Convert.ToDecimal(row["Lucro"])
                };

                lista.Add(item);
            }

            return lista;
        }
    }
}
