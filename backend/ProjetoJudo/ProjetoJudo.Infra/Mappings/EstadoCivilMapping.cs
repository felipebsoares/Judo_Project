using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class EstadoCivilMapping : IEntityTypeConfiguration<TbEstadosCivi>
{
    public void Configure(EntityTypeBuilder<TbEstadosCivi> builder)
    {
        builder.ToTable("TB_ESTADOS_CIVIS");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdEstadoCivil).HasColumnName("ID_ESTADO_CIVIL");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(3)
            .IsUnicode(false)
            .HasColumnName("SIGLA");
    }
}