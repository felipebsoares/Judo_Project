using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TabelaServicoMapping : IEntityTypeConfiguration<TbTabelaServico>
{
    public void Configure(EntityTypeBuilder<TbTabelaServico> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdServico })
            .HasName("PK_TABELA_SERVICOS")
            .IsClustered(false);
        builder.ToTable("TB_TABELA_SERVICOS");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TABELA_SERVICOS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdServico)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_SERVICO");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.Property(e => e.Valor)
            .HasColumnType("money")
            .HasColumnName("VALOR");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbTabelaServicos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TABELA_SERVICOS_CLIENTES");
    }
}