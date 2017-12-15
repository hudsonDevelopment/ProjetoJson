using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VilaAnimalJson.Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace VilaAnimalJson.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            string jsonstate;
            string json;
            using (var reader = new System.IO.StreamReader(Request.InputStream))
            {
                json = reader.ReadToEnd();
            }

            Response.Write(json);
            if (json != null)
            {
                ViewBag.jsonstate = " Não esta nula a variavel Json<br> ";
            }
            BaseConvert dadojson = (BaseConvert) JsonConvert.DeserializeObject(json);


            Connection conexao = new Connection();

            MySqlCommand command = new MySqlCommand("INSERT INTO usuario (nick)" +"VALUES('" + dadojson.nickname + "')", conexao.objConexao
                );
            conexao.abrir();
            command.ExecuteNonQuery();
            if (conexao.VerificaConexao())
            {
                ViewBag.conex = "   Conectado    ";
            }
            else
            {
                ViewBag.conex = "   Não Conectado    ";
            }


            return View();
        }
        
    }
}
