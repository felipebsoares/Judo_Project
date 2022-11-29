using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class UsuarioMapping : IEntityTypeConfiguration<TbUsuario>
{
    public void Configure(EntityTypeBuilder<TbUsuario> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdUsuario })
            .HasName("PK_USUARIOS")
            .IsClustered(false);
        builder.ToTable("TB_USUARIOS");

                builder.HasIndex(e => new { e.IdCliente, e.LoginUsuario }, "UK_USUARIOS_LOGIN_USUARIO")
                    .IsUnique();

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdUsuario)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_USUARIO");

                builder.Property(e => e.DataCriacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_CRIACAO");

                builder.Property(e => e.DataExpiracao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_EXPIRACAO");

                builder.Property(e => e.DataUltimoLogin)
                    .HasColumnType("date")
                    .HasColumnName("DATA_ULTIMO_LOGIN");

                builder.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                builder.Property(e => e.LoginUsuario)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("LOGIN_USUARIO");

                builder.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.Property(e => e.Senha)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("SENHA");

                builder.Property(e => e.Situacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SITUACAO")
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength();

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbUsuarios)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIOS_CLIENTES");
    }
}