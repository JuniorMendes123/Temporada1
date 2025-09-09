namespace Apresentação
{
    partial class FrmClienteCadastrar
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
            LabelCódigo = new Label();
            labelNome = new Label();
            labelDataNascimento = new Label();
            labelSexo = new Label();
            labelLimiteCompra = new Label();
            textBoxCodigo = new TextBox();
            textBoxNome = new TextBox();
            dateDataNascimento = new DateTimePicker();
            radioSexoMasculino = new RadioButton();
            radioSexoFeminino = new RadioButton();
            textBoxLimiteCompra = new TextBox();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // LabelCódigo
            // 
            LabelCódigo.AutoSize = true;
            LabelCódigo.Location = new Point(34, 20);
            LabelCódigo.Name = "LabelCódigo";
            LabelCódigo.Size = new Size(58, 20);
            LabelCódigo.TabIndex = 0;
            LabelCódigo.Text = "Código";
            LabelCódigo.Click += label1_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(34, 104);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome";
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(34, 188);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(124, 20);
            labelDataNascimento.TabIndex = 4;
            labelDataNascimento.Text = "Data Nascimento";
            // 
            // labelSexo
            // 
            labelSexo.AutoSize = true;
            labelSexo.Location = new Point(34, 272);
            labelSexo.Name = "labelSexo";
            labelSexo.Size = new Size(41, 20);
            labelSexo.TabIndex = 6;
            labelSexo.Text = "Sexo";
            // 
            // labelLimiteCompra
            // 
            labelLimiteCompra.AutoSize = true;
            labelLimiteCompra.Location = new Point(34, 356);
            labelLimiteCompra.Name = "labelLimiteCompra";
            labelLimiteCompra.Size = new Size(107, 20);
            labelLimiteCompra.TabIndex = 9;
            labelLimiteCompra.Text = "Limite Compra";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(34, 43);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.ReadOnly = true;
            textBoxCodigo.Size = new Size(91, 27);
            textBoxCodigo.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(34, 127);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(420, 27);
            textBoxNome.TabIndex = 3;
            // 
            // dateDataNascimento
            // 
            dateDataNascimento.Format = DateTimePickerFormat.Short;
            dateDataNascimento.Location = new Point(34, 211);
            dateDataNascimento.Name = "dateDataNascimento";
            dateDataNascimento.Size = new Size(127, 27);
            dateDataNascimento.TabIndex = 5;
            // 
            // radioSexoMasculino
            // 
            radioSexoMasculino.AutoSize = true;
            radioSexoMasculino.Checked = true;
            radioSexoMasculino.Location = new Point(34, 297);
            radioSexoMasculino.Name = "radioSexoMasculino";
            radioSexoMasculino.Size = new Size(97, 24);
            radioSexoMasculino.TabIndex = 7;
            radioSexoMasculino.TabStop = true;
            radioSexoMasculino.Text = "Masculino";
            radioSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // radioSexoFeminino
            // 
            radioSexoFeminino.AutoSize = true;
            radioSexoFeminino.Location = new Point(208, 297);
            radioSexoFeminino.Name = "radioSexoFeminino";
            radioSexoFeminino.Size = new Size(91, 24);
            radioSexoFeminino.TabIndex = 8;
            radioSexoFeminino.Text = "Feminino";
            radioSexoFeminino.UseVisualStyleBackColor = true;
            // 
            // textBoxLimiteCompra
            // 
            textBoxLimiteCompra.Location = new Point(34, 379);
            textBoxLimiteCompra.Name = "textBoxLimiteCompra";
            textBoxLimiteCompra.Size = new Size(107, 27);
            textBoxLimiteCompra.TabIndex = 10;
            textBoxLimiteCompra.TextAlign = HorizontalAlignment.Right;
            textBoxLimiteCompra.TextChanged += textBoxLimiteCompra_TextChanged;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(260, 412);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 11;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(360, 412);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 12;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += button2_Click;
            // 
            // FrmClienteCadastrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 453);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxLimiteCompra);
            Controls.Add(radioSexoFeminino);
            Controls.Add(radioSexoMasculino);
            Controls.Add(dateDataNascimento);
            Controls.Add(textBoxNome);
            Controls.Add(textBoxCodigo);
            Controls.Add(labelLimiteCompra);
            Controls.Add(labelSexo);
            Controls.Add(labelDataNascimento);
            Controls.Add(labelNome);
            Controls.Add(LabelCódigo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmClienteCadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCódigo;
        private Label labelNome;
        private Label labelDataNascimento;
        private Label labelSexo;
        private Label labelLimiteCompra;
        private TextBox textBoxCodigo;
        private TextBox textBoxNome;
        private DateTimePicker dateDataNascimento;
        private RadioButton radioSexoMasculino;
        private RadioButton radioSexoFeminino;
        private TextBox textBoxLimiteCompra;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}