using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TipoPromocaoAtletaMapping : IEntityTypeConfiguration<TbTiposPromocoesAtleta>
{
    public void Configure(EntityTypeBuilder<TbTiposPromocoesAtleta> builder)
    {
        builder.ToTable("TB_TIPOS_PROMOCOES_ATLETAS");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_PROMOCOES_ATLETAS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTipoPromocao)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TIPO_PROMOCAO");

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
            .WithMany(p => p.TbTiposPromocoesAtleta)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TIPOS_PROMOCOES_ATLETAS_CLIENTES");
    }
}