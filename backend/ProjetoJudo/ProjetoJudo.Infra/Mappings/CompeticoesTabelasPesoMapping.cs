using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesTabelasPesoMapping : IEntityTypeConfiguration<TbCompeticoesTabelasPeso>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesTabelasPeso> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdClasse, e.IdCategoria })
            .HasName("PK_COMPETICOES_TABELAS_PESOS")
            .IsClustered(false);
        builder.ToTable("TB_COMPETICOES_TABELAS_PESOS");

                builder.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicaoCategoria }, "UK_COMPETICOES_TABELAS_PESOS_ORDENS_EXIBICAO_CATEGORIAS")
                    .IsUnique();

                builder.HasIndex(e => new { e.IdCliente, e.IdCompeticao, e.OrdemExibicaoClasse }, "UK_COMPETICOES_TABELAS_PESOS_ORDENS_EXIBICAO_CLASSES")
                    .IsUnique();

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

                builder.Property(e => e.IdClasse).HasColumnName("ID_CLASSE");

                builder.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                builder.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                builder.Property(e => e.OrdemExibicaoCategoria).HasColumnName("ORDEM_EXIBICAO_CATEGORIA");

                builder.Property(e => e.OrdemExibicaoClasse).HasColumnName("ORDEM_EXIBICAO_CLASSE");

                builder.Property(e => e.PesoFinal).HasColumnName("PESO_FINAL");

                builder.Property(e => e.PesoInicial).HasColumnName("PESO_INICIAL");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbCompeticoesTabelasPesos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_CLIENTES");

                builder.HasOne(d => d.IdC)
                    .WithMany(p => p.TbCompeticoesTabelasPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_COMPETICOES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbCompeticoesTabelasPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_SEXOS");

                builder.HasOne(d => d.IdCNavigation)
                    .WithMany(p => p.TbCompeticoesTabelasPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdCategoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_COMPETICOES_CATEGORIAS");

                builder.HasOne(d => d.IdC1)
                    .WithMany(p => p.TbCompeticoesTabelasPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdClasse })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_COMPETICOES_CLASSES");
    }
}