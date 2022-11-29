using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticaoArbitroMapping : IEntityTypeConfiguration<TbCompeticoesArbitro>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesArbitro> builder)
    {
        builder.ToTable("TB_COMPETICOES_ARBITROS");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

        builder.Property(e => e.IdArbitro).HasColumnName("ID_ARBITRO");

        builder.Property(e => e.Presente)
            .IsRequired()
            .HasColumnName("PRESENTE")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbCompeticoesArbitros)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_ARBITROS_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbCompeticoesArbitros)
            .HasForeignKey(d => new { d.IdCliente, d.IdArbitro })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_ARBITROS_ARBITROS");

        builder.HasOne(d => d.IdC)
            .WithMany(p => p.TbCompeticoesArbitros)
            .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_ARBITROS_COMPETICOES");
    }
}