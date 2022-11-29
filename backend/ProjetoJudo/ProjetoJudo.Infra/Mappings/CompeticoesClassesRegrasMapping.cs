using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesClassesRegrasMapping : IEntityTypeConfiguration<TbCompeticoesClassesRegra>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesClassesRegra> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdClasseReal, e.IdClasseInscricao })
            .HasName("PK_COMPETICOES_CLASSES_REGRAS")
            .IsClustered(false);
        builder.ToTable("TB_COMPETICOES_CLASSES_REGRAS");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

        builder.Property(e => e.IdClasseReal).HasColumnName("ID_CLASSE_REAL");

        builder.Property(e => e.IdClasseInscricao).HasColumnName("ID_CLASSE_INSCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbCompeticoesClassesRegras)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_CLIENTES");

        builder.HasOne(d => d.IdC)
            .WithMany(p => p.TbCompeticoesClassesRegras)
            .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES");

        builder.HasOne(d => d.IdCNavigation)
            .WithMany(p => p.TbCompeticoesClassesRegraIdCNavigations)
            .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdClasseInscricao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES_CLASSES2");

        builder.HasOne(d => d.IdC1)
            .WithMany(p => p.TbCompeticoesClassesRegraIdC1s)
            .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao, d.IdClasseReal })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES_CLASSES1");
    }
}