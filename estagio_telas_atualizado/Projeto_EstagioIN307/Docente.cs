using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_EstagioIN307
{
    public partial class Docente : Form
    {
        private DataGridView DGVTurmaHora;
        private ComboBox ComboTurmaHora;
        private Label LabHorario;
        private Label LabTurmaHora;
        private DataGridView dataGridView1;

        public Docente()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.DGVTurmaHora = new System.Windows.Forms.DataGridView();
            this.ComboTurmaHora = new System.Windows.Forms.ComboBox();
            this.LabHorario = new System.Windows.Forms.Label();
            this.LabTurmaHora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTurmaHora)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTurmaHora
            // 
            this.DGVTurmaHora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTurmaHora.GridColor = System.Drawing.SystemColors.ControlLight;
            this.DGVTurmaHora.Location = new System.Drawing.Point(12, 116);
            this.DGVTurmaHora.Name = "DGVTurmaHora";
            this.DGVTurmaHora.Size = new System.Drawing.Size(741, 166);
            this.DGVTurmaHora.TabIndex = 0;
            this.DGVTurmaHora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ComboTurmaHora
            // 
            this.ComboTurmaHora.FormattingEnabled = true;
            this.ComboTurmaHora.Items.AddRange(new object[] {
            "Manhã",
            "Tarde"});
            this.ComboTurmaHora.Location = new System.Drawing.Point(92, 87);
            this.ComboTurmaHora.Name = "ComboTurmaHora";
            this.ComboTurmaHora.Size = new System.Drawing.Size(121, 21);
            this.ComboTurmaHora.TabIndex = 1;
            // 
            // LabHorario
            // 
            this.LabHorario.AutoSize = true;
            this.LabHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabHorario.Location = new System.Drawing.Point(317, 9);
            this.LabHorario.Name = "LabHorario";
            this.LabHorario.Size = new System.Drawing.Size(123, 31);
            this.LabHorario.TabIndex = 4;
            this.LabHorario.Text = "Docente";
            this.LabHorario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabTurmaHora
            // 
            this.LabTurmaHora.AutoSize = true;
            this.LabTurmaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTurmaHora.Location = new System.Drawing.Point(12, 87);
            this.LabTurmaHora.Name = "LabTurmaHora";
            this.LabTurmaHora.Size = new System.Drawing.Size(74, 20);
            this.LabTurmaHora.TabIndex = 5;
            this.LabTurmaHora.Text = "Docente:";
            // 
            // Docente
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(770, 293);
            this.Controls.Add(this.LabTurmaHora);
            this.Controls.Add(this.LabHorario);
            this.Controls.Add(this.ComboTurmaHora);
            this.Controls.Add(this.DGVTurmaHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Docente";
            this.Load += new System.EventHandler(this.Docente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTurmaHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void horario_Click(object sender, EventArgs e)
        {

        }

        private void Docente_Load(object sender, EventArgs e)
        {

        }


        }
    }
}
