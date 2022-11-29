using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesLutasPenalidadesMapping : IEntityTypeConfiguration<TbCompeticoesLutasPenalidade>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesLutasPenalidade> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdLuta, e.Tempo })
            .HasName("PK_COMPETICOES_LUTAS_PENALIDADES")
            .IsClustered(false);
        builder.ToTable("TB_COMPETICOES_LUTAS_PENALIDADES");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                builder.Property(e => e.IdLuta).HasColumnName("ID_LUTA");

                builder.Property(e => e.Tempo).HasColumnName("TEMPO");

                builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                builder.Property(e => e.IdPenalidade).HasColumnName("ID_PENALIDADE");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesLutasPenalidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesLutasPenalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_ATLETAS");

                builder.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesLutasPenalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_COMPETICOES");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesLutasPenalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdLuta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_LUTAS");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbCompeticoesLutasPenalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdPenalidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_COMPETICOES_PENALIDADES");
    }
}