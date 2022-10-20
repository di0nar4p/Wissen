using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
   public interface IDisciplina
    {
        Entidades.Models.Disciplina ConsultaPorId(int id);
        IEnumerable<Entidades.Models.Disciplina> ConsultaTodos();
        void Delete(Entidades.Models.Disciplina disciplina);
        void Insert(Entidades.Models.Disciplina disciplina);
        void Update(Entidades.Models.Disciplina disciplina);
    }
}
