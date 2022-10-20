using Entidades;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Boletim : IBoletim
    {
        private readonly IRepositoryBase<Entidades.Models.Boletim> _repositoryBase;
        public Boletim(IRepositoryBase<Entidades.Models.Boletim> repositoryBase)
        {
        }

        public Entidades.Models.Boletim ConsultaPorId(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Entidades.Models.Boletim> ConsultaTodos()
        {
            return _repositoryBase.GetAll();
        }

        public void Delete(Entidades.Models.Boletim boletim)
        {
            _repositoryBase.Delete(boletim);
        }

        public void Insert(Entidades.Models.Boletim boletim)
        {
            _repositoryBase.Insert(boletim);
        }

        public void Update(Entidades.Models.Boletim boletim)
        {
            _repositoryBase.Update(boletim);
        }
    }
}
