using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class RegistroEventoMapping : IEntityTypeConfiguration<TbRegistroEvento>
{
    public void Configure(EntityTypeBuilder<TbRegistroEvento> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdEvento })
            .HasName("PK_REGISTRO_EVENTOS")
            .IsClustered(false);
        builder.ToTable("TB_REGISTRO_EVENTOS");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdEvento)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_EVENTO");

                builder.Property(e => e.DataHoraEvento)
                    .HasColumnType("datetime")
                    .HasColumnName("DATA_HORA_EVENTO");

                builder.Property(e => e.Descricao)
                    .IsUnicode(false)
                    .HasColumnName("DESCRICAO");

                builder.Property(e => e.IdComputador)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ID_COMPUTADOR");

                builder.Property(e => e.IdFuncaoMenu).HasColumnName("ID_FUNCAO_MENU");

                builder.Property(e => e.IdTipoOperacao).HasColumnName("ID_TIPO_OPERACAO");

                builder.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbRegistroEventos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGISTRO_EVENTOS_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbRegistroEventos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdFuncaoMenu })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGISTRO_EVENTOS_FUNCOES_MENU");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbRegistroEventos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoOperacao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGISTRO_EVENTOS_TIPOS_OPERACOES");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbRegistroEventos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdUsuario })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REGISTRO_EVENTOS_USUARIOS");
    }
}