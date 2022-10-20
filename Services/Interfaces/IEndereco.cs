using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IEndereco
    {
        Entidades.Models.Endereco ConsultaPorId(int id);
        IEnumerable<Entidades.Models.Endereco> ConsultaTodos();
        void Delete(Entidades.Models.Endereco endereco);
        void Insert(Entidades.Models.Endereco endereco);
        void Update(Entidades.Models.Endereco endereco);
    }
}
