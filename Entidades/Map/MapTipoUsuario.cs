using Entidades.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Map
{
    public class MapTipoUsuario
    {
        public MapTipoUsuario(EntityTypeBuilder<TipoUsuario> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(tipoUsuario => tipoUsuario.Codigo);
            entityTypeBuilder.HasMany(tipoUsuario => tipoUsuario.Usuarios).WithOne(usuario => usuario.TipoUsuario).HasForeignKey(usuario => usuario.CodigoTipoUsuario);
        }
    }
}
