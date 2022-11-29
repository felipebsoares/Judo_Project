using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CurriculoAtletaMapping : IEntityTypeConfiguration<TbCurriculosAtleta>
{
    public void Configure(EntityTypeBuilder<TbCurriculosAtleta> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataEvento })
            .HasName("PK_CURRICULOS_ATLETAS")
            .IsClustered(false);
        builder.ToTable("TB_CURRICULOS_ATLETAS");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

        builder.Property(e => e.DataEvento)
            .HasColumnType("date")
            .HasColumnName("DATA_EVENTO");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.IdTipoCurriculoAtleta).HasColumnName("ID_TIPO_CURRICULO_ATLETA");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbCurriculosAtleta)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CURRICULOS_ATLETAS_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbCurriculosAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CURRICULOS_ATLETAS_ATLETAS");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbCurriculosAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdTipoCurriculoAtleta })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CURRICULOS_ATLETAS_TIPOS_CURRICULOS_ATLETAS");
    }
}