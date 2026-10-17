namespace Baurus_Thuor.Tela_Busca.Tela_Detalhes
{
    partial class FormDetalhe
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
            picFoto = new PictureBox();
            lblNome = new Label();
            lblEndereco = new Label();
            lblDescricao = new Label();
            btnMapa = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // picFoto
            // 
            picFoto.Location = new Point(30, 30);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(400, 300);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 0;
            picFoto.TabStop = false;
            picFoto.Click += picFoto_Click;
            // 
            // lblNome
            // 
            lblNome.BackColor = Color.Transparent;
            lblNome.Font = new Font("Segoe UI", 24F);
            lblNome.ForeColor = Color.FromArgb(10, 50, 110);
            lblNome.Location = new Point(460, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(500, 80);
            lblNome.TabIndex = 1;
            lblNome.Text = "label1";
            lblNome.Click += label1_Click;
            // 
            // lblEndereco
            // 
            lblEndereco.BackColor = Color.Transparent;
            lblEndereco.Font = new Font("Segoe UI", 12F);
            lblEndereco.ForeColor = Color.FromArgb(90, 100, 115);
            lblEndereco.Location = new Point(460, 120);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(500, 50);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "label1";
            lblEndereco.Click += lblEndereco_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 12F);
            lblDescricao.ForeColor = Color.FromArgb(50, 55, 65);
            lblDescricao.Location = new Point(460, 190);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(500, 200);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "label1";
            lblDescricao.Click += lblDescricao_Click;
            // 
            // btnMapa
            // 
            btnMapa.BackColor = Color.FromArgb(0, 120, 150);
            btnMapa.Cursor = Cursors.Hand;
            btnMapa.FlatAppearance.BorderSize = 0;
            btnMapa.FlatStyle = FlatStyle.Flat;
            btnMapa.Font = new Font("Segoe UI", 12F);
            btnMapa.ForeColor = Color.White;
            btnMapa.Location = new Point(460, 410);
            btnMapa.Name = "btnMapa";
            btnMapa.Size = new Size(240, 50);
            btnMapa.TabIndex = 4;
            btnMapa.Text = "Ver no mapa";
            btnMapa.UseVisualStyleBackColor = false;
            btnMapa.Click += btnMapa_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Cursor = Cursors.Hand;
            btnVoltar.FlatAppearance.BorderColor = Color.FromArgb(0, 120, 150);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Segoe UI", 12F);
            btnVoltar.ForeColor = Color.FromArgb(0, 120, 150);
            btnVoltar.Location = new Point(720, 410);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(240, 50);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // FormDetalhe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 248);
            ClientSize = new Size(984, 561);
            Controls.Add(btnVoltar);
            Controls.Add(btnMapa);
            Controls.Add(lblDescricao);
            Controls.Add(lblEndereco);
            Controls.Add(lblNome);
            Controls.Add(picFoto);
            Name = "FormDetalhe";
            Text = "Bauru's Tour";
            Load += FormDetalhe_Load;
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picFoto;
        private Label lblNome;
        private Label lblEndereco;
        private Label lblDescricao;
        private Button btnMapa;
        private Button btnVoltar;
    }
}