using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTrasnferencia;
using Negocios;

namespace Apresentação
{
    public partial class FmrProdutoCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;
        public FmrProdutoCadastrar(AcaoNaTela acaoNaTela, Produto produto)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Produto";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Produto";
                textBoxCodigoProduto.Text = produto.idProduto.ToString();
                textBoxNomeProduto.Text = produto.NomeProduto;
                textBoxDescricaoProduto.Text = produto.DescricaoProduto;
                textBoxValorVenda.Text = produto.ValorVenda.ToString();
                textBoxValorCusto.Text = produto.ValorCusto.ToString();


            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Produto";

                //Carregar campos da tela
                textBoxCodigoProduto.Text = produto.idProduto.ToString();
                textBoxNomeProduto.Text = produto.NomeProduto;
                textBoxDescricaoProduto.Text = produto.DescricaoProduto;
                textBoxValorVenda.Text = produto.ValorVenda.ToString();
                textBoxValorCusto.Text = produto.ValorCusto.ToString();



                //Desabilitar os campos da tela 
                textBoxNomeProduto.ReadOnly = true;
                textBoxNomeProduto.TabStop = false;

                textBoxDescricaoProduto.ReadOnly = true;
                textBoxDescricaoProduto.TabStop = false;

                textBoxValorVenda.ReadOnly = true;
                textBoxValorVenda.TabStop = false;

                textBoxValorCusto.ReadOnly = true;
                textBoxValorCusto.TabStop = false;



                btnSalvarProd.Visible = false;
                btnCancelarProd.Text = "Fechar";
                btnCancelarProd.Focus();



            }


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNomeProd_Click(object sender, EventArgs e)
        {

        }

        private void labelDescricaoProd_Click(object sender, EventArgs e)
        {

        }

        private void labelCódigoProd_Click(object sender, EventArgs e)
        {

        }

        private void FmrProdutoCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            //Verificar se é inserção ou alteração
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                Produto produto = new Produto();
                produto.NomeProduto = textBoxNomeProduto.Text;
                produto.DescricaoProduto = textBoxDescricaoProduto.Text;
                produto.ValorVenda = Convert.ToDecimal(textBoxValorVenda.Text);
                produto.ValorCusto = Convert.ToDecimal(textBoxValorCusto.Text);

                ProdutoNegócios produtoNegócios = new ProdutoNegócios();
                string retorno = produtoNegócios.Inserir(produto);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro

                try
                {
                    int idProduto = Convert.ToInt32(retorno);

                    MessageBox.Show("Produto inserido com sucesso. Código: " + idProduto.ToString());

                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível inserir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }


            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                //Crio um cliente
                Produto produto = new Produto();

                //Colo os campos da tela no objeto cliente e envio para alterar no banco
                produto.idProduto = Convert.ToInt32(textBoxCodigoProduto.Text);
                produto.NomeProduto = textBoxNomeProduto.Text;
                produto.DescricaoProduto = textBoxDescricaoProduto.Text;
                produto.ValorVenda = Convert.ToInt32(textBoxValorVenda.Text);
                produto.ValorCusto = Convert.ToInt32(textBoxValorCusto.Text);


                ProdutoNegócios produtoNegócios = new ProdutoNegócios();
                string retorno = produtoNegócios.Alterar(produto);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro

                try
                {
                    int idProduto = Convert.ToInt32(retorno);

                    MessageBox.Show("Produto alterado com sucesso. Código: " + idProduto.ToString());

                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível alterar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }

        }

        private void btnCancelarProd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}