using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class DesfiliacoesAgremiacoesMapping : IEntityTypeConfiguration<TbDesfiliacoesAgremiaco>
{
    public void Configure(EntityTypeBuilder<TbDesfiliacoesAgremiaco> builder)
    {
        builder.ToTable("TB_DESFILIACOES_AGREMIACOES");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

        builder.Property(e => e.DataDesfiliacao)
            .HasColumnType("date")
            .HasColumnName("DATA_DESFILIACAO");

        builder.Property(e => e.DataRefiliacao)
            .HasColumnType("date")
            .HasColumnName("DATA_REFILIACAO");

        builder.Property(e => e.IdTipoDesfiliacaoAgremiacao).HasColumnName("ID_TIPO_DESFILIACAO_AGREMIACAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbDesfiliacoesAgremiacos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_DESFILIACOES_AGREMIACOES_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbDesfiliacoesAgremiacos)
            .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_DESFILIACOES_AGREMIACOES_AGREMIACOES");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbDesfiliacoesAgremiacos)
            .HasForeignKey(d => new { d.IdCliente, d.IdTipoDesfiliacaoAgremiacao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_DESFILIACOES_AGREMIACOES_TIPOS_DESFILIACOES_AGREMIACOES");
    }
}