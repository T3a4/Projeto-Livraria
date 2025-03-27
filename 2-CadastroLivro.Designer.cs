namespace Projeto_Livraria
{
    partial class frmCadastrodeLivro
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
            lblTítulo = new Label();
            txtTítulo = new TextBox();
            lblPreço = new Label();
            txtPreço = new TextBox();
            lblQuantidade_estoque = new Label();
            cmoQuantidade_estoque = new ComboBox();
            btnVoltar = new Button();
            btnCadastrarLivro = new Button();
            SuspendLayout();
            // 
            // lblTítulo
            // 
            lblTítulo.AutoSize = true;
            lblTítulo.BackColor = Color.FromArgb(255, 128, 255);
            lblTítulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTítulo.Location = new Point(259, 102);
            lblTítulo.Name = "lblTítulo";
            lblTítulo.Size = new Size(45, 17);
            lblTítulo.TabIndex = 0;
            lblTítulo.Text = "Título";
            // 
            // txtTítulo
            // 
            txtTítulo.Location = new Point(227, 135);
            txtTítulo.Name = "txtTítulo";
            txtTítulo.PlaceholderText = "Insira o Título";
            txtTítulo.Size = new Size(331, 23);
            txtTítulo.TabIndex = 1;
            // 
            // lblPreço
            // 
            lblPreço.AutoSize = true;
            lblPreço.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPreço.Location = new Point(259, 161);
            lblPreço.Name = "lblPreço";
            lblPreço.Size = new Size(42, 17);
            lblPreço.TabIndex = 2;
            lblPreço.Text = "Preço";
            // 
            // txtPreço
            // 
            txtPreço.Location = new Point(227, 194);
            txtPreço.Name = "txtPreço";
            txtPreço.PlaceholderText = "Insira o Preço";
            txtPreço.Size = new Size(168, 23);
            txtPreço.TabIndex = 3;
            // 
            // lblQuantidade_estoque
            // 
            lblQuantidade_estoque.AutoSize = true;
            lblQuantidade_estoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade_estoque.Location = new Point(259, 231);
            lblQuantidade_estoque.Name = "lblQuantidade_estoque";
            lblQuantidade_estoque.Size = new Size(134, 17);
            lblQuantidade_estoque.TabIndex = 4;
            lblQuantidade_estoque.Text = "Quantidade_estoque";
            // 
            // cmoQuantidade_estoque
            // 
            cmoQuantidade_estoque.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmoQuantidade_estoque.ForeColor = SystemColors.WindowFrame;
            cmoQuantidade_estoque.FormattingEnabled = true;
            cmoQuantidade_estoque.Location = new Point(227, 265);
            cmoQuantidade_estoque.Name = "cmoQuantidade_estoque";
            cmoQuantidade_estoque.Size = new Size(251, 23);
            cmoQuantidade_estoque.TabIndex = 5;
            cmoQuantidade_estoque.Text = "Insira a Quantidade_estoque";
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(71, 32);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarLivro
            // 
            btnCadastrarLivro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarLivro.Location = new Point(259, 344);
            btnCadastrarLivro.Name = "btnCadastrarLivro";
            btnCadastrarLivro.Size = new Size(130, 32);
            btnCadastrarLivro.TabIndex = 7;
            btnCadastrarLivro.Text = "Cadastrar Livro";
            btnCadastrarLivro.UseVisualStyleBackColor = true;
            // 
            // frmCadastrodeLivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrarLivro);
            Controls.Add(btnVoltar);
            Controls.Add(cmoQuantidade_estoque);
            Controls.Add(lblQuantidade_estoque);
            Controls.Add(txtPreço);
            Controls.Add(lblPreço);
            Controls.Add(txtTítulo);
            Controls.Add(lblTítulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.WindowText;
            Name = "frmCadastrodeLivro";
            Text = "Cadastro de Livro";
            Load += this.frmCadastrodeLivro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTítulo;
        private TextBox txtTítulo;
        private Label lblPreço;
        private TextBox txtPreço;
        private Label lblQuantidade_estoque;
        private ComboBox cmoQuantidade_estoque;
        private Button btnVoltar;
        private Button btnCadastrarLivro;
    }
}