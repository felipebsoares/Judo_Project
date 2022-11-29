using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class AgremiacaoProfessoresMappings : IEntityTypeConfiguration<TbAgremiacoesProfessore>
{
    public void Configure(EntityTypeBuilder<TbAgremiacoesProfessore> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.IdProfessor })
                .HasName("PK_AGREMIACOES_PROFESSORES")
                .IsClustered(false);
            
        builder.ToTable("TB_AGREMIACOES_PROFESSORES");

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

        builder.Property(e => e.IdProfessor).HasColumnName("ID_PROFESSOR");

        builder.Property(e => e.DataInicio)
            .HasColumnType("date")
            .HasColumnName("DATA_INICIO");

        builder.Property(e => e.IdTipoProfessor).HasColumnName("ID_TIPO_PROFESSOR");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");
        
        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbAgremiacoesProfessores)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_AGREMIACOES_PROFESSORES_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbAgremiacoesProfessores)
            .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_AGREMIACOES_PROFESSORES_AGREMIACOES");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbAgremiacoesProfessores)
            .HasForeignKey(d => new { d.IdCliente, d.IdProfessor })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_AGREMIACOES_PROFESSORES_PROFESSORES");
    }
}