using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Models
{
    public class Boletim
    {
        public int Codigo { get; set; }
        public DateTime DataExclusao { get; set; }
        public string Ano { get; set; }
        public int CodigoAluno { get; set; }
        public int CodigoCurso { get; set; }
        public int CodigoNota { get; set; }
        public string NomeAluno { get; set; }
        public Curso Curso { get; set; }
        public Usuario Aluno { get; set; }
        public Nota Nota { get; set; }
    }
}
