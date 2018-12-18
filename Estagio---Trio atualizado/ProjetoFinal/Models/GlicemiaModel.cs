using Microsoft.AspNetCore.Http;
using ProjetoFinal.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Models
{
    public class GlicemiaModel
    {
        public string Cpf { get; set; }
        public int Nivel_glicemico { get; set; }
        public string data_cadastro { get; set; }
        public string Nome { get; set; }


        IHttpContextAccessor HttpContextAccessor;

        public GlicemiaModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public GlicemiaModel()
        {
        }

        public bool InserirGlicemia()
        {



            string sql = $"INSERT INTO NIVEL_GLICEMICO(NIVEL_GLICEMICO,DATA_CADASTRO) VALUES ('{Nivel_glicemico}', '{data_cadastro}') WHERE CPF ='{Cpf}'";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSql(sql);
            return true;
        }
        public List<GlicemiaModel> ListaGlicemia()
        {
            List<GlicemiaModel> lista = new List<GlicemiaModel>();
            GlicemiaModel item;

            // pegar iddo usuario logado

            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuario");
            string sql = $"SELECT CPF,Nivel_GLICEMICO FROM Nivel_Glicemico WHERE CPF='{Cpf}'";
            DAL objDAO = new DAL();
            DataTable dt = objDAO.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
           {
                item = new GlicemiaModel();
                item.Cpf = (dt.Rows[i]["CPF"].ToString());
                item.Nivel_glicemico = int.Parse(dt.Rows[i]["NIVEL_GLICEMICO"].ToString());
                lista.Add(item);

            }
            return lista;
        }
        public void AtualizarDados()
        {
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"INSERT INTO NIVEL_GLICEMICO(NIVEL_GLICEMICO)VALUES( '{Nivel_glicemico}')";
            DAL objDAO = new DAL();
            objDAO.ExecutarComandoSql(sql);
        }
        public void Excluir(int Cpf)
        {
            new DAL().ExecutarComandoSql("DELETE FROM NIVEL_GLICEMICO WHERE CPF=" + Cpf);
        }

    
        //Recebe o contexto para acesso às variáveis de sessão.

        public List<GlicemiaModel> ListGlicemia()
        {
            List<GlicemiaModel> lista = new List<GlicemiaModel>();
            GlicemiaModel item;

            //Utilizado pela View Extrato
            string filtro = "";

            if (data_cadastro != null)
            {
                filtro += $" and t.Data >='{DateTime.Parse(data_cadastro).ToString("yyyy/MM/dd")}'";
            }

          

            if (Cpf != " ")
            {
                filtro += $" and t.Cpf ='{Cpf}' ";
            }
            //Fim

            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = "select t.Cpf, t.Nivel_glicemico, t.data_cadastro," +
                        " from Glicemia as t " +
                        $" where t.Usuario_Id = {id_usuario_logado} {filtro} order by t.data desc limit 10";

            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new GlicemiaModel();
                item.Cpf = (dt.Rows[i]["Cpf"].ToString());
                item.Nivel_glicemico = int.Parse(dt.Rows[i]["Nivel_glicemico"].ToString());
                item.data_cadastro = DateTime.Parse(dt.Rows[i]["data_cadastro"].ToString()).ToString("dd/MM/yyyy"); 
               
                lista.Add(item);
            }
            return lista;
        }

        public GlicemiaModel CarregarRegistro(int? id)
        {
            GlicemiaModel item;

            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = "select t.Cpf, t.Nivel_glicemico, t.data_cadastro," +
                        " from Glicemia as t " +
                        $" where t.Usuario_Id = {id_usuario_logado} and t.id='{id}'";

            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            item = new GlicemiaModel();
            item.Cpf = (dt.Rows[0]["Cpf"].ToString());
            item.Nivel_glicemico = int.Parse(dt.Rows[0]["Nivel_glicemico"].ToString());
            item.data_cadastro = DateTime.Parse(dt.Rows[0]["data_cadastro"].ToString()).ToString("dd/MM/yyyy");


            return item;
        }

        public void Insert()
        {
            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = "";
            if (Cpf == " ")
            {
                sql = "INSERT INTO GLICEMIA (CPF,NIVEL_GLICEMICO,DATA_CADATRO) " +
                     $" VALUES('{DateTime.Parse(data_cadastro).ToString("yyyy/MM/dd")}','{Cpf}','{Nivel_glicemico}','{data_cadastro}')";
            }
            else
            {
                sql = $"UPDATE GLICEMIA SET DATA='{DateTime.Parse(data_cadastro).ToString("yyyy/MM/dd")}', " +
                     $" CPF ='{Cpf}', " +
                     $" NIVEL_GLICEMICO='{Nivel_glicemico}', " +
                     $" DATA_CADASTRO='{data_cadastro}', ";
                    
            }

            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSql(sql);
        }

        public void Excluir(string Cpf)
        {
            new DAL().ExecutarComandoSql("DELETE FROM GLICEMIA WHERE CPF = " + Cpf);
        }
    }

    public class Dashboard
    {
        public double Nivel_glicemico { get; set; }
        public string data_cadastro { get; set; }
        public string Cpf { get; set; }

        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public Dashboard()
        {

        }

        //Recebe o contexto para acesso às variáveis de sessão.
        public Dashboard(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public List<Dashboard> RetornarDadosGraficoPie()
        {
            List<Dashboard> lista = new List<Dashboard>();
            Dashboard item;

            string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");

            string sql = "select sum(t.Nivel_glicemico) as total, p.Descricao from transacao as t inner join plano_contas as p " +
                         $"on t.Plano_Contas_Id = p.Id where t.Tipo = 'D' and t.usuario_id={id_usuario_logado} group by p.Descricao;";
            DAL objDAL = new DAL();
            DataTable dt = new DataTable();
            dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new Dashboard();
                item.Cpf = (dt.Rows[i]["CPF"].ToString());
                item.Nivel_glicemico = double.Parse(dt.Rows[i]["NIVEL_GLICEMICO"].ToString());
                item.data_cadastro = (dt.Rows[i]["DATA_CADASTRO"].ToString());
                lista.Add(item);
            }
            return lista;
        }
    }
}
