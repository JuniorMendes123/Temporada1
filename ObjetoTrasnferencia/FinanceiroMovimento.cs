using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace ObjetoTrasnferencia
{
    public class FinanceiroMovimento
    {
        public int IdMovimento { get; set; }

        public string NomePessoa { get; set; }
        public string Tipo { get; set; } // Entrada ou Saída
        public DateTime Data { get; set; }
        public bool Pago { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime? DataVencimento { get; set; }
        public string Origem { get; set; }
        public string ClienteFornecedor { get; set; }
        public string NomeCliente { get; set; }
        public string NomeFornecedor { get; set; }
        public int? IdSaida { get; set; }


    }

}
