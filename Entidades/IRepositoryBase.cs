using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    /*
    *   Interface que representa ações nas tables,
    *   tipando com a classe super gênerica <T>
    */
    public interface IRepositoryBase<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
