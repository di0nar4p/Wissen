using Entidades;
using Entidades.Models;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class UsuarioServiceImplementation : IUsuarioService
    {
        private readonly IRepositoryBase<Usuario> _repositoryBase;
        public UsuarioServiceImplementation(IRepositoryBase<Usuario> repository)
        {
            this._repositoryBase = repository;
        }

        public Usuario ConsultaPorId(int id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<Usuario> ConsultaTodos()
        {
            return _repositoryBase.GetAll();
        }

        public void Delete(Usuario usuario)
        {
            _repositoryBase.Delete(usuario);
        }

        public void Insert(Usuario usuario)
        {
            _repositoryBase.Insert(usuario);
        }

        public void Update(Usuario usuario)
        {
            _repositoryBase.Update(usuario);
        }
    }
}
