using Entidades.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


namespace Entidades.Map
{
    class MapNota
    {
        public MapNota(EntityTypeBuilder<Nota> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(nota => nota.Codigo);
            entityTypeBuilder.HasOne(nota => nota.Aluno).WithMany(aluno => aluno.Notas).HasForeignKey(nota => nota.CodigoUsuario);
            entityTypeBuilder.HasOne(nota => nota.Boletim).WithOne(boletim => boletim.Nota).HasForeignKey<Boletim>(boletim => boletim.CodigoNota);
            entityTypeBuilder.HasOne(nota => nota.Disciplina).WithOne(disciplina => disciplina.Nota).HasForeignKey<Nota>(nota => nota.CodigoDisciplina);

        }
    }
}
