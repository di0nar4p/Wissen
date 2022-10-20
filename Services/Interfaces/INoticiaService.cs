using Entidades.Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface INoticiaService
    {

        Noticia ConsultaPorId(int id);
        IEnumerable<Noticia> ConsultaTodos();
        void Delete(Noticia noticia);
        void Insert(Noticia noticia);
        void Update(Noticia noticia);
    }
}
