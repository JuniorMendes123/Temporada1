using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTrasnferencia;
using Negocios;


namespace Apresentação
{
    public partial class FrmClienteCadastrar : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmClienteCadastrar(AcaoNaTela acaoNaTela, Cliente cliente)
        {
            InitializeComponent();

            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Cliente";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Cliente";
                textBoxCodigo.Text = cliente.idCliente.ToString();
                textBoxNome.Text = cliente.Nome;
                dateDataNascimento.Value = cliente.DataNascimento;

                if (cliente.Sexo == true) //Masculino
                    radioSexoMasculino.Checked = true;
                else
                    radioSexoFeminino.Checked = true;

                textBoxLimiteCompra.Text = cliente.LimiteCompra.ToString();
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Cliente";

                //Carregar campos da tela
                textBoxCodigo.Text = cliente.idCliente.ToString();
                textBoxNome.Text = cliente.Nome;
                dateDataNascimento.Value = cliente.DataNascimento;

                if (cliente.Sexo == true) //Masculino 
                    radioSexoMasculino.Checked = true;
                else
                    radioSexoFeminino.Checked = true;

                textBoxLimiteCompra.Text = cliente.LimiteCompra.ToString();

                //Desabilitar os campos da tela 
                textBoxNome.ReadOnly = true;
                textBoxNome.TabStop = false;
                dateDataNascimento.Enabled = false;

                radioSexoMasculino.Enabled = false;
                radioSexoFeminino.Enabled = false;

                textBoxLimiteCompra.ReadOnly = true;
                textBoxLimiteCompra.TabStop = false;

                buttonSalvar.Visible = false;
                buttonCancelar.Text = "Fechar";
                buttonCancelar.Focus();



            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void textBoxLimiteCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //Verificar se é inserção ou alteração
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                Cliente cliente = new Cliente();
                cliente.Nome = textBoxNome.Text;
                cliente.DataNascimento = dateDataNascimento.Value;
                if (radioSexoMasculino.Checked == true)
                    cliente.Sexo = true;
                else
                    cliente.Sexo = false;
                cliente.LimiteCompra = Convert.ToDecimal(textBoxLimiteCompra.Text);

                ClienteNegócios clienteNegócios = new ClienteNegócios();
                string retorno = clienteNegócios.Inserir(cliente);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro

                try
                {
                    int idCliente = Convert.ToInt32(retorno);

                    MessageBox.Show("Cliente inserido com sucesso. Código: " + idCliente.ToString());

                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível inserir. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }


            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                //Crio um cliente
                Cliente cliente = new Cliente();
                
                //Colo os campos da tela no objeto cliente e envio para alterar no banco
                cliente.idCliente = Convert.ToInt32(textBoxCodigo.Text);
                
                cliente.Nome = textBoxNome.Text;
                cliente.DataNascimento = dateDataNascimento.Value;
                
                if (radioSexoMasculino.Checked == true)
                    cliente.Sexo = true;
                else
                    cliente.Sexo = false;
                cliente.LimiteCompra = Convert.ToDecimal(textBoxLimiteCompra.Text);

                ClienteNegócios clienteNegócios = new ClienteNegócios();
                string retorno = clienteNegócios.Alterar(cliente);

                //Tentar converter para inteiro
                //Se der tudo certo é porque devolveu o código do cliente
                //Se der errado tem a mensagem de erro

                try
                {
                    int idCliente = Convert.ToInt32(retorno);

                    MessageBox.Show("Cliente alterado com sucesso. Código: " + idCliente.ToString());

                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Não foi possível alterar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }

        }
    }
}
