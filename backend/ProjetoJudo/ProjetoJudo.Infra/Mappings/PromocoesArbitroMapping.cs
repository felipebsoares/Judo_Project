using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class PromocoesArbitroMapping : IEntityTypeConfiguration<TbPromocoesArbitro>
{
    public void Configure(EntityTypeBuilder<TbPromocoesArbitro> builder)
    {
        builder.ToTable("TB_PROMOCOES_ARBITROS");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdArbitro).HasColumnName("ID_ARBITRO");

                builder.Property(e => e.DataPromocao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PROMOCAO");

                builder.Property(e => e.IdNivelArbitroAnterior).HasColumnName("ID_NIVEL_ARBITRO_ANTERIOR");

                builder.Property(e => e.IdNivelArbitroNovo).HasColumnName("ID_NIVEL_ARBITRO_NOVO");

                builder.Property(e => e.IdTipoPromocaoArbitro).HasColumnName("ID_TIPO_PROMOCAO_ARBITRO");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPromocoesArbitros)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ARBITROS_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbPromocoesArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdArbitro })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ARBITROS_ATLETAS");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbPromocoesArbitroIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNivelArbitroAnterior })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ARBITROS_NIVEIS_ARBITROS1");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbPromocoesArbitroId1s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNivelArbitroNovo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ARBITROS_NIVEIS_ARBITROS2");

                builder.HasOne(d => d.Id2)
                    .WithMany(p => p.TbPromocoesArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPromocaoArbitro })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ARBITROS_TIPOS_PROMOCOES_ARBITROS");
    }
}