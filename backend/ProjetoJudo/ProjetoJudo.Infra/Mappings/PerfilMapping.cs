using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class PerfilMapping : IEntityTypeConfiguration<TbPerfi>
{
    public void Configure(EntityTypeBuilder<TbPerfi> builder)
    {
        builder.ToTable("TB_PERFIS");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_PERFIS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdPerfil)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_PERFIL");

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
            .WithMany(p => p.TbPerfis)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PERFIS_CLIENTES");
    }
}