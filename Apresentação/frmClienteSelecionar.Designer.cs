namespace Apresentação
{
    partial class frmClienteSelecionar
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
            labelPesquisa = new Label();
            textBoxPesquisa = new TextBox();
            buttonPesquisar = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            buttonExcluir = new Button();
            buttonConsultar = new Button();
            buttonFechar = new Button();
            dataGridViewPrincipal = new DataGridView();
            colCódigo = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colDataNascimento = new DataGridViewTextBoxColumn();
            colSexo = new DataGridViewCheckBoxColumn();
            colLimiteCompra = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrincipal).BeginInit();
            SuspendLayout();
            // 
            // labelPesquisa
            // 
            labelPesquisa.AutoSize = true;
            labelPesquisa.Location = new Point(17, 22);
            labelPesquisa.Name = "labelPesquisa";
            labelPesquisa.Size = new Size(108, 20);
            labelPesquisa.TabIndex = 0;
            labelPesquisa.Text = "Código/Nome:";
            // 
            // textBoxPesquisa
            // 
            textBoxPesquisa.Location = new Point(127, 19);
            textBoxPesquisa.Name = "textBoxPesquisa";
            textBoxPesquisa.Size = new Size(643, 27);
            textBoxPesquisa.TabIndex = 1;
            textBoxPesquisa.TextChanged += textBoxPesquisa_TextChanged;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(776, 17);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(94, 29);
            buttonPesquisar.TabIndex = 2;
            buttonPesquisar.Text = "&Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(324, 402);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(94, 29);
            buttonInserir.TabIndex = 4;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(437, 402);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(94, 29);
            buttonAlterar.TabIndex = 5;
            buttonAlterar.Text = "Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(550, 402);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(94, 29);
            buttonExcluir.TabIndex = 6;
            buttonExcluir.Text = "Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonConsultar
            // 
            buttonConsultar.Location = new Point(663, 402);
            buttonConsultar.Name = "buttonConsultar";
            buttonConsultar.Size = new Size(94, 29);
            buttonConsultar.TabIndex = 7;
            buttonConsultar.Text = "Consultar";
            buttonConsultar.UseVisualStyleBackColor = true;
            buttonConsultar.Click += buttonConsultar_Click;
            // 
            // buttonFechar
            // 
            buttonFechar.Location = new Point(776, 402);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(94, 29);
            buttonFechar.TabIndex = 8;
            buttonFechar.Text = "Fechar";
            buttonFechar.UseVisualStyleBackColor = true;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // dataGridViewPrincipal
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrincipal.Columns.AddRange(new DataGridViewColumn[] { colCódigo, colCliente, colDataNascimento, colSexo, colLimiteCompra });
            dataGridViewPrincipal.Location = new Point(17, 62);
            dataGridViewPrincipal.MultiSelect = false;
            dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            dataGridViewPrincipal.ReadOnly = true;
            dataGridViewPrincipal.RowHeadersWidth = 51;
            dataGridViewPrincipal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPrincipal.Size = new Size(853, 322);
            dataGridViewPrincipal.TabIndex = 3;
            // 
            // colCódigo
            // 
            colCódigo.DataPropertyName = "IdCliente";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = Color.Red;
            dataGridViewCellStyle2.Format = "#,##0";
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            colCódigo.DefaultCellStyle = dataGridViewCellStyle2;
            colCódigo.HeaderText = "Código";
            colCódigo.MinimumWidth = 6;
            colCódigo.Name = "colCódigo";
            colCódigo.ReadOnly = true;
            colCódigo.Resizable = DataGridViewTriState.False;
            colCódigo.Width = 75;
            // 
            // colCliente
            // 
            colCliente.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colCliente.DefaultCellStyle = dataGridViewCellStyle3;
            colCliente.HeaderText = "Nome";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            colCliente.Width = 375;
            // 
            // colDataNascimento
            // 
            colDataNascimento.DataPropertyName = "DataNascimento";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            colDataNascimento.DefaultCellStyle = dataGridViewCellStyle4;
            colDataNascimento.HeaderText = "Nascimento";
            colDataNascimento.MinimumWidth = 6;
            colDataNascimento.Name = "colDataNascimento";
            colDataNascimento.ReadOnly = true;
            colDataNascimento.Width = 125;
            // 
            // colSexo
            // 
            colSexo.DataPropertyName = "Sexo";
            colSexo.HeaderText = "Sexo";
            colSexo.MinimumWidth = 6;
            colSexo.Name = "colSexo";
            colSexo.ReadOnly = true;
            colSexo.Width = 75;
            // 
            // colLimiteCompra
            // 
            colLimiteCompra.DataPropertyName = "LimiteCompra";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "#,##0.00";
            colLimiteCompra.DefaultCellStyle = dataGridViewCellStyle5;
            colLimiteCompra.HeaderText = "Limite Compra";
            colLimiteCompra.MinimumWidth = 6;
            colLimiteCompra.Name = "colLimiteCompra";
            colLimiteCompra.ReadOnly = true;
            colLimiteCompra.Width = 150;
            // 
            // frmClienteSelecionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(dataGridViewPrincipal);
            Controls.Add(buttonFechar);
            Controls.Add(buttonConsultar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonInserir);
            Controls.Add(buttonPesquisar);
            Controls.Add(textBoxPesquisa);
            Controls.Add(labelPesquisa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClienteSelecionar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Cliente";
            Load += frmClienteSelecionar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPesquisa;
        private TextBox textBoxPesquisa;
        private Button buttonPesquisar;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonExcluir;
        private Button buttonConsultar;
        private Button buttonFechar;
        private DataGridView dataGridViewPrincipal;
        private DataGridViewTextBoxColumn colCódigo;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colDataNascimento;
        private DataGridViewCheckBoxColumn colSexo;
        private DataGridViewTextBoxColumn colLimiteCompra;
    }
}