using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesTecnicosMapping : IEntityTypeConfiguration<TbCompeticoesTecnico>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesTecnico> builder)
    {
        builder.ToTable("TB_COMPETICOES_TECNICOS");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

        builder.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

        builder.Property(e => e.IdProfessor).HasColumnName("ID_PROFESSOR");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbCompeticoesTecnicos)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_TECNICOS_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbCompeticoesTecnicos)
            .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_TECNICOS_AGREMIACOES");

        builder.HasOne(d => d.IdC)
            .WithMany(p => p.TbCompeticoesTecnicos)
            .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_TECNICOS_COMPETICOES");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbCompeticoesTecnicos)
            .HasForeignKey(d => new { d.IdCliente, d.IdProfessor })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_TECNICOS_PROFESSORES");
    }
}