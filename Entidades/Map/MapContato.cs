using Entidades.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Map
{
    class MapContato
    {

        public MapContato(EntityTypeBuilder<Contato> builder)
        {
            builder.HasKey(contato => contato.Codigo);
            builder.HasOne(contato => contato.Usuario).WithOne(usuario => usuario.Contato).HasForeignKey<Contato>(contato => contato.CodUsuario);
        }
    }
}