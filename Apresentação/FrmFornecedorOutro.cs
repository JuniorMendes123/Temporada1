using iTextSharp.text.pdf.parser;
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
    public partial class FrmFornecedorOutro : Form
    {
        private FornecedorOutroNegocios negocios = new FornecedorOutroNegocios();

        public FrmFornecedorOutro()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void ConfigurarGrid()
        {
            dgvFornecedores.ReadOnly = true;
            dgvFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFornecedores.MultiSelect = false;
            dgvFornecedores.AllowUserToAddRows = false;
            dgvFornecedores.AllowUserToDeleteRows = false;
            dgvFornecedores.AllowUserToResizeRows = false;
            dgvFornecedores.RowHeadersVisible = false;
            dgvFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFornecedores.BackgroundColor = Color.White;

            // Formatação do cabeçalho
            dgvFornecedores.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvFornecedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvFornecedores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvFornecedores.EnableHeadersVisualStyles = false;

            // Largura menor para a coluna de Código
            dgvFornecedores.Columns["IdFornecedor"].HeaderText = "Código";
            dgvFornecedores.Columns["NomeFornecedor"].HeaderText = "Nome";

            dgvFornecedores.Columns["IdFornecedor"].FillWeight = 20;  // Código menor
            dgvFornecedores.Columns["NomeFornecedor"].FillWeight = 80;
        }
        private void CarregarDados()
        {
            dgvFornecedores.DataSource = negocios.Consultar();
            dgvFornecedores.Columns["IdFornecedor"].HeaderText = "Código";
            dgvFornecedores.Columns["NomeFornecedor"].HeaderText = "Nome";
            dgvFornecedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConfigurarGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Digite um nome para o fornecedor ou credor.");
                return;
            }

            var fornecedor = new FornecedorOutro
            {
                NomeFornecedor = txtNome.Text.Trim()
            };

            negocios.Inserir(fornecedor);
            txtNome.Clear();
            CarregarDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um fornecedor para excluir.");
                return;
            }

            int id = Convert.ToInt32(dgvFornecedores.SelectedRows[0].Cells["IdFornecedor"].Value);
            negocios.Excluir(id);
            CarregarDados();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFornecedorOutro_Load(object sender, EventArgs e)
        { 
            CarregarDados();
        }
    }
    
}
