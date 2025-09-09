namespace ObjetoTrasnferencia
{
    public class PedidoItem
    {
        public int IdPedidoItem { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Subtotal 
        {
            get { return Quantidade * ValorUnitario; }
        }
    }
}