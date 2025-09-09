using AcessoBancoDados;
using System;
using System.Data;

namespace Negócios
{
    public class RelatorioNegocios
    {
        private readonly RelatorioDal relatorioDal = new RelatorioDal();

        public DataTable ConsultarRelatorioMensal(int ano, int mes, int? idCliente)
        {
            try
            {
                return relatorioDal.ConsultarRelatorioMensal(ano, mes, idCliente);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na camada de negócios ao consultar relatório mensal. Detalhes: " + ex.Message);
            }
        }
    }
}
