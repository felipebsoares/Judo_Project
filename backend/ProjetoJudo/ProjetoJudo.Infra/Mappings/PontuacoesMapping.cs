using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class PontuacoesMapping : IEntityTypeConfiguration<TbPontuaco>
{
    public void Configure(EntityTypeBuilder<TbPontuaco> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdPontuacao })
            .HasName("PK_PONTUACOES")
            .IsClustered(false);
        builder.ToTable("TB_PONTUACOES");

        builder.HasIndex(e => new { e.IdCliente, e.OrdemExibicao }, "UK_PONTUACOES_ORDENS_EXIBICAO")
            .IsUnique();

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_PONTUACOES_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdPontuacao)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_PONTUACAO");

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
            .WithMany(p => p.TbPontuacos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PONTUACOES_CLIENTES");
    }
}