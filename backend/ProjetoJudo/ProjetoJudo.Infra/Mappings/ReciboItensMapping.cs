using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class ReciboItensMapping : IEntityTypeConfiguration<TbRecibosIten>
{
    public void Configure(EntityTypeBuilder<TbRecibosIten> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdRecibo, e.IdItemRecibo })
            .HasName("PK_RECIBOS_ITENS")
            .IsClustered(false);
        builder.ToTable("TB_RECIBOS_ITENS");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdRecibo).HasColumnName("ID_RECIBO");

                builder.Property(e => e.IdItemRecibo).HasColumnName("ID_ITEM_RECIBO");

                builder.Property(e => e.IdFormaPagamento).HasColumnName("ID_FORMA_PAGAMENTO");

                builder.Property(e => e.IdServico).HasColumnName("ID_SERVICO");

                builder.Property(e => e.Quantidade).HasColumnName("QUANTIDADE");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.Property(e => e.ValorDesconto)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_DESCONTO");

                builder.Property(e => e.ValorUnitario)
                    .HasColumnType("money")
                    .HasColumnName("VALOR_UNITARIO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbRecibosItens)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_ITENS_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbRecibosItens)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFormaPagamento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_ITENS_FORMAS_PAGAMENTO");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbRecibosItens)
                    .HasForeignKey(d => new { d.IdCliente, d.IdRecibo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_ITENS_RECIBOS");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbRecibosItens)
                    .HasForeignKey(d => new { d.IdCliente, d.IdServico })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RECIBOS_ITENS_SERVICOS");
    }
}