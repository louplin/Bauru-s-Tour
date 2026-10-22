namespace BauruTour
{
    partial class FormBusca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            txtBusca = new TextBox();
            btnBusca = new Button();
            lstResultados = new ListBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(345, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(294, 65);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Bauru's Tour";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.LightYellow;
            lblSubtitulo.Location = new Point(340, 56);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(305, 30);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Qual área vamos explorar hoje?";
            // 
            // txtBusca
            // 
            txtBusca.Anchor = AnchorStyles.Top;
            txtBusca.BackColor = Color.FromArgb(26, 16, 51);
            txtBusca.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusca.ForeColor = SystemColors.Window;
            txtBusca.Location = new Point(232, 89);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Buscar Pontos Turisticos...";
            txtBusca.Size = new Size(520, 33);
            txtBusca.TabIndex = 3;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // btnBusca
            // 
            btnBusca.BackColor = Color.FromArgb(184, 79, 232);
            btnBusca.FlatAppearance.BorderColor = Color.DarkViolet;
            btnBusca.FlatAppearance.BorderSize = 0;
            btnBusca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBusca.ForeColor = SystemColors.ButtonHighlight;
            btnBusca.Location = new Point(758, 87);
            btnBusca.Name = "btnBusca";
            btnBusca.Size = new Size(120, 36);
            btnBusca.TabIndex = 4;
            btnBusca.Text = "Buscar";
            btnBusca.UseVisualStyleBackColor = false;
            btnBusca.Click += btnBusca_Click;
            // 
            // lstResultados
            // 
            lstResultados.BackColor = Color.FromArgb(26, 16, 51);
            lstResultados.BorderStyle = BorderStyle.None;
            lstResultados.Font = new Font("Segoe UI", 12F);
            lstResultados.ForeColor = SystemColors.Window;
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(232, 121);
            lstResultados.Margin = new Padding(2, 2, 2, 2);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(452, 168);
            lstResultados.TabIndex = 5;
            lstResultados.Visible = false;
            lstResultados.SelectedIndexChanged += lstResultados_SelectedIndexChanged;
            // 
            // FormBusca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            BackgroundImage = Baurus_Thuor.Properties.Resources.ceu_estrelado_v2;
            ClientSize = new Size(984, 611);
            Controls.Add(lstResultados);
            Controls.Add(btnBusca);
            Controls.Add(txtBusca);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Name = "FormBusca";
            Text = "Bauru's Tour ";
            Load += FormBusca_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblSubtitulo;
        private TextBox txtBusca;
        private Button btnBusca;
        private ListBox lstResultados;
    }
}
