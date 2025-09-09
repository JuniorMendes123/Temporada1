using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTrasnferencia
{
    public class Produto
    {
        //Variável
        public int idProduto { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal ValorCusto { get; set; }
    }   
}