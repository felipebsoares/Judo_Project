using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class FuncoesMenuMapping : IEntityTypeConfiguration<TbFuncoesMenu>
{
    public void Configure(EntityTypeBuilder<TbFuncoesMenu> builder)
    {
        builder.ToTable("TB_FUNCOES_MENU");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_FUNCOES_MENU_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdFuncaoMenu)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_FUNCAO_MENU");

        builder.Property(e => e.Anexo).HasColumnName("ANEXO");

        builder.Property(e => e.Anotacoes).HasColumnName("ANOTACOES");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Foto).HasColumnName("FOTO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbFuncoesMenus)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_FUNCOES_MENU_CLIENTES");
    }
}