namespace Apresentação
{
    partial class frmProdutoSelecionar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            labelProduto = new Label();
            textPesquisarProduto = new TextBox();
            btnPesquisarProduto = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView2 = new DataGridView();
            clnCódigo = new DataGridViewTextBoxColumn();
            clnProduto = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorVenda = new DataGridViewTextBoxColumn();
            clnValorCusto = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // labelProduto
            // 
            labelProduto.AutoSize = true;
            labelProduto.Location = new Point(23, 38);
            labelProduto.Name = "labelProduto";
            labelProduto.Size = new Size(117, 20);
            labelProduto.TabIndex = 0;
            labelProduto.Text = "Código/Produto";
            // 
            // textPesquisarProduto
            // 
            textPesquisarProduto.Location = new Point(149, 35);
            textPesquisarProduto.Name = "textPesquisarProduto";
            textPesquisarProduto.Size = new Size(644, 27);
            textPesquisarProduto.TabIndex = 1;
            // 
            // btnPesquisarProduto
            // 
            btnPesquisarProduto.Location = new Point(799, 33);
            btnPesquisarProduto.Name = "btnPesquisarProduto";
            btnPesquisarProduto.Size = new Size(94, 29);
            btnPesquisarProduto.TabIndex = 2;
            btnPesquisarProduto.Text = "Pesquisar";
            btnPesquisarProduto.UseVisualStyleBackColor = true;
            btnPesquisarProduto.Click += btnPesquisarProduto_Click;
            // 
            // button2
            // 
            button2.Location = new Point(321, 404);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Inserir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(441, 404);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(561, 404);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(681, 404);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "Consultar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(801, 404);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 7;
            button6.Text = "Fechar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { clnCódigo, clnProduto, clnDescricao, clnValorVenda, clnValorCusto });
            dataGridView2.Location = new Point(23, 82);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(870, 304);
            dataGridView2.TabIndex = 8;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // clnCódigo
            // 
            clnCódigo.DataPropertyName = "IdProduto";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = Color.Red;
            dataGridViewCellStyle2.Format = "#,##0";
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            clnCódigo.DefaultCellStyle = dataGridViewCellStyle2;
            clnCódigo.Frozen = true;
            clnCódigo.HeaderText = "Código";
            clnCódigo.MinimumWidth = 6;
            clnCódigo.Name = "clnCódigo";
            clnCódigo.ReadOnly = true;
            clnCódigo.Width = 70;
            // 
            // clnProduto
            // 
            clnProduto.DataPropertyName = "NomeProduto";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            clnProduto.DefaultCellStyle = dataGridViewCellStyle3;
            clnProduto.Frozen = true;
            clnProduto.HeaderText = "Produto";
            clnProduto.MinimumWidth = 6;
            clnProduto.Name = "clnProduto";
            clnProduto.ReadOnly = true;
            clnProduto.Width = 150;
            // 
            // clnDescricao
            // 
            clnDescricao.DataPropertyName = "DescricaoProduto";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            clnDescricao.DefaultCellStyle = dataGridViewCellStyle4;
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.MinimumWidth = 6;
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 350;
            // 
            // clnValorVenda
            // 
            clnValorVenda.DataPropertyName = "ValorVenda";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "#,##0.00";
            clnValorVenda.DefaultCellStyle = dataGridViewCellStyle5;
            clnValorVenda.Frozen = true;
            clnValorVenda.HeaderText = "Valor Venda";
            clnValorVenda.MinimumWidth = 6;
            clnValorVenda.Name = "clnValorVenda";
            clnValorVenda.ReadOnly = true;
            clnValorVenda.Width = 125;
            // 
            // clnValorCusto
            // 
            clnValorCusto.DataPropertyName = "ValorCusto";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "#,##0.00";
            clnValorCusto.DefaultCellStyle = dataGridViewCellStyle6;
            clnValorCusto.HeaderText = "Valor Custo";
            clnValorCusto.MinimumWidth = 6;
            clnValorCusto.Name = "clnValorCusto";
            clnValorCusto.ReadOnly = true;
            clnValorCusto.Width = 125;
            // 
            // frmProdutoSelecionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(dataGridView2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnPesquisarProduto);
            Controls.Add(textPesquisarProduto);
            Controls.Add(labelProduto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProdutoSelecionar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Produto";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProduto;
        private TextBox textPesquisarProduto;
        private Button btnPesquisarProduto;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn clnCódigo;
        private DataGridViewTextBoxColumn clnProduto;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorVenda;
        private DataGridViewTextBoxColumn clnValorCusto;
    }
}