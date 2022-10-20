using Entidades.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Map
{
    public class MapNoticia
    {
        public MapNoticia(EntityTypeBuilder<Noticia> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(noticia => noticia.Codigo);
        }
    }
}
