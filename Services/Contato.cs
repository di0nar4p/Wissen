using Entidades;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
     public class Contato:IContato 
    {
        private readonly IRepositoryBase<Entidades.Models.Contato> _repositoryBase;

        public Contato(IRepositoryBase<Entidades.Models.Contato> repositoryBase)
        {
        }

        public Entidades.Models.Contato ConsultaPorId(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Entidades.Models.Contato> ConsultaTodos()
        {
            return _repositoryBase.GetAll();
        }

        public void Delete(Entidades.Models.Contato contato)
        {
            _repositoryBase.Delete(contato);
        }

        public void Insert(Entidades.Models.Contato contato)
        {
            _repositoryBase.Insert(contato);
        }

        public void Update(Entidades.Models.Contato contato)
        {
            _repositoryBase.Update(contato);
        }
    }
}
