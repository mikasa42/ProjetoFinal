namespace Projeto_EstagioIN307
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LabTitulo = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.LabMatricula = new System.Windows.Forms.Label();
            this.LabSenha = new System.Windows.Forms.Label();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LabErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(203)))), ((int)(((byte)(229)))));
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(266, 273);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 41);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LabTitulo
            // 
            this.LabTitulo.AutoSize = true;
            this.LabTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.LabTitulo.Location = new System.Drawing.Point(22, 24);
            this.LabTitulo.Name = "LabTitulo";
            this.LabTitulo.Size = new System.Drawing.Size(608, 92);
            this.LabTitulo.TabIndex = 3;
            this.LabTitulo.Text = "SISTEMA DE GRADE \r\nHORÁRIA DE PROFESSORES\r\n";
            this.LabTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(271, 343);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 4;
            // 
            // LabMatricula
            // 
            this.LabMatricula.AutoSize = true;
            this.LabMatricula.Location = new System.Drawing.Point(211, 169);
            this.LabMatricula.Name = "LabMatricula";
            this.LabMatricula.Size = new System.Drawing.Size(52, 13);
            this.LabMatricula.TabIndex = 5;
            this.LabMatricula.Text = "Matrícula";
            // 
            // LabSenha
            // 
            this.LabSenha.AutoSize = true;
            this.LabSenha.Location = new System.Drawing.Point(211, 215);
            this.LabSenha.Name = "LabSenha";
            this.LabSenha.Size = new System.Drawing.Size(38, 13);
            this.LabSenha.TabIndex = 6;
            this.LabSenha.Text = "Senha";
            // 
            // TxtMatricula
            // 
            this.TxtMatricula.Location = new System.Drawing.Point(214, 185);
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.Size = new System.Drawing.Size(200, 20);
            this.TxtMatricula.TabIndex = 7;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(214, 231);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(200, 20);
            this.TxtSenha.TabIndex = 8;
            // 
            // LabErro
            // 
            this.LabErro.AutoSize = true;
            this.LabErro.ForeColor = System.Drawing.Color.Red;
            this.LabErro.Location = new System.Drawing.Point(263, 323);
            this.LabErro.Name = "LabErro";
            this.LabErro.Size = new System.Drawing.Size(110, 13);
            this.LabErro.TabIndex = 9;
            this.LabErro.Text = "Informações Inválidas";
            this.LabErro.Visible = false;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(642, 345);
            this.Controls.Add(this.LabErro);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.LabSenha);
            this.Controls.Add(this.LabMatricula);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LabTitulo);
            this.Controls.Add(this.BtnLogin);
            this.Name = "TelaLogin";
            this.Text = "Início";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LabTitulo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label LabMatricula;
        private System.Windows.Forms.Label LabSenha;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LabErro;
    }
}

