namespace Projeto_EstagioIN307
{
    partial class CadastroDisponibilidade
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
            this.TabControlDisponilidade = new System.Windows.Forms.TabControl();
            this.TabPageManha = new System.Windows.Forms.TabPage();
            this.MaskTxtHoraFimM = new System.Windows.Forms.MaskedTextBox();
            this.MaskTxtHoraInicioM = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TabPageTarde = new System.Windows.Forms.TabPage();
            this.MaskTxtHoraFimT = new System.Windows.Forms.MaskedTextBox();
            this.MaskTxtHoraInicioT = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.TabPageNoite = new System.Windows.Forms.TabPage();
            this.MaskTxtHoraFimN = new System.Windows.Forms.MaskedTextBox();
            this.MaskTxtHoraInicioN = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BtnCadastroDispOK = new System.Windows.Forms.Button();
            this.BtnCancelaDisp = new System.Windows.Forms.Button();
            this.LabConcluido = new System.Windows.Forms.Label();
            this.TabControlDisponilidade.SuspendLayout();
            this.TabPageManha.SuspendLayout();
            this.TabPageTarde.SuspendLayout();
            this.TabPageNoite.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlDisponilidade
            // 
            this.TabControlDisponilidade.Controls.Add(this.TabPageManha);
            this.TabControlDisponilidade.Controls.Add(this.TabPageTarde);
            this.TabControlDisponilidade.Controls.Add(this.TabPageNoite);
            this.TabControlDisponilidade.Location = new System.Drawing.Point(40, 30);
            this.TabControlDisponilidade.Name = "TabControlDisponilidade";
            this.TabControlDisponilidade.SelectedIndex = 0;
            this.TabControlDisponilidade.Size = new System.Drawing.Size(286, 310);
            this.TabControlDisponilidade.TabIndex = 0;
            this.TabControlDisponilidade.Tag = "";
            // 
            // TabPageManha
            // 
            this.TabPageManha.Controls.Add(this.MaskTxtHoraFimM);
            this.TabPageManha.Controls.Add(this.MaskTxtHoraInicioM);
            this.TabPageManha.Controls.Add(this.label7);
            this.TabPageManha.Controls.Add(this.label8);
            this.TabPageManha.Controls.Add(this.label9);
            this.TabPageManha.Controls.Add(this.comboBox1);
            this.TabPageManha.Location = new System.Drawing.Point(4, 22);
            this.TabPageManha.Name = "TabPageManha";
            this.TabPageManha.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageManha.Size = new System.Drawing.Size(278, 284);
            this.TabPageManha.TabIndex = 0;
            this.TabPageManha.Text = "Manhã";
            this.TabPageManha.UseVisualStyleBackColor = true;
            // 
            // MaskTxtHoraFimM
            // 
            this.MaskTxtHoraFimM.Location = new System.Drawing.Point(143, 132);
            this.MaskTxtHoraFimM.Mask = "00:00";
            this.MaskTxtHoraFimM.Name = "MaskTxtHoraFimM";
            this.MaskTxtHoraFimM.Size = new System.Drawing.Size(32, 20);
            this.MaskTxtHoraFimM.TabIndex = 19;
            this.MaskTxtHoraFimM.ValidatingType = typeof(System.DateTime);
            // 
            // MaskTxtHoraInicioM
            // 
            this.MaskTxtHoraInicioM.Location = new System.Drawing.Point(143, 86);
            this.MaskTxtHoraInicioM.Mask = "00:00";
            this.MaskTxtHoraInicioM.Name = "MaskTxtHoraInicioM";
            this.MaskTxtHoraInicioM.Size = new System.Drawing.Size(32, 20);
            this.MaskTxtHoraInicioM.TabIndex = 18;
            this.MaskTxtHoraInicioM.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Horário de Fim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Horário de Início";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Dia da semana:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado"});
            this.comboBox1.Location = new System.Drawing.Point(143, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // TabPageTarde
            // 
            this.TabPageTarde.Controls.Add(this.MaskTxtHoraFimT);
            this.TabPageTarde.Controls.Add(this.MaskTxtHoraInicioT);
            this.TabPageTarde.Controls.Add(this.label1);
            this.TabPageTarde.Controls.Add(this.label2);
            this.TabPageTarde.Controls.Add(this.label3);
            this.TabPageTarde.Controls.Add(this.comboBox3);
            this.TabPageTarde.Location = new System.Drawing.Point(4, 22);
            this.TabPageTarde.Name = "TabPageTarde";
            this.TabPageTarde.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageTarde.Size = new System.Drawing.Size(278, 284);
            this.TabPageTarde.TabIndex = 1;
            this.TabPageTarde.Text = "Tarde";
            this.TabPageTarde.UseVisualStyleBackColor = true;
            // 
            // MaskTxtHoraFimT
            // 
            this.MaskTxtHoraFimT.Location = new System.Drawing.Point(133, 128);
            this.MaskTxtHoraFimT.Mask = "00:00";
            this.MaskTxtHoraFimT.Name = "MaskTxtHoraFimT";
            this.MaskTxtHoraFimT.Size = new System.Drawing.Size(32, 20);
            this.MaskTxtHoraFimT.TabIndex = 13;
            this.MaskTxtHoraFimT.ValidatingType = typeof(System.DateTime);
            // 
            // MaskTxtHoraInicioT
            // 
            this.MaskTxtHoraInicioT.Location = new System.Drawing.Point(133, 82);
            this.MaskTxtHoraInicioT.Mask = "00:00";
            this.MaskTxtHoraInicioT.Name = "MaskTxtHoraInicioT";
            this.MaskTxtHoraInicioT.Size = new System.Drawing.Size(32, 20);
            this.MaskTxtHoraInicioT.TabIndex = 12;
            this.MaskTxtHoraInicioT.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Horário de Fim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Horário de Início";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dia da semana:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado"});
            this.comboBox3.Location = new System.Drawing.Point(133, 11);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // TabPageNoite
            // 
            this.TabPageNoite.Controls.Add(this.MaskTxtHoraFimN);
            this.TabPageNoite.Controls.Add(this.MaskTxtHoraInicioN);
            this.TabPageNoite.Controls.Add(this.label4);
            this.TabPageNoite.Controls.Add(this.label5);
            this.TabPageNoite.Controls.Add(this.label6);
            this.TabPageNoite.Controls.Add(this.comboBox2);
            this.TabPageNoite.Location = new System.Drawing.Point(4, 22);
            this.TabPageNoite.Name = "TabPageNoite";
            this.TabPageNoite.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageNoite.Size = new System.Drawing.Size(278, 284);
            this.TabPageNoite.TabIndex = 2;
            this.TabPageNoite.Text = "Noite";
            this.TabPageNoite.UseVisualStyleBackColor = true;
            // 
            // MaskTxtHoraFimN
            // 
            this.MaskTxtHoraFimN.Location = new System.Drawing.Point(137, 130);
            this.MaskTxtHoraFimN.Mask = "00:00";
            this.MaskTxtHoraFimN.Name = "MaskTxtHoraFimN";
            this.MaskTxtHoraFimN.Size = new System.Drawing.Size(32, 20);
            this.MaskTxtHoraFimN.TabIndex = 19;
            this.MaskTxtHoraFimN.ValidatingType = typeof(System.DateTime);
            // 
            // MaskTxtHoraInicioN
            // 
            this.MaskTxtHoraInicioN.Location = new System.Drawing.Point(137, 84);
            this.MaskTxtHoraInicioN.Mask = "00:00";
            this.MaskTxtHoraInicioN.Name = "MaskTxtHoraInicioN";
            this.MaskTxtHoraInicioN.Size = new System.Drawing.Size(32, 20);
            this.MaskTxtHoraInicioN.TabIndex = 18;
            this.MaskTxtHoraInicioN.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Horário de Fim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Horário de Início";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dia da semana:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado"});
            this.comboBox2.Location = new System.Drawing.Point(137, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // BtnCadastroDispOK
            // 
            this.BtnCadastroDispOK.Location = new System.Drawing.Point(12, 378);
            this.BtnCadastroDispOK.Name = "BtnCadastroDispOK";
            this.BtnCadastroDispOK.Size = new System.Drawing.Size(93, 38);
            this.BtnCadastroDispOK.TabIndex = 1;
            this.BtnCadastroDispOK.Text = "Cadastrar";
            this.BtnCadastroDispOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancelaDisp
            // 
            this.BtnCancelaDisp.Location = new System.Drawing.Point(258, 378);
            this.BtnCancelaDisp.Name = "BtnCancelaDisp";
            this.BtnCancelaDisp.Size = new System.Drawing.Size(93, 38);
            this.BtnCancelaDisp.TabIndex = 2;
            this.BtnCancelaDisp.Text = "Cancelar";
            this.BtnCancelaDisp.UseVisualStyleBackColor = true;
            // 
            // LabConcluido
            // 
            this.LabConcluido.AutoSize = true;
            this.LabConcluido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabConcluido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.LabConcluido.ForeColor = System.Drawing.Color.Green;
            this.LabConcluido.Location = new System.Drawing.Point(157, 353);
            this.LabConcluido.Name = "LabConcluido";
            this.LabConcluido.Size = new System.Drawing.Size(73, 17);
            this.LabConcluido.TabIndex = 3;
            this.LabConcluido.Text = "Concluído!";
            // 
            // CadastroDisponibilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 428);
            this.Controls.Add(this.LabConcluido);
            this.Controls.Add(this.BtnCancelaDisp);
            this.Controls.Add(this.BtnCadastroDispOK);
            this.Controls.Add(this.TabControlDisponilidade);
            this.Name = "CadastroDisponibilidade";
            this.Text = "CadastroDisponibilidade";
            this.TabControlDisponilidade.ResumeLayout(false);
            this.TabPageManha.ResumeLayout(false);
            this.TabPageManha.PerformLayout();
            this.TabPageTarde.ResumeLayout(false);
            this.TabPageTarde.PerformLayout();
            this.TabPageNoite.ResumeLayout(false);
            this.TabPageNoite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlDisponilidade;
        private System.Windows.Forms.TabPage TabPageManha;
        private System.Windows.Forms.TabPage TabPageTarde;
        private System.Windows.Forms.TabPage TabPageNoite;
        private System.Windows.Forms.MaskedTextBox MaskTxtHoraFimM;
        private System.Windows.Forms.MaskedTextBox MaskTxtHoraInicioM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox MaskTxtHoraFimT;
        private System.Windows.Forms.MaskedTextBox MaskTxtHoraInicioT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.MaskedTextBox MaskTxtHoraFimN;
        private System.Windows.Forms.MaskedTextBox MaskTxtHoraInicioN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button BtnCadastroDispOK;
        private System.Windows.Forms.Button BtnCancelaDisp;
        private System.Windows.Forms.Label LabConcluido;
    }
}