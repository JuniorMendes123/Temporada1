namespace Apresentação
{
    partial class FrmFinanceiro
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
            panel1 = new Panel();
            btnFechar = new Button();
            btnLancarSaida = new Button();
            btnBuscar = new Button();
            cbFiltroPessoa = new ComboBox();
            label3 = new Label();
            dtpDataFinal = new DateTimePicker();
            label2 = new Label();
            dtpDataInicial = new DateTimePicker();
            label1 = new Label();
            panel3 = new Panel();
            txtSaldo = new TextBox();
            label6 = new Label();
            txtTotalSaidas = new TextBox();
            label5 = new Label();
            txtTotalEntradas = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            dgvMovimentos = new DataGridView();
            btnExcluirSaida = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimentos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExcluirSaida);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(btnLancarSaida);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(cbFiltroPessoa);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpDataFinal);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpDataInicial);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 124);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(1102, 27);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnLancarSaida
            // 
            btnLancarSaida.Location = new Point(944, 77);
            btnLancarSaida.Name = "btnLancarSaida";
            btnLancarSaida.Size = new Size(116, 29);
            btnLancarSaida.TabIndex = 7;
            btnLancarSaida.Text = "Lançar Saída";
            btnLancarSaida.UseVisualStyleBackColor = true;
            btnLancarSaida.Click += btnLancarSaida_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(833, 77);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Pesquisar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbFiltroPessoa
            // 
            cbFiltroPessoa.FormattingEnabled = true;
            cbFiltroPessoa.Location = new Point(157, 78);
            cbFiltroPessoa.Name = "cbFiltroPessoa";
            cbFiltroPessoa.Size = new Size(656, 28);
            cbFiltroPessoa.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 82);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 4;
            label3.Text = "Cliente/Fornecedor:";
            // 
            // dtpDataFinal
            // 
            dtpDataFinal.Format = DateTimePickerFormat.Short;
            dtpDataFinal.Location = new Point(305, 29);
            dtpDataFinal.Name = "dtpDataFinal";
            dtpDataFinal.Size = new Size(102, 27);
            dtpDataFinal.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 32);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Data Final:";
            // 
            // dtpDataInicial
            // 
            dtpDataInicial.Format = DateTimePickerFormat.Short;
            dtpDataInicial.Location = new Point(99, 29);
            dtpDataInicial.Name = "dtpDataInicial";
            dtpDataInicial.Size = new Size(105, 27);
            dtpDataInicial.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Data Inicial:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSaldo);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtTotalSaidas);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtTotalEntradas);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 609);
            panel3.Name = "panel3";
            panel3.Size = new Size(1205, 68);
            panel3.TabIndex = 2;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(933, 23);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.ReadOnly = true;
            txtSaldo.Size = new Size(240, 27);
            txtSaldo.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(877, 26);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 4;
            label6.Text = "Saldo:";
            // 
            // txtTotalSaidas
            // 
            txtTotalSaidas.Location = new Point(567, 23);
            txtTotalSaidas.Name = "txtTotalSaidas";
            txtTotalSaidas.ReadOnly = true;
            txtTotalSaidas.Size = new Size(219, 27);
            txtTotalSaidas.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(469, 26);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 2;
            label5.Text = "Total Saídas:";
            // 
            // txtTotalEntradas
            // 
            txtTotalEntradas.Location = new Point(163, 23);
            txtTotalEntradas.Name = "txtTotalEntradas";
            txtTotalEntradas.ReadOnly = true;
            txtTotalEntradas.Size = new Size(202, 27);
            txtTotalEntradas.TabIndex = 1;
            txtTotalEntradas.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 26);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 0;
            label4.Text = "Total Entradas:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvMovimentos);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(1205, 485);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint_1;
            // 
            // dgvMovimentos
            // 
            dgvMovimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimentos.Dock = DockStyle.Fill;
            dgvMovimentos.Location = new Point(0, 0);
            dgvMovimentos.Name = "dgvMovimentos";
            dgvMovimentos.RowHeadersWidth = 51;
            dgvMovimentos.Size = new Size(1205, 485);
            dgvMovimentos.TabIndex = 0;
            // 
            // btnExcluirSaida
            // 
            btnExcluirSaida.Location = new Point(1079, 77);
            btnExcluirSaida.Name = "btnExcluirSaida";
            btnExcluirSaida.Size = new Size(117, 29);
            btnExcluirSaida.TabIndex = 9;
            btnExcluirSaida.Text = "Excluir";
            btnExcluirSaida.UseVisualStyleBackColor = true;
            btnExcluirSaida.Click += btnExcluirSaida_Click;
            // 
            // FrmFinanceiro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 677);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FrmFinanceiro";
            Text = "FrmFinanceiro";
            Load += FrmFinanceiro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMovimentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBuscar;
        private ComboBox cbFiltroPessoa;
        private Label label3;
        private DateTimePicker dtpDataFinal;
        private Label label2;
        private DateTimePicker dtpDataInicial;
        private Label label1;
        private Panel panel3;
        private TextBox txtSaldo;
        private Label label6;
        private TextBox txtTotalSaidas;
        private Label label5;
        private TextBox txtTotalEntradas;
        private Label label4;
        private Button btnLancarSaida;
        private Panel panel2;
        private DataGridView dgvMovimentos;
        private Button btnFechar;
        private Button btnExcluirSaida;
    }
}