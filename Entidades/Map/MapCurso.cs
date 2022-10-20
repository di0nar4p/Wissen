using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Entidades.Models;

namespace Entidades.Map
{
        public class MapCurso
    {
        public MapCurso(EntityTypeBuilder <Curso> builder)
        {
            builder.HasKey(curso => curso.Codigo);
           
        }
    }
}
