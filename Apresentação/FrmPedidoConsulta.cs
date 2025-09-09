using AcessoBancoDados;
using AcessoBancoDados;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Negócios;
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
    public partial class FrmPedidoConsulta : Form
    {
        private void ConfigurarGridPedidos()
        {
            dgvPedidos.ReadOnly = true;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.MultiSelect = false;
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AllowUserToResizeRows = false;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPedidos.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dgvPedidos.DefaultCellStyle.ForeColor = Color.Black;
            dgvPedidos.DefaultCellStyle.BackColor = Color.White;
            dgvPedidos.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgvPedidos.DefaultCellStyle.SelectionForeColor = Color.Black;

            if (dgvPedidos.Columns.Contains("IdPedido"))
                dgvPedidos.Columns["IdPedido"].HeaderText = "Código";

            if (dgvPedidos.Columns.Contains("DataPedido"))
            {
                dgvPedidos.Columns["DataPedido"].HeaderText = "Data";
                dgvPedidos.Columns["DataPedido"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvPedidos.Columns.Contains("TotalPedido"))
            {
                dgvPedidos.Columns["TotalPedido"].HeaderText = "Total";
                dgvPedidos.Columns["TotalPedido"].DefaultCellStyle.Format = "C2";
                dgvPedidos.Columns["TotalPedido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvPedidos.Columns.Contains("Status"))
                dgvPedidos.Columns["Status"].HeaderText = "Situação";

            if (dgvPedidos.Columns.Contains("NomeCliente"))
                dgvPedidos.Columns["NomeCliente"].HeaderText = "Cliente";
        }

        private PedidoColeção listaPedidos;
        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se há linha selecionada
            if (dgvPedidos.CurrentRow != null)
            {
                // Pega o objeto Pedido da linha selecionada
                Pedido pedidoSelecionado = dgvPedidos.CurrentRow.DataBoundItem as Pedido;

                if (pedidoSelecionado != null)
                {
                    // Cria o objeto de negócios e consulta os itens do pedido
                    PedidoNegócios pedidoNegocios = new PedidoNegócios();
                    var itens = pedidoNegocios.ConsultarItensPorIdPedido(pedidoSelecionado.IdPedido);

                    // Mostra os itens na grid de baixo
                    dgvItensPedido.DataSource = itens;

                    // Atualiza o total, se quiser mostrar
                    lblTotalPedido.Text = "Total: R$ " + pedidoSelecionado.TotalPedido.ToString("F2");
                }
            }
        }

        public FrmPedidoConsulta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPedidoConsulta_Load(object sender, EventArgs e)
        {
            dgvPedidos.CellClick += dgvPedidos_CellContentClick_1;
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvItensPedido.AutoGenerateColumns = true;
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPedidos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && listaPedidos != null && e.RowIndex < listaPedidos.Count)
            {
                Pedido pedidoSelecionado = listaPedidos[e.RowIndex];

                PedidoNegócios pedidoNegocios = new PedidoNegócios();
                var itens = pedidoNegocios.ConsultarItensPorIdPedido(pedidoSelecionado.IdPedido);

                // Projeta apenas os dados que você quer exibir na grid de itens
                var itensFormatados = itens.Select(i => new
                {
                    Produto = i.NomeProduto,
                    Quantidade = i.Quantidade,
                    ValorUnitario = i.ValorUnitario,
                    Subtotal = i.Subtotal
                }).ToList();

                dgvItensPedido.DataSource = itensFormatados;

                dgvItensPedido.Columns["Produto"].HeaderText = "Produto";
                dgvItensPedido.Columns["Quantidade"].HeaderText = "Quantidade";
                dgvItensPedido.Columns["ValorUnitario"].HeaderText = "Valor Unitário";
                dgvItensPedido.Columns["Subtotal"].HeaderText = "Subtotal";

                dgvItensPedido.Columns["Produto"].HeaderText = "Produto";
                dgvItensPedido.Columns["Quantidade"].HeaderText = "Quantidade";
                dgvItensPedido.Columns["ValorUnitario"].HeaderText = "Valor Unitário";
                dgvItensPedido.Columns["Subtotal"].HeaderText = "Subtotal";

                // Alinha à direita colunas numéricas
                dgvItensPedido.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvItensPedido.Columns["ValorUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvItensPedido.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // Formata como moeda
                dgvItensPedido.Columns["ValorUnitario"].DefaultCellStyle.Format = "C2";
                dgvItensPedido.Columns["Subtotal"].DefaultCellStyle.Format = "C2";

                // ❌ Impede edição pelo usuário
                dgvItensPedido.ReadOnly = true;

                // ✅ Seleciona linha inteira ao clicar
                dgvItensPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // 🖼️ Estilo visual
                dgvItensPedido.RowHeadersVisible = false; // oculta a coluna de índice à esquerda
                dgvItensPedido.AllowUserToAddRows = false; // remove linha em branco no final
                dgvItensPedido.AllowUserToResizeRows = false;

                // 🔲 Ajuste de colunas (preenche espaço e evita cinza)
                dgvItensPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 🎨 Personalização extra (opcional)
                dgvItensPedido.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                dgvItensPedido.DefaultCellStyle.ForeColor = Color.Black;
                dgvItensPedido.DefaultCellStyle.BackColor = Color.White;
                dgvItensPedido.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dgvItensPedido.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idOrcamento = Convert.ToInt32(dgvOrcamentos.Rows[e.RowIndex].Cells["IdOrcamento"].Value);

                OrcamentoDAL orcamentoDal = new OrcamentoDAL();
                DataTable tabela = orcamentoDal.ConsultarItens(idOrcamento);

                dgvItenOrcamentoConsulta.DataSource = tabela;

                // Formatação opcional
                dgvItenOrcamentoConsulta.Columns["Produto"].HeaderText = "Produto";
                dgvItenOrcamentoConsulta.Columns["Quantidade"].HeaderText = "Qtd";
                dgvItenOrcamentoConsulta.Columns["ValorUnitario"].HeaderText = "Valor Unit.";
                dgvItenOrcamentoConsulta.Columns["Subtotal"].HeaderText = "Subtotal";

                dgvItenOrcamentoConsulta.Columns["ValorUnitario"].DefaultCellStyle.Format = "C2";
                dgvItenOrcamentoConsulta.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabConsultarOrcamento_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarOrcamento_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = 0;

                if (cbClienteConsultaOrcamento.SelectedValue != null)
                    idCliente = Convert.ToInt32(cbClienteConsultaOrcamento.SelectedValue);

                OrcamentoDAL orcamentoDal = new OrcamentoDAL();
                DataTable tabela = orcamentoDal.Consultar(idCliente);

                dgvOrcamentos.DataSource = tabela;

                dgvOrcamentos.Columns["IdOrcamento"].HeaderText = "Código";
                dgvOrcamentos.Columns["NomeCliente"].HeaderText = "Cliente";
                dgvOrcamentos.Columns["DataOrcamento"].HeaderText = "Data";
                dgvOrcamentos.Columns["Total"].HeaderText = "Total";

                dgvOrcamentos.Columns["Total"].DefaultCellStyle.Format = "C2"; // formato moeda
                dgvOrcamentos.Columns["DataOrcamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar orçamentos: " + ex.Message);
            }
        }

        private void btnExcluirOrcamento_Click(object sender, EventArgs e)
        {
            if (dgvOrcamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um orçamento para excluir.");
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir este orçamento?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                int idOrcamento = Convert.ToInt32(dgvOrcamentos.SelectedRows[0].Cells["IdOrcamento"].Value);

                try
                {
                    OrcamentoDAL orcamentoDAL = new OrcamentoDAL();
                    orcamentoDAL.Excluir(idOrcamento);

                    MessageBox.Show("Orçamento excluído com sucesso!");

                    // Recarrega a lista
                    btnBuscarOrcamento.PerformClick();

                    // Limpa os itens
                    dgvItenOrcamentoConsulta.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);
                }
            }
        }

        private void btnGerarPedido_Click(object sender, EventArgs e)
        {
            if (dgvOrcamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um orçamento para gerar pedido.");
                return;
            }

            int idOrcamento = Convert.ToInt32(dgvOrcamentos.SelectedRows[0].Cells["IdOrcamento"].Value);

            try
            {
                // 1. Gera o pedido via DAL
                PedidoDal pedidoDal = new PedidoDal();
                int idPedido = pedidoDal.InserirViaOrcamento(idOrcamento);

                // 2. Exibe mensagem com ID do pedido gerado
                MessageBox.Show($"Pedido gerado com sucesso! Código: {idPedido}");

                // 3. Exclui o orçamento (já convertido em pedido)
                OrcamentoDAL orcamentoDal = new OrcamentoDAL();
                orcamentoDal.Excluir(idOrcamento);

                // 4. Atualiza a grid de orçamentos
                CarregarOrcamentos();

                // 5. Limpa seleção da grid e os itens exibidos
                dgvOrcamentos.ClearSelection();
                dgvItenOrcamentoConsulta.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar pedido: " + ex.Message);
            }
        }
        private void CarregarOrcamentos()
        {
            try
            {
                OrcamentoDAL orcamentoDal = new OrcamentoDAL();
                DataTable dt = orcamentoDal.Consultar(0); // 0 traz todos

                dgvOrcamentos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar orçamentos: " + ex.Message);
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
                PedidoNegócios pedidoNegocios = new PedidoNegócios();

                // Guarda a lista original completa
                listaPedidos = pedidoNegocios.ConsultarPorCliente(txtNomeCliente.Text);

                // Projeção para exibir nome do cliente corretamente
                var pedidosFormatados = listaPedidos.Select(p => new
                {
                    p.IdPedido,
                    p.DataPedido,
                    p.TotalPedido,
                    p.Status,
                    NomeCliente = p.Cliente != null ? p.Cliente.Nome : ""
                }).ToList();

                dgvPedidos.AutoGenerateColumns = true;
                dgvPedidos.DataSource = pedidosFormatados;
                ConfigurarGridPedidos();

                // ❌ Impede edição
                dgvPedidos.ReadOnly = true;

                // ✅ Seleciona linha inteira
                dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // 🖼️ Aparência
                dgvPedidos.RowHeadersVisible = false;
                dgvPedidos.AllowUserToAddRows = false;
                dgvPedidos.AllowUserToResizeRows = false;
                dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 🎨 Estilo visual
                dgvPedidos.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                dgvPedidos.DefaultCellStyle.ForeColor = Color.Black;
                dgvPedidos.DefaultCellStyle.BackColor = Color.White;
                dgvPedidos.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dgvPedidos.DefaultCellStyle.SelectionForeColor = Color.Black;

                // 💰 Formatação de moeda (se necessário)
                if (dgvPedidos.Columns.Contains("TotalPedido"))
                {
                    dgvPedidos.Columns["TotalPedido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgvPedidos.Columns["TotalPedido"].DefaultCellStyle.Format = "C2";
                }

                // Renomeia os títulos das colunas
                dgvPedidos.Columns["IdPedido"].HeaderText = "Código";
                dgvPedidos.Columns["DataPedido"].HeaderText = "Data";
                dgvPedidos.Columns["TotalPedido"].HeaderText = "Total";
                dgvPedidos.Columns["Status"].HeaderText = "Situação";
                dgvPedidos.Columns["NomeCliente"].HeaderText = "Cliente";

                // Limpa os itens da grid inferior
                dgvItensPedido.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar pedidos: " + ex.Message);
            }



        }

        private void dgvPedidos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idPedido = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells["IdPedido"].Value);

                PedidoDal pedidoDal = new PedidoDal();
                DataTable tabela = pedidoDal.ConsultarItensPedido(idPedido);

                dgvItensPedido.DataSource = tabela;

                // Chama método que formata a dgvItensPedido
                ConfigurarGridItensPedido();
            }
        }
        private void ConfigurarGridItensPedido()
        {
            // Ocultar colunas técnicas
            string[] colunasOcultas = { "IdPedidoItem", "IdPedido", "IdProduto" };
            foreach (string col in colunasOcultas)
            {
                if (dgvItensPedido.Columns.Contains(col))
                    dgvItensPedido.Columns[col].Visible = false;
            }

            // Formatar colunas visíveis
            if (dgvItensPedido.Columns.Contains("NomeProduto"))
            {
                dgvItensPedido.Columns["NomeProduto"].HeaderText = "Produto";
                dgvItensPedido.Columns["NomeProduto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgvItensPedido.Columns.Contains("Quantidade"))
            {
                dgvItensPedido.Columns["Quantidade"].HeaderText = "Qtd";
                dgvItensPedido.Columns["Quantidade"].Width = 60;
            }

            if (dgvItensPedido.Columns.Contains("PrecoUnitario"))
            {
                dgvItensPedido.Columns["PrecoUnitario"].HeaderText = "Valor Unit.";
                dgvItensPedido.Columns["PrecoUnitario"].DefaultCellStyle.Format = "C2";
                dgvItensPedido.Columns["PrecoUnitario"].Width = 90;
                dgvItensPedido.Columns["PrecoUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvItensPedido.Columns.Contains("Subtotal"))
            {
                dgvItensPedido.Columns["Subtotal"].HeaderText = "Subtotal";
                dgvItensPedido.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
                dgvItensPedido.Columns["Subtotal"].Width = 90;
                dgvItensPedido.Columns["Subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Opções gerais da grid
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToResizeRows = false;
            dgvItensPedido.RowHeadersVisible = false;
        }
        private void dgvItensPedido_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluirPedido_Click_1(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um pedido para excluir.");
                return;
            }

            var confirmar = MessageBox.Show("Deseja realmente excluir o pedido selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.No)
                return;

            // Recupera o objeto Pedido corretamente a partir do DataSource
            var linha = dgvPedidos.CurrentRow.DataBoundItem;

            if (linha == null)
            {
                MessageBox.Show("Erro ao obter o pedido selecionado.");
                return;
            }

            // Converte a linha para Pedido ou para o tipo anônimo, dependendo do DataSource
            int idPedido;
            if (linha.GetType().GetProperty("IdPedido") != null)
            {
                idPedido = (int)linha.GetType().GetProperty("IdPedido").GetValue(linha);
            }
            else
            {
                MessageBox.Show("Não foi possível identificar o pedido.");
                return;
            }

            Pedido pedido = new Pedido { IdPedido = idPedido };

            try
            {
                PedidoNegócios pedidoNegocios = new PedidoNegócios();
                pedidoNegocios.Excluir(pedido); // Agora é void, sem retorno

                MessageBox.Show("Pedido excluído com sucesso.");
                btnPesquisar.PerformClick(); // Atualiza a lista após exclusão
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o pedido: " + ex.Message);
            }
        }

        private void dgvItenOrcamentoConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGerarRecibo_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um pedido para gerar o recibo.");
                return;
            }

            int idPedido = Convert.ToInt32(dgvPedidos.SelectedRows[0].Cells["IdPedido"].Value);

            try
            {
                // Obter os dados do pedido
                PedidoNegócios pedidoNegocios = new PedidoNegócios();
                Pedido pedido = pedidoNegocios.ObterPedidoPorId(idPedido);

                // Obter os itens do pedido
                PedidoItemNegocios itemNegocios = new PedidoItemNegocios();
                List<PedidoItem> itens = itemNegocios.ConsultarPorPedido(idPedido);

                // Diálogo para salvar o arquivo
                SaveFileDialog salvar = new SaveFileDialog();
                salvar.Filter = "PDF (*.pdf)|*.pdf";
                salvar.FileName = $"Recibo_Pedido_{idPedido}.pdf";

                if (salvar.ShowDialog() != DialogResult.OK)
                    return;

                string caminho = salvar.FileName;

                // Gerar PDF com iTextSharp
                using (FileStream stream = new FileStream(caminho, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter.GetInstance(doc, stream);
                    doc.Open();

                    // LOGO
                    string caminhoLogo = Path.Combine(Application.StartupPath, "logo.png");
                    if (File.Exists(caminhoLogo))
                    {
                        iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminhoLogo);
                        logo.Alignment = Element.ALIGN_CENTER;
                        logo.ScaleToFit(100f, 100f); // tamanho ajustado
                        doc.Add(logo);
                    }

                    // DADOS DA EMPRESA
                    var fonteEmpresa = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11);
                    var empresa = new Paragraph("Av. Prof. Maria de Lourdes Andrade Hortal, 580 - Hercules Hortal\nCNPJ: 50.258.785/0001-75\nTelefone: (17) 99188-1985", fonteEmpresa);
                    empresa.Alignment = Element.ALIGN_CENTER;
                    doc.Add(empresa);

                    doc.Add(new Paragraph("\n"));

                    // TÍTULO
                    var titulo = new Paragraph("RECIBO DE PEDIDO", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                    titulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titulo);
                    doc.Add(new Paragraph("\n"));

                    // DADOS DO PEDIDO
                    doc.Add(new Paragraph($"Número do Pedido: {pedido.IdPedido}"));
                    doc.Add(new Paragraph($"Cliente: {pedido.Cliente?.Nome ?? "Não informado"}"));
                    doc.Add(new Paragraph($"Data Pedido: {pedido.DataPedido:dd/MM/yyyy}"));
                    doc.Add(new Paragraph($"Data de Emissão do Recibo: {DateTime.Now:dd/MM/yyyy}"));
                    doc.Add(new Paragraph("\nItens:\n"));

                    // ITENS
                    decimal total = 0;
                    foreach (var item in itens)
                    {
                        string nomeProduto = string.IsNullOrEmpty(item.NomeProduto) ? "Produto não informado" : item.NomeProduto;
                        decimal subtotal = item.Quantidade * item.ValorUnitario;
                        total += subtotal;

                        doc.Add(new Paragraph(
                            $"Produto: {nomeProduto} - Quantidade: {item.Quantidade} - Preço Unitário: {item.ValorUnitario:C2} - Subtotal: {subtotal:C2}"
                        ));
                    }

                    doc.Add(new Paragraph("\nTotal do Pedido: " + total.ToString("C2")));

                    doc.Close();
                }


                MessageBox.Show("Recibo gerado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar recibo: {ex.Message}");
            }
        }


    }
}



