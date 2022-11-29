using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesPenalidadesMapping : IEntityTypeConfiguration<TbCompeticoesPenalidade>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesPenalidade> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdPenalidade })
            .HasName("PK_COMPETICOES_PENALIDADES")
            .IsClustered(false);
        builder.ToTable("TB_COMPETICOES_PENALIDADES");

        builder.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicao }, "UK_COMPETICOES_PENALIDADES_ORDENS_EXIBICAO")
            .IsUnique();

        builder.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.Sigla }, "UK_COMPETICOES_PENALIDADES_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

        builder.Property(e => e.IdPenalidade)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_PENALIDADE");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbCompeticoesPenalidades)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_PENALIDADES_CLIENTES");

        builder.HasOne(d => d.IdC)
            .WithMany(p => p.TbCompeticoesPenalidades)
            .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_PENALIDADES_COMPETICOES");
    }
}