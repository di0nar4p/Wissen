using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface ICurso
    {
        Entidades.Models.Curso ConsultaPorId(int id);
        IEnumerable<Entidades.Models.Curso> ConsultaTodos();
        void Delete(Entidades.Models.Curso curso);
        void Insert(Entidades.Models.Curso curso);
        void Update(Entidades.Models.Curso curso);
    }
}
