
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_EstagioIN307
{
    class Login
    {
        int usuario;
        string senha;

        public bool FazerLogin(string matricula, string senha)
        {
            SqlConnection conex = new SqlConnection("Data Source = localhost; Initial Catalog = BancoMec; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();
            comd.Connection = conex;

            comd.CommandText = "SELECT Matricula FROM Adm WHERE MATRICULA = @Matricula AND SENHA = @Senha";
            comd.Parameters.AddWithValue("Matricula", matricula);
            comd.Parameters.AddWithValue("Senha", senha);

            comd.Connection.Open();
            SqlDataReader reader = comd.ExecuteReader();
            int id = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }
            }
            reader.Close();
            comd.Connection.Close();

            if (id == 1)
           
            {
               TelaInicial cadastro = new TelaInicial();
                return true;
            }
            return false;
        }
    }
}