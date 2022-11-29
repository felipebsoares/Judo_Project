using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesResultadosMapping : IEntityTypeConfiguration<TbCompeticoesResultado>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesResultado> builder)
    {
        builder.ToTable("TB_COMPETICOES_RESULTADOS");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                builder.Property(e => e.IdChave).HasColumnName("ID_CHAVE");

                builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                builder.Property(e => e.Colocacao).HasColumnName("COLOCACAO");

                builder.Property(e => e.DataResultado)
                    .HasColumnType("date")
                    .HasColumnName("DATA_RESULTADO");

                builder.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesResultados)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_RESULTADOS_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesResultados)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_RESULTADOS_ATLETAS");

                builder.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesResultados)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_RESULTADOS_COMPETICOES");

                builder.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbCompeticoesResultados)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdChave })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_RESULTADOS_CHAVES");
    }
}