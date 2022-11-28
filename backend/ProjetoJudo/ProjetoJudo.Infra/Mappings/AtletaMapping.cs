using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Mappings;

public class AtletaMapping : IEntityTypeConfiguration<TbAtleta>
{
    public void Configure(EntityTypeBuilder<TbAtleta> builder)
    {
        builder.Property(e => e.IdCliente).HasColumnName("ID_CLIENTE");

        builder.Property(e => e.IdAtleta)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID_ATLETA");

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

        builder.Property(e => e.Complemento)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("COMPLEMENTO");

        builder.Property(e => e.Cpf)
            .HasMaxLength(11)
            .IsUnicode(false)
            .HasColumnName("CPF");

        builder.Property(e => e.DataFiliacao)
            .HasColumnType("date")
            .HasColumnName("DATA_FILIACAO");

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

        builder.Property(e => e.IdAgremiacao).HasColumnName("ID_AGREMIACAO");

        builder.Property(e => e.IdCidade).HasColumnName("ID_CIDADE");

        builder.Property(e => e.IdEmissor).HasColumnName("ID_EMISSOR");

        builder.Property(e => e.IdEstado).HasColumnName("ID_ESTADO");

        builder.Property(e => e.IdEstadoCivil).HasColumnName("ID_ESTADO_CIVIL");

        builder.Property(e => e.IdFaixa).HasColumnName("ID_FAIXA");

        builder.Property(e => e.IdNacionalidade).HasColumnName("ID_NACIONALIDADE");

        builder.Property(e => e.IdPais).HasColumnName("ID_PAIS");

        builder.Property(e => e.IdProfissaoAtleta).HasColumnName("ID_PROFISSAO_ATLETA");

        builder.Property(e => e.IdProfissaoMae).HasColumnName("ID_PROFISSAO_MAE");

        builder.Property(e => e.IdProfissaoPai).HasColumnName("ID_PROFISSAO_PAI");

        builder.Property(e => e.IdSexo).HasColumnName("ID_SEXO");

        builder.Property(e => e.Identidade)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasColumnName("IDENTIDADE");

        builder.Property(e => e.Nome)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("NOME");

        builder.Property(e => e.NomeMae)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("NOME_MAE");

        builder.Property(e => e.NomePai)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("NOME_PAI");

        builder.Property(e => e.RegistroConfederacao)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("REGISTRO_CONFEDERACAO");

        builder.Property(e => e.RegistroFederacao)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("REGISTRO_FEDERACAO");

        builder.Property(e => e.Selecao).HasColumnName("SELECAO");

        builder.Property(e => e.Telefone)
            .HasMaxLength(60)
            .IsUnicode(false)
            .HasColumnName("TELEFONE");

        builder.HasOne(d => d.IdClienteNavigation)
            .WithMany(p => p.TbAtleta)
            .HasForeignKey(d => d.IdCliente)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ATLETAS_CLIENTES");

        builder.HasOne(d => d.Id)
            .WithMany(p => p.TbAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdAgremiacao })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ATLETAS_AGREMIACOES");

        builder.HasOne(d => d.IdNavigation)
            .WithMany(p => p.TbAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdEmissor })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ATLETAS_EMISSORES_IDENTIDADES");

        builder.HasOne(d => d.Id1)
            .WithMany(p => p.TbAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdEstadoCivil })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ATLETAS_ESTADOS_CIVIS");

        builder.HasOne(d => d.Id2)
            .WithMany(p => p.TbAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdFaixa })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ATLETAS_FAIXAS");

        builder.HasOne(d => d.Id3)
            .WithMany(p => p.TbAtletaId3s)
            .HasForeignKey(d => new { d.IdCliente, d.IdNacionalidade })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ATLETAS_PAISES1");

        builder.HasOne(d => d.Id4)
            .WithMany(p => p.TbAtletaId4s)
            .HasForeignKey(d => new { d.IdCliente, d.IdPais })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ATLETAS_PAISES");

        builder.HasOne(d => d.Id5)
            .WithMany(p => p.TbAtletaId5s)
            .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoAtleta })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ATLETAS_PROFISSOES1");

        builder.HasOne(d => d.Id6)
            .WithMany(p => p.TbAtletaId6s)
            .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoMae })
            .HasConstraintName("FK_ATLETAS_PROFISSOES3");

        builder.HasOne(d => d.Id7)
            .WithMany(p => p.TbAtletaId7s)
            .HasForeignKey(d => new { d.IdCliente, d.IdProfissaoPai })
            .HasConstraintName("FK_ATLETAS_PROFISSOES2");

        builder.HasOne(d => d.Id8)
            .WithMany(p => p.TbAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdSexo })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ATLETAS_SEXOS");

        builder.HasOne(d => d.Id9)
            .WithMany(p => p.TbAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ATLETAS_ESTADOS");

        builder.HasOne(d => d.Id10)
            .WithMany(p => p.TbAtleta)
            .HasForeignKey(d => new { d.IdCliente, d.IdPais, d.IdEstado, d.IdCidade })
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ATLETAS_CIDADES");
    }
}