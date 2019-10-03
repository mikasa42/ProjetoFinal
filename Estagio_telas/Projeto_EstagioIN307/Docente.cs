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
        private ComboBox comboBox1;
        private Label LabTitulo;
        private Label label1;
        private DataGridViewTextBoxColumn h;
        private DataGridViewTextBoxColumn t1;
        private DataGridViewTextBoxColumn t2;
        private DataGridViewTextBoxColumn t3;
        private DataGridViewTextBoxColumn t4;
        private DataGridViewTextBoxColumn t5;
        private DataGridViewTextBoxColumn t6;
        private Button button1;
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.t6});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.Location = new System.Drawing.Point(12, 116);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(741, 166);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manhã",
            "Tarde"});
            this.comboBox1.Location = new System.Drawing.Point(76, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // LabTitulo
            // 
            this.LabTitulo.AutoSize = true;
            this.LabTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTitulo.Location = new System.Drawing.Point(301, 13);
            this.LabTitulo.Name = "LabTitulo";
            this.LabTitulo.Size = new System.Drawing.Size(168, 31);
            this.LabTitulo.TabIndex = 4;
            this.LabTitulo.Text = "HORÁRIOS";
            this.LabTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Turma:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Alterar horários";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Docente
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(770, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabTitulo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
