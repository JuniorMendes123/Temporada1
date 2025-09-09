using AcessoBancoDados;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic.ApplicationServices;
using Negocios;
using ObjetoTrasnferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FontPdf = iTextSharp.text.Font;

namespace Apresentação
{
    public partial class FmrPedido : Form
    {
        private bool carregouTela = false;
        public FmrPedido()
        {
            InitializeComponent();
        }
        private void ConfigurarGridOrcamento()
        {
            dgvItensOrcamento.Columns.Clear();

            dgvItensOrcamento.Columns.Add("IdProduto", "Código");
            dgvItensOrcamento.Columns.Add("NomeProduto", "Produto");
            dgvItensOrcamento.Columns.Add("Quantidade", "Qtd");
            dgvItensOrcamento.Columns.Add("ValorUnitario", "Valor Unit.");
            dgvItensOrcamento.Columns.Add("Subtotal", "Subtotal");

            dgvItensOrcamento.Columns["IdProduto"].ReadOnly = true;
            dgvItensOrcamento.Columns["NomeProduto"].ReadOnly = true;
            dgvItensOrcamento.Columns["ValorUnitario"].ReadOnly = true;
            dgvItensOrcamento.Columns["Subtotal"].ReadOnly = true;
            dgvItensOrcamento.Columns["Quantidade"].ReadOnly = false;

            dgvItensOrcamento.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItensOrcamento.Columns["ValorUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvItensOrcamento.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvItensOrcamento.Columns["ValorUnitario"].DefaultCellStyle.Format = "C2";
            dgvItensOrcamento.Columns["Subtotal"].DefaultCellStyle.Format = "C2";

            dgvItensOrcamento.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dgvItensOrcamento.DefaultCellStyle.ForeColor = Color.Black;
            dgvItensOrcamento.DefaultCellStyle.BackColor = Color.White;
            dgvItensOrcamento.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvItensOrcamento.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvItensOrcamento.ReadOnly = false;
            dgvItensOrcamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensOrcamento.RowHeadersVisible = false;
            dgvItensOrcamento.AllowUserToAddRows = false;
            dgvItensOrcamento.AllowUserToResizeRows = false;
            dgvItensOrcamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvItensOrcamento.CellEndEdit -= dgvItensOrcamento_CellEndEdit; // Remove se já existir
            dgvItensOrcamento.CellEndEdit += dgvItensOrcamento_CellEndEdit; // Adiciona novamente


        }
        private void CarregarClientesOrcamento()
        {
            ClienteNegócios clienteNegocios = new ClienteNegócios();
            var clientes = clienteNegocios.ConsultarPorNome("");
            cbClienteOrcamento.DataSource = clientes;
            cbClienteOrcamento.DisplayMember = "Nome";
            cbClienteOrcamento.ValueMember = "IdCliente";
        }
        private void dgvItensOrcamento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvItensOrcamento.Columns[e.ColumnIndex].Name == "Quantidade")
            {
                DataGridViewRow row = dgvItensOrcamento.Rows[e.RowIndex];

                try
                {
                    int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                    decimal valorUnitario = Convert.ToDecimal(row.Cells["ValorUnitario"].Value);
                    decimal subtotal = quantidade * valorUnitario;

                    row.Cells["Subtotal"].Value = subtotal;

                    CalcularTotalOrcamento(); // Este método pode somar os subtotais e atualizar o campo Total
                }
                catch
                {
                    MessageBox.Show("Quantidade inválida!");
                }
            }
        }

        private async void FmrPedido_Shown(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                await Task.Run(() =>
                {
                    ClienteNegócios clienteNegocios = new ClienteNegócios();
                    var clientes = clienteNegocios.ConsultarPorNome("");

                    // Atualiza o ComboBox na thread da interface
                    Invoke((MethodInvoker)(() =>
                    {
                        cbCliente.DataSource = clientes;
                        cbCliente.DisplayMember = "Nome";
                        cbCliente.ValueMember = "IdCliente";
                    }));
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            carregouTela = true; // ✅ AGORA SIM: liberando a mudança de aba corretamente
        }
        private void dgvItensPedido_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvItensPedido.Columns["Quantidade"].Index)
            {
                try
                {
                    // Obtém valores da linha
                    var linha = dgvItensPedido.Rows[e.RowIndex];
                    int quantidade = Convert.ToInt32(linha.Cells["Quantidade"].Value);
                    decimal valorUnitario = Convert.ToDecimal(linha.Cells["ValorUnitario"].Value);

                    // Recalcula subtotal
                    linha.Cells["Subtotal"].Value = quantidade * valorUnitario;

                    // Recalcula total geral
                    CalcularTotal();
                }
                catch
                {
                    MessageBox.Show("Quantidade inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CalcularTotalOrcamento()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvItensOrcamento.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    decimal subtotal;
                    if (decimal.TryParse(row.Cells["Subtotal"].Value.ToString(), out subtotal))
                    {
                        total += subtotal;
                    }
                }
            }

            txtTotalOrcamento.Text = total.ToString("C2"); // Ajuste para o nome correto da TextBox do total
        }

        private void dgvItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FmrPedido_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // Configuração da grid
                dgvItensPedido.ReadOnly = true;
                dgvItensPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvItensPedido.RowHeadersVisible = false;
                dgvItensPedido.AllowUserToAddRows = false;
                dgvItensPedido.AllowUserToResizeRows = false;
                dgvItensPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvItensPedido.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                dgvItensPedido.DefaultCellStyle.ForeColor = Color.Black;
                dgvItensPedido.DefaultCellStyle.BackColor = Color.White;
                dgvItensPedido.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dgvItensPedido.DefaultCellStyle.SelectionForeColor = Color.Black;

                dgvItensPedido.Columns.Add("IdProduto", "Código");
                dgvItensPedido.Columns.Add("NomeProduto", "Produto");
                dgvItensPedido.Columns.Add("Quantidade", "Qtd");
                dgvItensPedido.Columns.Add("ValorUnitario", "Valor Unit.");
                dgvItensPedido.Columns.Add("Subtotal", "Subtotal");

                dgvItensPedido.Columns["Quantidade"].ReadOnly = false;
                dgvItensPedido.Columns["IdProduto"].ReadOnly = true;
                dgvItensPedido.Columns["NomeProduto"].ReadOnly = true;
                dgvItensPedido.Columns["ValorUnitario"].ReadOnly = true;
                dgvItensPedido.Columns["Subtotal"].ReadOnly = true;



                dgvItensPedido.CellEndEdit += dgvItensPedido_CellEndEdit;

                tabControl1.SelectedTab = tabPedido;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar formulário: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default; // Garantia de voltar ao cursor normal
            }

            // Vai carregar os clientes depois que o formulário estiver visível
            this.Shown += FmrPedido_Shown;

            this.UseWaitCursor = false;
            this.Cursor = Cursors.Default;
            Application.DoEvents(); // força a interface a atualizar o cursor
        }


        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            FrmProdutoConsulta frmProdutoConsulta = new FrmProdutoConsulta();

            if (frmProdutoConsulta.ShowDialog() == DialogResult.OK)
            {
                Produto produto = frmProdutoConsulta.ProdutoSelecionado;

                int quantidade = 1; // futuramente você pode permitir editar
                decimal subtotal = quantidade * produto.ValorVenda;

                dgvItensPedido.Rows.Add(
                    produto.idProduto,
                    produto.NomeProduto,
                    quantidade,
                    produto.ValorVenda,
                    subtotal
                );

                CalcularTotal();
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvItensPedido.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            txtTotalPedido.Text = total.ToString("N2");
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {

        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteNegócios clienteNegocios = new ClienteNegócios();
            cbCliente.DataSource = clienteNegocios.ConsultarPorNome("");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            {

            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carregouTela)
                return;

            if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Name == "tabOrcamento")
            {
                CarregarClientesOrcamento();
                ConfigurarGridOrcamento();
            }
        }

        private void btnAdicionarProdutoOrcamento_Click(object sender, EventArgs e)
        {
            FrmProdutoConsulta frmProdutoConsulta = new FrmProdutoConsulta();

            if (frmProdutoConsulta.ShowDialog() == DialogResult.OK)
            {
                Produto produto = frmProdutoConsulta.ProdutoSelecionado;

                int quantidade = 1; // valor padrão inicial
                decimal subtotal = quantidade * produto.ValorVenda;

                dgvItensOrcamento.Rows.Add(
                    produto.idProduto,
                    produto.NomeProduto,
                    quantidade,
                    produto.ValorVenda,
                    subtotal
                );

                CalcularTotalOrcamento(); // atualiza o total
            }
        }
        private void LimparCamposOrcamento()
        {
            cbClienteOrcamento.SelectedIndex = -1;
            dtpDataOrcamento.Value = DateTime.Now;
            textBox1.Clear(); // Se estiver usando

            dgvItensOrcamento.Rows.Clear(); // Limpa os produtos da grid
            txtTotalOrcamento.Text = "R$ 0,00"; // Atualiza o total visual
        }

        private void btnRemoverProdutoOrcamento_Click(object sender, EventArgs e)
        {
            if (dgvItensOrcamento.CurrentRow != null)
            {
                dgvItensOrcamento.Rows.Remove(dgvItensOrcamento.CurrentRow);
                CalcularTotalOrcamento(); // Atualiza o total
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private decimal CalcularTotalGrid()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvItensOrcamento.Rows)
            {
                if (row.Cells["Quantidade"].Value != null && row.Cells["ValorUnitario"].Value != null)
                {
                    int qtd = Convert.ToInt32(row.Cells["Quantidade"].Value);
                    decimal valor = Convert.ToDecimal(row.Cells["ValorUnitario"].Value);
                    total += qtd * valor;
                }
            }
            return total;
        }

        private void btnSalvarOrcamento_Click(object sender, EventArgs e)
        {
            if (cbClienteOrcamento.SelectedValue == null || dgvItensOrcamento.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Selecione um cliente e adicione pelo menos um produto.");
                return;
            }

            try
            {
                int idCliente = Convert.ToInt32(cbClienteOrcamento.SelectedValue);
                DateTime data = DateTime.Now;
                decimal total = CalcularTotalGrid(); // usando dgvItensOrcamento

                // SALVA CABEÇALHO
                AcessoDadosSqlServer acessoCabecalho = new AcessoDadosSqlServer();
                acessoCabecalho.LimparParametros();
                acessoCabecalho.AdicionarParametros("@IdCliente", idCliente);
                acessoCabecalho.AdicionarParametros("@DataOrcamento", data);
                acessoCabecalho.AdicionarParametros("@Total", total);
                acessoCabecalho.AdicionarParametros("@IdOrcamento", 0, true);

                object resultado = acessoCabecalho.ExecutarManipulacao(CommandType.StoredProcedure, "uspOrcamentoInserir");
                int idOrcamento = Convert.ToInt32(resultado);

                // SALVA ITENS
                foreach (DataGridViewRow row in dgvItensOrcamento.Rows)
                {
                    if (row.IsNewRow) continue;

                    int idProduto = Convert.ToInt32(row.Cells["IdProduto"].Value);
                    int quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                    decimal valorUnitario = Convert.ToDecimal(row.Cells["ValorUnitario"].Value);
                    decimal subtotal = quantidade * valorUnitario;

                    AcessoDadosSqlServer acessoItem = new AcessoDadosSqlServer();
                    acessoItem.LimparParametros();
                    acessoItem.AdicionarParametros("@IdOrcamento", idOrcamento);
                    acessoItem.AdicionarParametros("@IdProduto", idProduto);
                    acessoItem.AdicionarParametros("@Quantidade", quantidade);
                    acessoItem.AdicionarParametros("@ValorUnitario", valorUnitario);
                    acessoItem.AdicionarParametros("@Subtotal", subtotal); // ✅ ADICIONADO

                    acessoItem.ExecutarManipulacao(CommandType.StoredProcedure, "uspOrcamentoItemInserir");
                }

                MessageBox.Show("Orçamento salvo com sucesso!");
                LimparCamposOrcamento();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar orçamento: " + ex.Message);

            }
        }


        private void tabOrcamento_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarProduto_Click_1(object sender, EventArgs e)
        {
            FrmProdutoConsulta frmProdutoConsulta = new FrmProdutoConsulta();

            if (frmProdutoConsulta.ShowDialog() == DialogResult.OK)
            {
                Produto produto = frmProdutoConsulta.ProdutoSelecionado;

                int quantidade = 1; // futuramente você pode permitir editar
                decimal subtotal = quantidade * produto.ValorVenda;

                dgvItensPedido.Rows.Add(
                    produto.idProduto,
                    produto.NomeProduto,
                    quantidade,
                    produto.ValorVenda,
                    subtotal
                );

                CalcularTotal();
            }
        }

        private void btnRemoverItem_Click_1(object sender, EventArgs e)
        {
            if (dgvItensPedido.CurrentRow != null)
            {
                dgvItensPedido.Rows.Remove(dgvItensPedido.CurrentRow);
                CalcularTotal(); // Atualiza o total do pedido após remover
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFinalizarPedido_Click_1(object sender, EventArgs e)
        {
            if (dgvItensPedido.Rows.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto ao pedido antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Monta o objeto Pedido
                Pedido pedido = new Pedido();
                pedido.IdCliente = Convert.ToInt32(cbCliente.SelectedValue);
                pedido.DataPedido = DateTime.Now;
                pedido.TotalPedido = Convert.ToDecimal(txtTotalPedido.Text);
                pedido.IdCliente = ((Cliente)cbCliente.SelectedItem).idCliente;

                // 2. Monta os itens do pedido
                foreach (DataGridViewRow row in dgvItensPedido.Rows)
                {
                    PedidoItem item = new PedidoItem();
                    item.IdProduto = Convert.ToInt32(row.Cells["IdProduto"].Value);
                    item.Quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);
                    item.ValorUnitario = Convert.ToDecimal(row.Cells["ValorUnitario"].Value);

                    pedido.Itens.Add(item);
                }

                // 3. Grava o pedido
                PedidoDal pedidoDal = new PedidoDal();
                int idPedidoGerado = pedidoDal.Inserir(pedido);

                // 4. Grava os itens
                PedidoItemDal itemDal = new PedidoItemDal();
                foreach (PedidoItem item in pedido.Itens)
                {
                    item.IdPedido = idPedidoGerado; // importante!
                    itemDal.Inserir(item);
                }

                MessageBox.Show("Pedido salvo com sucesso! Código: " + idPedidoGerado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: limpar os campos após salvar
                dgvItensPedido.Rows.Clear();
                txtTotalPedido.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar pedido: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerarPdfOrcamento_Click(object sender, EventArgs e)
        {
            if (cbClienteOrcamento.SelectedItem == null || dgvItensOrcamento.Rows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente e adicione produtos antes de gerar o PDF.");
                return;
            }

            // Caminho para salvar o PDF
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            salvar.FileName = "Orcamento.pdf";

            if (salvar.ShowDialog() != DialogResult.OK)
                return;

            // Cria o documento
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(salvar.FileName, FileMode.Create));
            doc.Open();
            // Logo centralizada
            string caminhoLogo = Application.StartupPath + @"\logo.png";
            if (File.Exists(caminhoLogo))
            {
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminhoLogo);
                logo.ScaleAbsolute(120, 120); // Ajuste conforme necessário
                logo.Alignment = Element.ALIGN_CENTER; // <- Centraliza a imagem
                doc.Add(logo);
            }

            // Cabeçalho da empresa centralizado
            Paragraph cabecalho = new Paragraph(
                "José Luiz Mendes da Silva Junior\n" +
                "CNPJ: 50.258.785/0001-75\n" +
                "Av. Prof. Maria de Lourdes Andrade Hortal, 580 - Hercules Hortal - Bebedouro/SP\n\n",
                new FontPdf(FontPdf.FontFamily.HELVETICA, 10, FontPdf.NORMAL)
            );
            cabecalho.Alignment = Element.ALIGN_CENTER; // <- Centraliza o parágrafo
            doc.Add(cabecalho);

            // Título
            FontPdf fonteTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            var titulo = new Paragraph("Orçamento", fonteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            doc.Add(new Paragraph(" ")); // espaço

            // Dados do cliente e data
            string cliente = cbClienteOrcamento.Text;
            string data = dtpDataOrcamento.Value.ToString("dd/MM/yyyy");
            string prazoEntrega = textBox1.Text; // <- esse TextBox já deve existir na tela

            doc.Add(new Paragraph("Cliente: " + cliente));
            doc.Add(new Paragraph("Data: " + data));
            doc.Add(new Paragraph("Prazo de Entrega: " + prazoEntrega));
            doc.Add(new Paragraph(" ")); // espaço

            // Tabela de produtos
            PdfPTable tabela = new PdfPTable(4); // Qtd, Produto, Valor Unit, Subtotal
            tabela.WidthPercentage = 100;
            tabela.SetWidths(new float[] { 1, 3, 2, 2 });

            // Cabeçalhos
            tabela.AddCell("Qtd");
            tabela.AddCell("Produto");
            tabela.AddCell("Valor Unit.");
            tabela.AddCell("Subtotal");

            // Linhas da grid
            foreach (DataGridViewRow row in dgvItensOrcamento.Rows)
            {
                if (row.IsNewRow) continue;

                tabela.AddCell(row.Cells["Quantidade"].Value.ToString());
                tabela.AddCell(row.Cells["NomeProduto"].Value.ToString());
                tabela.AddCell(Convert.ToDecimal(row.Cells["ValorUnitario"].Value).ToString("C"));
                tabela.AddCell(Convert.ToDecimal(row.Cells["Subtotal"].Value).ToString("C"));
            }

            doc.Add(tabela);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph("Total: " + txtTotalOrcamento.Text));

            doc.Close();

            MessageBox.Show("PDF gerado com sucesso!");
        }
    }
}

