using Entidades;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class Endereco : IEndereco
    {
        private readonly IRepositoryBase<Entidades.Models.Endereco> _repositoryBase;
        public Endereco(IRepositoryBase<Entidades.Models.Endereco> repositoryBase)
        {
        }

        public Entidades.Models.Endereco ConsultaPorId(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Entidades.Models.Endereco> ConsultaTodos()
        {
            return _repositoryBase.GetAll();
        }

        public void Delete(Entidades.Models.Endereco endereco)
        {
            _repositoryBase.Delete(endereco);
        }

        public void Insert(Entidades.Models.Endereco endereco)
        {
            _repositoryBase.Insert(endereco);
        }

        public void Update(Entidades.Models.Endereco endereco)
        {
            _repositoryBase.Update(endereco);
        }
    }
}
