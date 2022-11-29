using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesInscricoesMapping : IEntityTypeConfiguration<TbCompeticoesInscrico>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesInscrico> builder)
    {
        builder.ToTable("TB_COMPETICOES_INSCRICOES");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                builder.Property(e => e.IdInscricao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_INSCRICAO");

                builder.Property(e => e.DataInscricao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_INSCRICAO");

                builder.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                builder.Property(e => e.IdChave).HasColumnName("ID_CHAVE");

                builder.Property(e => e.IdFaixa).HasColumnName("ID_FAIXA");

                builder.Property(e => e.Peso).HasColumnName("PESO");

                builder.Property(e => e.Presente)
                    .IsRequired()
                    .HasColumnName("PRESENTE")
                    .HasDefaultValueSql("((1))");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_AGREMIACOES");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_ATLETAS");

                builder.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_COMPETICOES");

                builder.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdChave })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_COMPETICOES_CHAVES");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbCompeticoesInscricos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdFaixa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_INSCRICOES_COMPETICOES_FAIXAS");
    }
}