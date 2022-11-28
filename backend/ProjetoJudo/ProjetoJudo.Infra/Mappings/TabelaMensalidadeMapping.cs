using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TabelaMensalidadeMapping : IEntityTypeConfiguration<TbTabelasMensalidade>
{
    public void Configure(EntityTypeBuilder<TbTabelasMensalidade> builder)
    {
        builder.ToTable("TB_TABELAS_MENSALIDADES");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTabela)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TABELA");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.ValorMensalidade)
            .HasColumnType("money")
            .HasColumnName("VALOR_MENSALIDADE");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbTabelasMensalidades)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TABELAS_MENSALIDADES_CLIENTES");
    }
}