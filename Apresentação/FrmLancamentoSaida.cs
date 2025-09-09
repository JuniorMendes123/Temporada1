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
    public partial class FrmLancamentoSaida : Form
    {
        public FrmLancamentoSaida()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validação
            if (cbPessoa.SelectedValue == null)
            {
                MessageBox.Show("Selecione um fornecedor ou credor.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtValor.Text) || !decimal.TryParse(txtValor.Text, out decimal valor) || valor <= 0)
            {
                MessageBox.Show("Informe um valor válido.");
                return;
            }

            // Monta o objeto
            FinanceiroSaida saida = new FinanceiroSaida();
            saida.IdFornecedor = Convert.ToInt32(cbPessoa.SelectedValue);
            saida.DataVencimento = dtData.Value.Date;
            saida.Valor = valor;
            saida.Observacoes = txtObservacoes.Text?.Trim();

            try
            {
                FinanceiroSaidaNegocios negocios = new FinanceiroSaidaNegocios();
                negocios.Inserir(saida);

                MessageBox.Show("Lançamento de saída salvo com sucesso!");
                this.Close(); // Fecha a tela após salvar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar saída: " + ex.Message);
            }
        }
        private void CarregarFornecedores()
        {
            FornecedorOutroNegocios negocios = new FornecedorOutroNegocios();
            List<FornecedorOutro> lista = negocios.ListarTodos();

            cbPessoa.DisplayMember = "NomeFornecedor";
            cbPessoa.ValueMember = "IdFornecedor";
            cbPessoa.DataSource = lista;

        }
        private void FrmLancamentoSaida_Load(object sender, EventArgs e)
        {
            CarregarFornecedores();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
