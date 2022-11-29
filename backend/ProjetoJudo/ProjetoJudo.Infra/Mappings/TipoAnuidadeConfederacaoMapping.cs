using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TipoAnuidadeConfederacaoMapping : IEntityTypeConfiguration<TbTiposAnuidadesConfederacao>
{
    public void Configure(EntityTypeBuilder<TbTiposAnuidadesConfederacao> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdTipoAnuidade })
            .HasName("PK_TIPOS_ANUIDADES_CONFEDERACAO")
            .IsClustered(false);
        builder.ToTable("TB_TIPOS_ANUIDADES_CONFEDERACAO");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_ANUIDADES_CONFEDERACAO_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTipoAnuidade)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TIPO_ANUIDADE");

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
            .WithMany(p => p.TbTiposAnuidadesConfederacaos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TIPOS_ANUIDADES_CONFEDERACAO_CLIENTES");
    }
}