using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesPontuacoesMapping : IEntityTypeConfiguration<TbCompeticoesPontuaco>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesPontuaco> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdPontuacao })
            .HasName("PK_COMPETICOES_PONTUACOES")
            .IsClustered(false);
        builder.ToTable("TB_COMPETICOES_PONTUACOES");

        builder.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicao }, "UK_COMPETICOES_PONTUACOES_ORDENS_EXIBICAO")
            .IsUnique();

        builder.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.Sigla }, "UK_COMPETICOES_PONTUACOES_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

        builder.Property(e => e.IdPontuacao)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_PONTUACAO");

        builder.Property(e => e.DscPontuacao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DSC_PONTUACAO");

        builder.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbCompeticoesPontuacos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_PONTUACOES_CLIENTES");

        builder.HasOne(d => d.IdC)
            .WithMany(p => p.TbCompeticoesPontuacos)
            .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_PONTUACOES_COMPETICOES");
    }
}