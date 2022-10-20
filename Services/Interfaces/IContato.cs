using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
   public interface IContato
    {
        Entidades.Models.Contato ConsultaPorId(int id);
        IEnumerable<Entidades.Models.Contato> ConsultaTodos();
        void Delete (Entidades.Models.Contato contato);
        void Insert (Entidades.Models.Contato contato);
        void Update(Entidades.Models.Contato contato);
    }
}
