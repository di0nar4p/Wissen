using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {

        private DbSet<T> _entities;
        private readonly ApplicationContext _context;

        public RepositoryBase(ApplicationContext applicationContext)
        {
            this._context = applicationContext;
            this._entities = applicationContext.Set<T>();
        }


        public void Delete(T entity)
        {
            this._entities.Remove(entity);
        }

        public T Get(int id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            IEnumerable<T> query = this._entities;
            return query.ToList();
        }
        
        public void Insert(T entity)
        {
            this._entities.Add(entity);
        }

        public void Update(T entity)
        {
            this._entities.Update(entity);
        }
    }
}
