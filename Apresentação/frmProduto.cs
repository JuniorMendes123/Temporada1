using Negocios;
using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentação
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto();
                p.Nome = txtNome.Text;
                p.Descricao = txtDescricao.Text;
                p.Preco = decimal.Parse(txtPreco.Text);
                p.Custo = decimal.Parse(txtCusto.Text);
                p.Estoque = int.Parse(txtEstoque.Text);

                ProdutoBLL bll = new ProdutoBLL();
                bll.InserirProduto(p);

                MessageBox.Show("Produto cadastrado com sucesso!");
                // Limpar campos, atualizar lista etc
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void labelCusto_Click(object sender, EventArgs e)
        {

        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

