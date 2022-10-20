using System.Collections.Generic;
using Entidades.Models;
namespace Services.Interfaces
{
    public interface IAluno
    {
        Entidades.Models.Aluno ConsultaPorId(int id);
        IEnumerable<Entidades.Models.Aluno> ConsultaTodos();
        void Delete(Entidades.Models.Aluno aluno);
        void Insert(Entidades.Models.Aluno aluno);
        void Update(Entidades.Models.Aluno aluno);
    }
}
