using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class EmissoresIdentidadeMapping : IEntityTypeConfiguration<TbEmissoresIdentidade>
{
    public void Configure(EntityTypeBuilder<TbEmissoresIdentidade> builder)
    {
        builder.ToTable("TB_EMISSORES_IDENTIDADES");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_EMISSORES_IDENTIDADES_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdEmissor)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_EMISSOR");

        builder.Property(e => e.Descricao)
            .HasMaxLength(80)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbEmissoresIdentidades)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_EMISSORES_IDENTIDADES_CLIENTES");
    }
}