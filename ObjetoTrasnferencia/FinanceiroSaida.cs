using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTrasnferencia
{
    public class FinanceiroSaida
    {
        public int IdSaida { get; set; }
        public int IdFornecedor { get; set; }
        public DateTime? DataVencimento { get; set; }

        public DateTime DataLancamento { get; set; } // só para leitura/exibição
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
        public string Observacoes { get; set; }

        // Opcional: se quiser incluir o nome do fornecedor para exibição
        public string NomeFornecedor { get; set; }
    }
}
