using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CurriculoAgremiacao : IEntityTypeConfiguration<TbCurriculosAgremiaco>
{
    public void Configure(EntityTypeBuilder<TbCurriculosAgremiaco> builder)
    {
        builder.ToTable("TB_CURRICULOS_AGREMIACOES");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

        builder.Property(e => e.DataEvento)
            .HasColumnType("date")
            .HasColumnName("DATA_EVENTO");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.IdTipoCurriculoAgremiacao).HasColumnName("ID_TIPO_CURRICULO_AGREMIACAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbCurriculosAgremiacos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CURRICULOS_AGREMIACOES_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbCurriculosAgremiacos)
            .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CURRICULOS_AGREMIACOES_AGREMIACOES");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbCurriculosAgremiacos)
            .HasForeignKey(d => new { d.IdCliente, d.IdTipoCurriculoAgremiacao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CURRICULOS_AGREMIACOES_TIPOS_CURRICULOS_AGREMIACOES");
    }
}