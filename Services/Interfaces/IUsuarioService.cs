using Entidades.Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IUsuarioService
    {
        Usuario ConsultaPorId(int id);
        IEnumerable<Usuario> ConsultaTodos();
        void Delete(Usuario usuario);
        void Insert(Usuario usuario);
        void Update(Usuario usuario);
    }
}
