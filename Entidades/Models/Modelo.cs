using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Models
{
    public class Modelo
    {
        public long Codigo { get; set; }
        protected int CodInstituicao { get; set; }
        protected string Descricao { get; set; }
        protected DateTime DataExclusao { get; set; }
        protected DateTime DataInclusao { get; set; }
        public DateTime Data { get; set; }
        protected string Label { get; set; }
        protected string Misc { get; set; }
        protected string Titulo { get; set; }
    }
}
