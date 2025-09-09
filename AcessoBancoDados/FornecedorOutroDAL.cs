using AcessoBancoDados;
using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class FornecedorOutroDAL
    {
        private AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public void Inserir(FornecedorOutro fornecedor)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@NomeFornecedor", fornecedor.NomeFornecedor);
            acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFornecedorOutroInserir");
        }

        public void Excluir(int idFornecedor)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParametros("@IdFornecedor", idFornecedor);
            acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFornecedorOutroExcluir");
        }


        public List<FornecedorOutro> Consultar()
        {
            List<FornecedorOutro> lista = new List<FornecedorOutro>();

            acessoDadosSqlServer.LimparParametros(); // <-- IMPORTANTE

            DataTable tabela = acessoDadosSqlServer.ExecutarConsulta(
                CommandType.StoredProcedure,
                "uspFornecedorOutroConsultar"
            );

            foreach (DataRow linha in tabela.Rows)
            {
                FornecedorOutro f = new FornecedorOutro();
                f.IdFornecedor = Convert.ToInt32(linha["IdFornecedor"]);
                f.NomeFornecedor = linha["NomeFornecedor"].ToString();
                lista.Add(f);
            }

            return lista;
        }
        public List<FornecedorOutro> ListarTodos()
        {
            List<FornecedorOutro> lista = new List<FornecedorOutro>();
            AcessoDadosSqlServer acesso = new AcessoDadosSqlServer();

            DataTable tabela = acesso.ExecutarConsulta(
                CommandType.Text, "SELECT IdFornecedor, NomeFornecedor FROM tblFornecedorOutro");

            foreach (DataRow row in tabela.Rows)
            {
                FornecedorOutro f = new FornecedorOutro();
                f.IdFornecedor = Convert.ToInt32(row["IdFornecedor"]);
                f.NomeFornecedor = row["NomeFornecedor"].ToString();
                lista.Add(f);
            }

            return lista;
        }
    }
}
