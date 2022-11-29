using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticaoMapping : IEntityTypeConfiguration<TbCompetico>
{
    public void Configure(EntityTypeBuilder<TbCompetico> builder)
    {
        builder.ToTable("TB_COMPETICOES");

                builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_COMPETICOES_SIGLAS")
                    .IsUnique();

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdCompeticao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_COMPETICAO");

                builder.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                builder.Property(e => e.DataFinal)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FINAL");

                builder.Property(e => e.DataInicio)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INICIO");

                builder.Property(e => e.Descricao1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO1");

                builder.Property(e => e.Descricao2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO2");

                builder.Property(e => e.IdLocal).HasColumnName("ID_LOCAL");

                builder.Property(e => e.IdTipoCompeticao).HasColumnName("ID_TIPO_COMPETICAO");

                builder.Property(e => e.IdadeMaxima).HasColumnName("IDADE_MAXIMA");

                builder.Property(e => e.IdadeMinima).HasColumnName("IDADE_MINIMA");

                builder.Property(e => e.PesoRanking).HasColumnName("PESO_RANKING");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdLocal })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LOCAIS_COMPETICOES");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_COMPETICOES_TIPO");
    }
}