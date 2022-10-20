using System;

namespace Entidades.Models
{
    public class Disciplina
    {
        public int Codigo { get; set; }
        public int CargaHoraria { get; set; }
        public string Nome { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataExclusao { get; set; }
        public string Descricao { get; set; }
        public string Label { get; set; }
        public Nota Nota { get; set; }
    }
}