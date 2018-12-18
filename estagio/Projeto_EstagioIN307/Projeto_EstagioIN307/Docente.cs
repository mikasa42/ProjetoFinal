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
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn h;
        private DataGridViewTextBoxColumn t1;
        private DataGridViewTextBoxColumn t2;
        private DataGridViewTextBoxColumn t3;
        private DataGridViewTextBoxColumn t4;
        private DataGridViewTextBoxColumn t5;
        private DataGridViewTextBoxColumn t6;
        private DataGridViewComboBoxColumn turno;
        private ComboBox comboBox1;
        private Label horario;
        private DataGridView dataGridView1;

        public Docente()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.h = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.horario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.h,
            this.t1,
            this.t2,
            this.t3,
            this.t4,
            this.t5,
            this.t6,
            this.turno});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.Location = new System.Drawing.Point(12, 163);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(744, 166);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // h
            // 
            this.h.HeaderText = "Horário";
            this.h.Name = "h";
            // 
            // t1
            // 
            this.t1.HeaderText = "Turma 1";
            this.t1.Name = "t1";
            // 
            // t2
            // 
            this.t2.HeaderText = "Turma 2";
            this.t2.Name = "t2";
            // 
            // t3
            // 
            this.t3.HeaderText = "Turma 3";
            this.t3.Name = "t3";
            // 
            // t4
            // 
            this.t4.HeaderText = "Turma 4";
            this.t4.Name = "t4";
            // 
            // t5
            // 
            this.t5.HeaderText = "Turma 5";
            this.t5.Name = "t5";
            // 
            // t6
            // 
            this.t6.HeaderText = "Turma 6";
            this.t6.Name = "t6";
            // 
            // turno
            // 
            this.turno.HeaderText = "Turno";
            this.turno.Name = "turno";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manhã",
            "Tarde"});
            this.comboBox1.Location = new System.Drawing.Point(12, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // horario
            // 
            this.horario.AutoSize = true;
            this.horario.Font = new System.Drawing.Font("Open Sans", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horario.Location = new System.Drawing.Point(321, 44);
            this.horario.Name = "horario";
            this.horario.Size = new System.Drawing.Size(142, 39);
            this.horario.TabIndex = 2;
            this.horario.Text = "Horários";
            this.horario.Click += new System.EventHandler(this.horario_Click);
            // 
            // Docente
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(768, 343);
            this.Controls.Add(this.horario);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Docente";
            this.Load += new System.EventHandler(this.Docente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
