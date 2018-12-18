﻿using System;
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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login novoLogin = new Login();

            if (novoLogin.FazerLogin(TxtMatricula.Text, TxtSenha.Text))
            {
                Administrador pg = new Administrador();
                pg.Show();
            }
            else
            {
                LabErro.Visible = true;
            }
        }

        private void BtnLogin_Click_1(object sender, EventArgs e)
        {

        }

        private void LabTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
