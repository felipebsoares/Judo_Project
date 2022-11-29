using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class FaixaMapping : IEntityTypeConfiguration<TbFaixa>
{
    public void Configure(EntityTypeBuilder<TbFaixa> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdFaixa })
            .HasName("PK_FAIXAS")
            .IsClustered(false);
        builder.ToTable("TB_FAIXAS");

        builder.HasIndex(e => new { e.IdCliente, e.OrdemExibicao }, "UK_FAIXAS_ORDENS_EXIBICAO")
            .IsUnique();

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_FAIXAS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdFaixa)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_FAIXA");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.IdadeMinima).HasColumnName("IDADE_MINIMA");

        builder.Property(e => e.MesesCarencia).HasColumnName("MESES_CARENCIA");

        builder.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbFaixas)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_FAIXAS_CLIENTES");
    }
}