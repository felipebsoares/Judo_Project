using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class SexoMapping : IEntityTypeConfiguration<TbSexo>
{
    public void Configure(EntityTypeBuilder<TbSexo> builder)
    {
        builder.ToTable("TB_SEXOS");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasColumnName("SIGLA")
            .IsFixedLength();
    }
}