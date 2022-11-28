using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class PermissoesMapping : IEntityTypeConfiguration<TbPermisso>
{
    public void Configure(EntityTypeBuilder<TbPermisso> builder)
    {
        builder.ToTable("TB_PERMISSOES");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdPerfil).HasColumnName("ID_PERFIL");

        builder.Property(e => e.IdFuncaoMenu).HasColumnName("ID_FUNCAO_MENU");

        builder.Property(e => e.IdTipoOperacao).HasColumnName("ID_TIPO_OPERACAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbPermissos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PERMISSOES_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbPermissos)
            .HasForeignKey(d => new { d.IdCliente, d.IdFuncaoMenu })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PERMISSOES_FUNCOES_MENU");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbPermissos)
            .HasForeignKey(d => new { d.IdCliente, d.IdPerfil })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PERMISSOES_PERFIS");

        builder.HasOne(d => d.Id1)
            .WithMany(p => p.TbPermissos)
            .HasForeignKey(d => new { d.IdCliente, d.IdTipoOperacao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PERMISSOES_TIPOS_OPERACOES");
    }
}