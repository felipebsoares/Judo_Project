using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesLutasMapping : IEntityTypeConfiguration<TbCompeticoesLuta>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesLuta> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdLuta })
            .HasName("PK_COMPETICOES_LUTAS")
            .IsClustered(false);
        builder.ToTable("TB_COMPETICOES_LUTAS");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                builder.Property(e => e.IdLuta)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_LUTA");

                builder.Property(e => e.DataFinal)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FINAL");

                builder.Property(e => e.DataInicio)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INICIO");

                builder.Property(e => e.IdAtleta1).HasColumnName("ID_ATLETA1");

                builder.Property(e => e.IdAtleta2).HasColumnName("ID_ATLETA2");

                builder.Property(e => e.IdAtletaVencedor).HasColumnName("ID_ATLETA_VENCEDOR");

                builder.Property(e => e.IdChave).HasColumnName("ID_CHAVE");

                builder.Property(e => e.OrdemAtleta1Chave).HasColumnName("ORDEM_ATLETA1_CHAVE");

                builder.Property(e => e.OrdemAtleta2Chave).HasColumnName("ORDEM_ATLETA2_CHAVE");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesLuta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesLutaIds)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta1 })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_ATLETAS1");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesLutaIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta2 })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_ATLETAS2");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbCompeticoesLutaId1s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtletaVencedor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_ATLETAS3");

                builder.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesLuta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_COMPETICOES");

                builder.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbCompeticoesLuta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdChave })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_LUTAS_COMPETICOES_CHAVES");
    }
}