using Entidades.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Map
{
    public class MapUsuario
    {
        public MapUsuario(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(usuario => usuario.Codigo);
            builder.HasOne(usuario => usuario.TipoUsuario);
            builder.HasOne(usuario => usuario.Contato).WithOne(contato => contato.Usuario).HasForeignKey<Contato>(contato => contato.CodUsuario);
            builder.HasOne(usuario => usuario.Endereco).WithOne(endereco => endereco.Usuario).HasForeignKey<Endereco>(endereco => endereco.Codigo);
            builder.HasMany(usuario => usuario.Notas).WithOne(nota => nota.Aluno).HasForeignKey(nota => nota.CodigoUsuario);
        }
    }
}
