using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class PenalidadeMapping : IEntityTypeConfiguration<TbPenalidade>
{
    public void Configure(EntityTypeBuilder<TbPenalidade> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdPenalidade })
            .HasName("PK_PENALIDADES")
            .IsClustered(false);
        builder.ToTable("TB_PENALIDADES");

        builder.HasIndex(e => new { e.IdCliente, e.OrdemExibicao }, "UK_PENALIDADES_ORDENS_EXIBICAO")
            .IsUnique();

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_PENALIDADES_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

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
            .WithMany(p => p.TbPenalidades)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PENALIDADES_CLIENTES");
    }
}