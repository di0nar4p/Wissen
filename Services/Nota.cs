using Entidades;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Nota : INota
    {
        private readonly IRepositoryBase<Entidades.Models.Nota> _repositoryBase;
        public Nota(IRepositoryBase<Entidades.Models.Nota> repositoryBase)
        {
        }

        public Entidades.Models.Nota ConsultaPorId(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Entidades.Models.Nota> ConsultaTodos()
        {
            return _repositoryBase.GetAll();
        }

        public void Delete(Entidades.Models.Nota nota)
        {
            _repositoryBase.Delete(nota);
        }

        public void Insert(Entidades.Models.Nota nota)
        {
            _repositoryBase.Insert(nota);
        }

        public void Update(Entidades.Models.Nota nota)
        {
            _repositoryBase.Update(nota);
        }
    }
}
