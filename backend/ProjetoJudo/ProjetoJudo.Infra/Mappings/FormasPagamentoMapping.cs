using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class FormasPagamentoMapping : IEntityTypeConfiguration<TbFormasPagamento>
{
    public void Configure(EntityTypeBuilder<TbFormasPagamento> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdFormaPagamento })
            .HasName("PK_FORMAS_PAGAMENTOS")
            .IsClustered(false);
        builder.ToTable("TB_FORMAS_PAGAMENTOS");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_FORMAS_PAGAMENTOS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdFormaPagamento)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_FORMA_PAGAMENTO");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbFormasPagamentos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_FORMAS_PAGAMENTOS_CLIENTES");
    }
}