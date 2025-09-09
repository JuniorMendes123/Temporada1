using ObjetoTrasnferencia;
using AcessoBancoDados;
using System;
using System.Collections.Generic;
using System.Data;


public class FinanceiroNegocios
{
    AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

    public List<FinanceiroMovimento> ConsultarMovimentos(DateTime dataInicio, DateTime dataFim, int? idCliente, int? idFornecedor)
    {
        acessoDados.LimparParametros();
        acessoDados.AdicionarParametros("@DataInicio", dataInicio);
        acessoDados.AdicionarParametros("@DataFim", dataFim);
        acessoDados.AdicionarParametros("@IdCliente", idCliente);
        acessoDados.AdicionarParametros("@IdFornecedor", idFornecedor);

        DataTable tabela = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "uspFinanceiroConsultarMovimentos");

        List<FinanceiroMovimento> lista = new List<FinanceiroMovimento>();

        foreach (DataRow row in tabela.Rows)
        {
            FinanceiroMovimento movimento = new FinanceiroMovimento
            {
                Data = Convert.ToDateTime(row["Data"]),
                Descricao = row["Descricao"].ToString(),
                Tipo = row["Tipo"].ToString(),
                Valor = Convert.ToDecimal(row["Valor"]),
                NomeCliente = row["NomeCliente"]?.ToString(),
                NomeFornecedor = row["NomeFornecedor"]?.ToString()
            };

            lista.Add(movimento);
        }

        return lista;
    }
    public List<FinanceiroMovimento> Consultar(DateTime dataInicio, DateTime dataFim, int? idPessoa)
    {
        FinanceiroDAL dal = new FinanceiroDAL();
        return dal.Consultar(dataInicio, dataFim, idPessoa);
    }


    public DataTable CarregarPessoas()
    {
        FinanceiroDAL dal = new FinanceiroDAL();
        return dal.ObterClientesEFornecedores();
    }
}
