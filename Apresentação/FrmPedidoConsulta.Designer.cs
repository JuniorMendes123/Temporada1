namespace Apresentação
{
    partial class FrmPedidoConsulta
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
            tabControlConsulta = new TabControl();
            tabConsultarPedido = new TabPage();
            btnExcluirPedido = new Button();
            lblTotalPedido = new Label();
            dgvItensPedido = new DataGridView();
            dgvPedidos = new DataGridView();
            btnPesquisar = new Button();
            txtNomeCliente = new TextBox();
            label1 = new Label();
            tabConsultarOrcamento = new TabPage();
            btnExcluirOrcamento = new Button();
            btnBuscarOrcamento = new Button();
            dgvItenOrcamentoConsulta = new DataGridView();
            dgvOrcamentos = new DataGridView();
            btnGerarPedido = new Button();
            cbClienteConsultaOrcamento = new ComboBox();
            label2 = new Label();
            btnGerarRecibo = new Button();
            tabControlConsulta.SuspendLayout();
            tabConsultarPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            tabConsultarOrcamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItenOrcamentoConsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrcamentos).BeginInit();
            SuspendLayout();
            // 
            // tabControlConsulta
            // 
            tabControlConsulta.Controls.Add(tabConsultarPedido);
            tabControlConsulta.Controls.Add(tabConsultarOrcamento);
            tabControlConsulta.Location = new Point(-2, 2);
            tabControlConsulta.Name = "tabControlConsulta";
            tabControlConsulta.SelectedIndex = 0;
            tabControlConsulta.Size = new Size(885, 450);
            tabControlConsulta.TabIndex = 0;
            // 
            // tabConsultarPedido
            // 
            tabConsultarPedido.Controls.Add(btnGerarRecibo);
            tabConsultarPedido.Controls.Add(btnExcluirPedido);
            tabConsultarPedido.Controls.Add(lblTotalPedido);
            tabConsultarPedido.Controls.Add(dgvItensPedido);
            tabConsultarPedido.Controls.Add(dgvPedidos);
            tabConsultarPedido.Controls.Add(btnPesquisar);
            tabConsultarPedido.Controls.Add(txtNomeCliente);
            tabConsultarPedido.Controls.Add(label1);
            tabConsultarPedido.Location = new Point(4, 29);
            tabConsultarPedido.Name = "tabConsultarPedido";
            tabConsultarPedido.Padding = new Padding(3);
            tabConsultarPedido.Size = new Size(877, 417);
            tabConsultarPedido.TabIndex = 0;
            tabConsultarPedido.Text = "Consultar Pedido";
            tabConsultarPedido.UseVisualStyleBackColor = true;
            // 
            // btnExcluirPedido
            // 
            btnExcluirPedido.Location = new Point(714, 367);
            btnExcluirPedido.Name = "btnExcluirPedido";
            btnExcluirPedido.Size = new Size(140, 29);
            btnExcluirPedido.TabIndex = 13;
            btnExcluirPedido.Text = "Excluir Pedido";
            btnExcluirPedido.UseVisualStyleBackColor = true;
            btnExcluirPedido.Click += btnExcluirPedido_Click_1;
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Location = new Point(692, 367);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(0, 20);
            lblTotalPedido.TabIndex = 12;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Location = new Point(23, 215);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.RowHeadersWidth = 51;
            dgvItensPedido.Size = new Size(831, 137);
            dgvItensPedido.TabIndex = 11;
            dgvItensPedido.CellContentClick += dgvItensPedido_CellContentClick_1;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(23, 54);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(831, 144);
            dgvPedidos.TabIndex = 10;
            dgvPedidos.CellContentClick += dgvPedidos_CellContentClick_1;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(760, 16);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click_1;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(143, 18);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(611, 27);
            txtNomeCliente.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 7;
            label1.Text = "Cliente / Pedido:";
            // 
            // tabConsultarOrcamento
            // 
            tabConsultarOrcamento.Controls.Add(btnExcluirOrcamento);
            tabConsultarOrcamento.Controls.Add(btnBuscarOrcamento);
            tabConsultarOrcamento.Controls.Add(dgvItenOrcamentoConsulta);
            tabConsultarOrcamento.Controls.Add(dgvOrcamentos);
            tabConsultarOrcamento.Controls.Add(btnGerarPedido);
            tabConsultarOrcamento.Controls.Add(cbClienteConsultaOrcamento);
            tabConsultarOrcamento.Controls.Add(label2);
            tabConsultarOrcamento.Location = new Point(4, 29);
            tabConsultarOrcamento.Name = "tabConsultarOrcamento";
            tabConsultarOrcamento.Padding = new Padding(3);
            tabConsultarOrcamento.Size = new Size(877, 417);
            tabConsultarOrcamento.TabIndex = 1;
            tabConsultarOrcamento.Text = "Consultar Orçamento";
            tabConsultarOrcamento.UseVisualStyleBackColor = true;
            tabConsultarOrcamento.Click += tabConsultarOrcamento_Click;
            // 
            // btnExcluirOrcamento
            // 
            btnExcluirOrcamento.Location = new Point(541, 372);
            btnExcluirOrcamento.Name = "btnExcluirOrcamento";
            btnExcluirOrcamento.Size = new Size(151, 29);
            btnExcluirOrcamento.TabIndex = 7;
            btnExcluirOrcamento.Text = "Excluir Orçamento";
            btnExcluirOrcamento.UseVisualStyleBackColor = true;
            btnExcluirOrcamento.Click += btnExcluirOrcamento_Click;
            // 
            // btnBuscarOrcamento
            // 
            btnBuscarOrcamento.Location = new Point(761, 18);
            btnBuscarOrcamento.Name = "btnBuscarOrcamento";
            btnBuscarOrcamento.Size = new Size(94, 29);
            btnBuscarOrcamento.TabIndex = 6;
            btnBuscarOrcamento.Text = "Pesquisar";
            btnBuscarOrcamento.UseVisualStyleBackColor = true;
            btnBuscarOrcamento.Click += btnBuscarOrcamento_Click;
            // 
            // dgvItenOrcamentoConsulta
            // 
            dgvItenOrcamentoConsulta.AllowUserToAddRows = false;
            dgvItenOrcamentoConsulta.AllowUserToDeleteRows = false;
            dgvItenOrcamentoConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItenOrcamentoConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItenOrcamentoConsulta.Location = new Point(23, 219);
            dgvItenOrcamentoConsulta.Name = "dgvItenOrcamentoConsulta";
            dgvItenOrcamentoConsulta.ReadOnly = true;
            dgvItenOrcamentoConsulta.RowHeadersWidth = 51;
            dgvItenOrcamentoConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItenOrcamentoConsulta.Size = new Size(832, 138);
            dgvItenOrcamentoConsulta.TabIndex = 5;
            dgvItenOrcamentoConsulta.CellContentClick += dgvItenOrcamentoConsulta_CellContentClick;
            // 
            // dgvOrcamentos
            // 
            dgvOrcamentos.AllowUserToAddRows = false;
            dgvOrcamentos.AllowUserToDeleteRows = false;
            dgvOrcamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrcamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrcamentos.Location = new Point(23, 56);
            dgvOrcamentos.Name = "dgvOrcamentos";
            dgvOrcamentos.ReadOnly = true;
            dgvOrcamentos.RowHeadersWidth = 51;
            dgvOrcamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrcamentos.Size = new Size(832, 144);
            dgvOrcamentos.TabIndex = 4;
            dgvOrcamentos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnGerarPedido
            // 
            btnGerarPedido.Location = new Point(709, 372);
            btnGerarPedido.Name = "btnGerarPedido";
            btnGerarPedido.Size = new Size(146, 29);
            btnGerarPedido.TabIndex = 3;
            btnGerarPedido.Text = "Gerar Pedido";
            btnGerarPedido.UseVisualStyleBackColor = true;
            btnGerarPedido.Click += btnGerarPedido_Click;
            // 
            // cbClienteConsultaOrcamento
            // 
            cbClienteConsultaOrcamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClienteConsultaOrcamento.FormattingEnabled = true;
            cbClienteConsultaOrcamento.Location = new Point(175, 18);
            cbClienteConsultaOrcamento.Name = "cbClienteConsultaOrcamento";
            cbClienteConsultaOrcamento.Size = new Size(580, 28);
            cbClienteConsultaOrcamento.TabIndex = 1;
            cbClienteConsultaOrcamento.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 22);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 0;
            label2.Text = "Cliente / Orçamento:";
            // 
            // btnGerarRecibo
            // 
            btnGerarRecibo.Location = new Point(559, 367);
            btnGerarRecibo.Name = "btnGerarRecibo";
            btnGerarRecibo.Size = new Size(133, 29);
            btnGerarRecibo.TabIndex = 14;
            btnGerarRecibo.Text = "Gerar Recibo";
            btnGerarRecibo.UseVisualStyleBackColor = true;
            btnGerarRecibo.Click += btnGerarRecibo_Click;
            // 
            // FrmPedidoConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(tabControlConsulta);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPedidoConsulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar";
            Load += FrmPedidoConsulta_Load;
            tabControlConsulta.ResumeLayout(false);
            tabConsultarPedido.ResumeLayout(false);
            tabConsultarPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            tabConsultarOrcamento.ResumeLayout(false);
            tabConsultarOrcamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItenOrcamentoConsulta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrcamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlConsulta;
        private TabPage tabConsultarPedido;
        private Button btnExcluirPedido;
        private Label lblTotalPedido;
        private DataGridView dgvItensPedido;
        private DataGridView dgvPedidos;
        private Button btnPesquisar;
        private TextBox txtNomeCliente;
        private Label label1;
        private TabPage tabConsultarOrcamento;
        private DataGridView dgvItenOrcamentoConsulta;
        private DataGridView dgvOrcamentos;
        private Button btnGerarPedido;
        private ComboBox cbClienteConsultaOrcamento;
        private Label label2;
        private Button btnBuscarOrcamento;
        private Button btnExcluirOrcamento;
        private Button btnGerarRecibo;
    }
}