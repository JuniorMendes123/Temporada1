namespace Apresentação
{
    partial class FmrProdutoCadastrar
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
            labelCódigoProd = new Label();
            labelNomeProd = new Label();
            labelDescricaoProd = new Label();
            labelValorVenda = new Label();
            labelValorCusto = new Label();
            textBoxCodigoProduto = new TextBox();
            textBoxNomeProduto = new TextBox();
            textBoxDescricaoProduto = new TextBox();
            textBoxValorVenda = new TextBox();
            textBoxValorCusto = new TextBox();
            btnSalvarProd = new Button();
            btnCancelarProd = new Button();
            SuspendLayout();
            // 
            // labelCódigoProd
            // 
            labelCódigoProd.AutoSize = true;
            labelCódigoProd.Location = new Point(29, 27);
            labelCódigoProd.Name = "labelCódigoProd";
            labelCódigoProd.Size = new Size(115, 20);
            labelCódigoProd.TabIndex = 0;
            labelCódigoProd.Text = "Código Produto";
            labelCódigoProd.Click += labelCódigoProd_Click;
            // 
            // labelNomeProd
            // 
            labelNomeProd.AutoSize = true;
            labelNomeProd.Location = new Point(29, 111);
            labelNomeProd.Name = "labelNomeProd";
            labelNomeProd.Size = new Size(107, 20);
            labelNomeProd.TabIndex = 1;
            labelNomeProd.Text = "Nome Produto";
            labelNomeProd.Click += labelNomeProd_Click;
            // 
            // labelDescricaoProd
            // 
            labelDescricaoProd.AutoSize = true;
            labelDescricaoProd.Location = new Point(29, 195);
            labelDescricaoProd.Name = "labelDescricaoProd";
            labelDescricaoProd.Size = new Size(131, 20);
            labelDescricaoProd.TabIndex = 2;
            labelDescricaoProd.Text = "Descrição Produto";
            labelDescricaoProd.Click += labelDescricaoProd_Click;
            // 
            // labelValorVenda
            // 
            labelValorVenda.AutoSize = true;
            labelValorVenda.Location = new Point(29, 302);
            labelValorVenda.Name = "labelValorVenda";
            labelValorVenda.Size = new Size(88, 20);
            labelValorVenda.TabIndex = 3;
            labelValorVenda.Text = "Valor Venda";
            // 
            // labelValorCusto
            // 
            labelValorCusto.AutoSize = true;
            labelValorCusto.Location = new Point(286, 302);
            labelValorCusto.Name = "labelValorCusto";
            labelValorCusto.Size = new Size(84, 20);
            labelValorCusto.TabIndex = 4;
            labelValorCusto.Text = "Valor Custo";
            // 
            // textBoxCodigoProduto
            // 
            textBoxCodigoProduto.Location = new Point(29, 50);
            textBoxCodigoProduto.Name = "textBoxCodigoProduto";
            textBoxCodigoProduto.ReadOnly = true;
            textBoxCodigoProduto.Size = new Size(115, 27);
            textBoxCodigoProduto.TabIndex = 6;
            textBoxCodigoProduto.TextChanged += textBox1_TextChanged;
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.Location = new Point(29, 138);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(430, 27);
            textBoxNomeProduto.TabIndex = 8;
            textBoxNomeProduto.TextChanged += textBox2_TextChanged;
            // 
            // textBoxDescricaoProduto
            // 
            textBoxDescricaoProduto.Location = new Point(29, 226);
            textBoxDescricaoProduto.Multiline = true;
            textBoxDescricaoProduto.Name = "textBoxDescricaoProduto";
            textBoxDescricaoProduto.Size = new Size(430, 34);
            textBoxDescricaoProduto.TabIndex = 9;
            // 
            // textBoxValorVenda
            // 
            textBoxValorVenda.Location = new Point(29, 328);
            textBoxValorVenda.Name = "textBoxValorVenda";
            textBoxValorVenda.Size = new Size(172, 27);
            textBoxValorVenda.TabIndex = 10;
            textBoxValorVenda.TextChanged += textBox4_TextChanged;
            // 
            // textBoxValorCusto
            // 
            textBoxValorCusto.Location = new Point(286, 328);
            textBoxValorCusto.Name = "textBoxValorCusto";
            textBoxValorCusto.Size = new Size(173, 27);
            textBoxValorCusto.TabIndex = 11;
            // 
            // btnSalvarProd
            // 
            btnSalvarProd.Location = new Point(254, 398);
            btnSalvarProd.Name = "btnSalvarProd";
            btnSalvarProd.Size = new Size(94, 29);
            btnSalvarProd.TabIndex = 12;
            btnSalvarProd.Text = "Salvar";
            btnSalvarProd.UseVisualStyleBackColor = true;
            btnSalvarProd.Click += btnSalvarProd_Click;
            // 
            // btnCancelarProd
            // 
            btnCancelarProd.Location = new Point(365, 398);
            btnCancelarProd.Name = "btnCancelarProd";
            btnCancelarProd.Size = new Size(94, 29);
            btnCancelarProd.TabIndex = 13;
            btnCancelarProd.Text = "Cancelar";
            btnCancelarProd.UseVisualStyleBackColor = true;
            btnCancelarProd.Click += btnCancelarProd_Click;
            // 
            // FmrProdutoCadastrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 453);
            Controls.Add(btnCancelarProd);
            Controls.Add(btnSalvarProd);
            Controls.Add(textBoxValorCusto);
            Controls.Add(textBoxValorVenda);
            Controls.Add(textBoxDescricaoProduto);
            Controls.Add(textBoxNomeProduto);
            Controls.Add(textBoxCodigoProduto);
            Controls.Add(labelValorCusto);
            Controls.Add(labelValorVenda);
            Controls.Add(labelDescricaoProd);
            Controls.Add(labelNomeProd);
            Controls.Add(labelCódigoProd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FmrProdutoCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCódigoProd;
        private Label labelNomeProd;
        private Label labelDescricaoProd;
        private Label labelValorVenda;
        private Label labelValorCusto;
        private TextBox textBoxCodigoProduto;
        private TextBox textBoxNomeProduto;
        private TextBox textBoxDescricaoProduto;
        private TextBox textBoxValorVenda;
        private TextBox textBoxValorCusto;
        private Button btnSalvarProd;
        private Button btnCancelarProd;
    }
}