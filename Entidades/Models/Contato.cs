using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Models
{
    public class Contato : Modelo
    {
        public int CodUsuario { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public Usuario Usuario { get; set; }
    }
}
