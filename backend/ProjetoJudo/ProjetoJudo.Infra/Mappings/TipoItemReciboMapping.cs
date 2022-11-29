using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TipoItemReciboMapping : IEntityTypeConfiguration<TbTiposItensRecibo>
{
    public void Configure(EntityTypeBuilder<TbTiposItensRecibo> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdTipoItem })
            .HasName("PK_TIPOS_ITENS_RECIBOS")
            .IsClustered(false);
        builder.ToTable("TB_TIPOS_ITENS_RECIBOS");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_ITENS_RECIBOS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTipoItem)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TIPO_ITEM");

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
            .WithMany(p => p.TbTiposItensRecibos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TIPOS_ITENS_RECIBOS_CLIENTES");
    }
}