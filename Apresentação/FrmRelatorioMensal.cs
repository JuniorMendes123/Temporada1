using Negocios;
using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Negócios;

namespace Apresentação
{
    public partial class FrmRelatorioMensal : Form
    {
        public FrmRelatorioMensal()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Load += FrmRelatorioMensal_Load; // ✅ Aqui está o local correto
        }

        private void FrmRelatorioMensal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;


            CarregarClientes();
            CarregarMeses();
            ConfigurarGrid();

            cbMes.SelectedIndex = DateTime.Now.Month - 1;
            txtAno.Text = DateTime.Now.Year.ToString();

            dgvRelatorio.Dock = DockStyle.Fill;
            dgvRelatorio.Margin = new Padding(0);
        }

        private void CarregarClientes()
        {
            ClienteNegócios clienteNegocios = new ClienteNegócios();
            ClienteColeção clienteColecao = clienteNegocios.ConsultarPorNome(""); // busca todos

            cbCliente.DataSource = clienteColecao;
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "IdCliente";
            cbCliente.SelectedIndex = -1;
        }

        private void CarregarMeses()
        {
            Dictionary<int, string> meses = new Dictionary<int, string>
            {
                { 1, "Janeiro" }, { 2, "Fevereiro" }, { 3, "Março" }, { 4, "Abril" },
                { 5, "Maio" }, { 6, "Junho" }, { 7, "Julho" }, { 8, "Agosto" },
                { 9, "Setembro" }, { 10, "Outubro" }, { 11, "Novembro" }, { 12, "Dezembro" }
            };

            cbMes.DataSource = new BindingSource(meses, null);
            cbMes.DisplayMember = "Value";
            cbMes.ValueMember = "Key";
            cbMes.SelectedIndex = -1;
        }

        private void ConfigurarGrid()
        {
            dgvRelatorio.AutoGenerateColumns = false;
            dgvRelatorio.Columns.Clear();

            dgvRelatorio.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataPedido",
                HeaderText = "Data da Venda",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvRelatorio.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeCliente",
                HeaderText = "Cliente",
                Width = 200
            });

            dgvRelatorio.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DescricaoProduto",
                HeaderText = "Produto",
                Width = 200
            });

            dgvRelatorio.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ValorVenda",
                HeaderText = "Venda",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvRelatorio.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustoProduto",
                HeaderText = "Custo",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            dgvRelatorio.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Lucro",
                HeaderText = "Lucro",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
            dgvRelatorio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // >>> Estilização adicional abaixo <<<

            dgvRelatorio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRelatorio.MultiSelect = false;
            dgvRelatorio.AllowUserToResizeRows = false;
            dgvRelatorio.RowHeadersVisible = false;
            dgvRelatorio.ReadOnly = true;

            dgvRelatorio.RowsDefaultCellStyle.BackColor = Color.White;
            dgvRelatorio.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

            dgvRelatorio.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvRelatorio.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvRelatorio.DefaultCellStyle.Font = new Font("Segoe UI", 9F);

            dgvRelatorio.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRelatorio.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvRelatorio.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvRelatorio.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRelatorio.EnableHeadersVisualStyles = false; // Necessário para aplicar estilo personalizado
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbMes.SelectedValue == null || string.IsNullOrWhiteSpace(txtAno.Text))
            {
                MessageBox.Show("Informe o mês e o ano para buscar o relatório.");
                return;
            }

            int mes = Convert.ToInt32(cbMes.SelectedValue);
            int ano = Convert.ToInt32(txtAno.Text);
            int? idCliente = cbCliente.SelectedIndex >= 0 ? (int?)cbCliente.SelectedValue : null;

            RelatorioMensalNegocios negocios = new RelatorioMensalNegocios();
            List<RelatorioMensalItem> lista = negocios.Consultar(mes, ano, idCliente);

            // Se o campo "Lucro" não vier preenchido na procedure, calcule manualmente:
            foreach (var item in lista)
            {
                if (item.Lucro == 0)
                {
                    item.Lucro = item.ValorVenda - item.CustoProduto;
                }
            }

            dgvRelatorio.DataSource = lista;

            decimal totalVenda = lista.Sum(i => i.ValorVenda);
            decimal totalCusto = lista.Sum(i => i.CustoProduto);
            decimal totalLucro = lista.Sum(i => i.Lucro);

            txtTotalVenda.Text = totalVenda.ToString("C2");
            txtTotalCusto.Text = totalCusto.ToString("C2");
            txtTotalLucro.Text = totalLucro.ToString("C2");

            txtTotalLucro.ForeColor = Color.Green;
            txtTotalLucro.Font = new Font(txtTotalLucro.Font, FontStyle.Bold);

            txtTotalCusto.ForeColor = Color.Red;
            txtTotalCusto.Font = new Font(txtTotalCusto.Font, FontStyle.Bold);

            txtTotalVenda.ForeColor = Color.Blue;
            txtTotalVenda.Font = new Font(txtTotalCusto.Font, FontStyle.Bold);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_2(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtTotalCusto_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void txtTotalVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalCusto_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblAno_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalVenda_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panelTopo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvRelatorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
