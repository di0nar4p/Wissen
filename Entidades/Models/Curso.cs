using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Models
{
    public class Curso
    {
        public int Codigo { get; set; }
        public int CodigoTurno { get; set; }
        public int CodigoGradeCurso { get; set; }
        public int CargaHoraria { get; set; }
        public Turno Turno { get; set; }
        public double Valor { get; set; }
        public DateTime Periodo { get; set; }
        public string Duracao { get; set; }
        public string Nome { get; set; }

    }
}
