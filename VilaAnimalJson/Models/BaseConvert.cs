using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VilaAnimalJson.Models
{
    public class BaseConvert
    {
        public string nickname;
        public string teste;
        public int idade;
        public List<float> pontuacao = new List<float>();
        public List<float> tempo = new List<float>();
        public List<string> data = new List<string>();
    }
}