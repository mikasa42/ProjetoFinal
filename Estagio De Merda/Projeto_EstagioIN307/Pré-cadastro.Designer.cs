namespace Projeto_EstagioIN307
{
    partial class PreCadastro
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
            this.btnCadastroTurma = new System.Windows.Forms.Button();
            this.btnCadastroDocente = new System.Windows.Forms.Button();
            this.btnCadastroAdm = new System.Windows.Forms.Button();
            this.LabTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastroTurma
            // 
            this.btnCadastroTurma.Location = new System.Drawing.Point(344, 87);
            this.btnCadastroTurma.Name = "btnCadastroTurma";
            this.btnCadastroTurma.Size = new System.Drawing.Size(120, 47);
            this.btnCadastroTurma.TabIndex = 13;
            this.btnCadastroTurma.Text = "Turma";
            this.btnCadastroTurma.UseVisualStyleBackColor = true;
            // 
            // btnCadastroDocente
            // 
            this.btnCadastroDocente.Location = new System.Drawing.Point(192, 87);
            this.btnCadastroDocente.Name = "btnCadastroDocente";
            this.btnCadastroDocente.Size = new System.Drawing.Size(120, 47);
            this.btnCadastroDocente.TabIndex = 12;
            this.btnCadastroDocente.Text = "Docente";
            this.btnCadastroDocente.UseVisualStyleBackColor = true;
            // 
            // btnCadastroAdm
            // 
            this.btnCadastroAdm.Location = new System.Drawing.Point(43, 87);
            this.btnCadastroAdm.Name = "btnCadastroAdm";
            this.btnCadastroAdm.Size = new System.Drawing.Size(120, 47);
            this.btnCadastroAdm.TabIndex = 11;
            this.btnCadastroAdm.Text = "Administrador";
            this.btnCadastroAdm.UseVisualStyleBackColor = true;
            // 
            // LabTitulo
            // 
            this.LabTitulo.AutoSize = true;
            this.LabTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTitulo.Location = new System.Drawing.Point(133, 35);
            this.LabTitulo.Name = "LabTitulo";
            this.LabTitulo.Size = new System.Drawing.Size(238, 29);
            this.LabTitulo.TabIndex = 14;
            this.LabTitulo.Text = "SELECIONE O TIPO";
            this.LabTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PreCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(507, 169);
            this.Controls.Add(this.LabTitulo);
            this.Controls.Add(this.btnCadastroTurma);
            this.Controls.Add(this.btnCadastroDocente);
            this.Controls.Add(this.btnCadastroAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PreCadastro";
            this.Text = "Selecionar tipo de cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroTurma;
        private System.Windows.Forms.Button btnCadastroDocente;
        private System.Windows.Forms.Button btnCadastroAdm;
        private System.Windows.Forms.Label LabTitulo;
    }
}