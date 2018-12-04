using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using ProjetoFinal.Util;
using Microsoft.AspNetCore.Http;

namespace ProjetoFinal.Models
{
    public class UsuarioModel
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Cpf { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public string Sexo { get; set; }
        public string Condicao { get; set; }
        public float Pressao { get; set; }
        public float Nivel_glicemico { get; set; }
        public DateTime Data_Nascimento { get; set; }

        IHttpContextAccessor HttpContextAccessor;

        public bool Autenticar()
        {
            string sql = $"SELECT ID, NOME, DATA_NASCIMENTO FROM CADASTRO WHERE EMAIL='{Email}'" +
                $" AND SENHA='{Senha}'";
            DAL objDAO = new DAL();
            DataTable dt = objDAO.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Id = int.Parse(dt.Rows[0]["ID"].ToString()); //dados para sessao
                    Nome = dt.Rows[0]["NOME"].ToString(); //dados para sessao
                    Data_Nascimento = DateTime.Parse(dt.Rows[0]["DATA_NASCIMENTO"].ToString());
                    return true;
                }
            }
            return false;
        }


        public bool Cadastrar()
        {



            string sql = $"INSERT INTO CADASTRO(NOME,EMAIL,SENHA,CPF,ALTURA,PESO,SEXO,CONDICAO,DATA_NASCIMENTO,PRESSAO,NIVEL_GLICEMICO) VALUES ('{Nome}','{Email}','{Senha}','{Cpf}','{Altura}','{Peso}','{Sexo}','{Condicao}','{Data_Nascimento}','{Pressao}','{Nivel_glicemico}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSql(sql);
            return true;




        }
        public bool AtualizarDados()
        {



            string sql = $"INSERT INTO PRESSAO(CPF,PRESSAO) VALUES ('{Cpf}','{Pressao}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSql(sql);
            return true;
        }

    

        
        public UsuarioModel()
        {
        }

        public UsuarioModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<UsuarioModel> ListaUsuario()
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();
            UsuarioModel item;

            // pegar iddo usuario logado

            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuario");
            string sql = $"SELECT CPF,Nivel_GLICEMICO FROM Nivel_Glicemico WHERE CPF='{Cpf}'AND SELECT CPF,PRESSAO FROM PRESSAO WHERE CPF='{Cpf}'";
            DAL objDAO = new DAL();
            DataTable dt = objDAO.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new UsuarioModel();
                item.Cpf = int.Parse(dt.Rows[i]["CPF"].ToString());
                item.Nivel_glicemico = int.Parse(dt.Rows[i]["NIVEL_GLICEMICO"].ToString());
                item.Pressao = int.Parse(dt.Rows[i]["PRESSAO"].ToString());
                lista.Add(item);

            }
            return lista;
        }
        public void InserirDados()
        {
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"INSERT INTO NIVEL_GLICEMICO(NIVEL_GLICEMICO)VALUES( '{Nivel_glicemico}')";
            DAL objDAO = new DAL();
            objDAO.ExecutarComandoSql(sql);
        }
        public void Excluir(int Cpf)
        {
            new DAL().ExecutarComandoSql("DELETE FROM NIVEL_GLICEMICO WHERE CPF=" +Cpf);
        }
        
    }
}
    
