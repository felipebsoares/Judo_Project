using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesFaixaMapping : IEntityTypeConfiguration<TbCompeticoesFaixa>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesFaixa> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdFaixa })
            .HasName("PK_COMPETICOES_FAIXAS")
            .IsClustered(false);
        builder.ToTable("TB_COMPETICOES_FAIXAS");

        builder.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicao }, "UK_COMPETICOES_FAIXAS_ORDENS_EXIBICAO")
            .IsUnique();

        builder.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.Sigla }, "UK_COMPETICOES_FAIXAS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

        builder.Property(e => e.IdFaixa)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_FAIXA");

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
            .WithMany(p => p.TbCompeticoesFaixas)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_FAIXAS_CLIENTES");

        builder.HasOne(d => d.IdC)
            .WithMany(p => p.TbCompeticoesFaixas)
            .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_FAIXAS_COMPETICOES");
    }
}