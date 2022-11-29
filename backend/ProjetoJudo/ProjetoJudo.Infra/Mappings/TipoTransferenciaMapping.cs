using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TipoTransferenciaMapping : IEntityTypeConfiguration<TbTiposTransferencia>
{
    public void Configure(EntityTypeBuilder<TbTiposTransferencia> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdTipoTransferencia })
            .HasName("PK_TIPOS_TRANSFERENCIAS")
            .IsClustered(false);
        builder.ToTable("TB_TIPOS_TRANSFERENCIAS");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_TRANSFERENCIAS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTipoTransferencia)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TIPO_TRANSFERENCIA");

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
            .WithMany(p => p.TbTiposTransferencia)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TIPOS_TRANSFERENCIAS_CLIENTES");
    }
}