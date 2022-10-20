using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IBoletim
    {
        Entidades.Models.Boletim ConsultaPorId(int id);
        IEnumerable<Entidades.Models.Boletim> ConsultaTodos();
        void Delete(Entidades.Models.Boletim boletim);
        void Insert(Entidades.Models.Boletim boletim);
        void Update(Entidades.Models.Boletim boletim);
    }
}
