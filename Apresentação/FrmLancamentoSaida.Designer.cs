namespace Apresentação
{
    partial class FrmLancamentoSaida
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
            cbPessoa = new ComboBox();
            label1 = new Label();
            dtData = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            txtValor = new TextBox();
            label4 = new Label();
            txtObservacoes = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cbPessoa
            // 
            cbPessoa.FormattingEnabled = true;
            cbPessoa.Location = new Point(11, 41);
            cbPessoa.Name = "cbPessoa";
            cbPessoa.Size = new Size(603, 28);
            cbPessoa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 1;
            label1.Text = "Cliente / Fornecedor / Credor:";
            // 
            // dtData
            // 
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(419, 96);
            dtData.Name = "dtData";
            dtData.Size = new Size(196, 27);
            dtData.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 101);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Vencimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 101);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(65, 98);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(154, 27);
            txtValor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 144);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 6;
            label4.Text = "Observações:";
            // 
            // txtObservacoes
            // 
            txtObservacoes.Location = new Point(11, 173);
            txtObservacoes.Multiline = true;
            txtObservacoes.Name = "txtObservacoes";
            txtObservacoes.Size = new Size(603, 34);
            txtObservacoes.TabIndex = 7;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(410, 258);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(521, 258);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmLancamentoSaida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 302);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtObservacoes);
            Controls.Add(label4);
            Controls.Add(txtValor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtData);
            Controls.Add(label1);
            Controls.Add(cbPessoa);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLancamentoSaida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saída";
            Load += FrmLancamentoSaida_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbPessoa;
        private Label label1;
        private DateTimePicker dtData;
        private Label label2;
        private Label label3;
        private TextBox txtValor;
        private Label label4;
        private TextBox txtObservacoes;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}