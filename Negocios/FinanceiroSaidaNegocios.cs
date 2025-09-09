using Dados;
using ObjetoTrasnferencia;
using System;

namespace Negocios
{
    public class FinanceiroSaidaNegocios
    {
        private readonly FinanceiroSaidaDAL dal = new FinanceiroSaidaDAL();

        public void Inserir(FinanceiroSaida saida)
        {
            try
            {
                dal.Inserir(saida);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao lançar saída financeira. Detalhes: " + ex.Message);
            }
        }
    }
}
