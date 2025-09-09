using Apresentação;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        private FlowLayoutPanel painelMenu;
        private Panel painelContainerMenu;
        private PictureBox logo;
        private PictureBox fundo;
        private Label lblBemVindo;

        public FrmMenu()
        {
            InitializeComponent();
            this.MdiChildActivate += (s, e) => GerenciarVisibilidadeBoasVindas();
            InicializarMenuComIcones();
            InicializarTelaCentral();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient mdiClient)
                {
                    mdiClient.BackColor = Color.White; // ou qualquer outra cor desejada
                }
            }

        }

        private void InicializarMenuComIcones()
        {
            this.Text = "Menu Principal";
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;

            // Painel de topo com barra azul
            painelContainerMenu = new Panel();
            painelContainerMenu.Dock = DockStyle.Top;
            painelContainerMenu.Height = 130;
            painelContainerMenu.BackColor = Color.LightSteelBlue;
            this.Controls.Add(painelContainerMenu);

            // FlowLayout centralizado dentro do painel azul
            painelMenu = new FlowLayoutPanel();
            painelMenu.Size = new Size(1600, 130);
            painelMenu.Location = new Point((this.ClientSize.Width - painelMenu.Width) / 2, 15);
            painelMenu.BackColor = Color.Transparent;
            painelMenu.WrapContents = false;
            painelMenu.FlowDirection = FlowDirection.LeftToRight;

            painelContainerMenu.Controls.Add(painelMenu);

            // Recalcular ao redimensionar janela
            this.Resize += (s, e) =>
            {
                painelMenu.Location = new Point((this.ClientSize.Width - painelMenu.Width) / 2, 15);
            };

            // Botões
            painelMenu.Controls.Add(CriarBotaoMenu("cliente.png", "Clientes", (s, e) => new frmClienteSelecionar { MdiParent = this }.Show()));
            painelMenu.Controls.Add(CriarBotaoMenu("fornecedor.png", "Fornecedor/Credor", (s, e) => new FrmFornecedorOutro { MdiParent = this }.Show()));
            painelMenu.Controls.Add(CriarBotaoMenu("produto.png", "Produtos", (s, e) => new frmProdutoSelecionar { MdiParent = this }.Show()));
            painelMenu.Controls.Add(CriarBotaoMenu("orcamento.png", "Orçamento/Pedido", (s, e) => new FmrPedido().ShowDialog()));
            painelMenu.Controls.Add(CriarBotaoMenu("consultar.png", "Consultar", (s, e) => new FrmPedidoConsulta().ShowDialog()));
            painelMenu.Controls.Add(CriarBotaoMenu("relatorios.png", "Relatórios", (s, e) =>
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form is FrmRelatorioMensal)
                    {
                        form.BringToFront();
                        return;
                    }
                }

                FrmRelatorioMensal frm = new FrmRelatorioMensal
                {
                    MdiParent = this,
                    FormBorderStyle = FormBorderStyle.None,
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };

                
                frm.Show();
            }));
            // NOVO BOTÃO FINANCEIRO
            painelMenu.Controls.Add(CriarBotaoMenu("financeiro.png", "Financeiro", (s, e) =>
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form is FrmFinanceiro)
                    {
                        form.BringToFront();
                        return;
                    }
                }

                FrmFinanceiro frm = new FrmFinanceiro
                {
                    MdiParent = this,
                    FormBorderStyle = FormBorderStyle.None,
                    StartPosition = FormStartPosition.CenterScreen,
                    TopLevel = false,
                };
                frm.Show();
            }));

            painelMenu.Controls.Add(CriarBotaoMenu("sair.png", "Sair", (s, e) => Application.Exit()));

        }
        
                  
        

        private Button CriarBotaoMenu(string nomeImagem, string texto, EventHandler onClick)
        {
            Button btn = new Button();
            btn.Size = new Size(150, 96);
            btn.Margin = new Padding(25, 0, 25, 0);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.LightSteelBlue;
            btn.Cursor = Cursors.Hand;
            btn.Text = texto;
            btn.TextAlign = ContentAlignment.BottomCenter;
            btn.ImageAlign = ContentAlignment.TopCenter;
            btn.TextImageRelation = TextImageRelation.ImageAboveText;
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            string caminhoImagem = Path.Combine(Application.StartupPath, "Imagens", nomeImagem);
            if (File.Exists(caminhoImagem))
            {
                Image imagemOriginal = Image.FromFile(caminhoImagem);
                Image imagemRedimensionada = new Bitmap(imagemOriginal, new Size(64, 64));
                btn.Image = imagemRedimensionada;
            }

            btn.Click += onClick;
            return btn;

        }

        private void InicializarTelaCentral()
        {
            fundo = new PictureBox();
            fundo.SizeMode = PictureBoxSizeMode.Zoom;
            fundo.Size = new Size(500, 500);
            fundo.BackColor = Color.White;

            lblBemVindo = new Label();
            lblBemVindo.BackColor = Color.White; // AGORA NÃO DÁ ERRO
            lblBemVindo.Text = "Bem-vindo!";
            lblBemVindo.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblBemVindo.ForeColor = Color.Gray;
            lblBemVindo.AutoSize = true;

            this.Controls.Add(fundo);
            this.Controls.Add(lblBemVindo);


            string caminhoFundo = Path.Combine(Application.StartupPath, "Imagens", "logo.png");
            if (File.Exists(caminhoFundo))
                fundo.Image = Image.FromFile(caminhoFundo);

            this.Controls.Add(fundo);

            lblBemVindo = new Label();
            lblBemVindo.Text = "Bem-vindo!";
            lblBemVindo.Font = new Font("Segoe UI", 36, FontStyle.Bold);
            lblBemVindo.ForeColor = Color.Black;
            lblBemVindo.AutoSize = true;
            lblBemVindo.BackColor = Color.White;

            this.Controls.Add(lblBemVindo);

            this.Load += (s, e) => Centralizar();
            this.Resize += (s, e) => Centralizar();
        }

        private void Centralizar()
        {
            int centroX = this.ClientSize.Width / 2;
            int centroY = this.ClientSize.Height / 2 + painelContainerMenu.Height / 2;

            fundo.Location = new Point(centroX - fundo.Width / 2, centroY - fundo.Height / 2 - 30);
            lblBemVindo.Location = new Point(centroX - lblBemVindo.Width / 2, fundo.Bottom + 10);
        }
        private void GerenciarVisibilidadeBoasVindas()
        {
            bool temFormularioAberto = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Visible)
                {
                    temFormularioAberto = true;
                    break;
                }
            }

            fundo.Visible = !temFormularioAberto;
            lblBemVindo.Visible = !temFormularioAberto;
        }

    }
}
