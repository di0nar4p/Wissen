using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface ITipoUsuario
    {
        Entidades.Models.TipoUsuario ConsultaPorId(int id);
        IEnumerable<Entidades.Models.TipoUsuario> ConsultaTodos();
        void Delete(Entidades.Models.TipoUsuario tipoUsuario);
        void Insert(Entidades.Models.TipoUsuario tipoUsuario);
        void Update(Entidades.Models.TipoUsuario tipoUsuario);
    }
}
