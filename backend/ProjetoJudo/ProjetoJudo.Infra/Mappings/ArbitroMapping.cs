﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class ArbitroMapping : IEntityTypeConfiguration<TbArbitro>
{
    public void Configure(EntityTypeBuilder<TbArbitro> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdArbitro })
            .HasName("PK_ARBITROS")
            .IsClustered(false);
        builder.ToTable("TB_ARBITROS");

                builder.HasIndex(e => new { e.IdCliente, e.Apelido }, "UK_ARBITROS_APELIDOS")
                    .IsUnique();

                builder.HasIndex(e => new { e.IdCliente, e.Cpf }, "UK_ARBITROS_CPF")
                    .IsUnique();

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdArbitro)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_ARBITRO");

                builder.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                builder.Property(e => e.Apelido)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("APELIDO");

                builder.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                builder.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                builder.Property(e => e.Complemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                builder.Property(e => e.Cpf)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CPF");

                builder.Property(e => e.DataIdentidade)
                    .HasColumnType("date")
                    .HasColumnName("DATA_IDENTIDADE");

                builder.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_NASCIMENTO");

                builder.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                builder.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                builder.Property(e => e.IdAtleta).HasColumnName("ID_ATLETA");

                builder.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                builder.Property(e => e.IdEmissor).HasColumnName("ID_EMISSOR");

                builder.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                builder.Property(e => e.IdEstadoCivil).HasColumnName("ID_ESTADO_CIVIL");

                builder.Property(e => e.IdNacionalidade).HasColumnName("ID_NACIONALIDADE");

                builder.Property(e => e.IdNivel).HasColumnName("ID_NIVEL");

                builder.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                builder.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

                builder.Property(e => e.Identidade)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("IDENTIDADE");

                builder.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.Property(e => e.Telefone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdAtleta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_ATLETAS");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEmissor })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_EMISSORES_IDENTIDADES");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdEstadoCivil })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_ESTADOS_CIVIS");

                builder.HasOne(d => d.Id2)
                    .WithMany(p => p.TbArbitroId2s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNacionalidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_PAISES1");

                builder.HasOne(d => d.Id3)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdNivel })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_NIVEIS_ARBITROS");

                builder.HasOne(d => d.Id4)
                    .WithMany(p => p.TbArbitroId4s)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_PAISES");

                builder.HasOne(d => d.Id5)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_SEXOS");

                builder.HasOne(d => d.Id6)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_ESTADOS");

                builder.HasOne(d => d.Id7)
                    .WithMany(p => p.TbArbitros)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ARBITROS_CIDADES");
    }
}