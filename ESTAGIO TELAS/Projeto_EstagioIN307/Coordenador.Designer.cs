namespace Projeto_EstagioIN307
{
    partial class Coordenador
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
            this.ComboProf = new System.Windows.Forms.ComboBox();
            this.BtnVerHoraProf = new System.Windows.Forms.Button();
            this.BtnCdstCoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboProf
            // 
            this.ComboProf.FormattingEnabled = true;
            this.ComboProf.Location = new System.Drawing.Point(181, 62);
            this.ComboProf.Name = "ComboProf";
            this.ComboProf.Size = new System.Drawing.Size(121, 21);
            this.ComboProf.TabIndex = 2;
            // 
            // BtnVerHoraProf
            // 
            this.BtnVerHoraProf.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnVerHoraProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.BtnVerHoraProf.Location = new System.Drawing.Point(181, 104);
            this.BtnVerHoraProf.Name = "BtnVerHoraProf";
            this.BtnVerHoraProf.Size = new System.Drawing.Size(120, 47);
            this.BtnVerHoraProf.TabIndex = 3;
            this.BtnVerHoraProf.Text = "Visualizar horário do professor";
            this.BtnVerHoraProf.UseVisualStyleBackColor = false;
            // 
            // BtnCdstCoord
            // 
            this.BtnCdstCoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.BtnCdstCoord.Location = new System.Drawing.Point(33, 104);
            this.BtnCdstCoord.Name = "BtnCdstCoord";
            this.BtnCdstCoord.Size = new System.Drawing.Size(120, 47);
            this.BtnCdstCoord.TabIndex = 28;
            this.BtnCdstCoord.Text = "Cadastrar Como Coordenador";
            this.BtnCdstCoord.UseVisualStyleBackColor = true;
            // 
            // Coordenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(342, 163);
            this.Controls.Add(this.BtnCdstCoord);
            this.Controls.Add(this.BtnVerHoraProf);
            this.Controls.Add(this.ComboProf);
            this.Name = "Coordenador";
            this.Text = "Coordenador";
            this.Load += new System.EventHandler(this.Coordenador_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboProf;
        private System.Windows.Forms.Button BtnVerHoraProf;
        private System.Windows.Forms.Button BtnCdstCoord;
    }
}