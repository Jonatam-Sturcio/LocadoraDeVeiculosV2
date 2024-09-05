using LocadoraDeVeiculos.Dominio.ModuloVeiculo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LocadoraDeVeiculos.Infra.Orm.ModuloVeiculo;
public class MapeadorVeiculo : IEntityTypeConfiguration<Veiculo>
{
    public void Configure(EntityTypeBuilder<Veiculo> builder)
    {
        builder.ToTable("TBVeiculo");

        builder.Property(v => v.Id)
            .IsRequired()
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(v => v.Modelo)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(v => v.Marca)
            .IsRequired()
            .HasColumnType("varchar(100)");

        builder.Property(v => v.TipoCombustivel)
            .IsRequired()
            .HasColumnType("int");

        builder.Property(v => v.CapacidadeTanque)
            .IsRequired()
            .HasColumnType("int");

        builder.Property(v => v.Foto)
            .HasColumnType("varbinary(max)")
            .HasDefaultValue(Array.Empty<byte>());

        builder.Property(v => v.GrupoVeiculosId)
            .IsRequired()
            .HasColumnType("int");

        builder.HasOne(v => v.GrupoVeiculos)
            .WithMany(g => g.Veiculos)
            .HasForeignKey(v => v.GrupoVeiculosId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
