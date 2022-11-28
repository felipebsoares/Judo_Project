using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class SistemaTipoMensagemMapping : IEntityTypeConfiguration<TbSistemasTiposMensagen>
{
    public void Configure(EntityTypeBuilder<TbSistemasTiposMensagen> builder)
    {
        builder.ToTable("TB_SISTEMAS_TIPOS_MENSAGENS");

        builder.HasIndex(e => new { e.IdSistema, e.Sigla }, "UK_SISTEMAS_TIPOS_MENSAGENS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdSistema).HasColumnName("ID_SISTEMA");

        builder.Property(e => e.IdTipoMensagem)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TIPO_MENSAGEM");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdSistemaNavigation)
            .WithMany(p => p.TbSistemasTiposMensagens)
            .HasForeignKey(d => d.IdSistema)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SISTEMAS_TIPOS_MENSAGENS_SISTEMAS");
    }
}