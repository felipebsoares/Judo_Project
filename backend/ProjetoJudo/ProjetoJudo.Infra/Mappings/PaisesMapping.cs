using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class PaisesMapping : IEntityTypeConfiguration<TbPaise>
{
    public void Configure(EntityTypeBuilder<TbPaise> builder)
    {
        builder.ToTable("TB_PAISES");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla2 }, "UK_PAISES_SIGLAS_2")
            .IsUnique();

        builder.HasIndex(e => new { e.IdCliente, e.Sigla3 }, "UK_PAISES_SIGLAS_3")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdPais)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_PAIS");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Nacionalidade)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasColumnName("NACIONALIDADE");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla2)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasColumnName("SIGLA_2");

        builder.Property(e => e.Sigla3)
            .HasMaxLength(3)
            .IsUnicode(false)
            .HasColumnName("SIGLA_3");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbPaises)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PAISES_CLIENTES");
    }
}