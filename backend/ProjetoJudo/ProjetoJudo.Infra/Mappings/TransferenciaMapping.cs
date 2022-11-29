using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TransferenciaMapping : IEntityTypeConfiguration<TbTransferencia>
{
    public void Configure(EntityTypeBuilder<TbTransferencia> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataTransferencia })
                .HasName("PK_TRANSFERENCIAS")
                .IsClustered(false);
        
            builder.ToTable("TB_TRANSFERENCIAS");

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                builder.Property(e => e.DataTransferencia)
                    .HasColumnType("date")
                    .HasColumnName("DATA_TRANSFERENCIA");

                builder.Property(e => e.IdAgremiacaoAnterior).HasColumnName("ID_AGREMIACAO_ANTERIOR");

                builder.Property(e => e.IdAgremiacaoNova).HasColumnName("ID_AGREMIACAO_NOVA");

                builder.Property(e => e.IdTipoTransferencia).HasColumnName("ID_TIPO_TRANSFERENCIA");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbTransferencia)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFERENCIAS_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbTransferenciaIds)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacaoAnterior })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFERENCIAS_AGREMIACOES1");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbTransferenciaIdNavigations)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacaoNova })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFERENCIAS_AGREMIACOES2");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbTransferencia)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFERENCIAS_ATLETAS");

                builder.HasOne(d => d.Id2)
                    .WithMany(p => p.TbTransferencia)
                    .HasForeignKey(d => new { d.IdCliente, d.IdTipoTransferencia })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANSFERENCIAS_TIPOS_TRANSFERENCIAS");
    }
}