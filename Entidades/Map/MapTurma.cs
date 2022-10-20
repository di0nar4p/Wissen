using Entidades.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Map
{
    class MapTurma
    {
        public MapTurma(EntityTypeBuilder<Turma> builder)
        {
            builder.HasKey(turma => turma.CodCurso);
            
        }
    }
}
