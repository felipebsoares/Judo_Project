using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class LocaisCompeticoesMapping : IEntityTypeConfiguration<TbLocaisCompetico>
{
    public void Configure(EntityTypeBuilder<TbLocaisCompetico> builder)
    {
        builder.HasKey(e => new { e.IdCliente, e.IdLocal })
            .HasName("PK_LOCAIS_COMPETICOES")
            .IsClustered(false);
        builder.ToTable("TB_LOCAIS_COMPETICOES");

                builder.HasIndex(e => new { e.IdCliente, e.Cnpj }, "UK_LOCAIS_COMPETICOES_CNPJ")
                    .IsUnique();

                builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_LOCAIS_COMPETICOES_SIGLAS")
                    .IsUnique();

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdLocal)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_LOCAL");

                builder.Property(e => e.Anotacoes)
                    .HasColumnType("text")
                    .HasColumnName("ANOTACOES");

                builder.Property(e => e.Bairro)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BAIRRO");

                builder.Property(e => e.Cep)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("CEP");

                builder.Property(e => e.Cnpj)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("CNPJ");

                builder.Property(e => e.Complemento)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("COMPLEMENTO");

                builder.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                builder.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                builder.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                builder.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                builder.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                builder.Property(e => e.InscricaoEstadual)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("INSCRICAO_ESTADUAL");

                builder.Property(e => e.InscricaoMunicipal)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("INSCRICAO_MUNICIPAL");

                builder.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("NOME");

                builder.Property(e => e.QtdLugares).HasColumnName("QTD_LUGARES");

                builder.Property(e => e.Responsavel)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RESPONSAVEL");

                builder.Property(e => e.Selecao).HasColumnName("SELECAO");

                builder.Property(e => e.Sigla)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SIGLA");

                builder.Property(e => e.Telefone)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONE");

                builder.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbLocaisCompeticos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCAIS_COMPETICOES_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbLocaisCompeticos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCAIS_COMPETICOES_PAISES");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbLocaisCompeticos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCAIS_COMPETICOES_ESTADOS");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbLocaisCompeticos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCAIS_COMPETICOES_CIDADES");
    }
}