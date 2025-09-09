namespace Apresentação
{
    partial class FmrPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabOrcamento = new TabPage();
            btnRemoverProdutoOrcamento = new Button();
            btnAdicionarProdutoOrcamento = new Button();
            txtTotalOrcamento = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            btnGerarPdfOrcamento = new Button();
            btnSalvarOrcamento = new Button();
            dgvItensOrcamento = new DataGridView();
            dtpDataOrcamento = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            cbClienteOrcamento = new ComboBox();
            label3 = new Label();
            tabPedido = new TabPage();
            btnRemoverItem = new Button();
            btnFinalizarPedido = new Button();
            txtTotalPedido = new TextBox();
            label2 = new Label();
            btnAdicionarProduto = new Button();
            label1 = new Label();
            cbCliente = new ComboBox();
            dgvItensPedido = new DataGridView();
            tabControl1 = new TabControl();
            tabOrcamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensOrcamento).BeginInit();
            tabPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabOrcamento
            // 
            tabOrcamento.Controls.Add(btnRemoverProdutoOrcamento);
            tabOrcamento.Controls.Add(btnAdicionarProdutoOrcamento);
            tabOrcamento.Controls.Add(txtTotalOrcamento);
            tabOrcamento.Controls.Add(label6);
            tabOrcamento.Controls.Add(textBox1);
            tabOrcamento.Controls.Add(button3);
            tabOrcamento.Controls.Add(btnGerarPdfOrcamento);
            tabOrcamento.Controls.Add(btnSalvarOrcamento);
            tabOrcamento.Controls.Add(dgvItensOrcamento);
            tabOrcamento.Controls.Add(dtpDataOrcamento);
            tabOrcamento.Controls.Add(label5);
            tabOrcamento.Controls.Add(label4);
            tabOrcamento.Controls.Add(cbClienteOrcamento);
            tabOrcamento.Controls.Add(label3);
            tabOrcamento.Location = new Point(4, 29);
            tabOrcamento.Name = "tabOrcamento";
            tabOrcamento.Padding = new Padding(3);
            tabOrcamento.Size = new Size(874, 420);
            tabOrcamento.TabIndex = 1;
            tabOrcamento.Text = "Orçamento";
            tabOrcamento.UseVisualStyleBackColor = true;
            tabOrcamento.Click += tabOrcamento_Click;
            // 
            // btnRemoverProdutoOrcamento
            // 
            btnRemoverProdutoOrcamento.Location = new Point(182, 330);
            btnRemoverProdutoOrcamento.Name = "btnRemoverProdutoOrcamento";
            btnRemoverProdutoOrcamento.Size = new Size(141, 29);
            btnRemoverProdutoOrcamento.TabIndex = 15;
            btnRemoverProdutoOrcamento.Text = "Remover Produto";
            btnRemoverProdutoOrcamento.UseVisualStyleBackColor = true;
            btnRemoverProdutoOrcamento.Click += btnRemoverProdutoOrcamento_Click;
            // 
            // btnAdicionarProdutoOrcamento
            // 
            btnAdicionarProdutoOrcamento.Location = new Point(21, 330);
            btnAdicionarProdutoOrcamento.Name = "btnAdicionarProdutoOrcamento";
            btnAdicionarProdutoOrcamento.Size = new Size(144, 29);
            btnAdicionarProdutoOrcamento.TabIndex = 14;
            btnAdicionarProdutoOrcamento.Text = "Adicionar Produto";
            btnAdicionarProdutoOrcamento.UseVisualStyleBackColor = true;
            btnAdicionarProdutoOrcamento.Click += btnAdicionarProdutoOrcamento_Click;
            // 
            // txtTotalOrcamento
            // 
            txtTotalOrcamento.Location = new Point(727, 331);
            txtTotalOrcamento.Name = "txtTotalOrcamento";
            txtTotalOrcamento.Size = new Size(125, 27);
            txtTotalOrcamento.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 334);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 12;
            label6.Text = "Total do Orçamento:";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(727, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(758, 377);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Fechar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnGerarPdfOrcamento
            // 
            btnGerarPdfOrcamento.Location = new Point(630, 377);
            btnGerarPdfOrcamento.Name = "btnGerarPdfOrcamento";
            btnGerarPdfOrcamento.Size = new Size(122, 29);
            btnGerarPdfOrcamento.TabIndex = 9;
            btnGerarPdfOrcamento.Text = "Gerar PDF";
            btnGerarPdfOrcamento.UseVisualStyleBackColor = true;
            btnGerarPdfOrcamento.Click += btnGerarPdfOrcamento_Click;
            // 
            // btnSalvarOrcamento
            // 
            btnSalvarOrcamento.Location = new Point(483, 377);
            btnSalvarOrcamento.Name = "btnSalvarOrcamento";
            btnSalvarOrcamento.Size = new Size(141, 29);
            btnSalvarOrcamento.TabIndex = 8;
            btnSalvarOrcamento.Text = "Salvar Orçamento";
            btnSalvarOrcamento.UseVisualStyleBackColor = true;
            btnSalvarOrcamento.Click += btnSalvarOrcamento_Click;
            // 
            // dgvItensOrcamento
            // 
            dgvItensOrcamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensOrcamento.Location = new Point(21, 127);
            dgvItensOrcamento.Name = "dgvItensOrcamento";
            dgvItensOrcamento.RowHeadersWidth = 51;
            dgvItensOrcamento.Size = new Size(831, 188);
            dgvItensOrcamento.TabIndex = 7;
            // 
            // dtpDataOrcamento
            // 
            dtpDataOrcamento.Format = DateTimePickerFormat.Short;
            dtpDataOrcamento.Location = new Point(146, 76);
            dtpDataOrcamento.Name = "dtpDataOrcamento";
            dtpDataOrcamento.Size = new Size(128, 27);
            dtpDataOrcamento.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(596, 79);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 3;
            label5.Text = "Prazo de Entrega:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 79);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 2;
            label4.Text = "Data Orçamento:";
            label4.Click += label4_Click;
            // 
            // cbClienteOrcamento
            // 
            cbClienteOrcamento.FormattingEnabled = true;
            cbClienteOrcamento.Location = new Point(158, 21);
            cbClienteOrcamento.Name = "cbClienteOrcamento";
            cbClienteOrcamento.Size = new Size(694, 28);
            cbClienteOrcamento.TabIndex = 1;
            cbClienteOrcamento.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 25);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 0;
            label3.Text = "Selecionar Cliente:";
            label3.Click += label3_Click;
            // 
            // tabPedido
            // 
            tabPedido.Controls.Add(btnRemoverItem);
            tabPedido.Controls.Add(btnFinalizarPedido);
            tabPedido.Controls.Add(txtTotalPedido);
            tabPedido.Controls.Add(label2);
            tabPedido.Controls.Add(btnAdicionarProduto);
            tabPedido.Controls.Add(label1);
            tabPedido.Controls.Add(cbCliente);
            tabPedido.Controls.Add(dgvItensPedido);
            tabPedido.Location = new Point(4, 29);
            tabPedido.Name = "tabPedido";
            tabPedido.Padding = new Padding(3);
            tabPedido.Size = new Size(874, 420);
            tabPedido.TabIndex = 0;
            tabPedido.Text = "Pedido";
            tabPedido.UseVisualStyleBackColor = true;
            // 
            // btnRemoverItem
            // 
            btnRemoverItem.Location = new Point(205, 322);
            btnRemoverItem.Name = "btnRemoverItem";
            btnRemoverItem.Size = new Size(187, 29);
            btnRemoverItem.TabIndex = 32;
            btnRemoverItem.Text = "Remover Produto";
            btnRemoverItem.UseVisualStyleBackColor = true;
            btnRemoverItem.Click += btnRemoverItem_Click_1;
            // 
            // btnFinalizarPedido
            // 
            btnFinalizarPedido.Location = new Point(693, 370);
            btnFinalizarPedido.Name = "btnFinalizarPedido";
            btnFinalizarPedido.Size = new Size(158, 29);
            btnFinalizarPedido.TabIndex = 31;
            btnFinalizarPedido.Text = "Salvar";
            btnFinalizarPedido.UseVisualStyleBackColor = true;
            btnFinalizarPedido.Click += btnFinalizarPedido_Click_1;
            // 
            // txtTotalPedido
            // 
            txtTotalPedido.Location = new Point(725, 322);
            txtTotalPedido.Name = "txtTotalPedido";
            txtTotalPedido.Size = new Size(125, 27);
            txtTotalPedido.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(627, 325);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 29;
            label2.Text = "Total Pedido";
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Location = new Point(11, 322);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(173, 29);
            btnAdicionarProduto.TabIndex = 28;
            btnAdicionarProduto.Text = "Adicionar Produto";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 24);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 27;
            label1.Text = "Selecionar Cliente:";
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(145, 21);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(705, 28);
            cbCliente.TabIndex = 26;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Location = new Point(13, 67);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.RowHeadersWidth = 51;
            dgvItensPedido.Size = new Size(839, 239);
            dgvItensPedido.TabIndex = 20;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPedido);
            tabControl1.Controls.Add(tabOrcamento);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(882, 453);
            tabControl1.TabIndex = 26;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.Enter += tabControl1_Enter;
            // 
            // FmrPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FmrPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inserir";
            Load += FmrPedido_Load;
            tabOrcamento.ResumeLayout(false);
            tabOrcamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensOrcamento).EndInit();
            tabPedido.ResumeLayout(false);
            tabPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabOrcamento;
        private ComboBox cbClienteOrcamento;
        private Label label3;
        private TabPage tabPedido;
        private Button btnRemoverItem;
        private Button btnFinalizarPedido;
        private TextBox txtTotalPedido;
        private Label label2;
        private Button btnAdicionarProduto;
        private Label label1;
        private ComboBox cbCliente;
        private DataGridView dgvItensPedido;
        private TabControl tabControl1;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpDataOrcamento;
        private DataGridView dgvItensOrcamento;
        private Button button3;
        private Button btnGerarPdfOrcamento;
        private Button btnSalvarOrcamento;
        private TextBox textBox1;
        private Label label6;
        private TextBox txtTotalOrcamento;
        private Button btnRemoverProdutoOrcamento;
        private Button btnAdicionarProdutoOrcamento;
    }
}