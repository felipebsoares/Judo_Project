using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class PerfilUsuarioMapping : IEntityTypeConfiguration<TbPerfisUsuario>
{
    public void Configure(EntityTypeBuilder<TbPerfisUsuario> builder)
    {
        builder.ToTable("TB_PERFIS_USUARIOS");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdPerfil).HasColumnName("ID_PERFIL");

        builder.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbPerfisUsuarios)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PERFIS_USUARIOS_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbPerfisUsuarios)
            .HasForeignKey(d => new { d.IdCliente, d.IdPerfil })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PERFIS_USUARIOS_PERFIS");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbPerfisUsuarios)
            .HasForeignKey(d => new { d.IdCliente, d.IdUsuario })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_PERFIS_USUARIOS_USUARIOS");
    }
}