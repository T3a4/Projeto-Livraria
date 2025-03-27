namespace Projeto_Livraria
{
    partial class frmConsultadeFuncionários
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
            dgvConsultadeFuncionários = new DataGridView();
            btnConsultarFuncionários = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsultadeFuncionários).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(75, 30);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dgvConsultadeFuncionários
            // 
            dgvConsultadeFuncionários.BackgroundColor = Color.White;
            dgvConsultadeFuncionários.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultadeFuncionários.Location = new Point(170, 25);
            dgvConsultadeFuncionários.Name = "dgvConsultadeFuncionários";
            dgvConsultadeFuncionários.Size = new Size(473, 321);
            dgvConsultadeFuncionários.TabIndex = 1;
            // 
            // btnConsultarFuncionários
            // 
            btnConsultarFuncionários.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultarFuncionários.Location = new Point(326, 381);
            btnConsultarFuncionários.Name = "btnConsultarFuncionários";
            btnConsultarFuncionários.Size = new Size(173, 33);
            btnConsultarFuncionários.TabIndex = 2;
            btnConsultarFuncionários.Text = "Consultar Funcionários";
            btnConsultarFuncionários.UseVisualStyleBackColor = true;
            // 
            // frmConsultadeFuncionários
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultarFuncionários);
            Controls.Add(dgvConsultadeFuncionários);
            Controls.Add(btnVoltar);
            Name = "frmConsultadeFuncionários";
            Text = "Consulta de Funcionários";
            ((System.ComponentModel.ISupportInitialize)dgvConsultadeFuncionários).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private DataGridView dgvConsultadeFuncionários;
        private Button btnConsultarFuncionários;
    }
}