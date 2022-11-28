using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class MensalidadeMapping : IEntityTypeConfiguration<TbMensalidade>
{
    public void Configure(EntityTypeBuilder<TbMensalidade> builder)
    {
        builder.ToTable("TB_MENSALIDADES");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

                builder.Property(e => e.MesBase)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MES_BASE")
                    .IsFixedLength();

                builder.Property(e => e.DataPagamento).HasColumnName("DATA_PAGAMENTO");

                builder.Property(e => e.IdTabelaMensalidades).HasColumnName("ID_TABELA_MENSALIDADES");

                builder.Property(e => e.IdTipoPagamento).HasColumnName("ID_TIPO_PAGAMENTO");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.Property(e => e.ValorDesconto)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO");

                builder.Property(e => e.ValorPago)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_PAGO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbMensalidades)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MENSALIDADES_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbMensalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MENSALIDADES_AGREMIACOES");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbMensalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTabelaMensalidades })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MENSALIDADES_TABELAS_MENSALIDADES");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbMensalidades)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoPagamento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MENSALIDADES_TIPOS_PAGAMENTOS_MENSALIDADES");
    }
}