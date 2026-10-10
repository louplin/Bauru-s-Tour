using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BauruTour
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaInicialForm());
        }
    }

    public class TelaInicialForm : Form
    {
        // O desenho foi feito em um espaço de 380 x 290 e é ampliado por S.
        // Com S = 2 a área do formulário fica 760 x 580.
        const float S = 2f;

        static readonly Color Ouro = Color.FromArgb(201, 169, 106);
        static readonly Color Branco = Color.FromArgb(243, 244, 246);

        readonly Button btnComecar;

        public TelaInicialForm()
        {
            Text = "Bauru's Tour";
            ClientSize = new Size((int)(380 * S), (int)(290 * S));
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            DoubleBuffered = true;
            BackColor = Color.FromArgb(4, 7, 13);

            btnComecar = new Button
            {
                Text = "Começar minha jornada  →",
                Location = new Point((int)(100.5f * S), (int)(132.5f * S)),
                Size = new Size((int)(179 * S), (int)(34 * S)),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(10, 18, 34),
                ForeColor = Branco,
                Font = new Font("Segoe UI", 13f * S, FontStyle.Regular, GraphicsUnit.Pixel),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            btnComecar.FlatAppearance.BorderColor = Ouro;
            btnComecar.FlatAppearance.BorderSize = 2;
            btnComecar.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 28, 51);
            btnComecar.FlatAppearance.MouseDownBackColor = Color.FromArgb(24, 36, 64);
            btnComecar.Click += BtnComecar_Click;
            Controls.Add(btnComecar);
        }

        void BtnComecar_Click(object sender, EventArgs e)
        {
            // Aqui você abre a próxima tela, por exemplo:
            // var tela = new PontosTuristicosForm();
            // tela.Show();
            // Hide();
            MessageBox.Show("Aqui vai abrir a tela com os pontos turísticos de Bauru.",
                            "Bauru's Tour");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            g.ScaleTransform(S, S);
            g.TranslateTransform(0, -30);

            DesenharFundo(g);
            DesenharEstrelas(g);
            DesenharTerra(g);
            DesenharTextos(g);
        }

        void DesenharFundo(Graphics g)
        {
            using (var b = new LinearGradientBrush(
                new RectangleF(0, 30, 380, 290),
                Color.FromArgb(4, 7, 13),
                Color.FromArgb(10, 18, 34),
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(b, 0, 30, 380, 290);
            }
        }

        void DesenharEstrelas(Graphics g)
        {
            float[][] estrelas =
            {
                new[] {34f, 58f, 0.8f}, new[] {90f, 98f, 0.7f}, new[] {336f, 66f, 0.9f},
                new[] {312f, 128f, 0.7f}, new[] {58f, 170f, 0.7f}, new[] {352f, 176f, 0.8f},
                new[] {150f, 46f, 0.6f}, new[] {262f, 48f, 0.7f}, new[] {22f, 120f, 0.6f}
            };

            using (var b = new SolidBrush(Color.FromArgb(115, 255, 255, 255)))
            {
                foreach (var s in estrelas)
                    g.FillEllipse(b, s[0] - s[2], s[1] - s[2], s[2] * 2, s[2] * 2);
            }
        }

        void DesenharTerra(Graphics g)
        {
            const float CX = 190f, CY = 520f, R = 300f;

            // Brilho azul da atmosfera
            for (int i = 0; i < 12; i++)
            {
                float rr = R + i * 1.6f;
                int alpha = (int)(80 * (1 - i / 12f));
                using (var pen = new Pen(Color.FromArgb(alpha, 127, 187, 255), 1.8f))
                    g.DrawEllipse(pen, CX - rr, CY - rr, rr * 2, rr * 2);
            }

            // Oceano
            using (var globo = new GraphicsPath())
            {
                globo.AddEllipse(CX - R, CY - R, R * 2, R * 2);

                using (var pgb = new PathGradientBrush(globo))
                {
                    pgb.CenterPoint = new PointF(CX, CY - R * 0.88f);
                    pgb.InterpolationColors = new ColorBlend
                    {
                        Colors = new[]
                        {
                            Color.FromArgb(2, 6, 15),
                            Color.FromArgb(10, 38, 71),
                            Color.FromArgb(20, 70, 122)
                        },
                        Positions = new[] { 0f, 0.55f, 1f }
                    };
                    g.FillPath(pgb, globo);
                }

                // Tudo abaixo fica recortado dentro do planeta
                g.SetClip(globo);

                // Continentes (formas simplificadas)
                using (var terra = new SolidBrush(Color.FromArgb(18, 33, 27)))
                {
                    PointF[] americaSul =
                    {
                        new PointF(148, 236), new PointF(190, 225), new PointF(234, 238),
                        new PointF(246, 270), new PointF(222, 302), new PointF(202, 332),
                        new PointF(150, 332), new PointF(146, 290), new PointF(138, 252)
                    };
                    PointF[] africa =
                    {
                        new PointF(302, 254), new PointF(340, 250), new PointF(376, 280),
                        new PointF(376, 332), new PointF(320, 332), new PointF(300, 290)
                    };
                    PointF[] americaNorte =
                    {
                        new PointF(4, 264), new PointF(60, 248), new PointF(128, 248),
                        new PointF(106, 294), new PointF(30, 332), new PointF(4, 332)
                    };

                    foreach (var pts in new[] { americaSul, africa, americaNorte })
                    {
                        using (var p = new GraphicsPath())
                        {
                            p.AddClosedCurve(pts, 0.5f);
                            g.FillPath(terra, p);
                        }
                    }
                }

                // Brilho das cidades
                Brilho(g, 212, 272, 22, 140);
                Brilho(g, 86, 284, 14, 90);
                Brilho(g, 338, 290, 12, 76);

                float[][] luzes =
                {
                    new[] {208f, 268f, 1.3f}, new[] {212f, 272f, 1.5f}, new[] {216f, 270f, 1.0f},
                    new[] {210f, 277f, 1.2f}, new[] {218f, 276f, 0.9f}, new[] {205f, 274f, 0.8f},
                    new[] {222f, 280f, 1.0f}, new[] {214f, 284f, 0.9f}, new[] {200f, 282f, 0.8f},
                    new[] {226f, 266f, 0.8f}, new[] {196f, 290f, 0.9f}, new[] {206f, 296f, 0.8f},
                    new[] {188f, 262f, 0.7f}, new[] {176f, 254f, 0.7f},
                    new[] {84f, 282f, 1.2f}, new[] {90f, 286f, 1.0f}, new[] {80f, 290f, 0.9f},
                    new[] {96f, 278f, 0.8f}, new[] {72f, 272f, 0.8f}, new[] {104f, 268f, 0.7f},
                    new[] {60f, 290f, 0.7f},
                    new[] {336f, 288f, 1.1f}, new[] {342f, 294f, 0.9f}, new[] {330f, 280f, 0.8f},
                    new[] {348f, 284f, 0.7f}, new[] {322f, 296f, 0.7f}
                };

                using (var luz = new SolidBrush(Color.FromArgb(255, 213, 138)))
                {
                    foreach (var l in luzes)
                        g.FillEllipse(luz, l[0] - l[2], l[1] - l[2], l[2] * 2, l[2] * 2);
                }

                // Sombra do lado direito (noite)
                using (var sombra = new SolidBrush(Color.FromArgb(71, 0, 0, 0)))
                    g.FillEllipse(sombra, 234 - R, CY - R, R * 2, R * 2);

                g.ResetClip();
            }

            // Marcação de Bauru
            using (var pen = new Pen(Ouro, 0.8f))
                g.DrawEllipse(pen, 211 - 6, 269 - 6, 12, 12);
        }

        void Brilho(Graphics g, float cx, float cy, float r, int alpha)
        {
            using (var gp = new GraphicsPath())
            {
                gp.AddEllipse(cx - r, cy - r, r * 2, r * 2);
                using (var b = new PathGradientBrush(gp))
                {
                    b.CenterColor = Color.FromArgb(alpha, 255, 201, 120);
                    b.SurroundColors = new[] { Color.FromArgb(0, 255, 201, 120) };
                    g.FillPath(b, gp);
                }
            }
        }

        void DesenharTextos(Graphics g)
        {
            using (var fLabel = new Font("Segoe UI", 11f, FontStyle.Regular, GraphicsUnit.Pixel))
            using (var fTitulo = new Font("Georgia", 32f, FontStyle.Regular, GraphicsUnit.Pixel))
            using (var fSub = new Font("Segoe UI", 12f, FontStyle.Regular, GraphicsUnit.Pixel))
            using (var bLabel = new SolidBrush(Color.FromArgb(154, 167, 189)))
            using (var bTitulo = new SolidBrush(Branco))
            using (var bSub = new SolidBrush(Color.FromArgb(139, 152, 174)))
            using (var penOuro = new Pen(Ouro, 1f))
            {
                TextoEspacado(g, "BEM VINDO AO", fLabel, bLabel, 190, 72, 5f);
                TextoEspacado(g, "BAURU'S TOUR", fTitulo, bTitulo, 190, 108, 4f);
                g.DrawLine(penOuro, 170, 122, 210, 122);
                TextoEspacado(g, "Descubra os pontos turísticos de Bauru", fSub, bSub, 190, 144, 0f);
            }
        }

        // Escreve texto centralizado com espaço extra entre as letras
        void TextoEspacado(Graphics g, string texto, Font fonte, Brush pincel,
                           float centroX, float baseY, float espaco)
        {
            using (var sf = new StringFormat(StringFormat.GenericTypographic))
            {
                sf.FormatFlags |= StringFormatFlags.MeasureTrailingSpaces;

                var larguras = new float[texto.Length];
                float total = 0;
                for (int i = 0; i < texto.Length; i++)
                {
                    larguras[i] = g.MeasureString(texto[i].ToString(), fonte, PointF.Empty, sf).Width;
                    total += larguras[i];
                }
                total += espaco * (texto.Length - 1);

                float x = centroX - total / 2f;
                float y = baseY - fonte.Size * 0.92f;

                for (int i = 0; i < texto.Length; i++)
                {
                    g.DrawString(texto[i].ToString(), fonte, pincel, x, y, sf);
                    x += larguras[i] + espaco;
                }
            }
        }
    }
}
