using Entidades;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Turma : ITurma
    {
        private readonly IRepositoryBase<Entidades.Models.Turma> _repositoryBase;
        public Turma(IRepositoryBase<Entidades.Models.Turma> repositoryBase)
        {
        }

        public Entidades.Models.Turma ConsultaPorId(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Entidades.Models.Turma> ConsultaTodos()
        {
            return _repositoryBase.GetAll();
        }

        public void Delete(Entidades.Models.Turma turma)
        {
            _repositoryBase.Delete(turma);
        }

        public void Insert(Entidades.Models.Turma turma)
        {
            _repositoryBase.Insert(turma);
        }

        public void Update(Entidades.Models.Turma turma)
        {
            _repositoryBase.Update(turma);
        }
    }
}
