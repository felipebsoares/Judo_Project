using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class PromocoesAtletaMapping : IEntityTypeConfiguration<TbPromocoesAtleta>
{
    public void Configure(EntityTypeBuilder<TbPromocoesAtleta> builder)
    {
        builder.ToTable("TB_PROMOCOES_ATLETAS");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                builder.Property(e => e.DataPromocao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_PROMOCAO");

                builder.Property(e => e.IdFaixaAnterior).HasColumnName("ID_FAIXA_ANTERIOR");

                builder.Property(e => e.IdFaixaNova).HasColumnName("ID_FAIXA_NOVA");

                builder.Property(e => e.IdTipoPromocaoAtleta).HasColumnName("ID_TIPO_PROMOCAO_ATLETA");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbPromocoesAtleta)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ATLETAS_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbPromocoesAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ATLETAS_ATLETAS");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbPromocoesAtletaIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFaixaAnterior })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ATLETAS_FAIXAS1");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbPromocoesAtletaId1s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFaixaNova })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ATLETAS_FAIXAS2");

                builder.HasOne(d => d.Id2)
                    .WithMany(p => p.TbPromocoesAtleta)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPromocaoAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROMOCOES_ATLETAS_TIPOS_PROMOCOES_ATLETAS");
    }
}