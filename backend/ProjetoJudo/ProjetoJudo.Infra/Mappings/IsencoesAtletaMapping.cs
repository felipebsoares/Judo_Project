using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class IsencoesAtletaMapping : IEntityTypeConfiguration<TbIsencoesAtleta>
{
    public void Configure(EntityTypeBuilder<TbIsencoesAtleta> builder)
    {
        builder.ToTable("TB_ISENCOES_ATLETAS");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

        builder.Property(e => e.DataInicio)
            .HasColumnType("date")
            .HasColumnName("DATA_INICIO");

        builder.Property(e => e.DataFim)
            .HasColumnType("date")
            .HasColumnName("DATA_FIM");

        builder.Property(e => e.IdTipoIsencaoAtleta).HasColumnName("ID_TIPO_ISENCAO_ATLETA");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbIsencoesAtleta)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ISENCOES_ATLETAS_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbIsencoesAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ISENCOES_ATLETAS_ATLETAS");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbIsencoesAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdTipoIsencaoAtleta })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ISENCOES_ATLETAS_TIPOS_ISENCOES_ATLETAS");
    }
}