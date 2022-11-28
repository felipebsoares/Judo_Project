using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CLientesMapping : IEntityTypeConfiguration<TbCliente>
{
    public void Configure(EntityTypeBuilder<TbCliente> builder)
    {
        builder.ToTable("TB_CLIENTES");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdSistema).HasColumnName("ID_SISTEMA");

        builder.Property(e => e.Nome)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("NOME");

        builder.Property(e => e.PastaArquivos)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("PASTA_ARQUIVOS");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdSistemaNavigation)
            .WithMany(p => p.TbClientes)
            .HasForeignKey(d => d.IdSistema)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CLIENTES_SISTEMAS");
    }
}