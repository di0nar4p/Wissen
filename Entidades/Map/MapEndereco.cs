using Entidades.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Map
{
    public class MapEndereco
    {
        public MapEndereco(EntityTypeBuilder<Endereco> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(endereco => endereco.Codigo);
            entityTypeBuilder.HasOne(endereco => endereco.Usuario).WithOne(usuario => usuario.Endereco);
        }
    }
}
