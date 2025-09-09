namespace Apresentação
{
    partial class frmProduto
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
            LabelNome = new Label();
            txtDescricao = new TextBox();
            labelDescricao = new Label();
            labelPreco = new Label();
            labelCusto = new Label();
            btnSalvar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnConsultar = new Button();
            txtNome = new TextBox();
            labelEstoque = new Label();
            txtPreco = new TextBox();
            txtCusto = new TextBox();
            txtEstoque = new TextBox();
            labelId = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Location = new Point(28, 90);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(62, 20);
            LabelNome.TabIndex = 0;
            LabelNome.Text = "Produto";
            LabelNome.Click += label1_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(117, 159);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(649, 27);
            txtDescricao.TabIndex = 2;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(28, 162);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(73, 20);
            labelDescricao.TabIndex = 3;
            labelDescricao.Text = "Dercrição";
            labelDescricao.Click += label2_Click;
            // 
            // labelPreco
            // 
            labelPreco.AutoSize = true;
            labelPreco.Location = new Point(28, 234);
            labelPreco.Name = "labelPreco";
            labelPreco.Size = new Size(88, 20);
            labelPreco.TabIndex = 5;
            labelPreco.Text = "Valor Venda";
            // 
            // labelCusto
            // 
            labelCusto.AutoSize = true;
            labelCusto.Location = new Point(547, 234);
            labelCusto.Name = "labelCusto";
            labelCusto.Size = new Size(84, 20);
            labelCusto.TabIndex = 6;
            labelCusto.Text = "Valor Custo";
            labelCusto.Click += labelCusto_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(291, 392);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(419, 392);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(94, 29);
            btnAlterar.TabIndex = 9;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(547, 392);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(675, 392);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(94, 29);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(117, 87);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(649, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // labelEstoque
            // 
            labelEstoque.AutoSize = true;
            labelEstoque.Location = new Point(28, 306);
            labelEstoque.Name = "labelEstoque";
            labelEstoque.Size = new Size(62, 20);
            labelEstoque.TabIndex = 13;
            labelEstoque.Text = "Estoque";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(132, 231);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(125, 27);
            txtPreco.TabIndex = 14;
            // 
            // txtCusto
            // 
            txtCusto.Location = new Point(641, 231);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(125, 27);
            txtCusto.TabIndex = 15;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(132, 303);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(125, 27);
            txtEstoque.TabIndex = 16;
            txtEstoque.TextChanged += txtEstoque_TextChanged;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(28, 20);
            labelId.Name = "labelId";
            labelId.Size = new Size(115, 20);
            labelId.TabIndex = 17;
            labelId.Text = "Código Produto";
            // 
            // txtId
            // 
            txtId.ImeMode = ImeMode.On;
            txtId.Location = new Point(168, 17);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(89, 27);
            txtId.TabIndex = 18;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(labelId);
            Controls.Add(txtEstoque);
            Controls.Add(txtCusto);
            Controls.Add(txtPreco);
            Controls.Add(labelEstoque);
            Controls.Add(btnConsultar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnSalvar);
            Controls.Add(labelCusto);
            Controls.Add(labelPreco);
            Controls.Add(labelDescricao);
            Controls.Add(txtDescricao);
            Controls.Add(txtNome);
            Controls.Add(LabelNome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelNome;
        private TextBox txtDescricao;
        private Label labelDescricao;
        private Label labelPreco;
        private Label labelCusto;
        private Button btnSalvar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnConsultar;
        private TextBox txtNome;
        private Label labelEstoque;
        private TextBox txtPreco;
        private TextBox txtCusto;
        private TextBox txtEstoque;
        private Label labelId;
        private TextBox textId;
        private TextBox txtId;
    }
}