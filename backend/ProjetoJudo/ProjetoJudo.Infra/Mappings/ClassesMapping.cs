using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class ClassesMapping : IEntityTypeConfiguration<TbClass>
{
    public void Configure(EntityTypeBuilder<TbClass> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdClasse })
            .HasName("PK_CLASSES")
            .IsClustered(false);
        builder.ToTable("TB_CLASSES");

                builder.HasIndex(e => new { e.IdCliente, e.OrdemExibicao }, "UK_CLASSES_ORDENS_EXIBICAO")
                    .IsUnique();

                builder.HasIndex(e => new { e.IdCliente, e.Sigla, e.IdSexo }, "UK_CLASSES_SIGLAS")
                    .IsUnique();

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdClasse)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CLASSE");

                builder.Property(e => e.Descricao1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO1");

                builder.Property(e => e.Descricao2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO2");

                builder.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                builder.Property(e => e.IdadeFinal).HasColumnName("IDADE_FINAL");

                builder.Property(e => e.IdadeInicial).HasColumnName("IDADE_INICIAL");

                builder.Property(e => e.OrdemExibicao).HasColumnName("ORDEM_EXIBICAO");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbClasses)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLASSES_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbClasses)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CLASSES_SEXOS");
    }
}