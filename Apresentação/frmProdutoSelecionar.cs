using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTrasnferencia;



namespace Apresentação
{
    public partial class frmProdutoSelecionar : Form
    {
        public frmProdutoSelecionar()
        {
            InitializeComponent();

            //NAO GERAR LINHAS AUTOMATICAMENTE
            dataGridView2.AutoGenerateColumns = false;
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }


        private void AtualizarGrid()
        {
            ProdutoNegócios produtoNegocios = new ProdutoNegócios();

            ProdutoColeção produtoColecao = new ProdutoColeção();

            produtoColecao = produtoNegocios.ConsultarPorNome(textPesquisarProduto.Text);

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = produtoColecao;

            dataGridView2.Update();
            dataGridView2.Refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Instanciar o formulário de cadastro
            FmrProdutoCadastrar fmrProdutoCadastrar = new FmrProdutoCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = fmrProdutoCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum registro selecionado
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            //Perguntar se realmente quer excluir

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            //Pegar o produto selecionado no grid

            Produto produtoSelecionado = (dataGridView2.SelectedRows[0].DataBoundItem as Produto);

            //Instânciar a regra de Negocios
            ProdutoNegócios produtoNegocios = new ProdutoNegócios();

            //Chamar o método para ecluir
            string retorno = produtoNegocios.Excluir(produtoSelecionado);

            //Verificar se excluiu com sucesso
            //Se o retorno for um numero é porque deu certo, senão é a mensagem de erro
            try
            {
                int IdProduto = Convert.ToInt32(retorno);
                MessageBox.Show("Produto excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid();

            }
            catch
            {
                MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            //Instanciar o formulário de cadastro
            FmrProdutoCadastrar fmrProdutoCadastrar = new FmrProdutoCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = fmrProdutoCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum registro selecionado
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            //Pegar o cliente selecionado no grid

            Produto produtoSelecionado = (dataGridView2.SelectedRows[0].DataBoundItem as Produto);

            //Instanciar o formulário de cadastro
            FmrProdutoCadastrar fmrProdutoCadastrar = new FmrProdutoCadastrar(AcaoNaTela.Alterar, produtoSelecionado);

            DialogResult resultado = fmrProdutoCadastrar.ShowDialog();
            if (resultado == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum registro selecionado
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum produto selecionado.");
                return;
            }

            //Pegar o produto selecionado no grid

            Produto produtoSelecionado = (dataGridView2.SelectedRows[0].DataBoundItem as Produto);

            //Instanciar o formulário de cadastro
            FmrProdutoCadastrar fmrProdutoCadastrar = new FmrProdutoCadastrar(AcaoNaTela.Consultar, produtoSelecionado);
            fmrProdutoCadastrar.ShowDialog();
        }
    }
    }


