using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TiposDesfiliacaoAgremiacaoMapping : IEntityTypeConfiguration<TbTiposDesfiliacoesAgremiaco>
{
    public void Configure(EntityTypeBuilder<TbTiposDesfiliacoesAgremiaco> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdTipoDesfiliacaoAgremiacao })
            .HasName("PK_TIPOS_DESFILIACOES_AGREMIACOES")
            .IsClustered(false);
        builder.ToTable("TB_TIPOS_DESFILIACOES_AGREMIACOES");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_DESFILIACOES_AGREMIACOES_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTipoDesfiliacaoAgremiacao)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TIPO_DESFILIACAO_AGREMIACAO");

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
            .WithMany(p => p.TbTiposDesfiliacoesAgremiacos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TIPOS_DESFILIACOES_AGREMIACOES_CLIENTES");
    }
}