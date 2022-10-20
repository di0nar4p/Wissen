using Entidades;
using Entidades.Models;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class NoticiaServiceImplementation : INoticiaService
    {
        private readonly IRepositoryBase<Noticia> _repositoryBase;

        public NoticiaServiceImplementation(IRepositoryBase<Noticia> repository)
        {
            this._repositoryBase = repository;
        }

        public Noticia ConsultaPorId(int id)
        {
            return this._repositoryBase.Get(id);
        }

        public IEnumerable<Noticia> ConsultaTodos()
        {
            return this._repositoryBase.GetAll();
        }

        public void Delete(Noticia noticia)
        {
            this._repositoryBase.Delete(noticia);
        }

        public void Insert(Noticia noticia)
        {
            this._repositoryBase.Insert(noticia);
        }

        public void Update(Noticia noticia)
        {
            this._repositoryBase.Update(noticia);
        }
    }
}
