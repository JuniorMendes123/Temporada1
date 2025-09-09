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
    public partial class FrmProdutoConsulta : Form
    {
        public Produto ProdutoSelecionado { get; private set; }
        public FrmProdutoConsulta()
        {
            InitializeComponent();
        }


        private void FrmProdutoConsulta_Load(object sender, EventArgs e)
        {
            ProdutoNegócios produtoNegocios = new ProdutoNegócios();
            ProdutoColeção produtos = produtoNegocios.ConsultarPorNome("");
            dgvProdutos.DataSource = produtos;

            // Ajusta cabeçalhos
            dgvProdutos.Columns["IdProduto"].HeaderText = "Código";
            dgvProdutos.Columns["NomeProduto"].HeaderText = "Produto";
            dgvProdutos.Columns["DescricaoProduto"].HeaderText = "Descrição";
            dgvProdutos.Columns["ValorVenda"].HeaderText = "Valor Unit.";
            dgvProdutos.Columns["ValorCusto"].HeaderText = "Custo";

            // Preenchimento proporcional
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ✅ Peso proporcional de cada coluna
            dgvProdutos.Columns["IdProduto"].FillWeight = 40;      // Menor
            dgvProdutos.Columns["NomeProduto"].FillWeight = 100;
            dgvProdutos.Columns["DescricaoProduto"].FillWeight = 180;     // Maior espaço
            dgvProdutos.Columns["ValorVenda"].FillWeight = 60;     // Menor
            dgvProdutos.Columns["ValorCusto"].FillWeight = 60;          // Menor

            // Estética (opcional)
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToResizeRows = false;

            dgvProdutos.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvProdutos.DefaultCellStyle.ForeColor = Color.Black;
            dgvProdutos.DefaultCellStyle.BackColor = Color.White;
            dgvProdutos.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvProdutos.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Formata valor como moeda
            dgvProdutos.Columns["ValorVenda"].DefaultCellStyle.Format = "C2";
            dgvProdutos.Columns["ValorCusto"].DefaultCellStyle.Format = "N2";
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow != null)
            {
                ProdutoSelecionado = dgvProdutos.CurrentRow.DataBoundItem as Produto;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();  
        }
    }
}
