using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesTiposMapping : IEntityTypeConfiguration<TbCompeticoesTipo>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesTipo> builder)
    {
        builder.ToTable("TB_COMPETICOES_TIPOS");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_COMPETICOES_TIPOS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTipoCompeticao)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TIPO_COMPETICAO");

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
            .WithMany(p => p.TbCompeticoesTipos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_TIPOS_CLIENTES");
    }
}