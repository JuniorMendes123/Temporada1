using AcessoBancoDados;
using Dados;
using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Apresentação
{
    public partial class FrmFinanceiro : Form
    {
        public FrmFinanceiro()
        {
            InitializeComponent();
        }

        private void ConfigurarGridFinanceiro()
        {
            dgvMovimentos.AutoGenerateColumns = false;
            dgvMovimentos.Columns.Clear();

            // TIPO
            dgvMovimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTipo",
                DataPropertyName = "Tipo",
                HeaderText = "Tipo",
                Width = 80,
                ReadOnly = true
            });

            // DATA (=> propriedade é "Data", não "DataMovimento")
            dgvMovimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colData",
                DataPropertyName = "Data",
                HeaderText = "Data",
                Width = 100,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            // DESCRIÇÃO
            dgvMovimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescricao",
                DataPropertyName = "Descricao",
                HeaderText = "Descrição",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                ReadOnly = true
            });

            // VALOR
            dgvMovimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colValor",
                DataPropertyName = "Valor",
                HeaderText = "Valor",
                Width = 110,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            // ORIGEM
            dgvMovimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colOrigem",
                DataPropertyName = "Origem",
                HeaderText = "Origem",
                Width = 160,
                ReadOnly = true
            });

            // PAGO (bool -> checkbox)
            dgvMovimentos.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "colPago",
                DataPropertyName = "Pago",
                HeaderText = "Pago",
                Width = 60,
                ReadOnly = true
            });

            // IdSaida oculto (necessário para excluir)
            dgvMovimentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdSaida",
                DataPropertyName = "IdSaida",
                Visible = false,
                ReadOnly = true
            });

            // Comportamento/estilo
            dgvMovimentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovimentos.MultiSelect = false;
            dgvMovimentos.ReadOnly = true;
            dgvMovimentos.AllowUserToAddRows = false;
            dgvMovimentos.AllowUserToDeleteRows = false;
            dgvMovimentos.RowHeadersVisible = false;

            // Cores alternadas
            dgvMovimentos.RowsDefaultCellStyle.BackColor = Color.White;
            dgvMovimentos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void FrmFinanceiro_Load(object sender, EventArgs e)
        {


            ConfigurarGridFinanceiro();
            CarregarFiltroPessoas(); // <-- adicione essa chamada

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataInicio = dtpDataInicial.Value.Date;
                DateTime dataFim = dtpDataFinal.Value.Date;

                int? idPessoa = null;

                if (cbFiltroPessoa.SelectedItem is Cliente cliente)
                {
                    idPessoa = cliente.idCliente;
                }
                else if (cbFiltroPessoa.SelectedItem is Fornecedor fornecedor)
                {
                    idPessoa = fornecedor.IdFornecedor;
                }

                // Instanciar a camada de negócios
                FinanceiroNegocios financeiroNegocios = new FinanceiroNegocios();

                // Buscar movimentos
                List<FinanceiroMovimento> lista = financeiroNegocios.Consultar(dataInicio, dataFim, idPessoa);

                // Preencher a grid
                dgvMovimentos.DataSource = lista;

                // Calcular totais
                decimal totalEntrada = lista.Where(m => m.Tipo == "Entrada").Sum(m => m.Valor);
                decimal totalSaida = lista.Where(m => m.Tipo == "Saída").Sum(m => m.Valor);
                decimal saldo = totalEntrada - totalSaida;

                // Exibir totais
                txtTotalEntradas.Text = totalEntrada.ToString("C2");
                txtTotalSaidas.Text = totalSaida.ToString("C2");
                txtSaldo.Text = saldo.ToString("C2");

                // Cores
                txtTotalEntradas.ForeColor = Color.Green;
                txtTotalSaidas.ForeColor = Color.Red;
                txtSaldo.ForeColor = saldo >= 0 ? Color.Green : Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar dados financeiros.\n" + ex.Message);
            }
            if (dgvMovimentos.Rows.Count == 0)
                MessageBox.Show("Nenhum movimento encontrado no período informado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Carregar novamente a grid (se necessário)
            // CarregarMovimentos(); ← só chame se estiver de fato atualizando fora do try
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CarregarFiltroPessoas()
        {
            FinanceiroNegocios financeiroNegocios = new FinanceiroNegocios();
            DataTable tabela = financeiroNegocios.CarregarPessoas();

            cbFiltroPessoa.DisplayMember = "Nome";
            cbFiltroPessoa.ValueMember = "Id";
            cbFiltroPessoa.DataSource = tabela;

            cbFiltroPessoa.SelectedIndex = -1; // Nenhum selecionado inicialmente
        }

        private void btnLancarSaida_Click(object sender, EventArgs e)
        {
            FrmLancamentoSaida frm = new FrmLancamentoSaida();
            frm.FormClosed += (s, args) => CarregarMovimentos(); // Recarrega ao fechar a janela
            frm.ShowDialog();


        }
        private void CarregarMovimentos()
        {
            // Filtros
            DateTime dataInicio = dtpDataInicial.Value.Date;
            DateTime dataFim = dtpDataFinal.Value.Date;
            int? idPessoa = cbFiltroPessoa.SelectedValue as int?;

            // Buscar dados via camada de negócios
            FinanceiroNegocios negocios = new FinanceiroNegocios();
            List<FinanceiroMovimento> lista = negocios.Consultar(dataInicio, dataFim, idPessoa);

            // Exibir na grid
            dgvMovimentos.DataSource = lista;

        }


        private void btnExcluirSaida_Click(object sender, EventArgs e)
        {
            if (dgvMovimentos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um lançamento.");
                return;
            }

            var mov = dgvMovimentos.CurrentRow.DataBoundItem as FinanceiroMovimento;
            if (mov == null)
            {
                MessageBox.Show("Linha inválida.");
                return;
            }

            if (!string.Equals(mov.Tipo, "Saída", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Só é possível excluir lançamentos do tipo Saída.");
                return;
            }

            if (!mov.IdSaida.HasValue)
            {
                MessageBox.Show("Id da saída não encontrado nesta linha.");
                return;
            }

            if (MessageBox.Show("Confirma a exclusão desta saída?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                var dal = new Dados.FinanceiroSaidaDAL();
                int afetadas = dal.ExcluirSaida(mov.IdSaida.Value);

                if (afetadas > 0)
                    MessageBox.Show("Saída excluída com sucesso.");
                else
                    MessageBox.Show("Nenhum registro foi excluído. Verifique se o Id existe.");

                CarregarMovimentos();
            }
            catch (Microsoft.Data.SqlClient.SqlException sqlEx)
            {
                MessageBox.Show("Erro SQL ao excluir: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

    }

}
