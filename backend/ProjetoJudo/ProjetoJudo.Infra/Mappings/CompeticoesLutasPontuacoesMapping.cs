using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesLutasPontuacoesMapping : IEntityTypeConfiguration<TbCompeticoesLutasPontuaco>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesLutasPontuaco> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdLuta, e.Tempo })
            .HasName("PK_COMPETICOES_LUTAS_PONTUACOES")
            .IsClustered(false);
        builder.ToTable("TB_COMPETICOES_LUTAS_PONTUACOES");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                builder.Property(e => e.IdLuta).HasColumnName("ID_LUTA");

                builder.Property(e => e.Tempo).HasColumnName("TEMPO");

                builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                builder.Property(e => e.IdPontuacao).HasColumnName("ID_PONTUACAO");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesLutasPontuacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesLutasPontuacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_ATLETAS");

                builder.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesLutasPontuacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_COMPETICOES");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesLutasPontuacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdLuta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_LUTAS");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbCompeticoesLutasPontuacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdPontuacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_COMPETICOES_PONTUACOES");
    }
}