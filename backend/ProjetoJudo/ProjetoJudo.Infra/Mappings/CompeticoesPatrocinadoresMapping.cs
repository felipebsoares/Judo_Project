using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesPatrocinadoresMapping : IEntityTypeConfiguration<TbCompeticoesPatrocinadore>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesPatrocinadore> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdPatrocinador })
            .HasName("PK_COMPETICOES_PATROCINADORES")
            .IsClustered(false);
        builder.ToTable("TB_COMPETICOES_PATROCINADORES");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

        builder.Property(e => e.IdPatrocinador).HasColumnName("ID_PATROCINADOR");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbCompeticoesPatrocinadores)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_PATROCINADORES_CLIENTES");

        builder.HasOne(d => d.IdC)
            .WithMany(p => p.TbCompeticoesPatrocinadores)
            .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_PATROCINADORES_COMPETICOES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbCompeticoesPatrocinadores)
            .HasForeignKey(d => new { d.IdCliente, d.IdPatrocinador })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_PATROCINADORES_PATROCINADORES");
    }
}