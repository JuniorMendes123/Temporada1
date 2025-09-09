using System;
using System.Collections.Generic;

namespace ObjetoTrasnferencia
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public string NomeCliente { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal TotalPedido { get; set; }
        public string Status { get; set; }

        public Cliente Cliente { get; set; } // <-- Adicione isso se ainda não existir

        // Lista dos itens que fazem parte do pedido
        public List<PedidoItem> Itens { get; set; } = new List<PedidoItem>();
    }
}