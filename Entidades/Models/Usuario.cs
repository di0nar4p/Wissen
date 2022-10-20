using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades.Models
{
    public partial class Usuario
    {
        public int Codigo { get; set; }
        public int CodigoTipoUsuario { get; set; }
        public string Senha { get; set; }
        public IList<Nota> Notas { get; set; }
        public string Matricula { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataExclusao { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
        public TipoUsuario TipoUsuario { get; set; }
    }
}
