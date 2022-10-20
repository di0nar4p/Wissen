using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Models
{
    public class Instituicao : Modelo
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
    }
}
