using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Models
{
    public class Turma : Modelo
    {
        public int CodCurso { get; set; }
        public string Nome { get; set; }
        public string AnoLetivo { get; set; }
    }
}
