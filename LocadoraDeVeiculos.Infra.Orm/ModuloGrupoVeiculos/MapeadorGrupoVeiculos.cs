﻿using LocadoraDeVeiculos.Dominio.ModuloGrupoVeiculos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloGrupoVeiculos;
public class MapeadorGrupoVeiculos : IEntityTypeConfiguration<GrupoVeiculos>
{
    public void Configure(EntityTypeBuilder<GrupoVeiculos> builder)
    {
        builder.ToTable("TbGrupoVeiculos");

        builder.Property(g => g.Id)
            .IsRequired()
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(g => g.Nome)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(s => s.EmpresaId)
            .HasColumnType("int")
            .HasColumnName("Empresa_Id")
            .IsRequired();

        builder.HasOne(g => g.Empresa)
            .WithMany()
            .HasForeignKey(s => s.EmpresaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
