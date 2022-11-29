using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticaoAreasMapping : IEntityTypeConfiguration<TbCompeticoesArea>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesArea> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdArea })
            .HasName("PK_COMPETICOES_AREAS")
            .IsClustered(false);
        builder.ToTable("TB_COMPETICOES_AREAS");

        builder.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.Sigla }, "UK_COMPETICOES_AREAS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

        builder.Property(e => e.IdArea)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_AREA");

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
            .WithMany(p => p.TbCompeticoesAreas)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_AREAS_CLIENTES");

        builder.HasOne(d => d.IdC)
            .WithMany(p => p.TbCompeticoesAreas)
            .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_AREAS_COMPETICOES");
    }
}