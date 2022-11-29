using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TabelaAnuidadeConfederacaoMapping : IEntityTypeConfiguration<TbTabelasAnuidadesConfederacao>
{
    public void Configure(EntityTypeBuilder<TbTabelasAnuidadesConfederacao> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdTabela })
            .HasName("PK_TABELAS_ANUIDADES_CONFEDERACAO")
            .IsClustered(false);
        builder.ToTable("TB_TABELAS_ANUIDADES_CONFEDERACAO");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTabela)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TABELA");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.ValorAnuidade)
            .HasColumnType("money")
            .HasColumnName("VALOR_ANUIDADE");

        builder.Property(e => e.ValorRegistro)
            .HasColumnType("money")
            .HasColumnName("VALOR_REGISTRO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbTabelasAnuidadesConfederacaos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TABELAS_ANUIDADES_CONFEDERACAO_CLIENTES");
    }
}