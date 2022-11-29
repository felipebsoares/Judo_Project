using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class CompeticoesPessoalApoioMapping : IEntityTypeConfiguration<TbCompeticoesPessoalApoio>
{
    public void Configure(EntityTypeBuilder<TbCompeticoesPessoalApoio> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdApoio, e.IdFuncao })
            .HasName("PK_COMPETICOES_PESSOAL_APOIO")
            .IsClustered(false);
        builder.ToTable("TB_COMPETICOES_PESSOAL_APOIO");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdCompeticao).HasColumnName("ID_COMPETICAO");

        builder.Property(e => e.IdApoio).HasColumnName("ID_APOIO");

        builder.Property(e => e.IdFuncao).HasColumnName("ID_FUNCAO");

        builder.Property(e => e.Presente)
            .IsRequired()
            .HasColumnName("PRESENTE")
            .HasDefaultValueSql("((1))");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbCompeticoesPessoalApoios)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIOS_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbCompeticoesPessoalApoios)
            .HasForeignKey(d => new { d.IdCliente, d.IdApoio })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIO_PESSOAL_APOIO");

        builder.HasOne(d => d.IdC)
            .WithMany(p => p.TbCompeticoesPessoalApoios)
            .HasForeignKey(d => new { d.IdCliente, d.IdCompeticao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIO_COMPETICOES");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbCompeticoesPessoalApoios)
            .HasForeignKey(d => new { d.IdCliente, d.IdFuncao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIO_FUNCOES_APOIO");
    }
}