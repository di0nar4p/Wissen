using Entidades;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Curso : ICurso
    {
        private readonly IRepositoryBase<Entidades.Models.Curso> _repositoryBase;
        public Curso(IRepositoryBase<Entidades.Models.Curso> repositoryBase)
        {

        }
        public Entidades.Models.Curso ConsultaPorId(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Entidades.Models.Curso> ConsultaTodos()
        {
            return _repositoryBase.GetAll();
        }

        public void Delete(Entidades.Models.Curso curso)
        {
            _repositoryBase.Delete(curso);
        }

        public void Insert(Entidades.Models.Curso curso)
        {
            _repositoryBase.Insert(curso);
        }

        public void Update(Entidades.Models.Curso curso)
        {
            _repositoryBase.Update(curso);
        }
    }
    }

