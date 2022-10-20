using Entidades.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Map
{
    public class MapDisciplina
    {
        public MapDisciplina(EntityTypeBuilder<Disciplina> entityFrameworkBuilder)
        {
            entityFrameworkBuilder.HasKey(disciplina => disciplina.Codigo);
        }
    }
}
