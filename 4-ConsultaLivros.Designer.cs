namespace Projeto_Livraria
{
    partial class frmConsultadeLivros
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
            dgvConsultadeLivros = new DataGridView();
            btnConsultarLivros = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsultadeLivros).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(70, 33);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // dgvConsultadeLivros
            // 
            dgvConsultadeLivros.BackgroundColor = Color.White;
            dgvConsultadeLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultadeLivros.Location = new Point(220, 25);
            dgvConsultadeLivros.Name = "dgvConsultadeLivros";
            dgvConsultadeLivros.Size = new Size(424, 330);
            dgvConsultadeLivros.TabIndex = 1;
            // 
            // btnConsultarLivros
            // 
            btnConsultarLivros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultarLivros.Location = new Point(363, 392);
            btnConsultarLivros.Name = "btnConsultarLivros";
            btnConsultarLivros.Size = new Size(148, 29);
            btnConsultarLivros.TabIndex = 2;
            btnConsultarLivros.Text = "Consultar Livros";
            btnConsultarLivros.UseVisualStyleBackColor = true;
            // 
            // frmConsultadeLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(btnConsultarLivros);
            Controls.Add(dgvConsultadeLivros);
            Controls.Add(btnVoltar);
            Name = "frmConsultadeLivros";
            Text = "Consulta de Livros";
            ((System.ComponentModel.ISupportInitialize)dgvConsultadeLivros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private DataGridView dgvConsultadeLivros;
        private Button btnConsultarLivros;
    }
}