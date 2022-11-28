using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class AgremiacoesMapping : IEntityTypeConfiguration<TbAgremiaco>
{
    public void Configure(EntityTypeBuilder<TbAgremiaco> builder)
    {
        builder.ToTable("TB_AGREMIACOES");

                builder.HasIndex(e => new { e.IdCliente, e.Cnpj }, "UK_AGREMIACOES_CNPJ")
                    .IsUnique();

                builder.HasIndex(e => new { e.IdCliente, e.Sigla }, "UK_AGREMIACOES_SIGLAS")
                    .IsUnique();

                builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

                builder.Property(e => e.IdAgremiacao)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_AGREMIACAO");

                builder.Property(e => e.AlvaraLocacao)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ALVARA_LOCACAO")
                    .IsFixedLength();

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

                builder.Property(e => e.ContratoSocial)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CONTRATO_SOCIAL")
                    .IsFixedLength();

                builder.Property(e => e.DataAta)
                    .HasColumnType("date")
                    .HasColumnName("DATA_ATA");

                builder.Property(e => e.DataCnpj)
                    .HasColumnType("date")
                    .HasColumnName("DATA_CNPJ");

                builder.Property(e => e.DataFiliacao)
                    .HasColumnType("date")
                    .HasColumnName("DATA_FILIACAO");

                builder.Property(e => e.DataNascimento)
                    .HasColumnType("date")
                    .HasColumnName("DATA_NASCIMENTO");

                builder.Property(e => e.DocumentacaoAtualizada)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENTACAO_ATUALIZADA")
                    .IsFixedLength();

                builder.Property(e => e.Email)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                builder.Property(e => e.Endereco)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ENDERECO");

                builder.Property(e => e.Estatuto)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ESTATUTO")
                    .IsFixedLength();

                builder.Property(e => e.Fantasia)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("FANTASIA");

                builder.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

                builder.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

                builder.Property(e => e.IdPais).HasColumnName("ID_PAIS");

                builder.Property(e => e.IdRegiao).HasColumnName("ID_REGIAO");

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

                builder.Property(e => e.Representante)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("REPRESENTANTE");

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
                    .WithMany(p => p.TbAgremiacos)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_CLIENTES");

                builder.HasOne(d => d.Id)
                    .WithMany(p => p.TbAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_PAISES");

                builder.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TbAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdRegiao })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_REGIOES");

                builder.HasOne(d => d.Id1)
                    .WithMany(p => p.TbAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_ESTADOS");

                builder.HasOne(d => d.Id2)
                    .WithMany(p => p.TbAgremiacos)
                    .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AGREMIACOES_CIDADES");
    }
}