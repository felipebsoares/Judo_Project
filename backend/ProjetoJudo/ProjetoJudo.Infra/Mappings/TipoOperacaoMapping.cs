using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TipoOperacaoMapping : IEntityTypeConfiguration<TbTiposOperaco>
{
    public void Configure(EntityTypeBuilder<TbTiposOperaco> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdTipoOperacao })
            .HasName("PK_TIPOS_OPERACOES")
            .IsClustered(false);
        builder.ToTable("TB_TIPOS_OPERACOES");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_OPERACOES_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTipoOperacao)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TIPO_OPERACAO");

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
            .WithMany(p => p.TbTiposOperacos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TIPOS_OPERACOES_CLIENTES");
    }
}