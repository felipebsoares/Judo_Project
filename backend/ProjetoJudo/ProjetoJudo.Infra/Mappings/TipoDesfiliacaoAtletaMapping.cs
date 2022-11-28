using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TipoDesfiliacaoAtletaMapping : IEntityTypeConfiguration<TbTiposDesfiliacoesAtleta>
{
    public void Configure(EntityTypeBuilder<TbTiposDesfiliacoesAtleta> builder)
    {
        builder.ToTable("TB_TIPOS_DESFILIACOES_ATLETAS");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_DESFILIACOES_ATLETAS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTipoDesfiliacaoAtleta)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TIPO_DESFILIACAO_ATLETA");

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
            .WithMany(p => p.TbTiposDesfiliacoesAtleta)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TIPOS_DESFILIACOES_ATLETAS_CLIENTES");
    }
}