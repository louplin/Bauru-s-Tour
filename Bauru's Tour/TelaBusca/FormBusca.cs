using BauruTuor.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BauruTour
{
    public partial class FormBusca : Form
    {
        // Posições originais (já reescaladas pelo Windows Forms), guardadas no OnLoad
        readonly Dictionary<Control, Point> posOriginal = new Dictionary<Control, Point>();
        Rectangle areaBusca;   // retângulo que contém busca + botão + lista
        int alturaTotal;       // altura de todo o conteúdo (do título até o fim da lista)

        public FormBusca()
        {
            InitializeComponent();

            // Âncora fixa em Top|Left: só o nosso cálculo manda na posição
            foreach (Control c in Controls)
                c.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            FormBorderStyle = FormBorderStyle.None;    // sem bordas
            WindowState = FormWindowState.Maximized;   // tela cheia

            // Esc fecha
            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape) Close();
            };

            // A tela inicial está só escondida (Hide), então ao fechar esta
            // o programa precisa ser encerrado por completo
            FormClosed += (s, e) => Application.Exit();

            Resize += (s, e) => Centralizar();
        }

        // Roda depois do reescalonamento automático: aqui as posições são as reais
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // dispara o seu FormBusca_Load normalmente

            posOriginal.Clear();
            foreach (Control c in Controls)
                posOriginal[c] = c.Location;

            // Retângulo da busca + botão + lista
            areaBusca = Rectangle.Union(txtBusca.Bounds, btnBusca.Bounds);
            areaBusca = Rectangle.Union(areaBusca, lstResultados.Bounds);

            // Altura de todo o conteúdo (título incluído)
            int topo = int.MaxValue, fundo = int.MinValue;
            foreach (Control c in Controls)
            {
                topo = Math.Min(topo, c.Top);
                fundo = Math.Max(fundo, c.Bottom);
            }
            alturaTotal = fundo - topo;

            Centralizar();
        }

        void Centralizar()
        {
            if (posOriginal.Count == 0) return; // ainda não carregou

            // Deslocamento vertical: centraliza o conjunto na altura da tela
            int dy = Math.Max(0, (ClientSize.Height - alturaTotal) / 2);

            // Deslocamento horizontal do grupo busca + botão + lista
            int dxGrupo = (ClientSize.Width - areaBusca.Width) / 2 - areaBusca.X;

            foreach (var par in posOriginal)
            {
                Control c = par.Key;
                Point p = par.Value;

                if (c == lblTitulo || c == lblSubtitulo)
                    c.Location = new Point((ClientSize.Width - c.Width) / 2, p.Y + dy); // centro da tela
                else
                    c.Location = new Point(p.X + dxGrupo, p.Y + dy);
            }
        }

        // ===== Seu código original =====

        private void Botão_teste_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBusca_Load(object sender, EventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            string termo = txtBusca.Text.Trim();

            List<string> pontos = new List<string>
            {
            "Parque Vitória Régia",
            "Jardim Botânico",
            "Horto Florestal",
            "Bosque da Comunidade",
            "Zoológico Municipal",
            "Praça da Paz",
            "Flipper Lanches",
            "Coisa Boa do Chef Moa",
            "Agustina Parrilla e Bar",
            "Terrazzo Cucina",
            "Dona Baunilha",
            "Teatro Municipal de Bauru Celine Lourdes Alves Neves",
            "Catedral do Divino Espírito Santo",
            "SESC Bauru",
            "Ginásio SESI Vôlei Paulo Skaf",
            "Estádio Alfredo de Castilho",
            "Ginásio Panela de Pressão",
            "Calçadão da Batista",
            "Bauru Shopping",
            "Boulevard Shopping",
            "Alameda Rodoserv Center"

            };

            lstResultados.Items.Clear();

            foreach (string ponto in pontos)
            {
                if (ponto.Contains(termo, StringComparison.OrdinalIgnoreCase))
                {
                    lstResultados.Items.Add(ponto);
                }
            }

            lstResultados.Visible = true;
        }


        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}