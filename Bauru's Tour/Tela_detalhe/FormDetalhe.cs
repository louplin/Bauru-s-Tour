using BauruThur.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Baurus_Thuor.Tela_Busca.Tela_Detalhes
{
    public partial class FormDetalhe : Form
    {
        private PontoTuristico ponto = null!;

        // Posições originais dos controles e a área que o conjunto ocupa
        readonly Dictionary<Control, Point> posOriginal = new Dictionary<Control, Point>();
        Rectangle areaConteudo;

        // Usado só pelo Designer do Visual Studio
        public FormDetalhe()
        {
            InitializeComponent();
        }

        // Usado pelo programa: recebe o ponto que foi clicado
        public FormDetalhe(PontoTuristico ponto) : this()
        {
            this.ponto = ponto;

            FormBorderStyle = FormBorderStyle.None;    // sem bordas
            WindowState = FormWindowState.Maximized;   // tela cheia

            // Esc fecha esta tela e volta pra busca
            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape) Close();
            };

            Resize += (s, e) => Centralizar();
        }

        // Roda depois do reescalonamento automático: aqui as posições são as reais
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // dispara o FormDetalhe_Load (preenche os textos)

            posOriginal.Clear();
            areaConteudo = Rectangle.Empty;

            foreach (Control c in Controls)
            {
                posOriginal[c] = c.Location;
                areaConteudo = areaConteudo.IsEmpty
                    ? c.Bounds
                    : Rectangle.Union(areaConteudo, c.Bounds);
            }

            Centralizar();
        }

        // Centraliza o conjunto (foto, textos e botões) na tela
        void Centralizar()
        {
            if (posOriginal.Count == 0) return; // ainda não carregou

            int dx = (ClientSize.Width - areaConteudo.Width) / 2 - areaConteudo.X;
            int dy = (ClientSize.Height - areaConteudo.Height) / 2 - areaConteudo.Y;

            foreach (var par in posOriginal)
                par.Key.Location = new Point(par.Value.X + dx, par.Value.Y + dy);
        }

        // Preenche a tela com os dados do ponto
        private void FormDetalhe_Load(object sender, EventArgs e)
        {
            if (ponto == null) return; // aberto pelo Designer

            lblNome.Text = ponto.Nome;
            lblEndereco.Text = ponto.Endereco;
            lblDescricao.Text = ponto.Descricao;

            picFoto.BackColor = Color.FromArgb(225, 232, 240); // cinza-azulado claro enquanto não há foto

            if (!string.IsNullOrWhiteSpace(ponto.Imagem))
            {
                string caminho = Path.Combine(AppContext.BaseDirectory, ponto.Imagem);
                if (File.Exists(caminho))
                    picFoto.Image = Image.FromFile(caminho);
            }
        }

        // Abre o ponto no Google Maps (navegador padrão)
        private void btnMapa_Click(object sender, EventArgs e)
        {
            if (ponto == null || string.IsNullOrWhiteSpace(ponto.LinkMaps)) return;

            Process.Start(new ProcessStartInfo(ponto.LinkMaps) { UseShellExecute = true });
        }

        // Fecha esta tela e volta pra busca
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Métodos que o Designer criou e ligou; podem ficar vazios
        private void label1_Click(object sender, EventArgs e) { }
        private void picFoto_Click(object sender, EventArgs e) { }
        private void lblEndereco_Click(object sender, EventArgs e) { }
        private void lblDescricao_Click(object sender, EventArgs e) { }
    }
}