using ObjetoTrasnferencia;
using Dados;
using System.Collections.Generic;

namespace Negocios
{
    public class FornecedorOutroNegocios
    {
        private FornecedorOutroDAL fornecedorDal = new FornecedorOutroDAL();

        public void Inserir(FornecedorOutro fornecedor)
        {
            // Aqui você pode adicionar validações se quiser, antes de salvar
            fornecedorDal.Inserir(fornecedor);
        }

        public void Excluir(int idFornecedor)
        {
            fornecedorDal.Excluir(idFornecedor);
        }

        public List<FornecedorOutro> Consultar()
        {
            return fornecedorDal.Consultar();
        }
        public List<FornecedorOutro> ListarTodos()
        {
            FornecedorOutroDAL dal = new FornecedorOutroDAL();
            return dal.ListarTodos();
        }
    }
}
