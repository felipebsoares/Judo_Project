﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class TipoIsencoesAtletaMapping : IEntityTypeConfiguration<TbTiposIsencoesAtleta>
{
    public void Configure(EntityTypeBuilder<TbTiposIsencoesAtleta> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdTipoIsencaoAtleta })
            .HasName("PK_TIPOS_ISENCOES_ATLETAS")
            .IsClustered(false);
        builder.ToTable("TB_TIPOS_ISENCOES_ATLETAS");

        builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_TIPOS_ISENCOES_ATLETAS_SIGLAS")
            .IsUnique();

        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdTipoIsencaoAtleta)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_TIPO_ISENCAO_ATLETA");

        builder.Property(e => e.Descricao)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("DESCRICAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Sigla)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("SIGLA");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbTiposIsencoesAtleta)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_TIPOS_ISENCOES_ATLETAS_CLIENTES");
    }
}