namespace Projeto_Livraria
{
    partial class Menu4
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
            btnSair = new Button();
            btnCadastroLivro = new Button();
            btnConsultarLivro = new Button();
            SuspendLayout();
            // 
            // btnSair
            // 
            btnSair.Location = new Point(28, 40);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 0;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnCadastroLivro
            // 
            btnCadastroLivro.Location = new Point(265, 52);
            btnCadastroLivro.Name = "btnCadastroLivro";
            btnCadastroLivro.Size = new Size(184, 23);
            btnCadastroLivro.TabIndex = 1;
            btnCadastroLivro.Text = "Cadastro Livro";
            btnCadastroLivro.UseVisualStyleBackColor = true;
            btnCadastroLivro.Click += btnCadastroLivro_Click;
            // 
            // btnConsultarLivro
            // 
            btnConsultarLivro.Location = new Point(265, 94);
            btnConsultarLivro.Name = "btnConsultarLivro";
            btnConsultarLivro.Size = new Size(184, 23);
            btnConsultarLivro.TabIndex = 2;
            btnConsultarLivro.Text = "Consultar Livro";
            btnConsultarLivro.UseVisualStyleBackColor = true;
            btnConsultarLivro.Click += btnConsultarLivro_Click;
            // 
            // Menu4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultarLivro);
            Controls.Add(btnCadastroLivro);
            Controls.Add(btnSair);
            Name = "Menu4";
            Text = "Menu4";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSair;
        private Button btnCadastroLivro;
        private Button btnConsultarLivro;
    }
}