namespace Bauru_s_Tour
{
    partial class Form1
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
            Botão_teste = new Button();
            SuspendLayout();
            // 
            // Botão_teste
            // 
            Botão_teste.Cursor = Cursors.Hand;
            Botão_teste.Location = new Point(363, 141);
            Botão_teste.Name = "Botão_teste";
            Botão_teste.Size = new Size(139, 23);
            Botão_teste.TabIndex = 0;
            Botão_teste.Text = "Aperte aqui";
            Botão_teste.UseVisualStyleBackColor = true;
            Botão_teste.Click += Botão_teste_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Botão_teste);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Botão_teste;
    }
}
