using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class InsencoesAgremiacoesMapping : IEntityTypeConfiguration<TbIsencoesAgremiaco>
{
    public void Configure(EntityTypeBuilder<TbIsencoesAgremiaco> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.DataInicio })
            .HasName("PK_ISENCOES_AGREMIACOES")
            .IsClustered(false);
        builder.ToTable("TB_ISENCOES_AGREMIACOES");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

        builder.Property(e => e.DataInicio)
            .HasColumnType("date")
            .HasColumnName("DATA_INICIO");

        builder.Property(e => e.DataFim)
            .HasColumnType("date")
            .HasColumnName("DATA_FIM");

        builder.Property(e => e.IdTipoIsencaoAgremiacao).HasColumnName("ID_TIPO_ISENCAO_AGREMIACAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbIsencoesAgremiacos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ISENCOES_AGREMIACOES_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbIsencoesAgremiacos)
            .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ISENCOES_AGREMIACOES_AGREMIACOES");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbIsencoesAgremiacos)
            .HasForeignKey(d => new { d.IdCliente, d.IdTipoIsencaoAgremiacao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ISENCOES_AGREMIACOES_TIPOS_ISENCOES_AGREMIACOES");
    }
}