﻿using drakaysa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace drakaysa.Data.Mapping
{
    public class PacientePlanoMap : IEntityTypeConfiguration<PacientePlano>
    {
        public void Configure(EntityTypeBuilder<PacientePlano> builder)
        {
            builder.ToTable("PacientePlanos");

            builder.HasKey(p => new { p.IdPlano, p.IdPaciente });

            builder.Property(p => p.IdPaciente)
                .IsRequired();

            builder.Property(p => p.IdPlano)
                .IsRequired();

            builder.Property(p => p.PlanoAtivo)
                .HasColumnName("PlanoAtivo")
                .HasColumnType("BIT")
                .IsRequired();

            builder.HasOne(x => x.Paciente)
                .WithMany();

            builder.HasOne(p => p.Paciente)
                .WithMany(p => p.PacientePlanos)
                .HasForeignKey(p => p.IdPaciente)
                .OnDelete(DeleteBehavior.Restrict); // Restrict especifica que ao excluir o pai, o filho não será excluído.

            builder.HasOne(p => p.Plano)
                .WithMany(p => p.PacientePlanos)
                .HasForeignKey(p => p.IdPlano)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
