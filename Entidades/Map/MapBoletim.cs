using Entidades.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Map
{
    public class MapBoletim
    {
        public MapBoletim(EntityTypeBuilder<Boletim> entityTypeBuilder)
        {

            entityTypeBuilder.HasKey(boletim => boletim.Codigo);
            
        }
    }
}
