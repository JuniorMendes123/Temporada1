using System;
using System.Data;
using System.Data.SqlClient;
using ObjetoTrasnferencia;

using Microsoft.Data.SqlClient;




namespace AcessoBancoDados
{
    public class ProdutoDal
    {
        public void Inserir(Produto produto)
        {
            AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

            using (SqlConnection conexao = acesso.CriarConexao())
            {
                SqlCommand comando = new SqlCommand(
                    "INSERT INTO dbo.Produto (Nome, Preco, PrecoVenda, Estoque) " +
                    "VALUES (@Nome, @Descricao, @Preco, @Estoque)", conexao);

                comando.Parameters.AddWithValue("@Nome", produto.Nome);
                comando.Parameters.AddWithValue("@Descricao", produto.Descricao);
                comando.Parameters.AddWithValue("@Preco", produto.Preco);
                comando.Parameters.AddWithValue("@PrecoVenda", produto.PrecoVenda);
                comando.Parameters.AddWithValue("@Estoque", produto.Estoque);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
        }

        public ProdutoColecao ListarProdutos()
        {
            ProdutoColecao colecao = new ProdutoColecao();

            // Aqui você deve colocar a lógica de SELECT no banco
            return colecao;
        }



        // Método para consultar produtos pelo nome
        public ProdutoColecao ConsultarPorNome(string nome)
        {
            try
            {
                // Criar coleção de retorno
                ProdutoColecao produtoColecao = new ProdutoColecao();

                // Conexão com o banco
                using (SqlConnection conexao = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=JuniorMendesSist;User Id=sa;Password=123456")
)
                {
                    conexao.Open();

                    string query = "SELECT IdProduto, Nome, Preco, Estoque FROM Produto WHERE Nome LIKE @Nome";

                    SqlCommand comando = new SqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@Nome", "%" + nome + "%");

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Produto produto = new Produto
                        {
                            Id = Convert.ToInt32(reader["IdProduto"]),
                            Nome = reader["Nome"].ToString(),
                            Preco = Convert.ToDecimal(reader["Preco"]),
                            Custo = Convert.ToDecimal(reader["Custo"]),
                            Estoque = Convert.ToInt32(reader["Estoque"])
                        };

                        produtoColecao.Add(produto);
                    }

                    return produtoColecao;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar produto por nome: " + ex.Message);
            }
        }
    }
}