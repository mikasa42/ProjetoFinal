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
            this.BtnCadastroTurma = new System.Windows.Forms.Button();
            this.BtnCadastroDocente = new System.Windows.Forms.Button();
            this.BtnCadastroAdm = new System.Windows.Forms.Button();
            this.LabSelecao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCadastroTurma
            // 
            this.BtnCadastroTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.BtnCadastroTurma.Location = new System.Drawing.Point(344, 87);
            this.BtnCadastroTurma.Name = "BtnCadastroTurma";
            this.BtnCadastroTurma.Size = new System.Drawing.Size(120, 47);
            this.BtnCadastroTurma.TabIndex = 13;
            this.BtnCadastroTurma.Text = "Turma";
            this.BtnCadastroTurma.UseVisualStyleBackColor = true;
            // 
            // BtnCadastroDocente
            // 
            this.BtnCadastroDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.BtnCadastroDocente.Location = new System.Drawing.Point(192, 87);
            this.BtnCadastroDocente.Name = "BtnCadastroDocente";
            this.BtnCadastroDocente.Size = new System.Drawing.Size(120, 47);
            this.BtnCadastroDocente.TabIndex = 12;
            this.BtnCadastroDocente.Text = "Docente";
            this.BtnCadastroDocente.UseVisualStyleBackColor = true;
            // 
            // BtnCadastroAdm
            // 
            this.BtnCadastroAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.BtnCadastroAdm.Location = new System.Drawing.Point(43, 87);
            this.BtnCadastroAdm.Name = "BtnCadastroAdm";
            this.BtnCadastroAdm.Size = new System.Drawing.Size(120, 47);
            this.BtnCadastroAdm.TabIndex = 11;
            this.BtnCadastroAdm.Text = "Administrador";
            this.BtnCadastroAdm.UseVisualStyleBackColor = true;
            // 
            // LabSelecao
            // 
            this.LabSelecao.AutoSize = true;
            this.LabSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabSelecao.Location = new System.Drawing.Point(133, 35);
            this.LabSelecao.Name = "LabSelecao";
            this.LabSelecao.Size = new System.Drawing.Size(238, 29);
            this.LabSelecao.TabIndex = 14;
            this.LabSelecao.Text = "SELECIONE O TIPO";
            this.LabSelecao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PreCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(507, 169);
            this.Controls.Add(this.LabSelecao);
            this.Controls.Add(this.BtnCadastroTurma);
            this.Controls.Add(this.BtnCadastroDocente);
            this.Controls.Add(this.BtnCadastroAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PreCadastro";
            this.Text = "Selecionar tipo de cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastroTurma;
        private System.Windows.Forms.Button BtnCadastroDocente;
        private System.Windows.Forms.Button BtnCadastroAdm;
        private System.Windows.Forms.Label LabSelecao;
    }
}