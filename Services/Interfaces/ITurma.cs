using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface ITurma
    {
        Entidades.Models.Turma ConsultaPorId(int id);
        IEnumerable<Entidades.Models.Turma> ConsultaTodos();
        void Delete(Entidades.Models.Turma turma);
        void Insert(Entidades.Models.Turma turma);
        void Update(Entidades.Models.Turma turma);
    }
}
