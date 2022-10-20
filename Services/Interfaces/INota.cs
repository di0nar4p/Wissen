using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    interface INota
    {
        Entidades.Models.Nota ConsultaPorId(int id);
        IEnumerable<Entidades.Models.Nota> ConsultaTodos();
        void Delete(Entidades.Models.Nota nota);
        void Insert(Entidades.Models.Nota nota);
        void Update(Entidades.Models.Nota nota);
    }
}
