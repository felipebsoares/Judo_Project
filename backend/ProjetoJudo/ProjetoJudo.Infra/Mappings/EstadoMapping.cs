using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class EstadoMapping : IEntityTypeConfiguration<TbEstado>
{
    public void Configure(EntityTypeBuilder<TbEstado> builder)
    {
        builder.ToTable("TB_ESTADOS");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdPais).HasColumnName("ID_PAIS");

        builder.Property(e => e.IdEstado)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_ESTADO");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(2)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbEstados)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ESTADOS_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbEstados)
            .HasForeignKey(d => new { d.IdCliente, d.IdPais })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ESTADOS_PAISES");
    }
}