using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using VilaAnimalJson.Interface;

namespace VilaAnimalJson.Models
{
    public class Connection 
    {
        public string sqlCon = "SERVER=localhost; DATABASE=vilaanimalbanco; UID=root; PASSWORD=;";
        public MySqlConnection objConexao;

        public Connection()
        {
            objConexao = new MySqlConnection(sqlCon);
            

        }
        
        public MySqlConnection abrir()
        {
            if(objConexao.State  == ConnectionState.Closed)
                objConexao.Open();
            return objConexao;
        }
        public bool VerificaConexao()
        {
            if (objConexao.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /*
        private SqlConnection conexao;
        private string dataSource = "server=localhost;database=vilaanimalbanco;uid=root;server=localhost;database=vilaanimalbanco;uid=root;pwd=''";

        public Connection()
        {
            conexao = new SqlConnection(dataSource);
        }
        public SqlConnection abrir()
        {
            if(conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }
        public SqlConnection buscar()
        {
            return this.abrir();
        }
        public void fechar()
        {
            if(conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        public void Dispose()
        {
            this.fechar();
            GC.SuppressFinalize(this);
        }
        public bool VerificaConexao()
        {
            if(conexao.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */
        /*private SqlConnection conexao;

        private SqlConnection criaConexao()
        {
            this.conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
            return conexao;
        }*/




    }
}