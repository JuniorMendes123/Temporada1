using AcessoBancoDados;
using System;
using System.Data;

public class OrcamentoDAL
{
    AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

    public DataTable Consultar(int idCliente)
    {
        try
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IdCliente", idCliente);

            return acessoDadosSqlServer.ExecutarConsulta(
                CommandType.StoredProcedure, "uspOrcamentoConsultar"
            );
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao consultar orçamentos. Detalhes: " + ex.Message);
        }
    }

    public DataTable ConsultarItens(int idOrcamento)
    {
        try
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IdOrcamento", idOrcamento);

            return acessoDadosSqlServer.ExecutarConsulta(
                CommandType.StoredProcedure, "uspOrcamentoItemConsultar"
            );
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao consultar itens do orçamento. Detalhes: " + ex.Message);
        }
    }

    public void Excluir(int idOrcamento)
    {
        try
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IdOrcamento", idOrcamento);

            acessoDadosSqlServer.ExecutarManipulacao(
                CommandType.StoredProcedure,
                "uspOrcamentoExcluir"
            );
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao excluir orçamento. Detalhes: " + ex.Message);
        }
    }
   
}

