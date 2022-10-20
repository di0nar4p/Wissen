using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Models
{
    public class Grade : Modelo
    {
        public Usuario Usuario { get; set; }
        public IList<Disciplina> Disciplina { get; set; }
    }
}
