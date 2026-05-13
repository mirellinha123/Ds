using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace POO
{
    class Apresentacao : Form
    {
        PictureBox img = new PictureBox();

        Label txtTitulo = new Label();
        Label txtTitulo2 = new Label();
        Label txtNome = new Label();
        Label txtJogos = new Label();
        Label txtIdade = new Label();

        Panel menu = new Panel();
        Panel conteudo = new Panel();

        Button btobj01 = new Button();
        Button btobj02 = new Button();
        Button btobj03 = new Button();
        Button btobj04 = new Button();
        Button btobj05 = new Button();

        public Apresentacao()
        {
            // FORM
            this.Text = "The Last of Us- Personagens";
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(25, 25, 25);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // MENU LATERAL
            menu.Size = new Size(250, 700);
            menu.BackColor = Color.FromArgb(15, 15, 15);
            menu.Dock = DockStyle.Left;

            // PAINEL PRINCIPAL
            conteudo.Dock = DockStyle.Fill;
            conteudo.BackColor = Color.FromArgb(35, 35, 35);

            // TITULO
            txtTitulo.Text = "TLOU";
            txtTitulo.ForeColor = Color.Red;
            txtTitulo.Font = new Font("Impact", 22, FontStyle.Bold);
            txtTitulo.AutoSize = true;
            txtTitulo.Location = new Point(20, 20);

            // SUBTITULO
            txtTitulo2.Text = "PERSONAGENS";
            txtTitulo2.ForeColor = Color.Brown;
            txtTitulo2.Font = new Font("Times New Roman", 22, FontStyle.Bold);
            txtTitulo2.AutoSize = true;
            txtTitulo2.Location = new Point(20, 60);

            // CONFIG BOTÕES
            ConfigurarBotao(btobj01, "Joel", 120);
            ConfigurarBotao(btobj02, "Ellie", 190);
            ConfigurarBotao(btobj03, "Dina", 260);
            ConfigurarBotao(btobj04, "Abby", 330);
            ConfigurarBotao(btobj05, "Lev", 400);
            // EVENTOS
            btobj01.Click += Joel;
            btobj02.Click += Ellie;
            btobj03.Click += Dina;
            btobj04.Click += Abby;
            btobj05.Click += Lev;

            // LABELS INFO
            ConfigurarLabel(txtNome, 350);
            ConfigurarLabel(txtIdade, 400);
            ConfigurarLabel(txtJogos, 450);

            // IMAGEM
            img.Size = new Size(250, 350);
            img.Location = new Point(70, 170);
            img.SizeMode = PictureBoxSizeMode.StretchImage;
            img.BorderStyle = BorderStyle.FixedSingle;

            // ADICIONAR CONTROLES
            menu.Controls.Add(txtTitulo);
            menu.Controls.Add(txtTitulo2);

            menu.Controls.Add(btobj01);
            menu.Controls.Add(btobj02);
            menu.Controls.Add(btobj03);
            menu.Controls.Add(btobj04);
            menu.Controls.Add(btobj05);

            conteudo.Controls.Add(img);
            conteudo.Controls.Add(txtNome);
            conteudo.Controls.Add(txtIdade);
            conteudo.Controls.Add(txtJogos);

            this.Controls.Add(conteudo);
            this.Controls.Add(menu);
        }

        // ESTILO DOS BOTÕES
        private void ConfigurarBotao(Button bt, string texto, int y)
        {
            bt.Text = texto;
            bt.Size = new Size(180, 50);
            bt.Location = new Point(35, y);

            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 0;

            bt.BackColor = Color.FromArgb(50, 50, 50);
            bt.ForeColor = Color.White;

            bt.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            bt.Cursor = Cursors.Hand;
        }

        // ESTILO DAS LABELS
        private void ConfigurarLabel(Label lb, int y)
        {
            lb.ForeColor = Color.White;
            lb.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lb.AutoSize = true;
            lb.Location = new Point(380, y);
        }

        // MOSTRAR PERSONAGEM
        private void MostrarPersonagem(Personagem p)
        {
            txtNome.Text = "Nome: " + p.Nome;
            txtIdade.Text = "Idade: " + p.Idade;
            txtJogos.Text = "Jogos: " + p.Jogos;

            string imgPath = Path.Combine(Application.StartupPath, p.Imagem());

            if (File.Exists(imgPath))
            {
                img.Image = Image.FromFile(imgPath);
            }
            else
            {
                img.Image = null;
                MessageBox.Show("Imagem não encontrada!");
            }
        }

        // BOTÕES
        private void Joel(object sender, EventArgs e)
        {
            MostrarPersonagem(new Joel());
        }

        private void Ellie(object sender, EventArgs e)
        {
            MostrarPersonagem(new Ellie());
        }

        private void Dina(object sender, EventArgs e)
        {
            MostrarPersonagem(new Dina());
        }

        private void Abby(object sender, EventArgs e)
        {
            MostrarPersonagem(new Abby());
        }

        private void Lev(object sender, EventArgs e)
        {
            MostrarPersonagem(new Lev());
        }
    }
}