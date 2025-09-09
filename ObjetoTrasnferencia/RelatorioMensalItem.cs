using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTrasnferencia
{
    public class RelatorioMensalItem
    {
        public string NomeCliente { get; set; }
        public string DescricaoProduto { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal CustoProduto { get; set; }
        public decimal Lucro { get; set; }
        public DateTime DataPedido { get; set; }
    }
    }
