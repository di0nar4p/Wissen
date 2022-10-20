using Entidades;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Aluno : IAluno
    {
        private readonly IRepositoryBase<Entidades.Models.Aluno> _repositoryBase;
        public Aluno(IRepositoryBase<Entidades.Models.Aluno> repositoryBase)
        {
        }

        public Entidades.Models.Aluno ConsultaPorId(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Entidades.Models.Aluno> ConsultaTodos()
        {
            return _repositoryBase.GetAll();
        }

        public void Delete(Entidades.Models.Aluno aluno)
        {
            _repositoryBase.Delete(aluno);
        }

        public void Insert(Entidades.Models.Aluno aluno)
        {
            _repositoryBase.Insert(aluno);
        }

        public void Update(Entidades.Models.Aluno aluno)
        {
            _repositoryBase.Update(aluno);
        }
    }
}
