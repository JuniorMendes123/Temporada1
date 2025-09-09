using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AcessoBancoDados
{
    public class FinanceiroDAL
    {
        private readonly AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        // OVERLOAD simples chamado pelo Negócios
        public List<FinanceiroMovimento> Consultar(DateTime dataInicio, DateTime dataFim, int? idPessoa, bool? pessoaEhFornecedor = null)
        {
            int? idCliente = null;
            int? idFornecedor = null;

            if (idPessoa.HasValue)
            {
                if (pessoaEhFornecedor == true) idFornecedor = idPessoa;
                else idCliente = idPessoa;
            }

            return ConsultarPorPeriodo(dataInicio, dataFim, idCliente, idFornecedor);
        }

        // Método que faz a consulta na procedure uspFinanceiroConsultar
        public List<FinanceiroMovimento> ConsultarPorPeriodo(DateTime dataInicio, DateTime dataFim, int? idCliente, int? idFornecedor)
        {
            var lista = new List<FinanceiroMovimento>();

            acesso.LimparParametros();
            acesso.AdicionarParametros("@DataInicio", dataInicio);
            acesso.AdicionarParametros("@DataFim", dataFim);
            acesso.AdicionarParametros("@IdCliente", (object)idCliente ?? DBNull.Value);
            acesso.AdicionarParametros("@IdFornecedor", (object)idFornecedor ?? DBNull.Value);

            DataTable tabela = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspFinanceiroConsultar");

            foreach (DataRow row in tabela.Rows)
            {
                var mov = new FinanceiroMovimento
                {
                    Tipo = SafeGet<string>(row, "Tipo"),
                    Data = SafeGet<DateTime>(row, "Data"),
                    DataVencimento = SafeGet<DateTime?>(row, "DataVencimento"),
                    Origem = SafeGet<string>(row, "Origem"),
                    NomePessoa = SafeGet<string>(row, "Origem"),
                    Descricao = SafeGet<string>(row, "Descricao"),
                    Valor = SafeGet<decimal>(row, "Valor"),
                    Pago = SafeGet<bool>(row, "Pago"),
                    IdSaida = SafeGet<int?>(row, "IdSaida"),
                };
                lista.Add(mov);
            }
            return lista;
        
        }

        public DataTable ObterClientesEFornecedores()
        {
            acesso.LimparParametros();
            // ajuste o nome se sua proc tiver outro:
            return acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspObterClientesFornecedores");
        }

        // helper
        private static T SafeGet<T>(DataRow row, string col, string fallbackColumn = null)
        {
            string useCol = row.Table.Columns.Contains(col) ? col :
                            (!string.IsNullOrEmpty(fallbackColumn) && row.Table.Columns.Contains(fallbackColumn) ? fallbackColumn : null);
            if (useCol == null || row[useCol] == DBNull.Value) return default!;
            Type target = Nullable.GetUnderlyingType(typeof(T)) ?? typeof(T);
            return (T)Convert.ChangeType(row[useCol], target);
        }

        // Se quiser manter, alinhe esta assinatura; caso contrário, remova para não confundir
        // (Ela estava usando parâmetros/colunas diferentes da procedure.)
        // public FinanceiroMovimentoColecao ConsultarPorPeriodo(...) { REMOVER/ATUALIZAR }

       
       
    }
}
