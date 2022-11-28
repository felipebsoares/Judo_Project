using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CidadesMapping : IEntityTypeConfiguration<TbCidade>
{
    public void Configure(EntityTypeBuilder<TbCidade> builder)
    {
        builder.ToTable("TB_CIDADES");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdPais).HasColumnName("ID_PAIS");

        builder.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

        builder.Property(e => e.IdCidade)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_CIDADE");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbCidades)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CIDADES_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbCidades)
            .HasForeignKey(d => new { d.IdCliente, d.IdPais })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CIDADES_PAIS");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbCidades)
            .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CIDADES_ESTADOS");
    }
}