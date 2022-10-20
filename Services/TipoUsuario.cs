using Entidades;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class TipoUsuario : ITipoUsuario
    {
        private readonly IRepositoryBase<Entidades.Models.TipoUsuario> _repositoryBase;
        public TipoUsuario(IRepositoryBase<Entidades.Models.TipoUsuario> repositoryBase)
        {
        }

        public Entidades.Models.TipoUsuario ConsultaPorId(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Entidades.Models.TipoUsuario> ConsultaTodos()
        {
            return _repositoryBase.GetAll();
        }

        public void Delete(Entidades.Models.TipoUsuario tipoUsuario)
        {
            _repositoryBase.Delete(tipoUsuario);
        }

        public void Insert(Entidades.Models.TipoUsuario tipoUsuario)
        {
            _repositoryBase.Insert(tipoUsuario);
        }

        public void Update(Entidades.Models.TipoUsuario tipoUsuario)
        {
            _repositoryBase.Update(tipoUsuario);
        }
    }
}
