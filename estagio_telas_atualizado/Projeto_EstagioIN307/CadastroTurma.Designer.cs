namespace Projeto_EstagioIN307
{
    partial class CadastroTurma
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
            this.LabTurma = new System.Windows.Forms.Label();
            this.TxtCdstTurma = new System.Windows.Forms.TextBox();
            this.LabTurno = new System.Windows.Forms.Label();
            this.ComboTurno = new System.Windows.Forms.ComboBox();
            this.BtnCadastroTurmaOK = new System.Windows.Forms.Button();
            this.BtnCancelaTurma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabTurma
            // 
            this.LabTurma.AutoSize = true;
            this.LabTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.LabTurma.Location = new System.Drawing.Point(15, 24);
            this.LabTurma.Name = "LabTurma";
            this.LabTurma.Size = new System.Drawing.Size(46, 15);
            this.LabTurma.TabIndex = 0;
            this.LabTurma.Text = "Turma:";
            // 
            // TxtCdstTurma
            // 
            this.TxtCdstTurma.Location = new System.Drawing.Point(18, 40);
            this.TxtCdstTurma.Name = "TxtCdstTurma";
            this.TxtCdstTurma.Size = new System.Drawing.Size(134, 20);
            this.TxtCdstTurma.TabIndex = 1;
            // 
            // LabTurno
            // 
            this.LabTurno.AutoSize = true;
            this.LabTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.LabTurno.Location = new System.Drawing.Point(169, 24);
            this.LabTurno.Name = "LabTurno";
            this.LabTurno.Size = new System.Drawing.Size(42, 15);
            this.LabTurno.TabIndex = 2;
            this.LabTurno.Text = "Turno:";
            // 
            // ComboTurno
            // 
            this.ComboTurno.FormattingEnabled = true;
            this.ComboTurno.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Integral"});
            this.ComboTurno.Location = new System.Drawing.Point(172, 40);
            this.ComboTurno.Name = "ComboTurno";
            this.ComboTurno.Size = new System.Drawing.Size(134, 21);
            this.ComboTurno.TabIndex = 3;
            // 
            // BtnCadastroTurmaOK
            // 
            this.BtnCadastroTurmaOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.BtnCadastroTurmaOK.Location = new System.Drawing.Point(18, 96);
            this.BtnCadastroTurmaOK.Name = "BtnCadastroTurmaOK";
            this.BtnCadastroTurmaOK.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastroTurmaOK.TabIndex = 4;
            this.BtnCadastroTurmaOK.Text = "Cadastrar";
            this.BtnCadastroTurmaOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancelaTurma
            // 
            this.BtnCancelaTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.BtnCancelaTurma.Location = new System.Drawing.Point(231, 96);
            this.BtnCancelaTurma.Name = "BtnCancelaTurma";
            this.BtnCancelaTurma.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelaTurma.TabIndex = 5;
            this.BtnCancelaTurma.Text = "Cancelar";
            this.BtnCancelaTurma.UseVisualStyleBackColor = true;
            // 
            // CadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(321, 149);
            this.Controls.Add(this.BtnCancelaTurma);
            this.Controls.Add(this.BtnCadastroTurmaOK);
            this.Controls.Add(this.ComboTurno);
            this.Controls.Add(this.LabTurno);
            this.Controls.Add(this.TxtCdstTurma);
            this.Controls.Add(this.LabTurma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroTurma";
            this.Text = "Cadastrar Turma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabTurma;
        private System.Windows.Forms.TextBox TxtCdstTurma;
        private System.Windows.Forms.Label LabTurno;
        private System.Windows.Forms.ComboBox ComboTurno;
        private System.Windows.Forms.Button BtnCadastroTurmaOK;
        private System.Windows.Forms.Button BtnCancelaTurma;
    }
}