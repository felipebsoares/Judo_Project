using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesChaveMapping : IEntityTypeConfiguration<TbCompeticoesChafe>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesChafe> builder)
    {
        builder.ToTable("TB_COMPETICOES_CHAVES");

                builder.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicaoChave }, "UK_COMPETICOES_CHAVES_ORDENS_EXIBICAO_CHAVES")
                    .IsUnique();

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                builder.Property(e => e.IdChave)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_CHAVE");

                builder.Property(e => e.Descricao)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                builder.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                builder.Property(e => e.IdClasse).HasColumnName("ID_CLASSE");

                builder.Property(e => e.IdFaixaFinal).HasColumnName("ID_FAIXA_FINAL");

                builder.Property(e => e.IdFaixaInicial).HasColumnName("ID_FAIXA_INICIAL");

                builder.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                builder.Property(e => e.OrdemExibicaoChave).HasColumnName("ORDEM_EXIBICAO_CHAVE");

                builder.Property(e => e.PesoRanking).HasColumnName("PESO_RANKING");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesChaves)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_CLIENTES");

                builder.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesChaves)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesChaves)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_SEXOS");

                builder.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbCompeticoesChaves)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdCategoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_CATEGORIAS");

                builder.HasOne(d => d.IdC1)
                    .WithMany(p => p.TbCompeticoesChaves)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdClasse })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_CLASSES");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbCompeticoesChafeIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdFaixaFinal })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_FAIXAS2");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbCompeticoesChafeId1s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdFaixaInicial })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_FAIXAS1");
    }
}