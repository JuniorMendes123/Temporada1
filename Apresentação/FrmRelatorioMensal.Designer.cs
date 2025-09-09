namespace Apresentação
{
    partial class FrmRelatorioMensal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAno;

        private void InitializeComponent()
        {
            panelTopo = new Panel();
            lblCliente = new Label();
            cbCliente = new ComboBox();
            lblMes = new Label();
            cbMes = new ComboBox();
            lblAno = new Label();
            txtAno = new TextBox();
            btnBuscar = new Button();
            panelGrid = new Panel();
            dgvRelatorio = new DataGridView();
            txtTotalLucro = new TextBox();
            lblTotalLucro = new Label();
            txtTotalCusto = new TextBox();
            lblTotalCusto = new Label();
            txtTotalVenda = new TextBox();
            lblTotalVenda = new Label();
            panelTotais = new Panel();
            panelTopo.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            panelTotais.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopo
            // 
            panelTopo.BackColor = Color.FromArgb(230, 236, 250);
            panelTopo.Controls.Add(lblCliente);
            panelTopo.Controls.Add(cbCliente);
            panelTopo.Controls.Add(lblMes);
            panelTopo.Controls.Add(cbMes);
            panelTopo.Controls.Add(lblAno);
            panelTopo.Controls.Add(txtAno);
            panelTopo.Controls.Add(btnBuscar);
            panelTopo.Dock = DockStyle.Top;
            panelTopo.Location = new Point(0, 0);
            panelTopo.Name = "panelTopo";
            panelTopo.Size = new Size(1182, 64);
            panelTopo.TabIndex = 2;
            panelTopo.Paint += panelTopo_Paint;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(10, 27);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(58, 20);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // cbCliente
            // 
            cbCliente.Location = new Point(70, 23);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(306, 28);
            cbCliente.TabIndex = 1;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(435, 27);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(39, 20);
            lblMes.TabIndex = 2;
            lblMes.Text = "Mês:";
            // 
            // cbMes
            // 
            cbMes.Location = new Point(478, 23);
            cbMes.Name = "cbMes";
            cbMes.Size = new Size(178, 28);
            cbMes.TabIndex = 3;
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Location = new Point(749, 27);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(39, 20);
            lblAno.TabIndex = 4;
            lblAno.Text = "Ano:";
            lblAno.Click += lblAno_Click;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(794, 24);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(129, 27);
            txtAno.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1015, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(141, 30);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgvRelatorio);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 64);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1182, 639);
            panelGrid.TabIndex = 0;
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.AllowUserToAddRows = false;
            dgvRelatorio.AllowUserToDeleteRows = false;
            dgvRelatorio.ColumnHeadersHeight = 29;
            dgvRelatorio.Dock = DockStyle.Fill;
            dgvRelatorio.Location = new Point(0, 0);
            dgvRelatorio.Margin = new Padding(0);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.ReadOnly = true;
            dgvRelatorio.RowHeadersWidth = 51;
            dgvRelatorio.Size = new Size(1182, 639);
            dgvRelatorio.TabIndex = 0;
            dgvRelatorio.CellContentClick += dgvRelatorio_CellContentClick;
            // 
            // txtTotalLucro
            // 
            txtTotalLucro.Location = new Point(941, 12);
            txtTotalLucro.Name = "txtTotalLucro";
            txtTotalLucro.Size = new Size(213, 27);
            txtTotalLucro.TabIndex = 5;
            // 
            // lblTotalLucro
            // 
            lblTotalLucro.AutoSize = true;
            lblTotalLucro.Location = new Point(850, 15);
            lblTotalLucro.Name = "lblTotalLucro";
            lblTotalLucro.Size = new Size(85, 20);
            lblTotalLucro.TabIndex = 4;
            lblTotalLucro.Text = "Total Lucro:";
            // 
            // txtTotalCusto
            // 
            txtTotalCusto.Location = new Point(518, 12);
            txtTotalCusto.Name = "txtTotalCusto";
            txtTotalCusto.Size = new Size(203, 27);
            txtTotalCusto.TabIndex = 3;
            // 
            // lblTotalCusto
            // 
            lblTotalCusto.AutoSize = true;
            lblTotalCusto.Location = new Point(428, 15);
            lblTotalCusto.Name = "lblTotalCusto";
            lblTotalCusto.Size = new Size(86, 20);
            lblTotalCusto.TabIndex = 2;
            lblTotalCusto.Text = "Total Custo:";
            // 
            // txtTotalVenda
            // 
            txtTotalVenda.Location = new Point(106, 12);
            txtTotalVenda.Name = "txtTotalVenda";
            txtTotalVenda.Size = new Size(203, 27);
            txtTotalVenda.TabIndex = 1;
            txtTotalVenda.TextChanged += txtTotalVenda_TextChanged_1;
            // 
            // lblTotalVenda
            // 
            lblTotalVenda.AutoSize = true;
            lblTotalVenda.Location = new Point(10, 15);
            lblTotalVenda.Name = "lblTotalVenda";
            lblTotalVenda.Size = new Size(90, 20);
            lblTotalVenda.TabIndex = 0;
            lblTotalVenda.Text = "Total Venda:";
            // 
            // panelTotais
            // 
            panelTotais.BackColor = Color.WhiteSmoke;
            panelTotais.Controls.Add(lblTotalVenda);
            panelTotais.Controls.Add(txtTotalVenda);
            panelTotais.Controls.Add(lblTotalCusto);
            panelTotais.Controls.Add(txtTotalCusto);
            panelTotais.Controls.Add(lblTotalLucro);
            panelTotais.Controls.Add(txtTotalLucro);
            panelTotais.Dock = DockStyle.Bottom;
            panelTotais.Location = new Point(0, 703);
            panelTotais.Name = "panelTotais";
            panelTotais.Size = new Size(1182, 50);
            panelTotais.TabIndex = 1;
            // 
            // FrmRelatorioMensal
            // 
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1182, 753);
            Controls.Add(panelGrid);
            Controls.Add(panelTotais);
            Controls.Add(panelTopo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRelatorioMensal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatórios Mensais";
            Load += FrmRelatorioMensal_Load;
            panelTopo.ResumeLayout(false);
            panelTopo.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            panelTotais.ResumeLayout(false);
            panelTotais.PerformLayout();
            ResumeLayout(false);
        }
        private TextBox txtTotalLucro;
        private Label lblTotalLucro;
        private TextBox txtTotalCusto;
        private Label lblTotalCusto;
        private TextBox txtTotalVenda;
        private Label lblTotalVenda;
        private Panel panelTotais;
    }
}
