using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class SistemaMensagemMapping : IEntityTypeConfiguration<TbSistemasMensagen>
{
    public void Configure(EntityTypeBuilder<TbSistemasMensagen> builder)
    {
        builder.HasKey(e => new { e.IdSistema, e.IdMensagem })
            .HasName("PK_SISTEMAS_MENSAGENS")
            .IsClustered(false);
        builder.ToTable("TB_SISTEMAS_MENSAGENS");

        builder.HasIndex(e => new { e.IdSistema, e.Sigla }, "UK_SISTEMAS_MENSAGENS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdSistema).HasColumnName("ID_SISTEMA");

        builder.Property(e => e.IdMensagem)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_MENSAGEM");

        builder.Property(e => e.Descricao)
            .HasMaxLength(80)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.IdTipoMensagem).HasColumnName("ID_TIPO_MENSAGEM");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdSistemaNavigation)
            .WithMany(p => p.TbSistemasMensagens)
            .HasForeignKey(d => d.IdSistema)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SISTEMAS_MENSAGENS_SISTEMAS");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbSistemasMensagens)
            .HasForeignKey(d => new { d.IdSistema, d.IdTipoMensagem })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SISTEMAS_MENSAGENS_SISTEMAS_TIPOS_MENSAGENS");
    }
}