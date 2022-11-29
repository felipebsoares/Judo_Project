using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class DesfiliacoesAtletaMapping : IEntityTypeConfiguration<TbDesfiliacoesAtleta>
{
    public void Configure(EntityTypeBuilder<TbDesfiliacoesAtleta> builder)
    {
        builder.ToTable("TB_DESFILIACOES_ATLETAS");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

        builder.Property(e => e.DataDesfiliacao)
            .HasColumnType("date")
            .HasColumnName("DATA_DESFILIACAO");

        builder.Property(e => e.DataRefiliacao)
            .HasColumnType("date")
            .HasColumnName("DATA_REFILIACAO");

        builder.Property(e => e.IdTipoDesfiliacaoAtleta).HasColumnName("ID_TIPO_DESFILIACAO_ATLETA");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbDesfiliacoesAtleta)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_DESFILIACOES_ATLETAS_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbDesfiliacoesAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_DESFILIACOES_ATLETAS_ATLETAS");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbDesfiliacoesAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdTipoDesfiliacaoAtleta })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_DESFILIACOES_ATLETAS_TIPOS_DESFILIACOES_ATLETAS");
    }
}