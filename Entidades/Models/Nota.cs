namespace Entidades.Models
{
    public class Nota : Modelo
    {
        public long CodigoUsuario { get; set; }
        public int CodigoBoletim { get; set; }
        public int CodigoCurso { get; set; }
        public int CodigoDisciplina { get; set; }
        public double PrimeiraNota { get; set; }
        public double SegundaNota { get; set; }
        public double TerceiraNota { get; set; }
        public double QuartaNota { get; set; }
        public double NotaFinal { get; set; }
        public double Media { get; set; }
        public Usuario Aluno { get; set; }
        public Curso Curso { get; set; }
        public Disciplina Disciplina { get; set; }
        public Boletim Boletim { get; set; }
    }
}