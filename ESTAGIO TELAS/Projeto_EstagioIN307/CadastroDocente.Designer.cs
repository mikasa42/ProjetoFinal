namespace Projeto_EstagioIN307
{
    partial class CadastroDocente
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
            this.LabNomeDoc = new System.Windows.Forms.Label();
            this.TxtNomeDoc = new System.Windows.Forms.TextBox();
            this.LabDisciplina = new System.Windows.Forms.Label();
            this.LabTempoDoc = new System.Windows.Forms.Label();
            this.LabTelDoc = new System.Windows.Forms.Label();
            this.TxtTelDoc = new System.Windows.Forms.TextBox();
            this.LabCpfDoc = new System.Windows.Forms.Label();
            this.TxtCPFDoc = new System.Windows.Forms.TextBox();
            this.BtnCadastroDocenteOK = new System.Windows.Forms.Button();
            this.ComboDisciplina = new System.Windows.Forms.ComboBox();
            this.TxtMatDoc = new System.Windows.Forms.TextBox();
            this.LabMatriculaDoc = new System.Windows.Forms.Label();
            this.BtnCancelaDocente = new System.Windows.Forms.Button();
            this.LabDeuCerto = new System.Windows.Forms.Label();
            this.NumTempoCampus = new System.Windows.Forms.NumericUpDown();
            this.TxtEmailDoc = new System.Windows.Forms.TextBox();
            this.LabEmailDoc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumTempoCampus)).BeginInit();
            this.SuspendLayout();
            // 
            // LabNomeDoc
            // 
            this.LabNomeDoc.AutoSize = true;
            this.LabNomeDoc.Location = new System.Drawing.Point(21, 73);
            this.LabNomeDoc.Name = "LabNomeDoc";
            this.LabNomeDoc.Size = new System.Drawing.Size(35, 13);
            this.LabNomeDoc.TabIndex = 0;
            this.LabNomeDoc.Text = "Nome";
            // 
            // TxtNomeDoc
            // 
            this.TxtNomeDoc.Location = new System.Drawing.Point(25, 89);
            this.TxtNomeDoc.Name = "TxtNomeDoc";
            this.TxtNomeDoc.Size = new System.Drawing.Size(201, 20);
            this.TxtNomeDoc.TabIndex = 2;
            this.TxtNomeDoc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabDisciplina
            // 
            this.LabDisciplina.AutoSize = true;
            this.LabDisciplina.Location = new System.Drawing.Point(124, 19);
            this.LabDisciplina.Name = "LabDisciplina";
            this.LabDisciplina.Size = new System.Drawing.Size(52, 13);
            this.LabDisciplina.TabIndex = 8;
            this.LabDisciplina.Text = "Disciplina";
            // 
            // LabTempoDoc
            // 
            this.LabTempoDoc.AutoSize = true;
            this.LabTempoDoc.Location = new System.Drawing.Point(237, 119);
            this.LabTempoDoc.Name = "LabTempoDoc";
            this.LabTempoDoc.Size = new System.Drawing.Size(128, 13);
            this.LabTempoDoc.TabIndex = 10;
            this.LabTempoDoc.Text = "Tempo no Campus (anos)";
            // 
            // LabTelDoc
            // 
            this.LabTelDoc.AutoSize = true;
            this.LabTelDoc.Location = new System.Drawing.Point(23, 119);
            this.LabTelDoc.Name = "LabTelDoc";
            this.LabTelDoc.Size = new System.Drawing.Size(49, 13);
            this.LabTelDoc.TabIndex = 11;
            this.LabTelDoc.Text = "Telefone";
            // 
            // TxtTelDoc
            // 
            this.TxtTelDoc.Location = new System.Drawing.Point(26, 135);
            this.TxtTelDoc.Name = "TxtTelDoc";
            this.TxtTelDoc.Size = new System.Drawing.Size(200, 20);
            this.TxtTelDoc.TabIndex = 12;
            this.TxtTelDoc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // LabCpfDoc
            // 
            this.LabCpfDoc.AutoSize = true;
            this.LabCpfDoc.Location = new System.Drawing.Point(237, 73);
            this.LabCpfDoc.Name = "LabCpfDoc";
            this.LabCpfDoc.Size = new System.Drawing.Size(27, 13);
            this.LabCpfDoc.TabIndex = 17;
            this.LabCpfDoc.Text = "CPF";
            this.LabCpfDoc.Click += new System.EventHandler(this.label9_Click);
            // 
            // TxtCPFDoc
            // 
            this.TxtCPFDoc.Location = new System.Drawing.Point(240, 89);
            this.TxtCPFDoc.Name = "TxtCPFDoc";
            this.TxtCPFDoc.Size = new System.Drawing.Size(200, 20);
            this.TxtCPFDoc.TabIndex = 18;
            this.TxtCPFDoc.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // BtnCadastroDocenteOK
            // 
            this.BtnCadastroDocenteOK.Location = new System.Drawing.Point(24, 332);
            this.BtnCadastroDocenteOK.Name = "BtnCadastroDocenteOK";
            this.BtnCadastroDocenteOK.Size = new System.Drawing.Size(86, 32);
            this.BtnCadastroDocenteOK.TabIndex = 27;
            this.BtnCadastroDocenteOK.Text = "Cadastrar";
            this.BtnCadastroDocenteOK.UseVisualStyleBackColor = true;
            // 
            // ComboDisciplina
            // 
            this.ComboDisciplina.FormattingEnabled = true;
            this.ComboDisciplina.Location = new System.Drawing.Point(127, 36);
            this.ComboDisciplina.Name = "ComboDisciplina";
            this.ComboDisciplina.Size = new System.Drawing.Size(98, 21);
            this.ComboDisciplina.TabIndex = 28;
            // 
            // TxtMatDoc
            // 
            this.TxtMatDoc.Enabled = false;
            this.TxtMatDoc.Location = new System.Drawing.Point(27, 37);
            this.TxtMatDoc.Name = "TxtMatDoc";
            this.TxtMatDoc.Size = new System.Drawing.Size(93, 20);
            this.TxtMatDoc.TabIndex = 30;
            // 
            // LabMatriculaDoc
            // 
            this.LabMatriculaDoc.AutoSize = true;
            this.LabMatriculaDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabMatriculaDoc.Location = new System.Drawing.Point(24, 19);
            this.LabMatriculaDoc.Name = "LabMatriculaDoc";
            this.LabMatriculaDoc.Size = new System.Drawing.Size(61, 13);
            this.LabMatriculaDoc.TabIndex = 29;
            this.LabMatriculaDoc.Text = "Matrícula";
            // 
            // BtnCancelaDocente
            // 
            this.BtnCancelaDocente.Location = new System.Drawing.Point(362, 332);
            this.BtnCancelaDocente.Name = "BtnCancelaDocente";
            this.BtnCancelaDocente.Size = new System.Drawing.Size(86, 32);
            this.BtnCancelaDocente.TabIndex = 31;
            this.BtnCancelaDocente.Text = "Cancelar";
            this.BtnCancelaDocente.UseVisualStyleBackColor = true;
            // 
            // LabDeuCerto
            // 
            this.LabDeuCerto.AutoSize = true;
            this.LabDeuCerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDeuCerto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabDeuCerto.Location = new System.Drawing.Point(53, 290);
            this.LabDeuCerto.Name = "LabDeuCerto";
            this.LabDeuCerto.Size = new System.Drawing.Size(336, 25);
            this.LabDeuCerto.TabIndex = 33;
            this.LabDeuCerto.Text = "Dados cadastrados com sucesso!";
            // 
            // NumTempoCampus
            // 
            this.NumTempoCampus.Location = new System.Drawing.Point(241, 135);
            this.NumTempoCampus.Name = "NumTempoCampus";
            this.NumTempoCampus.Size = new System.Drawing.Size(120, 20);
            this.NumTempoCampus.TabIndex = 34;
            // 
            // TxtEmailDoc
            // 
            this.TxtEmailDoc.Location = new System.Drawing.Point(26, 186);
            this.TxtEmailDoc.Name = "TxtEmailDoc";
            this.TxtEmailDoc.Size = new System.Drawing.Size(414, 20);
            this.TxtEmailDoc.TabIndex = 36;
            // 
            // LabEmailDoc
            // 
            this.LabEmailDoc.AutoSize = true;
            this.LabEmailDoc.Location = new System.Drawing.Point(24, 170);
            this.LabEmailDoc.Name = "LabEmailDoc";
            this.LabEmailDoc.Size = new System.Drawing.Size(35, 13);
            this.LabEmailDoc.TabIndex = 35;
            this.LabEmailDoc.Text = "E-mail";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 37;
            this.button1.Text = "Disponibilidade";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CadastroDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(460, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtEmailDoc);
            this.Controls.Add(this.LabEmailDoc);
            this.Controls.Add(this.NumTempoCampus);
            this.Controls.Add(this.LabDeuCerto);
            this.Controls.Add(this.BtnCancelaDocente);
            this.Controls.Add(this.TxtMatDoc);
            this.Controls.Add(this.LabMatriculaDoc);
            this.Controls.Add(this.ComboDisciplina);
            this.Controls.Add(this.BtnCadastroDocenteOK);
            this.Controls.Add(this.TxtCPFDoc);
            this.Controls.Add(this.LabCpfDoc);
            this.Controls.Add(this.TxtTelDoc);
            this.Controls.Add(this.LabTelDoc);
            this.Controls.Add(this.LabTempoDoc);
            this.Controls.Add(this.LabDisciplina);
            this.Controls.Add(this.TxtNomeDoc);
            this.Controls.Add(this.LabNomeDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroDocente";
            this.Text = "Cadastrar Docente";
            ((System.ComponentModel.ISupportInitialize)(this.NumTempoCampus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabNomeDoc;
        private System.Windows.Forms.TextBox TxtNomeDoc;
        private System.Windows.Forms.Label LabDisciplina;
        private System.Windows.Forms.Label LabTempoDoc;
        private System.Windows.Forms.Label LabTelDoc;
        private System.Windows.Forms.TextBox TxtTelDoc;
        private System.Windows.Forms.Label LabCpfDoc;
        private System.Windows.Forms.TextBox TxtCPFDoc;
        private System.Windows.Forms.Button BtnCadastroDocenteOK;
        private System.Windows.Forms.ComboBox ComboDisciplina;
        private System.Windows.Forms.TextBox TxtMatDoc;
        private System.Windows.Forms.Label LabMatriculaDoc;
        private System.Windows.Forms.Button BtnCancelaDocente;
        private System.Windows.Forms.Label LabDeuCerto;
        private System.Windows.Forms.NumericUpDown NumTempoCampus;
        private System.Windows.Forms.TextBox TxtEmailDoc;
        private System.Windows.Forms.Label LabEmailDoc;
        private System.Windows.Forms.Button button1;
    }
}