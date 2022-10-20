using Entidades;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
   public class Disciplina: IDisciplina
    {
        private readonly IRepositoryBase<Entidades.Models.Disciplina> _repositoryBase;

        public Disciplina(IRepositoryBase<Entidades.Models.Disciplina> repositoryBase)
        {
        }

        public Entidades.Models.Disciplina ConsultaPorId(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Entidades.Models.Disciplina> ConsultaTodos()
        {
            return _repositoryBase.GetAll();
        }

        public void Delete(Entidades.Models.Disciplina disciplina)
        {
            _repositoryBase.Delete(disciplina);
        }

        public void Insert(Entidades.Models.Disciplina disciplina)
        {
            _repositoryBase.Insert(disciplina);
        }

        public void Update(Entidades.Models.Disciplina disciplina)
        {
            _repositoryBase.Update(disciplina);
        }
    }
}
