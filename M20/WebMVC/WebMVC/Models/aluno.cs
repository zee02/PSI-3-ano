using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class aluno
    {
        public int Naluno { get; set; }

        public string PriNome { get; set; }
        public string UltNome { get; set; }
        public string Morada { get; set; }
        public Genero Genero { get; set; }
        public DateTime DataNasc { get; set; }
        public int AnoEscolaridade { get; set; }
        public string ImgPath { get; set; }

        public HttpPostedFileBase imagem { get; set; }
    }

    public enum Genero
    {
        Masculino, Feminino
    }
}