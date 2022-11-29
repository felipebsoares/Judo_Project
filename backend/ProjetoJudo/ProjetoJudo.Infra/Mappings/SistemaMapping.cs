using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class SistemaMapping : IEntityTypeConfiguration<TbSistema>
{
    public void Configure(EntityTypeBuilder<TbSistema> builder)
    {
        builder.HasKey(e => e.IdSistema)
            .HasName("PK_SISTEMA")
            .IsClustered(false);
        builder.ToTable("TB_SISTEMAS");

        builder.Property(e => e.IdSistema)
            .ValueGeneratedNever()
            .HasColumnName("ID_SISTEMA");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.Property(e => e.Versao)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasColumnName("VERSAO");
    }
}