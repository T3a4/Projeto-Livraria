namespace Projeto_Livraria
{
    partial class frmCadastrodeFuncionário
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
            btnVoltar = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCargo = new Label();
            comboBox1 = new ComboBox();
            lblSalário = new Label();
            txtSalário = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 36);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(310, 75);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(45, 17);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(271, 108);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Inserir o Nome";
            txtNome.Size = new Size(226, 23);
            txtNome.TabIndex = 2;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCargo.Location = new Point(310, 152);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(44, 17);
            lblCargo.TabIndex = 3;
            lblCargo.Text = "Cargo";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = SystemColors.WindowFrame;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(271, 188);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Inserir o Cargo";
            // 
            // lblSalário
            // 
            lblSalário.AutoSize = true;
            lblSalário.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalário.Location = new Point(310, 225);
            lblSalário.Name = "lblSalário";
            lblSalário.Size = new Size(50, 17);
            lblSalário.TabIndex = 5;
            lblSalário.Text = "Salário";
            // 
            // txtSalário
            // 
            txtSalário.Location = new Point(271, 257);
            txtSalário.Name = "txtSalário";
            txtSalário.PlaceholderText = "Inserir o Salário";
            txtSalário.Size = new Size(226, 23);
            txtSalário.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(310, 354);
            button1.Name = "button1";
            button1.Size = new Size(166, 37);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar Funcionário";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmCadastrodeFuncionário
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtSalário);
            Controls.Add(lblSalário);
            Controls.Add(comboBox1);
            Controls.Add(lblCargo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(btnVoltar);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmCadastrodeFuncionário";
            Text = "Cadastro de Funcionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCargo;
        private ComboBox comboBox1;
        private Label lblSalário;
        private TextBox txtSalário;
        private Button button1;
    }
}