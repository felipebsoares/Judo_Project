using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class ProfissoesMappings : IEntityTypeConfiguration<TbProfisso>
{
    public void Configure(EntityTypeBuilder<TbProfisso> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdProfissao })
            .HasName("PK_PROFISSOES")
            .IsClustered(false);
        builder.ToTable("TB_PROFISSOES");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_PROFISSOES_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdProfissao)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_PROFISSAO");

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
            .WithMany(p => p.TbProfissos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PROFISSOES_CLIENTES");
    }
}