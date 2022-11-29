using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CobrancaMapping : IEntityTypeConfiguration<TbCobranca>
{
    public void Configure(EntityTypeBuilder<TbCobranca> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCobranca })
            .HasName("PK_COBRANCAS")
            .IsClustered(false);
        builder.ToTable("TB_COBRANCAS");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdCobranca)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_COBRANCA");

        builder.Property(e => e.DataCobranca)
            .HasColumnType("date")
            .HasColumnName("DATA_COBRANCA");

        builder.Property(e => e.DataVencimento)
            .HasColumnType("date")
            .HasColumnName("DATA_VENCIMENTO");

        builder.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

        builder.Property(e => e.MesBase)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("MES_BASE")
            .IsFixedLength();

        builder.Property(e => e.Oficio)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasColumnName("OFICIO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.ValorCobranca)
            .HasColumnType("money")
            .HasColumnName("VALOR_COBRANCA");

        builder.Property(e => e.ValorDesconto)
            .HasColumnType("money")
            .HasColumnName("VALOR_DESCONTO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbCobrancas)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COBRANCAS_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbCobrancas)
            .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COBRANCAS_AGREMIACOES");
    }
}