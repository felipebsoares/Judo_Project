using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TipoPagamentoAnuidadeMapping : IEntityTypeConfiguration<TbTiposPagamentosAnuidade>
{
    public void Configure(EntityTypeBuilder<TbTiposPagamentosAnuidade> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdTipoPagamento })
            .HasName("PK_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO")
            .IsClustered(false);
        builder.ToTable("TB_TIPOS_PAGAMENTOS_ANUIDADES");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_PAGAMENTOS_ANUIDADES_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTipoPagamento)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TIPO_PAGAMENTO");

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
            .WithMany(p => p.TbTiposPagamentosAnuidades)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TIPOS_PAGAMENTOS_ANUIDADES_CLIENTES");
    }
}