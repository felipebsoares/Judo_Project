using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class NiveisArbitrosMapping : IEntityTypeConfiguration<TbNiveisArbitro>
{
    public void Configure(EntityTypeBuilder<TbNiveisArbitro> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdNivelArbitro })
            .HasName("PK_NIVEIS_ARBITROS")
            .IsClustered(false);
        builder.ToTable("TB_NIVEIS_ARBITROS");

        builder.HasIndex(e => new { e.IdCliente, e.OrdemExibicao }, "UK_NIVEIS_ARBITROS_ORDENS_EXIBICAO")
            .IsUnique();

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_NIVEIS_ARBITROS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdNivelArbitro)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_NIVEL_ARBITRO");

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
            .WithMany(p => p.TbNiveisArbitros)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_NIVEIS_ARBITROS_CLIENTES");
    }
}