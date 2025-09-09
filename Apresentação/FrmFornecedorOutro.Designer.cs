namespace Apresentação
{
    partial class FrmFornecedorOutro
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
            label1 = new Label();
            txtNome = new TextBox();
            dgvFornecedores = new DataGridView();
            btnExcluir = new Button();
            btnFechar = new Button();
            btnAdicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Fornecedor / Credor:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(161, 18);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(377, 27);
            txtNome.TabIndex = 1;
            // 
            // dgvFornecedores
            // 
            dgvFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedores.Location = new Point(12, 66);
            dgvFornecedores.Name = "dgvFornecedores";
            dgvFornecedores.RowHeadersWidth = 51;
            dgvFornecedores.Size = new Size(628, 259);
            dgvFornecedores.TabIndex = 2;
            dgvFornecedores.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(444, 331);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(544, 331);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 29);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(544, 17);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // FrmFornecedorOutro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 368);
            Controls.Add(btnAdicionar);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(dgvFornecedores);
            Controls.Add(txtNome);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "FrmFornecedorOutro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Fornecedor / Credor";
            Load += FrmFornecedorOutro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private DataGridView dgvFornecedores;
        private Button btnExcluir;
        private Button btnFechar;
        private Button btnAdicionar;
    }
}