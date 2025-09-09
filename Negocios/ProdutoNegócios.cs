using AcessoBancoDados;
using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class ProdutoNegócios
    {//Instanciar = criar um novo objeto baseado em um modelo.
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NomeProduto", produto.NomeProduto);
                acessoDadosSqlServer.AdicionarParametros("@DescricaoProduto", produto.DescricaoProduto);
                acessoDadosSqlServer.AdicionarParametros("@ValorVenda", produto.ValorVenda);
                acessoDadosSqlServer.AdicionarParametros("@ValorCusto", produto.ValorCusto);

                object retorno = acessoDadosSqlServer.ExecutarManipulacao(
                    CommandType.StoredProcedure, "uspProdutoInserir");

                if (retorno == null || retorno == DBNull.Value)
                    throw new Exception("A procedure não retornou o ID. Confira o SELECT SCOPE_IDENTITY().");

                return retorno.ToString();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string Alterar(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NomeProduto", produto.NomeProduto);
                acessoDadosSqlServer.AdicionarParametros("@DescricaoProduto", produto.DescricaoProduto);
                acessoDadosSqlServer.AdicionarParametros("@ValorVenda", produto.ValorVenda);
                acessoDadosSqlServer.AdicionarParametros("@ValorCusto", produto.ValorCusto);
                
                string idProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoAlterar").ToString();
                return idProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Produto produto)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdProduto", produto.idProduto);
                string idProduto = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoExcluir").ToString();
                return idProduto;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ProdutoColeção ConsultarPorNome(string nome)
        {
            try
            {
                // Criar uma nova coleção de clientes (aqui ela está vazia)
                ProdutoColeção produtoColecao = new ProdutoColeção();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@NomeProduto", nome);

                DataTable dataTableProduto = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProdutoConsultarPorNome");

                //Percorrer o DataTable e transformar em coleção de cliente
                // Cada linha do DataTable é um cliente.
                //Data=Dados e Row = linha
                //For=Para   Each=Cada

                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //Criar um cliente vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleção

                    Produto produto = new Produto();
                    produto.idProduto = Convert.ToInt32(linha["IdProduto"]);
                    produto.NomeProduto = Convert.ToString(linha["NomeProduto"]);
                    produto.DescricaoProduto = Convert.ToString(linha["DescricaoProduto"]);
                    produto.ValorVenda = Convert.ToDecimal(linha["ValorVenda"]);
                    produto.ValorCusto = Convert.ToDecimal(linha["ValorCusto"]);

                    produtoColecao.Add(produto);

                }
                return produtoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o produto por nome. Detalhe:" + ex.Message);
            }
        }

        public ProdutoColeção ConsultarPorId(int idProduto)
        {
            try
            {
                ProdutoColeção produtoColecao = new ProdutoColeção();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdProduto", idProduto);

                DataTable dataTableProduto = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "upsProdutoConsultarPorId");

                foreach (DataRow dataRowLinha in dataTableProduto.Rows)
                {
                    Produto produto = new Produto();
                    produto.idProduto = Convert.ToInt32(dataRowLinha["IdProduto"]);
                    produto.NomeProduto = Convert.ToString(dataRowLinha["NomeProduto"]);
                    produto.DescricaoProduto = Convert.ToString(dataRowLinha["DescricaoProduto"]);
                    produto.ValorVenda = Convert.ToDecimal(dataRowLinha["ValorVenda"]);
                    produto.ValorCusto = Convert.ToDecimal(dataRowLinha["ValorCusto"]); ;

                    produtoColecao.Add(produto);

                }

                return produtoColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o produto por código. Detalhe:" + ex.Message);
            }
        }
    }
}
