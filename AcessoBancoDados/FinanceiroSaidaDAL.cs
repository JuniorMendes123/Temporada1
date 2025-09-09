using AcessoBancoDados;
using ObjetoTrasnferencia;
using System;
using System.Data;

namespace Dados
{
    public class FinanceiroSaidaDAL
    {
        private readonly AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

        // EXCLUIR SAÍDA (use o mesmo nome chamado pelo botão)
        public int ExcluirSaida(int idSaida)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdSaida", idSaida);

            // Se sua proc retorna @@ROWCOUNT, esse retorno vira o número de linhas afetadas
            object ret = acesso.ExecutarManipulacao(
                CommandType.StoredProcedure,
                "dbo.uspFinanceiroSaidaExcluir"   // confirme o nome exato no banco
            );

            return Convert.ToInt32(ret ?? 0);
        }

        // INSERIR SAÍDA
        public int Inserir(FinanceiroSaida saida)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdFornecedor", saida.IdFornecedor);

            // Você definiu que a data informada na tela é de VENCIMENTO.
            // Se sua proc espera @DataSaida, mantenha esse mapeamento:
            acesso.AdicionarParametros("@DataSaida", saida.DataVencimento);

            acesso.AdicionarParametros("@Valor", saida.Valor);
            acesso.AdicionarParametros("@Observacoes", saida.Observacoes ?? string.Empty);

            object ret = acesso.ExecutarManipulacao(
                CommandType.StoredProcedure,
                "dbo.uspFinanceiroSaidaInserir"   // padronize o nome no SQL
            );

            if (ret == null || ret == DBNull.Value)
                throw new Exception("A procedure 'uspFinanceiroSaidaInserir' não retornou o ID.");

            return Convert.ToInt32(ret);
        }
    }
}
