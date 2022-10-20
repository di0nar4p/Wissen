using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Models
{
    public class Endereco : Modelo
    {
        public int CodigoUsuario { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string UF { get; set; }
        public Usuario Usuario { get; set; }
    }
}
