using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoBancoDados;
using ObjetoTrasnferencia;
using System.Data;


namespace Negocios
{
    public class ClienteNegócios
    {
        //Instanciar = criar um novo objeto baseado em um modelo.
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Cliente cliente)
        {
            try
            { 
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
            acessoDadosSqlServer.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
            acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.Sexo);
            acessoDadosSqlServer.AdicionarParametros("@LimiteCompra", cliente.LimiteCompra);
            string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();
                        
            return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string Alterar(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.idCliente);
                acessoDadosSqlServer.AdicionarParametros("@Nome", cliente.Nome);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", cliente.Sexo);
                acessoDadosSqlServer.AdicionarParametros("@LimiteCompra", cliente.LimiteCompra);
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Cliente cliente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", cliente.idCliente);
                string idCliente = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString();
                return idCliente;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ClienteColeção ConsultarPorNome(string nome)
        {
            try
            {
                // Criar uma nova coleção de clientes (aqui ela está vazia)
                ClienteColeção clienteColecao = new ClienteColeção();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@Nome", nome);

                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "upsClienteConsultarPorNome");

                //Percorrer o DataTable e transformar em coleção de cliente
                // Cada linha do DataTable é um cliente.
                //Data=Dados e Row = linha
                //For=Para   Each=Cada

                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //Criar um cliente vazio
                    //Colocar os dados da linha nele
                    //Adicionar ele na coleção

                    Cliente cliente = new Cliente();
                    cliente.idCliente = Convert.ToInt32(linha["IdCliente"]);
                    cliente.Nome = Convert.ToString(linha["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(linha["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(linha["LimiteCompra"]);

                    clienteColecao.Add(cliente);

                }
                return clienteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o cliente por nome. Detalhe:" + ex.Message);
            }
        }

        public ClienteColeção ConsultarPorId(int idCliente)
        {
            try
            {
                ClienteColeção clienteColecao = new ClienteColeção();

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParametros("@IdCliente", idCliente);

                DataTable dataTableCliente = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "upsClienteConsultarPorId");

                foreach (DataRow dataRowLinha in dataTableCliente.Rows)
                {
                    Cliente cliente = new Cliente();

                    cliente.idCliente = Convert.ToInt32(dataRowLinha["IdCliente"]);
                    cliente.Nome = Convert.ToString(dataRowLinha["Nome"]);
                    cliente.DataNascimento = Convert.ToDateTime(dataRowLinha["DataNascimento"]);
                    cliente.Sexo = Convert.ToBoolean(dataRowLinha["Sexo"]);
                    cliente.LimiteCompra = Convert.ToDecimal(dataRowLinha["LimiteCompra"]);

                    clienteColecao.Add(cliente);

                }

                return clienteColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível consultar o cliente por código. Detalhe:" + ex.Message);
            }
        }
    }
}
