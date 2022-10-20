using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Models
{
    public class TipoUsuario : Modelo
    {
        public string Nome { get; set; }
        public IList<Usuario> Usuarios { get; set; }
    }
}
