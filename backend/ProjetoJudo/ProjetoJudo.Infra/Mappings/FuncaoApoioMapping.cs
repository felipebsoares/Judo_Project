using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class FuncaoApoioMapping : IEntityTypeConfiguration<TbFuncoesApoio>
{
    public void Configure(EntityTypeBuilder<TbFuncoesApoio> builder)
    {
        builder.ToTable("TB_FUNCOES_APOIO");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_FUNCOES_APOIO_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdFuncao)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_FUNCAO");

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
            .WithMany(p => p.TbFuncoesApoios)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_FUNCOES_APOIO_CLIENTES");
    }
}