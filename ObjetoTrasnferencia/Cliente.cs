using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTrasnferencia
{
    public class Cliente
    {
        public int idCliente {  get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Boolean Sexo { get; set; }
        public decimal LimiteCompra { get; set; }


        public Cliente cliente { get; set; }
    }
     
}