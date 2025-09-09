using AcessoBancoDados;
using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Negocios
{
    public class ProdutoBLL
    {
        public void InserirProduto(Produto produto)
        {
            // Validações
            if (string.IsNullOrEmpty(produto.Nome))
                throw new Exception("O nome do produto é obrigatório");

            if (produto.Preco <= 0)
                throw new Exception("O preço deve ser maior que zero");

            ProdutoDal dal = new ProdutoDal();
            dal.Inserir(produto); // CHAMAR A DAL aqui!
        }

        public ProdutoColecao ListarProdutos()
        {
            ProdutoDal dal = new ProdutoDal();
            return dal.ListarProdutos(); // CHAMAR A DAL aqui também
        }
    }
    // Métodos para alterar, excluir e buscar por ID
}
