using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TipoPromocoesArbitroMapping : IEntityTypeConfiguration<TbTiposPromocoesArbitro>
{
    public void Configure(EntityTypeBuilder<TbTiposPromocoesArbitro> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdTipoPromocao })
            .HasName("PK_TIPOS_PROMOCOES_ARBITROS")
            .IsClustered(false);
        
        builder.ToTable("TB_TIPOS_PROMOCOES_ARBITROS");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_PROMOCOES_ARBITROS_SIGLAS")
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
            .WithMany(p => p.TbTiposPromocoesArbitros)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TIPOS_PROMOCOES_ARBITROS_CLIENTES");
    }
}