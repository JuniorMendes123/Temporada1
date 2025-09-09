using ObjetoTrasnferencia;
using AcessoBancoDados;
using System;
using System.Data;


public class FornecedorNegocios
{
    AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

    public FornecedorColecao ConsultarPorNome(string nome)
    {
        acessoDados.LimparParametros();
        acessoDados.AdicionarParametros("@Nome", nome);

        DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "uspFornecedorConsultarPorNome");

        FornecedorColecao colecao = new FornecedorColecao();

        foreach (DataRow row in dataTable.Rows)
        {
            Fornecedor fornecedor = new Fornecedor
            {
                IdFornecedor = Convert.ToInt32(row["IdFornecedor"]),
                Nome = row["Nome"].ToString()
            };
            colecao.Add(fornecedor);
        }

        return colecao;
    }
}