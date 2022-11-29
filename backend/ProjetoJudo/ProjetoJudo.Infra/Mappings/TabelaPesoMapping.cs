using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TabelaPesoMapping : IEntityTypeConfiguration<TbTabelaPeso>
{
    public void Configure(EntityTypeBuilder<TbTabelaPeso> builder)
    {
        builder.ToTable("TB_TABELA_PESOS");

                builder.HasIndex(e => new { e.IdCliente, e.OrdemExibicaoCategoria }, "UK_TABELA_PESOS_ORDENS_EXIBICAO_CATEGORIAS")
                    .IsUnique();

                builder.HasIndex(e => new { e.IdCliente, e.OrdemExibicaoClasse }, "UK_TABELA_PESOS_ORDENS_EXIBICAO_CLASSES")
                    .IsUnique();

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdClasse).HasColumnName("ID_CLASSE");

                builder.Property(e => e.IdCategoria).HasColumnName("ID_CATEGORIA");

                builder.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                builder.Property(e => e.OrdemExibicaoCategoria).HasColumnName("ORDEM_EXIBICAO_CATEGORIA");

                builder.Property(e => e.OrdemExibicaoClasse).HasColumnName("ORDEM_EXIBICAO_CLASSE");

                builder.Property(e => e.PesoFinal).HasColumnName("PESO_FINAL");

                builder.Property(e => e.PesoInicial).HasColumnName("PESO_INICIAL");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTabelaPesos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABELA_PESOS_CLIENTES");

                builder.HasOne(d => d.IdC)
                    .WithMany(p => p.TbTabelaPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdCategoria })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABELA_PESOS_CATEGORIAS");

                builder.HasOne(d => d.IdCl)
                    .WithMany(p => p.TbTabelaPesos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdClasse })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TABELA_PESOS_CLASSES");
    }
}