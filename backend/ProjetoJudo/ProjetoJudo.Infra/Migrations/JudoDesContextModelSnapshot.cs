﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoJudo.Infra.Context;

#nullable disable

namespace ProjetoJudo.Infra.Migrations
{
    [DbContext(typeof(JudoDesContext))]
    partial class JudoDesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAgremiaco", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAgremiacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAgremiacao"), 1L, 1);

                    b.Property<string>("AlvaraLocacao")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("ALVARA_LOCACAO")
                        .IsFixedLength();

                    b.Property<string>("Anotacoes")
                        .HasColumnType("text")
                        .HasColumnName("ANOTACOES");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CEP");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<string>("ContratoSocial")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("CONTRATO_SOCIAL")
                        .IsFixedLength();

                    b.Property<DateTime?>("DataAta")
                        .HasColumnType("date")
                        .HasColumnName("DATA_ATA");

                    b.Property<DateTime?>("DataCnpj")
                        .HasColumnType("date")
                        .HasColumnName("DATA_CNPJ");

                    b.Property<DateTime>("DataFiliacao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_FILIACAO");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("DATA_NASCIMENTO");

                    b.Property<string>("DocumentacaoAtualizada")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("DOCUMENTACAO_ATUALIZADA")
                        .IsFixedLength();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("ENDERECO");

                    b.Property<string>("Estatuto")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("ESTATUTO")
                        .IsFixedLength();

                    b.Property<string>("Fantasia")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("FANTASIA");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_CIDADE");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    b.Property<int>("IdRegiao")
                        .HasColumnType("int")
                        .HasColumnName("ID_REGIAO");

                    b.Property<string>("InscricaoEstadual")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("INSCRICAO_ESTADUAL");

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("INSCRICAO_MUNICIPAL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME");

                    b.Property<string>("Representante")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("REPRESENTANTE");

                    b.Property<string>("Responsavel")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("RESPONSAVEL");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("TELEFONE");

                    b.HasKey("IdCliente", "IdAgremiacao")
                        .HasName("PK_AGREMIACOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAgremiacao"), false);

                    b.HasIndex("IdCliente", "IdRegiao");

                    b.HasIndex("IdCliente", "IdPais", "IdEstado", "IdCidade");

                    b.HasIndex(new[] { "IdCliente", "Cnpj" }, "UK_AGREMIACOES_CNPJ")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_AGREMIACOES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_AGREMIACOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAgremiacoesProfessore", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    b.Property<int>("IdProfessor")
                        .HasColumnType("int")
                        .HasColumnName("ID_PROFESSOR");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("date")
                        .HasColumnName("DATA_INICIO");

                    b.Property<int>("IdTipoProfessor")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PROFESSOR");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdAgremiacao", "IdProfessor")
                        .HasName("PK_AGREMIACOES_PROFESSORES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAgremiacao", "IdProfessor"), false);

                    b.HasIndex("IdCliente", "IdProfessor");

                    b.ToTable("TB_AGREMIACOES_PROFESSORES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAnuidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<string>("AnoBase")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("ANO_BASE")
                        .IsFixedLength();

                    b.Property<int>("DataPagamento")
                        .HasColumnType("int")
                        .HasColumnName("DATA_PAGAMENTO");

                    b.Property<int>("IdTabelaAnuidades")
                        .HasColumnType("int")
                        .HasColumnName("ID_TABELA_ANUIDADES");

                    b.Property<int>("IdTipoAnuidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ANUIDADE");

                    b.Property<int>("IdTipoPagamento")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PAGAMENTO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<decimal>("ValorDesconto")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_DESCONTO");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_PAGO");

                    b.HasKey("IdCliente", "IdAtleta", "AnoBase")
                        .HasName("PK_ANUIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAtleta", "AnoBase"), false);

                    b.HasIndex("IdCliente", "IdTabelaAnuidades");

                    b.HasIndex("IdCliente", "IdTipoAnuidade");

                    b.HasIndex("IdCliente", "IdTipoPagamento");

                    b.ToTable("TB_ANUIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAnuidadesConfederacao", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<string>("AnoBase")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("ANO_BASE")
                        .IsFixedLength();

                    b.Property<int>("DataPagamento")
                        .HasColumnType("int")
                        .HasColumnName("DATA_PAGAMENTO");

                    b.Property<int>("IdTabelaAnuidades")
                        .HasColumnType("int")
                        .HasColumnName("ID_TABELA_ANUIDADES");

                    b.Property<int>("IdTipoAnuidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ANUIDADE");

                    b.Property<int>("IdTipoPagamento")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PAGAMENTO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<decimal>("ValorDesconto")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_DESCONTO");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_PAGO");

                    b.HasKey("IdCliente", "IdAtleta", "AnoBase")
                        .HasName("PK_ANUIDADES_CONFEDERACAO");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAtleta", "AnoBase"), false);

                    b.HasIndex("IdCliente", "IdTabelaAnuidades");

                    b.HasIndex("IdCliente", "IdTipoAnuidade");

                    b.HasIndex("IdCliente", "IdTipoPagamento");

                    b.ToTable("TB_ANUIDADES_CONFEDERACAO", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbArbitro", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdArbitro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_ARBITRO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdArbitro"), 1L, 1);

                    b.Property<string>("Anotacoes")
                        .HasColumnType("text")
                        .HasColumnName("ANOTACOES");

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("APELIDO");

                    b.Property<string>("Bairro")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CEP");

                    b.Property<string>("Complemento")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("DataIdentidade")
                        .HasColumnType("date")
                        .HasColumnName("DATA_IDENTIDADE");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("DATA_NASCIMENTO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("ENDERECO");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_CIDADE");

                    b.Property<int>("IdEmissor")
                        .HasColumnType("int")
                        .HasColumnName("ID_EMISSOR");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO");

                    b.Property<int>("IdEstadoCivil")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO_CIVIL");

                    b.Property<int>("IdNacionalidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_NACIONALIDADE");

                    b.Property<int>("IdNivel")
                        .HasColumnType("int")
                        .HasColumnName("ID_NIVEL");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    b.Property<int>("IdSexo")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO");

                    b.Property<string>("Identidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("IDENTIDADE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("TELEFONE");

                    b.HasKey("IdCliente", "IdArbitro")
                        .HasName("PK_ARBITROS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdArbitro"), false);

                    b.HasIndex("IdCliente", "IdAtleta");

                    b.HasIndex("IdCliente", "IdEmissor");

                    b.HasIndex("IdCliente", "IdEstadoCivil");

                    b.HasIndex("IdCliente", "IdNacionalidade");

                    b.HasIndex("IdCliente", "IdNivel");

                    b.HasIndex("IdCliente", "IdSexo");

                    b.HasIndex("IdCliente", "IdPais", "IdEstado", "IdCidade");

                    b.HasIndex(new[] { "IdCliente", "Apelido" }, "UK_ARBITROS_APELIDOS")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "Cpf" }, "UK_ARBITROS_CPF")
                        .IsUnique();

                    b.ToTable("TB_ARBITROS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAtleta", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAtleta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAtleta"), 1L, 1);

                    b.Property<string>("Anotacoes")
                        .HasColumnType("text")
                        .HasColumnName("ANOTACOES");

                    b.Property<string>("Bairro")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CEP");

                    b.Property<string>("Complemento")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("DataFiliacao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_FILIACAO");

                    b.Property<DateTime>("DataIdentidade")
                        .HasColumnType("date")
                        .HasColumnName("DATA_IDENTIDADE");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("DATA_NASCIMENTO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("ENDERECO");

                    b.Property<int>("IdAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_CIDADE");

                    b.Property<int>("IdEmissor")
                        .HasColumnType("int")
                        .HasColumnName("ID_EMISSOR");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO");

                    b.Property<int>("IdEstadoCivil")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO_CIVIL");

                    b.Property<int>("IdFaixa")
                        .HasColumnType("int")
                        .HasColumnName("ID_FAIXA");

                    b.Property<int>("IdNacionalidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_NACIONALIDADE");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    b.Property<int>("IdProfissaoAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_PROFISSAO_ATLETA");

                    b.Property<int?>("IdProfissaoMae")
                        .HasColumnType("int")
                        .HasColumnName("ID_PROFISSAO_MAE");

                    b.Property<int?>("IdProfissaoPai")
                        .HasColumnType("int")
                        .HasColumnName("ID_PROFISSAO_PAI");

                    b.Property<int>("IdSexo")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO");

                    b.Property<string>("Identidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("IDENTIDADE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME");

                    b.Property<string>("NomeMae")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME_MAE");

                    b.Property<string>("NomePai")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME_PAI");

                    b.Property<string>("RegistroConfederacao")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("REGISTRO_CONFEDERACAO");

                    b.Property<string>("RegistroFederacao")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("REGISTRO_FEDERACAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("TELEFONE");

                    b.HasKey("IdCliente", "IdAtleta")
                        .HasName("PK_ATLETAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAtleta"), false);

                    b.HasIndex("IdCliente", "IdAgremiacao");

                    b.HasIndex("IdCliente", "IdEmissor");

                    b.HasIndex("IdCliente", "IdEstadoCivil");

                    b.HasIndex("IdCliente", "IdFaixa");

                    b.HasIndex("IdCliente", "IdNacionalidade");

                    b.HasIndex("IdCliente", "IdProfissaoAtleta");

                    b.HasIndex("IdCliente", "IdProfissaoMae");

                    b.HasIndex("IdCliente", "IdProfissaoPai");

                    b.HasIndex("IdCliente", "IdSexo");

                    b.HasIndex("IdCliente", "IdPais", "IdEstado", "IdCidade");

                    b.HasIndex(new[] { "IdCliente", "Cpf" }, "UK_ATLETAS_CPF")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "RegistroConfederacao" }, "UK_ATLETAS_REGISTRO_CONFEDERACAO")
                        .IsUnique()
                        .HasFilter("[REGISTRO_CONFEDERACAO] IS NOT NULL");

                    b.HasIndex(new[] { "IdCliente", "RegistroFederacao" }, "UK_ATLETAS_REGISTRO_FEDERACAO")
                        .IsUnique();

                    b.ToTable("TB_ATLETAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCategoria", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CATEGORIA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("OrdemExibicao")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdCategoria")
                        .HasName("PK_CATEGORIAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCategoria"), false);

                    b.HasIndex(new[] { "IdCliente", "OrdemExibicao" }, "UK_CATEGORIAS_ORDENS_EXIBICAO")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_CATEGORIAS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_CATEGORIAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO");

                    b.Property<int>("IdCidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CIDADE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCidade"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdPais", "IdEstado", "IdCidade")
                        .HasName("PK_CIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdPais", "IdEstado", "IdCidade"), false);

                    b.ToTable("TB_CIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbClass", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdClasse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CLASSE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClasse"), 1L, 1);

                    b.Property<string>("Descricao1")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO1");

                    b.Property<string>("Descricao2")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO2");

                    b.Property<int>("IdSexo")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO");

                    b.Property<short>("IdadeFinal")
                        .HasColumnType("smallint")
                        .HasColumnName("IDADE_FINAL");

                    b.Property<short>("IdadeInicial")
                        .HasColumnType("smallint")
                        .HasColumnName("IDADE_INICIAL");

                    b.Property<int>("OrdemExibicao")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdClasse")
                        .HasName("PK_CLASSES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdClasse"), false);

                    b.HasIndex("IdCliente", "IdSexo");

                    b.HasIndex(new[] { "IdCliente", "OrdemExibicao" }, "UK_CLASSES_ORDENS_EXIBICAO")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "Sigla", "IdSexo" }, "UK_CLASSES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_CLASSES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"), 1L, 1);

                    b.Property<int>("IdSistema")
                        .HasColumnType("int")
                        .HasColumnName("ID_SISTEMA");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME");

                    b.Property<string>("PastaArquivos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("PASTA_ARQUIVOS");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente")
                        .HasName("PK_CLIENTES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente"), false);

                    b.HasIndex("IdSistema");

                    b.ToTable("TB_CLIENTES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCobranca", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCobranca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_COBRANCA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCobranca"), 1L, 1);

                    b.Property<DateTime>("DataCobranca")
                        .HasColumnType("date")
                        .HasColumnName("DATA_COBRANCA");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("date")
                        .HasColumnName("DATA_VENCIMENTO");

                    b.Property<int>("IdAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    b.Property<string>("MesBase")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("MES_BASE")
                        .IsFixedLength();

                    b.Property<string>("Oficio")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("OFICIO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<decimal>("ValorCobranca")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_COBRANCA");

                    b.Property<decimal>("ValorDesconto")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_DESCONTO");

                    b.HasKey("IdCliente", "IdCobranca")
                        .HasName("PK_COBRANCAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCobranca"), false);

                    b.HasIndex("IdCliente", "IdAgremiacao");

                    b.ToTable("TB_COBRANCAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompetico", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCompeticao"), 1L, 1);

                    b.Property<string>("Anotacoes")
                        .HasColumnType("text")
                        .HasColumnName("ANOTACOES");

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("date")
                        .HasColumnName("DATA_FINAL");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("date")
                        .HasColumnName("DATA_INICIO");

                    b.Property<string>("Descricao1")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO1");

                    b.Property<string>("Descricao2")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO2");

                    b.Property<int>("IdLocal")
                        .HasColumnType("int")
                        .HasColumnName("ID_LOCAL");

                    b.Property<int>("IdTipoCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_COMPETICAO");

                    b.Property<int>("IdadeMaxima")
                        .HasColumnType("int")
                        .HasColumnName("IDADE_MAXIMA");

                    b.Property<int>("IdadeMinima")
                        .HasColumnType("int")
                        .HasColumnName("IDADE_MINIMA");

                    b.Property<int>("PesoRanking")
                        .HasColumnType("int")
                        .HasColumnName("PESO_RANKING");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdCompeticao")
                        .HasName("PK_COMPETICOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao"), false);

                    b.HasIndex("IdCliente", "IdLocal");

                    b.HasIndex("IdCliente", "IdTipoCompeticao");

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_COMPETICOES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_COMPETICOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesArbitro", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdArbitro")
                        .HasColumnType("int")
                        .HasColumnName("ID_ARBITRO");

                    b.Property<bool?>("Presente")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("PRESENTE")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdArbitro")
                        .HasName("PK_COMPETICOES_ARBITROS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdArbitro"), false);

                    b.HasIndex("IdCliente", "IdArbitro");

                    b.ToTable("TB_COMPETICOES_ARBITROS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesArea", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdArea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_AREA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdArea"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdCompeticao", "IdArea")
                        .HasName("PK_COMPETICOES_AREAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdArea"), false);

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "Sigla" }, "UK_COMPETICOES_AREAS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_COMPETICOES_AREAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesCategoria", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CATEGORIA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("OrdemExibicao")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdCompeticao", "IdCategoria")
                        .HasName("PK_COMPETICOES_CATEGORIAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdCategoria"), false);

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "OrdemExibicao" }, "UK_COMPETICOES_CATEGORIAS_ORDENS_EXIBICAO")
                        .IsUnique();

                    b.ToTable("TB_COMPETICOES_CATEGORIAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesChafe", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdChave")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CHAVE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdChave"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("ID_CATEGORIA");

                    b.Property<int>("IdClasse")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLASSE");

                    b.Property<int>("IdFaixaFinal")
                        .HasColumnType("int")
                        .HasColumnName("ID_FAIXA_FINAL");

                    b.Property<int>("IdFaixaInicial")
                        .HasColumnType("int")
                        .HasColumnName("ID_FAIXA_INICIAL");

                    b.Property<int>("IdSexo")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO");

                    b.Property<short>("OrdemExibicaoChave")
                        .HasColumnType("smallint")
                        .HasColumnName("ORDEM_EXIBICAO_CHAVE");

                    b.Property<short>("PesoRanking")
                        .HasColumnType("smallint")
                        .HasColumnName("PESO_RANKING");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdChave")
                        .HasName("PK_COMPETICOES_CHAVES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdChave"), false);

                    b.HasIndex("IdCliente", "IdSexo");

                    b.HasIndex("IdCliente", "IdCompeticao", "IdCategoria");

                    b.HasIndex("IdCliente", "IdCompeticao", "IdClasse");

                    b.HasIndex("IdCliente", "IdCompeticao", "IdFaixaFinal");

                    b.HasIndex("IdCliente", "IdCompeticao", "IdFaixaInicial");

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "OrdemExibicaoChave" }, "UK_COMPETICOES_CHAVES_ORDENS_EXIBICAO_CHAVES")
                        .IsUnique();

                    b.ToTable("TB_COMPETICOES_CHAVES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesClass", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdClasse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_CLASSE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClasse"), 1L, 1);

                    b.Property<string>("Descricao1")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO1");

                    b.Property<string>("Descricao2")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO2");

                    b.Property<int>("IdSexo")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO");

                    b.Property<short>("IdadeFinal")
                        .HasColumnType("smallint")
                        .HasColumnName("IDADE_FINAL");

                    b.Property<short>("IdadeInicial")
                        .HasColumnType("smallint")
                        .HasColumnName("IDADE_INICIAL");

                    b.Property<int>("OrdemExibicao")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdCompeticao", "IdClasse")
                        .HasName("PK_COMPETICOES_CLASSES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdClasse"), false);

                    b.HasIndex("IdCliente", "IdSexo");

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "OrdemExibicao" }, "UK_COMPETICOES_CLASSES_ORDENS_EXIBICAO")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "Sigla", "IdSexo" }, "UK_COMPETICOES_CLASSES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_COMPETICOES_CLASSES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesClassesRegra", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdClasseReal")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLASSE_REAL");

                    b.Property<int>("IdClasseInscricao")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLASSE_INSCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdClasseReal", "IdClasseInscricao")
                        .HasName("PK_COMPETICOES_CLASSES_REGRAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdClasseReal", "IdClasseInscricao"), false);

                    b.HasIndex("IdCliente", "IdCompeticao", "IdClasseInscricao");

                    b.ToTable("TB_COMPETICOES_CLASSES_REGRAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesFaixa", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdFaixa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_FAIXA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFaixa"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("OrdemExibicao")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdCompeticao", "IdFaixa")
                        .HasName("PK_COMPETICOES_FAIXAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdFaixa"), false);

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "OrdemExibicao" }, "UK_COMPETICOES_FAIXAS_ORDENS_EXIBICAO")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "Sigla" }, "UK_COMPETICOES_FAIXAS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_COMPETICOES_FAIXAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesInscrico", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdInscricao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_INSCRICAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInscricao"), 1L, 1);

                    b.Property<DateTime>("DataInscricao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_INSCRICAO");

                    b.Property<int>("IdAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<int>("IdChave")
                        .HasColumnType("int")
                        .HasColumnName("ID_CHAVE");

                    b.Property<int>("IdFaixa")
                        .HasColumnType("int")
                        .HasColumnName("ID_FAIXA");

                    b.Property<double>("Peso")
                        .HasColumnType("float")
                        .HasColumnName("PESO");

                    b.Property<bool?>("Presente")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("PRESENTE")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdInscricao")
                        .HasName("PK_COMPETICOES_INSCRICOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdInscricao"), false);

                    b.HasIndex("IdCliente", "IdAgremiacao");

                    b.HasIndex("IdCliente", "IdAtleta");

                    b.HasIndex("IdCliente", "IdCompeticao", "IdChave");

                    b.HasIndex("IdCliente", "IdCompeticao", "IdFaixa");

                    b.ToTable("TB_COMPETICOES_INSCRICOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesLuta", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdLuta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_LUTA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLuta"), 1L, 1);

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("date")
                        .HasColumnName("DATA_FINAL");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("date")
                        .HasColumnName("DATA_INICIO");

                    b.Property<int>("IdAtleta1")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA1");

                    b.Property<int>("IdAtleta2")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA2");

                    b.Property<int>("IdAtletaVencedor")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA_VENCEDOR");

                    b.Property<int>("IdChave")
                        .HasColumnType("int")
                        .HasColumnName("ID_CHAVE");

                    b.Property<int>("OrdemAtleta1Chave")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_ATLETA1_CHAVE");

                    b.Property<int>("OrdemAtleta2Chave")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_ATLETA2_CHAVE");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdLuta")
                        .HasName("PK_COMPETICOES_LUTAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdLuta"), false);

                    b.HasIndex("IdCliente", "IdAtleta1");

                    b.HasIndex("IdCliente", "IdAtleta2");

                    b.HasIndex("IdCliente", "IdAtletaVencedor");

                    b.HasIndex("IdCliente", "IdCompeticao", "IdChave");

                    b.ToTable("TB_COMPETICOES_LUTAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesLutasPenalidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdLuta")
                        .HasColumnType("int")
                        .HasColumnName("ID_LUTA");

                    b.Property<int>("Tempo")
                        .HasColumnType("int")
                        .HasColumnName("TEMPO");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<int>("IdPenalidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_PENALIDADE");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdLuta", "Tempo")
                        .HasName("PK_COMPETICOES_LUTAS_PENALIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdLuta", "Tempo"), false);

                    b.HasIndex("IdCliente", "IdAtleta");

                    b.HasIndex("IdCliente", "IdCompeticao", "IdPenalidade");

                    b.ToTable("TB_COMPETICOES_LUTAS_PENALIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesLutasPontuaco", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdLuta")
                        .HasColumnType("int")
                        .HasColumnName("ID_LUTA");

                    b.Property<int>("Tempo")
                        .HasColumnType("int")
                        .HasColumnName("TEMPO");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<int>("IdPontuacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_PONTUACAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdLuta", "Tempo")
                        .HasName("PK_COMPETICOES_LUTAS_PONTUACOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdLuta", "Tempo"), false);

                    b.HasIndex("IdCliente", "IdAtleta");

                    b.HasIndex("IdCliente", "IdCompeticao", "IdPontuacao");

                    b.ToTable("TB_COMPETICOES_LUTAS_PONTUACOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesPatrocinadore", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdPatrocinador")
                        .HasColumnType("int")
                        .HasColumnName("ID_PATROCINADOR");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdPatrocinador")
                        .HasName("PK_COMPETICOES_PATROCINADORES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdPatrocinador"), false);

                    b.HasIndex("IdCliente", "IdPatrocinador");

                    b.ToTable("TB_COMPETICOES_PATROCINADORES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesPenalidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdPenalidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PENALIDADE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPenalidade"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("OrdemExibicao")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdCompeticao", "IdPenalidade")
                        .HasName("PK_COMPETICOES_PENALIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdPenalidade"), false);

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "OrdemExibicao" }, "UK_COMPETICOES_PENALIDADES_ORDENS_EXIBICAO")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "Sigla" }, "UK_COMPETICOES_PENALIDADES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_COMPETICOES_PENALIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesPessoalApoio", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdApoio")
                        .HasColumnType("int")
                        .HasColumnName("ID_APOIO");

                    b.Property<int>("IdFuncao")
                        .HasColumnType("int")
                        .HasColumnName("ID_FUNCAO");

                    b.Property<bool?>("Presente")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("PRESENTE")
                        .HasDefaultValueSql("((1))");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdApoio", "IdFuncao")
                        .HasName("PK_COMPETICOES_PESSOAL_APOIO");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdApoio", "IdFuncao"), false);

                    b.HasIndex("IdCliente", "IdApoio");

                    b.HasIndex("IdCliente", "IdFuncao");

                    b.ToTable("TB_COMPETICOES_PESSOAL_APOIO", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesPontuaco", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdPontuacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PONTUACAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPontuacao"), 1L, 1);

                    b.Property<string>("DscPontuacao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DSC_PONTUACAO");

                    b.Property<int>("OrdemExibicao")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdCompeticao", "IdPontuacao")
                        .HasName("PK_COMPETICOES_PONTUACOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdPontuacao"), false);

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "OrdemExibicao" }, "UK_COMPETICOES_PONTUACOES_ORDENS_EXIBICAO")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "Sigla" }, "UK_COMPETICOES_PONTUACOES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_COMPETICOES_PONTUACOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesResultado", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdChave")
                        .HasColumnType("int")
                        .HasColumnName("ID_CHAVE");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<short>("Colocacao")
                        .HasColumnType("smallint")
                        .HasColumnName("COLOCACAO");

                    b.Property<DateTime>("DataResultado")
                        .HasColumnType("date")
                        .HasColumnName("DATA_RESULTADO");

                    b.Property<string>("Descricao")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdChave", "IdAtleta")
                        .HasName("PK_COMPETICOES_RESULTADOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdChave", "IdAtleta"), false);

                    b.HasIndex("IdCliente", "IdAtleta");

                    b.ToTable("TB_COMPETICOES_RESULTADOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesTabelasPeso", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdClasse")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLASSE");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("ID_CATEGORIA");

                    b.Property<int>("IdSexo")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO");

                    b.Property<int>("OrdemExibicaoCategoria")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO_CATEGORIA");

                    b.Property<int>("OrdemExibicaoClasse")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO_CLASSE");

                    b.Property<double>("PesoFinal")
                        .HasColumnType("float")
                        .HasColumnName("PESO_FINAL");

                    b.Property<double>("PesoInicial")
                        .HasColumnType("float")
                        .HasColumnName("PESO_INICIAL");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdClasse", "IdCategoria")
                        .HasName("PK_COMPETICOES_TABELAS_PESOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdClasse", "IdCategoria"), false);

                    b.HasIndex("IdCliente", "IdSexo");

                    b.HasIndex("IdCliente", "IdCompeticao", "IdCategoria");

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "OrdemExibicaoCategoria" }, "UK_COMPETICOES_TABELAS_PESOS_ORDENS_EXIBICAO_CATEGORIAS")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "IdCompeticao", "OrdemExibicaoClasse" }, "UK_COMPETICOES_TABELAS_PESOS_ORDENS_EXIBICAO_CLASSES")
                        .IsUnique();

                    b.ToTable("TB_COMPETICOES_TABELAS_PESOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesTecnico", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int>("IdAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    b.Property<int>("IdProfessor")
                        .HasColumnType("int")
                        .HasColumnName("ID_PROFESSOR");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdCompeticao", "IdAgremiacao", "IdProfessor")
                        .HasName("PK_COMPETICOES_TECNICOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdCompeticao", "IdAgremiacao", "IdProfessor"), false);

                    b.HasIndex("IdCliente", "IdAgremiacao");

                    b.HasIndex("IdCliente", "IdProfessor");

                    b.ToTable("TB_COMPETICOES_TECNICOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesTipo", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoCompeticao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_COMPETICAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoCompeticao"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoCompeticao")
                        .HasName("PK_COMPETICOES_TIPOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoCompeticao"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_COMPETICOES_TIPOS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_COMPETICOES_TIPOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCurriculosAgremiaco", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    b.Property<DateTime>("DataEvento")
                        .HasColumnType("date")
                        .HasColumnName("DATA_EVENTO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("IdTipoCurriculoAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_CURRICULO_AGREMIACAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdAgremiacao", "DataEvento")
                        .HasName("PK_CURRICULOS_AGREMIACOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAgremiacao", "DataEvento"), false);

                    b.HasIndex("IdCliente", "IdTipoCurriculoAgremiacao");

                    b.ToTable("TB_CURRICULOS_AGREMIACOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCurriculosAtleta", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<DateTime>("DataEvento")
                        .HasColumnType("date")
                        .HasColumnName("DATA_EVENTO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("IdTipoCurriculoAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_CURRICULO_ATLETA");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdAtleta", "DataEvento")
                        .HasName("PK_CURRICULOS_ATLETAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAtleta", "DataEvento"), false);

                    b.HasIndex("IdCliente", "IdTipoCurriculoAtleta");

                    b.ToTable("TB_CURRICULOS_ATLETAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbDesfiliacoesAgremiaco", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    b.Property<DateTime>("DataDesfiliacao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_DESFILIACAO");

                    b.Property<DateTime?>("DataRefiliacao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_REFILIACAO");

                    b.Property<int>("IdTipoDesfiliacaoAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_DESFILIACAO_AGREMIACAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdAgremiacao", "DataDesfiliacao")
                        .HasName("PK_DESFILIACOES_AGREMIACOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAgremiacao", "DataDesfiliacao"), false);

                    b.HasIndex("IdCliente", "IdTipoDesfiliacaoAgremiacao");

                    b.ToTable("TB_DESFILIACOES_AGREMIACOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbDesfiliacoesAtleta", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<DateTime>("DataDesfiliacao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_DESFILIACAO");

                    b.Property<DateTime?>("DataRefiliacao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_REFILIACAO");

                    b.Property<int>("IdTipoDesfiliacaoAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_DESFILIACAO_ATLETA");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdAtleta", "DataDesfiliacao")
                        .HasName("PK_DESFILIACOES_ATLETAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAtleta", "DataDesfiliacao"), false);

                    b.HasIndex("IdCliente", "IdTipoDesfiliacaoAtleta");

                    b.ToTable("TB_DESFILIACOES_ATLETAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbEmissoresIdentidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdEmissor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_EMISSOR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEmissor"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdEmissor")
                        .HasName("PK_EMISSORES_IDENTIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdEmissor"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_EMISSORES_IDENTIDADES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_EMISSORES_IDENTIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbEstado", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstado"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdPais", "IdEstado")
                        .HasName("PK_ESTADOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdPais", "IdEstado"), false);

                    b.ToTable("TB_ESTADOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbEstadosCivi", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdEstadoCivil")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO_CIVIL");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdEstadoCivil")
                        .HasName("PK_ESTADO_CIVIL");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdEstadoCivil"), false);

                    b.ToTable("TB_ESTADOS_CIVIS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFaixa", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdFaixa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_FAIXA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFaixa"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<short>("IdadeMinima")
                        .HasColumnType("smallint")
                        .HasColumnName("IDADE_MINIMA");

                    b.Property<short>("MesesCarencia")
                        .HasColumnType("smallint")
                        .HasColumnName("MESES_CARENCIA");

                    b.Property<int>("OrdemExibicao")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdFaixa")
                        .HasName("PK_FAIXAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdFaixa"), false);

                    b.HasIndex(new[] { "IdCliente", "OrdemExibicao" }, "UK_FAIXAS_ORDENS_EXIBICAO")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_FAIXAS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_FAIXAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFormasPagamento", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdFormaPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_FORMA_PAGAMENTO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFormaPagamento"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdFormaPagamento")
                        .HasName("PK_FORMAS_PAGAMENTOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdFormaPagamento"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_FORMAS_PAGAMENTOS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_FORMAS_PAGAMENTOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFuncoesApoio", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdFuncao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_FUNCAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFuncao"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdFuncao")
                        .HasName("PK_FUNCOES_APOIO");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdFuncao"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_FUNCOES_APOIO_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_FUNCOES_APOIO", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFuncoesApoioPessoalApoio", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdFuncao")
                        .HasColumnType("int")
                        .HasColumnName("ID_FUNCAO");

                    b.Property<int>("IdApoio")
                        .HasColumnType("int")
                        .HasColumnName("ID_APOIO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdFuncao", "IdApoio");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdFuncao", "IdApoio"), false);

                    b.HasIndex("IdCliente", "IdApoio");

                    b.ToTable("TB_FUNCOES_APOIO_PESSOAL_APOIO", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFuncoesMenu", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdFuncaoMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_FUNCAO_MENU");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFuncaoMenu"), 1L, 1);

                    b.Property<bool>("Anexo")
                        .HasColumnType("bit")
                        .HasColumnName("ANEXO");

                    b.Property<bool>("Anotacoes")
                        .HasColumnType("bit")
                        .HasColumnName("ANOTACOES");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Foto")
                        .HasColumnType("bit")
                        .HasColumnName("FOTO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdFuncaoMenu")
                        .HasName("PK_FUNCOES_MENU");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdFuncaoMenu"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_FUNCOES_MENU_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_FUNCOES_MENU", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbIsencoesAgremiaco", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("date")
                        .HasColumnName("DATA_INICIO");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("date")
                        .HasColumnName("DATA_FIM");

                    b.Property<int>("IdTipoIsencaoAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ISENCAO_AGREMIACAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdAgremiacao", "DataInicio")
                        .HasName("PK_ISENCOES_AGREMIACOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAgremiacao", "DataInicio"), false);

                    b.HasIndex("IdCliente", "IdTipoIsencaoAgremiacao");

                    b.ToTable("TB_ISENCOES_AGREMIACOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbIsencoesAtleta", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("date")
                        .HasColumnName("DATA_INICIO");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("date")
                        .HasColumnName("DATA_FIM");

                    b.Property<int>("IdTipoIsencaoAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ISENCAO_ATLETA");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdAtleta", "DataInicio")
                        .HasName("PK_ISENCOES_ATLETAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAtleta", "DataInicio"), false);

                    b.HasIndex("IdCliente", "IdTipoIsencaoAtleta");

                    b.ToTable("TB_ISENCOES_ATLETAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbLocaisCompetico", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdLocal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_LOCAL");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLocal"), 1L, 1);

                    b.Property<string>("Anotacoes")
                        .HasColumnType("text")
                        .HasColumnName("ANOTACOES");

                    b.Property<string>("Bairro")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CEP");

                    b.Property<string>("Cnpj")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Complemento")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<string>("Email")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("ENDERECO");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_CIDADE");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    b.Property<string>("InscricaoEstadual")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("INSCRICAO_ESTADUAL");

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("INSCRICAO_MUNICIPAL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME");

                    b.Property<int?>("QtdLugares")
                        .HasColumnType("int")
                        .HasColumnName("QTD_LUGARES");

                    b.Property<string>("Responsavel")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("RESPONSAVEL");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.Property<string>("Telefone")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("TELEFONE");

                    b.HasKey("IdCliente", "IdLocal")
                        .HasName("PK_LOCAIS_COMPETICOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdLocal"), false);

                    b.HasIndex("IdCliente", "IdPais", "IdEstado", "IdCidade");

                    b.HasIndex(new[] { "IdCliente", "Cnpj" }, "UK_LOCAIS_COMPETICOES_CNPJ")
                        .IsUnique()
                        .HasFilter("[CNPJ] IS NOT NULL");

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_LOCAIS_COMPETICOES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_LOCAIS_COMPETICOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbMensalidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    b.Property<string>("MesBase")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("MES_BASE")
                        .IsFixedLength();

                    b.Property<int>("DataPagamento")
                        .HasColumnType("int")
                        .HasColumnName("DATA_PAGAMENTO");

                    b.Property<int>("IdTabelaMensalidades")
                        .HasColumnType("int")
                        .HasColumnName("ID_TABELA_MENSALIDADES");

                    b.Property<int>("IdTipoPagamento")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PAGAMENTO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<decimal>("ValorDesconto")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_DESCONTO");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_PAGO");

                    b.HasKey("IdCliente", "IdAgremiacao", "MesBase")
                        .HasName("PK_MENSALIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAgremiacao", "MesBase"), false);

                    b.HasIndex("IdCliente", "IdTabelaMensalidades");

                    b.HasIndex("IdCliente", "IdTipoPagamento");

                    b.ToTable("TB_MENSALIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbNiveisArbitro", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdNivelArbitro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_NIVEL_ARBITRO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNivelArbitro"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("OrdemExibicao")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdNivelArbitro")
                        .HasName("PK_NIVEIS_ARBITROS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdNivelArbitro"), false);

                    b.HasIndex(new[] { "IdCliente", "OrdemExibicao" }, "UK_NIVEIS_ARBITROS_ORDENS_EXIBICAO")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_NIVEIS_ARBITROS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_NIVEIS_ARBITROS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPaise", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdPais")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPais"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Nacionalidade")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("NACIONALIDADE");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla2")
                        .IsRequired()
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("SIGLA_2");

                    b.Property<string>("Sigla3")
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnType("varchar(3)")
                        .HasColumnName("SIGLA_3");

                    b.HasKey("IdCliente", "IdPais")
                        .HasName("PK_PAISES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdPais"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla2" }, "UK_PAISES_SIGLAS_2")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "Sigla3" }, "UK_PAISES_SIGLAS_3")
                        .IsUnique();

                    b.ToTable("TB_PAISES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPatrocinadore", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdPatrocinador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PATROCINADOR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPatrocinador"), 1L, 1);

                    b.Property<string>("Anotacoes")
                        .HasColumnType("text")
                        .HasColumnName("ANOTACOES");

                    b.Property<string>("Bairro")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CEP");

                    b.Property<string>("Cnpj")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Complemento")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<string>("Email")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("ENDERECO");

                    b.Property<string>("Fantasia")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("FANTASIA");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_CIDADE");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    b.Property<string>("InscricaoEstadual")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("INSCRICAO_ESTADUAL");

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("INSCRICAO_MUNICIPAL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME");

                    b.Property<string>("Responsavel")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("RESPONSAVEL");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.Property<string>("Telefone")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("TELEFONE");

                    b.HasKey("IdCliente", "IdPatrocinador")
                        .HasName("PK_PATROCINADORES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdPatrocinador"), false);

                    b.HasIndex("IdCliente", "IdPais", "IdEstado", "IdCidade");

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_PATROCINADORES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_PATROCINADORES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPenalidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdPenalidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PENALIDADE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPenalidade"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("OrdemExibicao")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdPenalidade")
                        .HasName("PK_PENALIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdPenalidade"), false);

                    b.HasIndex(new[] { "IdCliente", "OrdemExibicao" }, "UK_PENALIDADES_ORDENS_EXIBICAO")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_PENALIDADES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_PENALIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPerfi", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdPerfil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PERFIL");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPerfil"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdPerfil")
                        .HasName("PK_PERFIS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdPerfil"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_PERFIS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_PERFIS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPerfisUsuario", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdPerfil")
                        .HasColumnType("int")
                        .HasColumnName("ID_PERFIL");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdPerfil", "IdUsuario")
                        .HasName("PK_PERFIS_USUARIOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdPerfil", "IdUsuario"), false);

                    b.HasIndex("IdCliente", "IdUsuario");

                    b.ToTable("TB_PERFIS_USUARIOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPermisso", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdPerfil")
                        .HasColumnType("int")
                        .HasColumnName("ID_PERFIL");

                    b.Property<int>("IdFuncaoMenu")
                        .HasColumnType("int")
                        .HasColumnName("ID_FUNCAO_MENU");

                    b.Property<int>("IdTipoOperacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_OPERACAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdPerfil", "IdFuncaoMenu", "IdTipoOperacao")
                        .HasName("PK_PERMISSOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdPerfil", "IdFuncaoMenu", "IdTipoOperacao"), false);

                    b.HasIndex("IdCliente", "IdFuncaoMenu");

                    b.HasIndex("IdCliente", "IdTipoOperacao");

                    b.ToTable("TB_PERMISSOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPessoalApoio", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdApoio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_APOIO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdApoio"), 1L, 1);

                    b.Property<string>("Anotacoes")
                        .HasColumnType("text")
                        .HasColumnName("ANOTACOES");

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("APELIDO");

                    b.Property<string>("Bairro")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CEP");

                    b.Property<string>("Complemento")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("DataIdentidade")
                        .HasColumnType("date")
                        .HasColumnName("DATA_IDENTIDADE");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("DATA_NASCIMENTO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("ENDERECO");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_CIDADE");

                    b.Property<int>("IdEmissor")
                        .HasColumnType("int")
                        .HasColumnName("ID_EMISSOR");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO");

                    b.Property<int>("IdEstadoCivil")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO_CIVIL");

                    b.Property<int>("IdNacionalidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_NACIONALIDADE");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    b.Property<int>("IdSexo")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO");

                    b.Property<string>("Identidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("IDENTIDADE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("TELEFONE");

                    b.HasKey("IdCliente", "IdApoio")
                        .HasName("PK_PESSOAL_APOIO");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdApoio"), false);

                    b.HasIndex("IdCliente", "IdAtleta");

                    b.HasIndex("IdCliente", "IdEmissor");

                    b.HasIndex("IdCliente", "IdEstadoCivil");

                    b.HasIndex("IdCliente", "IdNacionalidade");

                    b.HasIndex("IdCliente", "IdSexo");

                    b.HasIndex("IdCliente", "IdPais", "IdEstado", "IdCidade");

                    b.HasIndex(new[] { "IdCliente", "Apelido" }, "UK_PESSOAL_APOIO_APELIDOS")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "Cpf" }, "UK_PESSOAL_APOIO_CPF")
                        .IsUnique();

                    b.ToTable("TB_PESSOAL_APOIO", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPontuaco", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdPontuacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PONTUACAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPontuacao"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("OrdemExibicao")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdPontuacao")
                        .HasName("PK_PONTUACOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdPontuacao"), false);

                    b.HasIndex(new[] { "IdCliente", "OrdemExibicao" }, "UK_PONTUACOES_ORDENS_EXIBICAO")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_PONTUACOES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_PONTUACOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbProfessore", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdProfessor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PROFESSOR");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProfessor"), 1L, 1);

                    b.Property<string>("Anotacoes")
                        .HasColumnType("text")
                        .HasColumnName("ANOTACOES");

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("APELIDO");

                    b.Property<string>("Bairro")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CEP");

                    b.Property<string>("Complemento")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("DataIdentidade")
                        .HasColumnType("date")
                        .HasColumnName("DATA_IDENTIDADE");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("DATA_NASCIMENTO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("ENDERECO");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_CIDADE");

                    b.Property<int>("IdEmissor")
                        .HasColumnType("int")
                        .HasColumnName("ID_EMISSOR");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO");

                    b.Property<int>("IdEstadoCivil")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO_CIVIL");

                    b.Property<int>("IdNacionalidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_NACIONALIDADE");

                    b.Property<int>("IdNivel")
                        .HasColumnType("int")
                        .HasColumnName("ID_NIVEL");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    b.Property<int>("IdSexo")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO");

                    b.Property<string>("Identidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("IDENTIDADE");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("TELEFONE");

                    b.HasKey("IdCliente", "IdProfessor")
                        .HasName("PK_PROFESSORES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdProfessor"), false);

                    b.HasIndex("IdCliente", "IdAtleta");

                    b.HasIndex("IdCliente", "IdEmissor");

                    b.HasIndex("IdCliente", "IdEstadoCivil");

                    b.HasIndex("IdCliente", "IdNacionalidade");

                    b.HasIndex("IdCliente", "IdSexo");

                    b.HasIndex("IdCliente", "IdPais", "IdEstado", "IdCidade");

                    b.HasIndex(new[] { "IdCliente", "Apelido" }, "UK_PROFESSORES_APELIDOS")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "Cpf" }, "UK_PROFESSORES_CPF")
                        .IsUnique();

                    b.ToTable("TB_PROFESSORES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbProfisso", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdProfissao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PROFISSAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProfissao"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdProfissao")
                        .HasName("PK_PROFISSOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdProfissao"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_PROFISSOES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_PROFISSOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPromocoesArbitro", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdArbitro")
                        .HasColumnType("int")
                        .HasColumnName("ID_ARBITRO");

                    b.Property<DateTime>("DataPromocao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_PROMOCAO");

                    b.Property<int>("IdNivelArbitroAnterior")
                        .HasColumnType("int")
                        .HasColumnName("ID_NIVEL_ARBITRO_ANTERIOR");

                    b.Property<int>("IdNivelArbitroNovo")
                        .HasColumnType("int")
                        .HasColumnName("ID_NIVEL_ARBITRO_NOVO");

                    b.Property<int>("IdTipoPromocaoArbitro")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PROMOCAO_ARBITRO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdArbitro", "DataPromocao")
                        .HasName("PK_PROMOCOES_ARBITROS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdArbitro", "DataPromocao"), false);

                    b.HasIndex("IdCliente", "IdNivelArbitroAnterior");

                    b.HasIndex("IdCliente", "IdNivelArbitroNovo");

                    b.HasIndex("IdCliente", "IdTipoPromocaoArbitro");

                    b.ToTable("TB_PROMOCOES_ARBITROS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPromocoesAtleta", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<DateTime>("DataPromocao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_PROMOCAO");

                    b.Property<int>("IdFaixaAnterior")
                        .HasColumnType("int")
                        .HasColumnName("ID_FAIXA_ANTERIOR");

                    b.Property<int>("IdFaixaNova")
                        .HasColumnType("int")
                        .HasColumnName("ID_FAIXA_NOVA");

                    b.Property<int>("IdTipoPromocaoAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PROMOCAO_ATLETA");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdAtleta", "DataPromocao")
                        .HasName("PK_PROMOCOES_ATLETAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAtleta", "DataPromocao"), false);

                    b.HasIndex("IdCliente", "IdFaixaAnterior");

                    b.HasIndex("IdCliente", "IdFaixaNova");

                    b.HasIndex("IdCliente", "IdTipoPromocaoAtleta");

                    b.ToTable("TB_PROMOCOES_ATLETAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbRecibo", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("NumeroRecibo")
                        .HasColumnType("int")
                        .HasColumnName("NUMERO_RECIBO");

                    b.Property<string>("Cnpj")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("date")
                        .HasColumnName("DATA_PAGAMENTO");

                    b.Property<int?>("IdAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    b.Property<int?>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME");

                    b.Property<string>("Origem")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("ORIGEM")
                        .HasDefaultValueSql("('G')")
                        .IsFixedLength();

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<decimal?>("ValorBonificacao")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_BONIFICACAO");

                    b.Property<decimal?>("ValorCartaoCredito")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_CARTAO_CREDITO");

                    b.Property<decimal?>("ValorCartaoDebito")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_CARTAO_DEBITO");

                    b.Property<decimal?>("ValorCheque")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_CHEQUE");

                    b.Property<decimal?>("ValorDebitoAutomatico")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_DEBITO_AUTOMATICO");

                    b.Property<decimal?>("ValorDinheiro")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_DINHEIRO");

                    b.Property<decimal?>("ValorPix")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_PIX");

                    b.HasKey("IdCliente", "NumeroRecibo")
                        .HasName("PK_RECIBOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "NumeroRecibo"), false);

                    b.HasIndex("IdCliente", "IdAgremiacao");

                    b.HasIndex("IdCliente", "IdAtleta");

                    b.HasIndex("IdCliente", "IdUsuario");

                    b.ToTable("TB_RECIBOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbRecibosIten", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdRecibo")
                        .HasColumnType("int")
                        .HasColumnName("ID_RECIBO");

                    b.Property<int>("IdItemRecibo")
                        .HasColumnType("int")
                        .HasColumnName("ID_ITEM_RECIBO");

                    b.Property<int>("IdFormaPagamento")
                        .HasColumnType("int")
                        .HasColumnName("ID_FORMA_PAGAMENTO");

                    b.Property<int>("IdServico")
                        .HasColumnType("int")
                        .HasColumnName("ID_SERVICO");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("QUANTIDADE");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<decimal>("ValorDesconto")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_DESCONTO");

                    b.Property<decimal>("ValorUnitario")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_UNITARIO");

                    b.HasKey("IdCliente", "IdRecibo", "IdItemRecibo")
                        .HasName("PK_RECIBOS_ITENS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdRecibo", "IdItemRecibo"), false);

                    b.HasIndex("IdCliente", "IdFormaPagamento");

                    b.HasIndex("IdCliente", "IdServico");

                    b.ToTable("TB_RECIBOS_ITENS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbRegio", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdRegiao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_REGIAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRegiao"), 1L, 1);

                    b.Property<string>("Anotacoes")
                        .HasColumnType("text")
                        .HasColumnName("ANOTACOES");

                    b.Property<string>("Bairro")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("BAIRRO");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CEP");

                    b.Property<string>("Complemento")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("COMPLEMENTO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Email")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("ENDERECO");

                    b.Property<int>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_CIDADE");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO");

                    b.Property<int>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    b.Property<string>("Responsavel")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("RESPONSAVEL");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.Property<string>("Telefone")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("TELEFONE");

                    b.HasKey("IdCliente", "IdRegiao")
                        .HasName("PK_REGIOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdRegiao"), false);

                    b.HasIndex("IdCliente", "IdPais", "IdEstado", "IdCidade");

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_REGIOES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_REGIOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbRegistroEvento", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_EVENTO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEvento"), 1L, 1);

                    b.Property<DateTime>("DataHoraEvento")
                        .HasColumnType("datetime")
                        .HasColumnName("DATA_HORA_EVENTO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("IdComputador")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("ID_COMPUTADOR");

                    b.Property<int>("IdFuncaoMenu")
                        .HasColumnType("int")
                        .HasColumnName("ID_FUNCAO_MENU");

                    b.Property<int>("IdTipoOperacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_OPERACAO");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdEvento")
                        .HasName("PK_REGISTRO_EVENTOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdEvento"), false);

                    b.HasIndex("IdCliente", "IdFuncaoMenu");

                    b.HasIndex("IdCliente", "IdTipoOperacao");

                    b.HasIndex("IdCliente", "IdUsuario");

                    b.ToTable("TB_REGISTRO_EVENTOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbSexo", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdSexo")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("SIGLA")
                        .IsFixedLength();

                    b.HasKey("IdCliente", "IdSexo")
                        .HasName("PK_SEXOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdSexo"), false);

                    b.ToTable("TB_SEXOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbSistema", b =>
                {
                    b.Property<int>("IdSistema")
                        .HasColumnType("int")
                        .HasColumnName("ID_SISTEMA");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.Property<string>("Versao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("VERSAO");

                    b.HasKey("IdSistema")
                        .HasName("PK_SISTEMA");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdSistema"), false);

                    b.ToTable("TB_SISTEMAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbSistemasMensagen", b =>
                {
                    b.Property<int>("IdSistema")
                        .HasColumnType("int")
                        .HasColumnName("ID_SISTEMA");

                    b.Property<int>("IdMensagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_MENSAGEM");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMensagem"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)")
                        .HasColumnName("DESCRICAO");

                    b.Property<int>("IdTipoMensagem")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_MENSAGEM");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdSistema", "IdMensagem")
                        .HasName("PK_SISTEMAS_MENSAGENS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdSistema", "IdMensagem"), false);

                    b.HasIndex("IdSistema", "IdTipoMensagem");

                    b.HasIndex(new[] { "IdSistema", "Sigla" }, "UK_SISTEMAS_MENSAGENS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_SISTEMAS_MENSAGENS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbSistemasTiposMensagen", b =>
                {
                    b.Property<int>("IdSistema")
                        .HasColumnType("int")
                        .HasColumnName("ID_SISTEMA");

                    b.Property<int>("IdTipoMensagem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_MENSAGEM");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoMensagem"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdSistema", "IdTipoMensagem")
                        .HasName("PK_SISTEMAS_TIPOS_MENSAGENS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdSistema", "IdTipoMensagem"), false);

                    b.HasIndex(new[] { "IdSistema", "Sigla" }, "UK_SISTEMAS_TIPOS_MENSAGENS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_SISTEMAS_TIPOS_MENSAGENS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelaPeso", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdClasse")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLASSE");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("ID_CATEGORIA");

                    b.Property<int>("IdSexo")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO");

                    b.Property<int>("OrdemExibicaoCategoria")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO_CATEGORIA");

                    b.Property<int>("OrdemExibicaoClasse")
                        .HasColumnType("int")
                        .HasColumnName("ORDEM_EXIBICAO_CLASSE");

                    b.Property<double>("PesoFinal")
                        .HasColumnType("float")
                        .HasColumnName("PESO_FINAL");

                    b.Property<double>("PesoInicial")
                        .HasColumnType("float")
                        .HasColumnName("PESO_INICIAL");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdClasse", "IdCategoria")
                        .HasName("PK_TABELA_PESOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdClasse", "IdCategoria"), false);

                    b.HasIndex("IdCliente", "IdCategoria");

                    b.HasIndex(new[] { "IdCliente", "OrdemExibicaoCategoria" }, "UK_TABELA_PESOS_ORDENS_EXIBICAO_CATEGORIAS")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCliente", "OrdemExibicaoClasse" }, "UK_TABELA_PESOS_ORDENS_EXIBICAO_CLASSES")
                        .IsUnique();

                    b.ToTable("TB_TABELA_PESOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelasAnuidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTabela")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TABELA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTabela"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<decimal>("ValorAnuidade")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_ANUIDADE");

                    b.Property<decimal>("ValorRegistro")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_REGISTRO");

                    b.HasKey("IdCliente", "IdTabela")
                        .HasName("PK_TABELAS_ANUIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTabela"), false);

                    b.ToTable("TB_TABELAS_ANUIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelasAnuidadesConfederacao", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTabela")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TABELA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTabela"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<decimal>("ValorAnuidade")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_ANUIDADE");

                    b.Property<decimal>("ValorRegistro")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_REGISTRO");

                    b.HasKey("IdCliente", "IdTabela")
                        .HasName("PK_TABELAS_ANUIDADES_CONFEDERACAO");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTabela"), false);

                    b.ToTable("TB_TABELAS_ANUIDADES_CONFEDERACAO", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelaServico", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_SERVICO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdServico"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.Property<decimal>("Valor")
                        .HasColumnType("money")
                        .HasColumnName("VALOR");

                    b.HasKey("IdCliente", "IdServico")
                        .HasName("PK_TABELA_SERVICOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdServico"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TABELA_SERVICOS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TABELA_SERVICOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelasMensalidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTabela")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TABELA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTabela"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<decimal>("ValorMensalidade")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_MENSALIDADE");

                    b.HasKey("IdCliente", "IdTabela")
                        .HasName("PK_TABELAS_MENSALIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTabela"), false);

                    b.ToTable("TB_TABELAS_MENSALIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposAnuidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoAnuidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ANUIDADE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoAnuidade"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoAnuidade")
                        .HasName("PK_TIPOS_ANUIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoAnuidade"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_ANUIDADES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_ANUIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposAnuidadesConfederacao", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoAnuidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ANUIDADE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoAnuidade"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoAnuidade")
                        .HasName("PK_TIPOS_ANUIDADES_CONFEDERACAO");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoAnuidade"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_ANUIDADES_CONFEDERACAO_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_ANUIDADES_CONFEDERACAO", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposCurriculosAgremiaco", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoCurriculoAgremiacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_CURRICULO_AGREMIACAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoCurriculoAgremiacao"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoCurriculoAgremiacao")
                        .HasName("PK_TIPOS_CURRICULOS_AGREMIACOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoCurriculoAgremiacao"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_CURRICULOS_AGREMIACOES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_CURRICULOS_AGREMIACOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposCurriculosAtleta", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoCurriculoAtleta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_CURRICULO_ATLETA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoCurriculoAtleta"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoCurriculoAtleta")
                        .HasName("PK_TIPOS_CURRICULOS_ATLETAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoCurriculoAtleta"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_CURRICULOS_ATLETAS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_CURRICULOS_ATLETAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposDesfiliacoesAgremiaco", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoDesfiliacaoAgremiacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_DESFILIACAO_AGREMIACAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoDesfiliacaoAgremiacao"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoDesfiliacaoAgremiacao")
                        .HasName("PK_TIPOS_DESFILIACOES_AGREMIACOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoDesfiliacaoAgremiacao"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_DESFILIACOES_AGREMIACOES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_DESFILIACOES_AGREMIACOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposDesfiliacoesAtleta", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoDesfiliacaoAtleta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_DESFILIACAO_ATLETA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoDesfiliacaoAtleta"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoDesfiliacaoAtleta")
                        .HasName("PK_TIPOS_DESFILIACOES_ATLETAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoDesfiliacaoAtleta"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_DESFILIACOES_ATLETAS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_DESFILIACOES_ATLETAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposIsencoesAgremiaco", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoIsencaoAgremiacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ISENCAO_AGREMIACAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoIsencaoAgremiacao"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoIsencaoAgremiacao")
                        .HasName("PK_TIPOS_ISENCOES_AGREMIACOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoIsencaoAgremiacao"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_ISENCOES_AGREMIACOES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_ISENCOES_AGREMIACOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposIsencoesAtleta", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoIsencaoAtleta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ISENCAO_ATLETA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoIsencaoAtleta"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoIsencaoAtleta")
                        .HasName("PK_TIPOS_ISENCOES_ATLETAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoIsencaoAtleta"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_ISENCOES_ATLETAS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_ISENCOES_ATLETAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposItensRecibo", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ITEM");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoItem"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoItem")
                        .HasName("PK_TIPOS_ITENS_RECIBOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoItem"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_ITENS_RECIBOS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_ITENS_RECIBOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposOperaco", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoOperacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_OPERACAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoOperacao"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoOperacao")
                        .HasName("PK_TIPOS_OPERACOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoOperacao"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_OPERACOES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_OPERACOES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPagamentosAnuidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PAGAMENTO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoPagamento"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoPagamento")
                        .HasName("PK_TIPOS_PAGAMENTOS_ANUIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoPagamento"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_PAGAMENTOS_ANUIDADES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_PAGAMENTOS_ANUIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPagamentosAnuidadesConfederacao", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PAGAMENTO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoPagamento"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoPagamento")
                        .HasName("PK_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoPagamento"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPagamentosMensalidade", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PAGAMENTO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoPagamento"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoPagamento")
                        .HasName("PK_TIPOS_PAGAMENTOS_MENSALIDADES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoPagamento"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_PAGAMENTOS_MENSALIDADES_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_PAGAMENTOS_MENSALIDADES", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPromocoesArbitro", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoPromocao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PROMOCAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoPromocao"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoPromocao")
                        .HasName("PK_TIPOS_PROMOCOES_ARBITROS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoPromocao"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_PROMOCOES_ARBITROS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_PROMOCOES_ARBITROS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPromocoesAtleta", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoPromocao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PROMOCAO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoPromocao"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoPromocao")
                        .HasName("PK_TIPOS_PROMOCOES");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoPromocao"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_PROMOCOES_ATLETAS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_PROMOCOES_ATLETAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposTransferencia", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdTipoTransferencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_TRANSFERENCIA");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoTransferencia"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("DESCRICAO");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("SIGLA");

                    b.HasKey("IdCliente", "IdTipoTransferencia")
                        .HasName("PK_TIPOS_TRANSFERENCIAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdTipoTransferencia"), false);

                    b.HasIndex(new[] { "IdCliente", "Sigla" }, "UK_TIPOS_TRANSFERENCIAS_SIGLAS")
                        .IsUnique();

                    b.ToTable("TB_TIPOS_TRANSFERENCIAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTransferencia", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<DateTime>("DataTransferencia")
                        .HasColumnType("date")
                        .HasColumnName("DATA_TRANSFERENCIA");

                    b.Property<int>("IdAgremiacaoAnterior")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO_ANTERIOR");

                    b.Property<int>("IdAgremiacaoNova")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO_NOVA");

                    b.Property<int>("IdTipoTransferencia")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_TRANSFERENCIA");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.HasKey("IdCliente", "IdAtleta", "DataTransferencia")
                        .HasName("PK_TRANSFERENCIAS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdAtleta", "DataTransferencia"), false);

                    b.HasIndex("IdCliente", "IdAgremiacaoAnterior");

                    b.HasIndex("IdCliente", "IdAgremiacaoNova");

                    b.HasIndex("IdCliente", "IdTipoTransferencia");

                    b.ToTable("TB_TRANSFERENCIAS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbUsuario", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_USUARIO");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"), 1L, 1);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_CRIACAO");

                    b.Property<DateTime?>("DataExpiracao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_EXPIRACAO");

                    b.Property<DateTime?>("DataUltimoLogin")
                        .HasColumnType("date")
                        .HasColumnName("DATA_ULTIMO_LOGIN");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("LoginUsuario")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("LOGIN_USUARIO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("NOME");

                    b.Property<bool>("Selecao")
                        .HasColumnType("bit")
                        .HasColumnName("SELECAO");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("SENHA");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("SITUACAO")
                        .HasDefaultValueSql("('A')")
                        .IsFixedLength();

                    b.HasKey("IdCliente", "IdUsuario")
                        .HasName("PK_USUARIOS");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdUsuario"), false);

                    b.HasIndex(new[] { "IdCliente", "LoginUsuario" }, "UK_USUARIOS_LOGIN_USUARIO")
                        .IsUnique();

                    b.ToTable("TB_USUARIOS", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbValoresDefault", b =>
                {
                    b.Property<int>("IdCliente")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLIENTE");

                    b.Property<int>("IdDefault")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_DEFAULT");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDefault"), 1L, 1);

                    b.Property<string>("AnoBase")
                        .HasMaxLength(4)
                        .IsUnicode(false)
                        .HasColumnType("char(4)")
                        .HasColumnName("ANO_BASE")
                        .IsFixedLength();

                    b.Property<string>("Bairro")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("BAIRRO");

                    b.Property<DateTime?>("DataDesfiliacaoAgremiacao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_DESFILIACAO_AGREMIACAO");

                    b.Property<DateTime?>("DataDesfiliacaoAtleta")
                        .HasColumnType("date")
                        .HasColumnName("DATA_DESFILIACAO_ATLETA");

                    b.Property<int?>("DataEventoCurriculoAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("DATA_EVENTO_CURRICULO_AGREMIACAO");

                    b.Property<int?>("DataEventoCurriculoAtleta")
                        .HasColumnType("int")
                        .HasColumnName("DATA_EVENTO_CURRICULO_ATLETA");

                    b.Property<DateTime?>("DataFiliacao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_FILIACAO");

                    b.Property<DateTime?>("DataInscricao")
                        .HasColumnType("date")
                        .HasColumnName("DATA_INSCRICAO");

                    b.Property<DateTime?>("DataNascimento")
                        .HasColumnType("date")
                        .HasColumnName("DATA_NASCIMENTO");

                    b.Property<DateTime?>("DataPagamentoAnuidade")
                        .HasColumnType("date")
                        .HasColumnName("DATA_PAGAMENTO_ANUIDADE");

                    b.Property<DateTime?>("DataPagamentoMensalidade")
                        .HasColumnType("date")
                        .HasColumnName("DATA_PAGAMENTO_MENSALIDADE");

                    b.Property<DateTime?>("DataPagamentoRecibo")
                        .HasColumnType("date")
                        .HasColumnName("DATA_PAGAMENTO_RECIBO");

                    b.Property<DateTime?>("DataPromocaoArbitro")
                        .HasColumnType("date")
                        .HasColumnName("DATA_PROMOCAO_ARBITRO");

                    b.Property<DateTime?>("DataPromocaoAtleta")
                        .HasColumnType("date")
                        .HasColumnName("DATA_PROMOCAO_ATLETA");

                    b.Property<DateTime?>("DataTransferencia")
                        .HasColumnType("date")
                        .HasColumnName("DATA_TRANSFERENCIA");

                    b.Property<int?>("IdAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO");

                    b.Property<int?>("IdAgremiacaoAnterior")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO_ANTERIOR");

                    b.Property<int?>("IdAgremiacaoNova")
                        .HasColumnType("int")
                        .HasColumnName("ID_AGREMIACAO_NOVA");

                    b.Property<int?>("IdApoio")
                        .HasColumnType("int")
                        .HasColumnName("ID_APOIO");

                    b.Property<int?>("IdArbitro")
                        .HasColumnType("int")
                        .HasColumnName("ID_ARBITRO");

                    b.Property<int?>("IdAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_ATLETA");

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("ID_CATEGORIA");

                    b.Property<int?>("IdCidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_CIDADE");

                    b.Property<int?>("IdClasse")
                        .HasColumnType("int")
                        .HasColumnName("ID_CLASSE");

                    b.Property<int?>("IdCompeticao")
                        .HasColumnType("int")
                        .HasColumnName("ID_COMPETICAO");

                    b.Property<int?>("IdEmissorIdentidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_EMISSOR_IDENTIDADE");

                    b.Property<int?>("IdEstado")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO");

                    b.Property<int?>("IdEstadoCivil")
                        .HasColumnType("int")
                        .HasColumnName("ID_ESTADO_CIVIL");

                    b.Property<int?>("IdFaixa")
                        .HasColumnType("int")
                        .HasColumnName("ID_FAIXA");

                    b.Property<int?>("IdFaixaAnterior")
                        .HasColumnType("int")
                        .HasColumnName("ID_FAIXA_ANTERIOR");

                    b.Property<int?>("IdFaixaNova")
                        .HasColumnType("int")
                        .HasColumnName("ID_FAIXA_NOVA");

                    b.Property<int?>("IdFormaPagamento")
                        .HasColumnType("int")
                        .HasColumnName("ID_FORMA_PAGAMENTO");

                    b.Property<int?>("IdLocal")
                        .HasColumnType("int")
                        .HasColumnName("ID_LOCAL");

                    b.Property<int?>("IdNacionalidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_NACIONALIDADE");

                    b.Property<int?>("IdNivelAnterior")
                        .HasColumnType("int")
                        .HasColumnName("ID_NIVEL_ANTERIOR");

                    b.Property<int?>("IdNivelNovo")
                        .HasColumnType("int")
                        .HasColumnName("ID_NIVEL_NOVO");

                    b.Property<int?>("IdPais")
                        .HasColumnType("int")
                        .HasColumnName("ID_PAIS");

                    b.Property<int?>("IdPatrocinador")
                        .HasColumnType("int")
                        .HasColumnName("ID_PATROCINADOR");

                    b.Property<int?>("IdPenalidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_PENALIDADE");

                    b.Property<int?>("IdPontuacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_PONTUACAO");

                    b.Property<int?>("IdProfessor")
                        .HasColumnType("int")
                        .HasColumnName("ID_PROFESSOR");

                    b.Property<int?>("IdProfissaoAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_PROFISSAO_ATLETA");

                    b.Property<int?>("IdProfissaoMae")
                        .HasColumnType("int")
                        .HasColumnName("ID_PROFISSAO_MAE");

                    b.Property<int?>("IdProfissaoPai")
                        .HasColumnType("int")
                        .HasColumnName("ID_PROFISSAO_PAI");

                    b.Property<int?>("IdRegiao")
                        .HasColumnType("int")
                        .HasColumnName("ID_REGIAO");

                    b.Property<int?>("IdServico")
                        .HasColumnType("int")
                        .HasColumnName("ID_SERVICO");

                    b.Property<int?>("IdSexo")
                        .HasColumnType("int")
                        .HasColumnName("ID_SEXO");

                    b.Property<int?>("IdTabelaAnuidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_TABELA_ANUIDADE");

                    b.Property<int?>("IdTabelaMensalidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_TABELA_MENSALIDADE");

                    b.Property<int?>("IdTipoAnuidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ANUIDADE");

                    b.Property<int?>("IdTipoCurriculoAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_CURRICULO_AGREMIACAO");

                    b.Property<int?>("IdTipoCurriculoAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_CURRICULO_ATLETA");

                    b.Property<int?>("IdTipoDesfiliacaoAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_DESFILIACAO_AGREMIACAO");

                    b.Property<int?>("IdTipoDesfiliacaoAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_DESFILIACAO_ATLETA");

                    b.Property<int?>("IdTipoIsencaoAgremiacao")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ISENCAO_AGREMIACAO");

                    b.Property<int?>("IdTipoIsencaoAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_ISENCAO_ATLETA");

                    b.Property<int?>("IdTipoPagamentoAnuidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PAGAMENTO_ANUIDADE");

                    b.Property<int?>("IdTipoPagamentoMensalidade")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PAGAMENTO_MENSALIDADE");

                    b.Property<int?>("IdTipoPromocaoArbitro")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PROMOCAO_ARBITRO");

                    b.Property<int?>("IdTipoPromocaoAtleta")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_PROMOCAO_ATLETA");

                    b.Property<int?>("IdTipoTransferencia")
                        .HasColumnType("int")
                        .HasColumnName("ID_TIPO_TRANSFERENCIA");

                    b.Property<string>("MesBase")
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("char(6)")
                        .HasColumnName("MES_BASE")
                        .IsFixedLength();

                    b.Property<string>("Origem")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("char(1)")
                        .HasColumnName("ORIGEM")
                        .IsFixedLength();

                    b.Property<int?>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("QUANTIDADE");

                    b.Property<decimal?>("ValorAnuidade")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_ANUIDADE");

                    b.Property<decimal?>("ValorDescontoAnuidade")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_DESCONTO_ANUIDADE");

                    b.Property<decimal?>("ValorDescontoMensalidade")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_DESCONTO_MENSALIDADE");

                    b.Property<decimal?>("ValorMensalidade")
                        .HasColumnType("money")
                        .HasColumnName("VALOR_MENSALIDADE");

                    b.HasKey("IdCliente", "IdDefault")
                        .HasName("PK_VALORES_DEFAULT");

                    SqlServerKeyBuilderExtensions.IsClustered(b.HasKey("IdCliente", "IdDefault"), false);

                    b.HasIndex("IdCliente", "IdAgremiacao");

                    b.HasIndex("IdCliente", "IdAgremiacaoAnterior");

                    b.HasIndex("IdCliente", "IdAgremiacaoNova");

                    b.HasIndex("IdCliente", "IdApoio");

                    b.HasIndex("IdCliente", "IdArbitro");

                    b.HasIndex("IdCliente", "IdAtleta");

                    b.HasIndex("IdCliente", "IdCategoria");

                    b.HasIndex("IdCliente", "IdClasse");

                    b.HasIndex("IdCliente", "IdCompeticao");

                    b.HasIndex("IdCliente", "IdEmissorIdentidade");

                    b.HasIndex("IdCliente", "IdEstadoCivil");

                    b.HasIndex("IdCliente", "IdFaixa");

                    b.HasIndex("IdCliente", "IdFaixaAnterior");

                    b.HasIndex("IdCliente", "IdFaixaNova");

                    b.HasIndex("IdCliente", "IdFormaPagamento");

                    b.HasIndex("IdCliente", "IdLocal");

                    b.HasIndex("IdCliente", "IdNacionalidade");

                    b.HasIndex("IdCliente", "IdNivelAnterior");

                    b.HasIndex("IdCliente", "IdNivelNovo");

                    b.HasIndex("IdCliente", "IdPatrocinador");

                    b.HasIndex("IdCliente", "IdPenalidade");

                    b.HasIndex("IdCliente", "IdPontuacao");

                    b.HasIndex("IdCliente", "IdProfessor");

                    b.HasIndex("IdCliente", "IdProfissaoAtleta");

                    b.HasIndex("IdCliente", "IdProfissaoMae");

                    b.HasIndex("IdCliente", "IdProfissaoPai");

                    b.HasIndex("IdCliente", "IdRegiao");

                    b.HasIndex("IdCliente", "IdServico");

                    b.HasIndex("IdCliente", "IdSexo");

                    b.HasIndex("IdCliente", "IdTabelaAnuidade");

                    b.HasIndex("IdCliente", "IdTabelaMensalidade");

                    b.HasIndex("IdCliente", "IdTipoAnuidade");

                    b.HasIndex("IdCliente", "IdTipoCurriculoAgremiacao");

                    b.HasIndex("IdCliente", "IdTipoCurriculoAtleta");

                    b.HasIndex("IdCliente", "IdTipoDesfiliacaoAgremiacao");

                    b.HasIndex("IdCliente", "IdTipoDesfiliacaoAtleta");

                    b.HasIndex("IdCliente", "IdTipoIsencaoAgremiacao");

                    b.HasIndex("IdCliente", "IdTipoIsencaoAtleta");

                    b.HasIndex("IdCliente", "IdTipoPagamentoAnuidade");

                    b.HasIndex("IdCliente", "IdTipoPagamentoMensalidade");

                    b.HasIndex("IdCliente", "IdTipoPromocaoArbitro");

                    b.HasIndex("IdCliente", "IdTipoPromocaoAtleta");

                    b.HasIndex("IdCliente", "IdTipoTransferencia");

                    b.HasIndex("IdCliente", "IdPais", "IdEstado", "IdCidade");

                    b.ToTable("TB_VALORES_DEFAULT", (string)null);
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAgremiaco", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbAgremiacos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_AGREMIACOES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id")
                        .WithMany("TbAgremiacos")
                        .HasForeignKey("IdCliente", "IdPais")
                        .IsRequired()
                        .HasConstraintName("FK_AGREMIACOES_PAISES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbRegio", "IdNavigation")
                        .WithMany("TbAgremiacos")
                        .HasForeignKey("IdCliente", "IdRegiao")
                        .IsRequired()
                        .HasConstraintName("FK_AGREMIACOES_REGIOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstado", "Id1")
                        .WithMany("TbAgremiacos")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado")
                        .IsRequired()
                        .HasConstraintName("FK_AGREMIACOES_ESTADOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCidade", "Id2")
                        .WithMany("TbAgremiacos")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado", "IdCidade")
                        .IsRequired()
                        .HasConstraintName("FK_AGREMIACOES_CIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("Id2");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAgremiacoesProfessore", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbAgremiacoesProfessores")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_AGREMIACOES_PROFESSORES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbAgremiacoesProfessores")
                        .HasForeignKey("IdCliente", "IdAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_AGREMIACOES_PROFESSORES_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbProfessore", "IdNavigation")
                        .WithMany("TbAgremiacoesProfessores")
                        .HasForeignKey("IdCliente", "IdProfessor")
                        .IsRequired()
                        .HasConstraintName("FK_AGREMIACOES_PROFESSORES_PROFESSORES");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAnuidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbAnuidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_ANUIDADES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbAnuidades")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_ANUIDADES_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTabelasAnuidade", "IdNavigation")
                        .WithMany("TbAnuidades")
                        .HasForeignKey("IdCliente", "IdTabelaAnuidades")
                        .IsRequired()
                        .HasConstraintName("FK_ANUIDADES_TABELAS_ANUIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposAnuidade", "Id1")
                        .WithMany("TbAnuidades")
                        .HasForeignKey("IdCliente", "IdTipoAnuidade")
                        .IsRequired()
                        .HasConstraintName("FK_ANUIDADES_TIPOS_ANUIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposPagamentosAnuidade", "Id2")
                        .WithMany("TbAnuidades")
                        .HasForeignKey("IdCliente", "IdTipoPagamento")
                        .IsRequired()
                        .HasConstraintName("FK_ANUIDADES_TIPOS_PAGAMENTOS_ANUIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("Id2");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAnuidadesConfederacao", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbAnuidadesConfederacaos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbAnuidadesConfederacaos")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTabelasAnuidadesConfederacao", "IdNavigation")
                        .WithMany("TbAnuidadesConfederacaos")
                        .HasForeignKey("IdCliente", "IdTabelaAnuidades")
                        .IsRequired()
                        .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_TABELAS_ANUIDADES_CONFEDERACAO");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposAnuidadesConfederacao", "Id1")
                        .WithMany("TbAnuidadesConfederacaos")
                        .HasForeignKey("IdCliente", "IdTipoAnuidade")
                        .IsRequired()
                        .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_TIPOS_ANUIDADES_CONFEDERACAO");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposPagamentosAnuidadesConfederacao", "Id2")
                        .WithMany("TbAnuidadesConfederacaos")
                        .HasForeignKey("IdCliente", "IdTipoPagamento")
                        .IsRequired()
                        .HasConstraintName("FK_ANUIDADES_CONFEDERACAO_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("Id2");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbArbitro", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbArbitros")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_ARBITROS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbArbitros")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_ARBITROS_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEmissoresIdentidade", "IdNavigation")
                        .WithMany("TbArbitros")
                        .HasForeignKey("IdCliente", "IdEmissor")
                        .IsRequired()
                        .HasConstraintName("FK_ARBITROS_EMISSORES_IDENTIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstadosCivi", "Id1")
                        .WithMany("TbArbitros")
                        .HasForeignKey("IdCliente", "IdEstadoCivil")
                        .IsRequired()
                        .HasConstraintName("FK_ARBITROS_ESTADOS_CIVIS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id2")
                        .WithMany("TbArbitroId2s")
                        .HasForeignKey("IdCliente", "IdNacionalidade")
                        .IsRequired()
                        .HasConstraintName("FK_ARBITROS_PAISES1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbNiveisArbitro", "Id3")
                        .WithMany("TbArbitros")
                        .HasForeignKey("IdCliente", "IdNivel")
                        .IsRequired()
                        .HasConstraintName("FK_ARBITROS_NIVEIS_ARBITROS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id4")
                        .WithMany("TbArbitroId4s")
                        .HasForeignKey("IdCliente", "IdPais")
                        .IsRequired()
                        .HasConstraintName("FK_ARBITROS_PAISES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbSexo", "Id5")
                        .WithMany("TbArbitros")
                        .HasForeignKey("IdCliente", "IdSexo")
                        .IsRequired()
                        .HasConstraintName("FK_ARBITROS_SEXOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstado", "Id6")
                        .WithMany("TbArbitros")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado")
                        .IsRequired()
                        .HasConstraintName("FK_ARBITROS_ESTADOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCidade", "Id7")
                        .WithMany("TbArbitros")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado", "IdCidade")
                        .IsRequired()
                        .HasConstraintName("FK_ARBITROS_CIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("Id2");

                    b.Navigation("Id3");

                    b.Navigation("Id4");

                    b.Navigation("Id5");

                    b.Navigation("Id6");

                    b.Navigation("Id7");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAtleta", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbAtleta")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_ATLETAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbAtleta")
                        .HasForeignKey("IdCliente", "IdAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_ATLETAS_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEmissoresIdentidade", "IdNavigation")
                        .WithMany("TbAtleta")
                        .HasForeignKey("IdCliente", "IdEmissor")
                        .IsRequired()
                        .HasConstraintName("FK_ATLETAS_EMISSORES_IDENTIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstadosCivi", "Id1")
                        .WithMany("TbAtleta")
                        .HasForeignKey("IdCliente", "IdEstadoCivil")
                        .IsRequired()
                        .HasConstraintName("FK_ATLETAS_ESTADOS_CIVIS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFaixa", "Id2")
                        .WithMany("TbAtleta")
                        .HasForeignKey("IdCliente", "IdFaixa")
                        .IsRequired()
                        .HasConstraintName("FK_ATLETAS_FAIXAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id3")
                        .WithMany("TbAtletaId3s")
                        .HasForeignKey("IdCliente", "IdNacionalidade")
                        .IsRequired()
                        .HasConstraintName("FK_ATLETAS_PAISES1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id4")
                        .WithMany("TbAtletaId4s")
                        .HasForeignKey("IdCliente", "IdPais")
                        .IsRequired()
                        .HasConstraintName("FK_ATLETAS_PAISES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbProfisso", "Id5")
                        .WithMany("TbAtletaId5s")
                        .HasForeignKey("IdCliente", "IdProfissaoAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_ATLETAS_PROFISSOES1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbProfisso", "Id6")
                        .WithMany("TbAtletaId6s")
                        .HasForeignKey("IdCliente", "IdProfissaoMae")
                        .HasConstraintName("FK_ATLETAS_PROFISSOES3");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbProfisso", "Id7")
                        .WithMany("TbAtletaId7s")
                        .HasForeignKey("IdCliente", "IdProfissaoPai")
                        .HasConstraintName("FK_ATLETAS_PROFISSOES2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbSexo", "Id8")
                        .WithMany("TbAtleta")
                        .HasForeignKey("IdCliente", "IdSexo")
                        .IsRequired()
                        .HasConstraintName("FK_ATLETAS_SEXOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstado", "Id9")
                        .WithMany("TbAtleta")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado")
                        .IsRequired()
                        .HasConstraintName("FK_ATLETAS_ESTADOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCidade", "Id10")
                        .WithMany("TbAtleta")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado", "IdCidade")
                        .IsRequired()
                        .HasConstraintName("FK_ATLETAS_CIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("Id10");

                    b.Navigation("Id2");

                    b.Navigation("Id3");

                    b.Navigation("Id4");

                    b.Navigation("Id5");

                    b.Navigation("Id6");

                    b.Navigation("Id7");

                    b.Navigation("Id8");

                    b.Navigation("Id9");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCategoria", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCategoria")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_CATEGORIAS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_CIDADES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id")
                        .WithMany("TbCidades")
                        .HasForeignKey("IdCliente", "IdPais")
                        .IsRequired()
                        .HasConstraintName("FK_CIDADES_PAIS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstado", "IdNavigation")
                        .WithMany("TbCidades")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado")
                        .IsRequired()
                        .HasConstraintName("FK_CIDADES_ESTADOS");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbClass", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbClasses")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_CLASSES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbSexo", "Id")
                        .WithMany("TbClasses")
                        .HasForeignKey("IdCliente", "IdSexo")
                        .IsRequired()
                        .HasConstraintName("FK_CLASSES_SEXOS");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCliente", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbSistema", "IdSistemaNavigation")
                        .WithMany("TbClientes")
                        .HasForeignKey("IdSistema")
                        .IsRequired()
                        .HasConstraintName("FK_CLIENTES_SISTEMAS");

                    b.Navigation("IdSistemaNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCobranca", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCobrancas")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COBRANCAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbCobrancas")
                        .HasForeignKey("IdCliente", "IdAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_COBRANCAS_AGREMIACOES");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompetico", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbLocaisCompetico", "Id")
                        .WithMany("TbCompeticos")
                        .HasForeignKey("IdCliente", "IdLocal")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LOCAIS_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesTipo", "IdNavigation")
                        .WithMany("TbCompeticos")
                        .HasForeignKey("IdCliente", "IdTipoCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_COMPETICOES_TIPO");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesArbitro", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesArbitros")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_ARBITROS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbArbitro", "Id")
                        .WithMany("TbCompeticoesArbitros")
                        .HasForeignKey("IdCliente", "IdArbitro")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_ARBITROS_ARBITROS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesArbitros")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_ARBITROS_COMPETICOES");

                    b.Navigation("Id");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesArea", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesAreas")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_AREAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesAreas")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_AREAS_COMPETICOES");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesCategoria", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesCategoria")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CATEGORIAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesCategoria")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CATEGORIAS_COMPETICOES");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesChafe", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesChaves")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CHAVES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesChaves")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbSexo", "Id")
                        .WithMany("TbCompeticoesChaves")
                        .HasForeignKey("IdCliente", "IdSexo")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CHAVES_SEXOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesCategoria", "IdCNavigation")
                        .WithMany("TbCompeticoesChaves")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdCategoria")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_CATEGORIAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesClass", "IdC1")
                        .WithMany("TbCompeticoesChaves")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdClasse")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_CLASSES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesFaixa", "IdNavigation")
                        .WithMany("TbCompeticoesChafeIdNavigations")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdFaixaFinal")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_FAIXAS2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesFaixa", "Id1")
                        .WithMany("TbCompeticoesChafeId1s")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdFaixaInicial")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CHAVES_COMPETICOES_FAIXAS1");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdC");

                    b.Navigation("IdC1");

                    b.Navigation("IdCNavigation");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesClass", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesClasses")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CLASSES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesClasses")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CLASSES_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbSexo", "Id")
                        .WithMany("TbCompeticoesClasses")
                        .HasForeignKey("IdCliente", "IdSexo")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CLASSES_SEXOS");

                    b.Navigation("Id");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesClassesRegra", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesClassesRegras")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesClassesRegras")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesClass", "IdCNavigation")
                        .WithMany("TbCompeticoesClassesRegraIdCNavigations")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdClasseInscricao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES_CLASSES2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesClass", "IdC1")
                        .WithMany("TbCompeticoesClassesRegraIdC1s")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdClasseReal")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES_CLASSES1");

                    b.Navigation("IdC");

                    b.Navigation("IdC1");

                    b.Navigation("IdCNavigation");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesFaixa", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesFaixas")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_FAIXAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesFaixas")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_FAIXAS_COMPETICOES");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesInscrico", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesInscricos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_INSCRICOES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbCompeticoesInscricos")
                        .HasForeignKey("IdCliente", "IdAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_INSCRICOES_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "IdNavigation")
                        .WithMany("TbCompeticoesInscricos")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_INSCRICOES_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesInscricos")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_INSCRICOES_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesChafe", "IdCNavigation")
                        .WithMany("TbCompeticoesInscricos")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdChave")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_INSCRICOES_COMPETICOES_CHAVES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesFaixa", "Id1")
                        .WithMany("TbCompeticoesInscricos")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdFaixa")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_INSCRICOES_COMPETICOES_FAIXAS");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdC");

                    b.Navigation("IdCNavigation");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesLuta", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesLuta")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbCompeticoesLutaIds")
                        .HasForeignKey("IdCliente", "IdAtleta1")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_ATLETAS1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "IdNavigation")
                        .WithMany("TbCompeticoesLutaIdNavigations")
                        .HasForeignKey("IdCliente", "IdAtleta2")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_ATLETAS2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id1")
                        .WithMany("TbCompeticoesLutaId1s")
                        .HasForeignKey("IdCliente", "IdAtletaVencedor")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_ATLETAS3");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesLuta")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesChafe", "IdCNavigation")
                        .WithMany("TbCompeticoesLuta")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdChave")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_COMPETICOES_CHAVES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdC");

                    b.Navigation("IdCNavigation");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesLutasPenalidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesLutasPenalidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbCompeticoesLutasPenalidades")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesLutasPenalidades")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesLuta", "IdNavigation")
                        .WithMany("TbCompeticoesLutasPenalidades")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdLuta")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_LUTAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesPenalidade", "Id1")
                        .WithMany("TbCompeticoesLutasPenalidades")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdPenalidade")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_PENALIDADES_COMPETICOES_PENALIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesLutasPontuaco", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesLutasPontuacos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbCompeticoesLutasPontuacos")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesLutasPontuacos")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesLuta", "IdNavigation")
                        .WithMany("TbCompeticoesLutasPontuacos")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdLuta")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_LUTAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesPontuaco", "Id1")
                        .WithMany("TbCompeticoesLutasPontuacos")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdPontuacao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_LUTAS_PONTUACOES_COMPETICOES_PONTUACOES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesPatrocinadore", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesPatrocinadores")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_PATROCINADORES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesPatrocinadores")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_PATROCINADORES_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPatrocinadore", "Id")
                        .WithMany("TbCompeticoesPatrocinadores")
                        .HasForeignKey("IdCliente", "IdPatrocinador")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_PATROCINADORES_PATROCINADORES");

                    b.Navigation("Id");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesPenalidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesPenalidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_PENALIDADES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesPenalidades")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_PENALIDADES_COMPETICOES");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesPessoalApoio", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesPessoalApoios")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIOS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPessoalApoio", "Id")
                        .WithMany("TbCompeticoesPessoalApoios")
                        .HasForeignKey("IdCliente", "IdApoio")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIO_PESSOAL_APOIO");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesPessoalApoios")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIO_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFuncoesApoio", "IdNavigation")
                        .WithMany("TbCompeticoesPessoalApoios")
                        .HasForeignKey("IdCliente", "IdFuncao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_PESSOAL_APOIO_FUNCOES_APOIO");

                    b.Navigation("Id");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesPontuaco", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesPontuacos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_PONTUACOES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesPontuacos")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_PONTUACOES_COMPETICOES");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesResultado", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesResultados")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_RESULTADOS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbCompeticoesResultados")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_RESULTADOS_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesResultados")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_RESULTADOS_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesChafe", "IdCNavigation")
                        .WithMany("TbCompeticoesResultados")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdChave")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_RESULTADOS_CHAVES");

                    b.Navigation("Id");

                    b.Navigation("IdC");

                    b.Navigation("IdCNavigation");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesTabelasPeso", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesTabelasPesos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesTabelasPesos")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbSexo", "Id")
                        .WithMany("TbCompeticoesTabelasPesos")
                        .HasForeignKey("IdCliente", "IdSexo")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_SEXOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesCategoria", "IdCNavigation")
                        .WithMany("TbCompeticoesTabelasPesos")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdCategoria")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_COMPETICOES_CATEGORIAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompeticoesClass", "IdC1")
                        .WithMany("TbCompeticoesTabelasPesos")
                        .HasForeignKey("IdCliente", "IdCompeticao", "IdClasse")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_TABELAS_PESOS_COMPETICOES_CLASSES");

                    b.Navigation("Id");

                    b.Navigation("IdC");

                    b.Navigation("IdC1");

                    b.Navigation("IdCNavigation");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesTecnico", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesTecnicos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_TECNICOS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbCompeticoesTecnicos")
                        .HasForeignKey("IdCliente", "IdAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_TECNICOS_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdC")
                        .WithMany("TbCompeticoesTecnicos")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_TECNICOS_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbProfessore", "IdNavigation")
                        .WithMany("TbCompeticoesTecnicos")
                        .HasForeignKey("IdCliente", "IdProfessor")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_TECNICOS_PROFESSORES");

                    b.Navigation("Id");

                    b.Navigation("IdC");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesTipo", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCompeticoesTipos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_COMPETICOES_TIPOS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCurriculosAgremiaco", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCurriculosAgremiacos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_CURRICULOS_AGREMIACOES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbCurriculosAgremiacos")
                        .HasForeignKey("IdCliente", "IdAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_CURRICULOS_AGREMIACOES_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposCurriculosAgremiaco", "IdNavigation")
                        .WithMany("TbCurriculosAgremiacos")
                        .HasForeignKey("IdCliente", "IdTipoCurriculoAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_CURRICULOS_AGREMIACOES_TIPOS_CURRICULOS_AGREMIACOES");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCurriculosAtleta", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbCurriculosAtleta")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_CURRICULOS_ATLETAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbCurriculosAtleta")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_CURRICULOS_ATLETAS_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposCurriculosAtleta", "IdNavigation")
                        .WithMany("TbCurriculosAtleta")
                        .HasForeignKey("IdCliente", "IdTipoCurriculoAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_CURRICULOS_ATLETAS_TIPOS_CURRICULOS_ATLETAS");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbDesfiliacoesAgremiaco", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbDesfiliacoesAgremiacos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_DESFILIACOES_AGREMIACOES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbDesfiliacoesAgremiacos")
                        .HasForeignKey("IdCliente", "IdAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_DESFILIACOES_AGREMIACOES_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposDesfiliacoesAgremiaco", "IdNavigation")
                        .WithMany("TbDesfiliacoesAgremiacos")
                        .HasForeignKey("IdCliente", "IdTipoDesfiliacaoAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_DESFILIACOES_AGREMIACOES_TIPOS_DESFILIACOES_AGREMIACOES");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbDesfiliacoesAtleta", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbDesfiliacoesAtleta")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_DESFILIACOES_ATLETAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbDesfiliacoesAtleta")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_DESFILIACOES_ATLETAS_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposDesfiliacoesAtleta", "IdNavigation")
                        .WithMany("TbDesfiliacoesAtleta")
                        .HasForeignKey("IdCliente", "IdTipoDesfiliacaoAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_DESFILIACOES_ATLETAS_TIPOS_DESFILIACOES_ATLETAS");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbEmissoresIdentidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbEmissoresIdentidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_EMISSORES_IDENTIDADES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbEstado", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbEstados")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_ESTADOS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id")
                        .WithMany("TbEstados")
                        .HasForeignKey("IdCliente", "IdPais")
                        .IsRequired()
                        .HasConstraintName("FK_ESTADOS_PAISES");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFaixa", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbFaixas")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_FAIXAS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFormasPagamento", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbFormasPagamentos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_FORMAS_PAGAMENTOS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFuncoesApoio", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbFuncoesApoios")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_FUNCOES_APOIO_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFuncoesApoioPessoalApoio", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbFuncoesApoioPessoalApoios")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_FUNCOES_APOIO_PESSOAL_APOIO_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPessoalApoio", "Id")
                        .WithMany("TbFuncoesApoioPessoalApoios")
                        .HasForeignKey("IdCliente", "IdApoio")
                        .IsRequired()
                        .HasConstraintName("FK_FUNCOES_APOIO_PESSOAL_APOIO_PESSOAL_APOIO");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFuncoesApoio", "IdNavigation")
                        .WithMany("TbFuncoesApoioPessoalApoios")
                        .HasForeignKey("IdCliente", "IdFuncao")
                        .IsRequired()
                        .HasConstraintName("FK_FUNCOES_APOIO_PESSOAL_APOIO_FUNCOES_APOIO");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFuncoesMenu", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbFuncoesMenus")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_FUNCOES_MENU_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbIsencoesAgremiaco", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbIsencoesAgremiacos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_ISENCOES_AGREMIACOES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbIsencoesAgremiacos")
                        .HasForeignKey("IdCliente", "IdAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_ISENCOES_AGREMIACOES_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposIsencoesAgremiaco", "IdNavigation")
                        .WithMany("TbIsencoesAgremiacos")
                        .HasForeignKey("IdCliente", "IdTipoIsencaoAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_ISENCOES_AGREMIACOES_TIPOS_ISENCOES_AGREMIACOES");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbIsencoesAtleta", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbIsencoesAtleta")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_ISENCOES_ATLETAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbIsencoesAtleta")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_ISENCOES_ATLETAS_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposIsencoesAtleta", "IdNavigation")
                        .WithMany("TbIsencoesAtleta")
                        .HasForeignKey("IdCliente", "IdTipoIsencaoAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_ISENCOES_ATLETAS_TIPOS_ISENCOES_ATLETAS");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbLocaisCompetico", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbLocaisCompeticos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_LOCAIS_COMPETICOES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id")
                        .WithMany("TbLocaisCompeticos")
                        .HasForeignKey("IdCliente", "IdPais")
                        .IsRequired()
                        .HasConstraintName("FK_LOCAIS_COMPETICOES_PAISES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstado", "IdNavigation")
                        .WithMany("TbLocaisCompeticos")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado")
                        .IsRequired()
                        .HasConstraintName("FK_LOCAIS_COMPETICOES_ESTADOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCidade", "Id1")
                        .WithMany("TbLocaisCompeticos")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado", "IdCidade")
                        .IsRequired()
                        .HasConstraintName("FK_LOCAIS_COMPETICOES_CIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbMensalidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbMensalidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_MENSALIDADES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbMensalidades")
                        .HasForeignKey("IdCliente", "IdAgremiacao")
                        .IsRequired()
                        .HasConstraintName("FK_MENSALIDADES_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTabelasMensalidade", "IdNavigation")
                        .WithMany("TbMensalidades")
                        .HasForeignKey("IdCliente", "IdTabelaMensalidades")
                        .IsRequired()
                        .HasConstraintName("FK_MENSALIDADES_TABELAS_MENSALIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposPagamentosMensalidade", "Id1")
                        .WithMany("TbMensalidades")
                        .HasForeignKey("IdCliente", "IdTipoPagamento")
                        .IsRequired()
                        .HasConstraintName("FK_MENSALIDADES_TIPOS_PAGAMENTOS_MENSALIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbNiveisArbitro", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbNiveisArbitros")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_NIVEIS_ARBITROS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPaise", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbPaises")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PAISES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPatrocinadore", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbPatrocinadores")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PATROCINADORES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id")
                        .WithMany("TbPatrocinadores")
                        .HasForeignKey("IdCliente", "IdPais")
                        .IsRequired()
                        .HasConstraintName("FK_PATROCINADORES_PAISES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstado", "IdNavigation")
                        .WithMany("TbPatrocinadores")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado")
                        .IsRequired()
                        .HasConstraintName("FK_PATROCINADORES_ESTADOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCidade", "Id1")
                        .WithMany("TbPatrocinadores")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado", "IdCidade")
                        .IsRequired()
                        .HasConstraintName("FK_PATROCINADORES_CIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPenalidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbPenalidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PENALIDADES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPerfi", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbPerfis")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PERFIS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPerfisUsuario", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbPerfisUsuarios")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PERFIS_USUARIOS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPerfi", "Id")
                        .WithMany("TbPerfisUsuarios")
                        .HasForeignKey("IdCliente", "IdPerfil")
                        .IsRequired()
                        .HasConstraintName("FK_PERFIS_USUARIOS_PERFIS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbUsuario", "IdNavigation")
                        .WithMany("TbPerfisUsuarios")
                        .HasForeignKey("IdCliente", "IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_PERFIS_USUARIOS_USUARIOS");

                    b.Navigation("Id");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPermisso", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbPermissos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PERMISSOES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFuncoesMenu", "Id")
                        .WithMany("TbPermissos")
                        .HasForeignKey("IdCliente", "IdFuncaoMenu")
                        .IsRequired()
                        .HasConstraintName("FK_PERMISSOES_FUNCOES_MENU");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPerfi", "IdNavigation")
                        .WithMany("TbPermissos")
                        .HasForeignKey("IdCliente", "IdPerfil")
                        .IsRequired()
                        .HasConstraintName("FK_PERMISSOES_PERFIS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposOperaco", "Id1")
                        .WithMany("TbPermissos")
                        .HasForeignKey("IdCliente", "IdTipoOperacao")
                        .IsRequired()
                        .HasConstraintName("FK_PERMISSOES_TIPOS_OPERACOES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPessoalApoio", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbPessoalApoios")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PESSOAL_APOIO_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbPessoalApoios")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_PESSOAL_APOIO_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEmissoresIdentidade", "IdNavigation")
                        .WithMany("TbPessoalApoios")
                        .HasForeignKey("IdCliente", "IdEmissor")
                        .IsRequired()
                        .HasConstraintName("FK_PESSOAL_APOIO_EMISSORES_IDENTIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstadosCivi", "Id1")
                        .WithMany("TbPessoalApoios")
                        .HasForeignKey("IdCliente", "IdEstadoCivil")
                        .IsRequired()
                        .HasConstraintName("FK_PESSOAL_APOIO_ESTADOS_CIVIS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id2")
                        .WithMany("TbPessoalApoioId2s")
                        .HasForeignKey("IdCliente", "IdNacionalidade")
                        .IsRequired()
                        .HasConstraintName("FK_PESSOAL_APOIO_PAISES1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id3")
                        .WithMany("TbPessoalApoioId3s")
                        .HasForeignKey("IdCliente", "IdPais")
                        .IsRequired()
                        .HasConstraintName("FK_PESSOAL_APOIO_PAISES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbSexo", "Id4")
                        .WithMany("TbPessoalApoios")
                        .HasForeignKey("IdCliente", "IdSexo")
                        .IsRequired()
                        .HasConstraintName("FK_PESSOAL_APOIO_SEXOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstado", "Id5")
                        .WithMany("TbPessoalApoios")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado")
                        .IsRequired()
                        .HasConstraintName("FK_PESSOAL_APOIO_ESTADOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCidade", "Id6")
                        .WithMany("TbPessoalApoios")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado", "IdCidade")
                        .IsRequired()
                        .HasConstraintName("FK_PESSOAL_APOIO_CIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("Id2");

                    b.Navigation("Id3");

                    b.Navigation("Id4");

                    b.Navigation("Id5");

                    b.Navigation("Id6");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPontuaco", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbPontuacos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PONTUACOES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbProfessore", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbProfessores")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PROFESSORES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbProfessores")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_PROFESSORES_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEmissoresIdentidade", "IdNavigation")
                        .WithMany("TbProfessores")
                        .HasForeignKey("IdCliente", "IdEmissor")
                        .IsRequired()
                        .HasConstraintName("FK_PROFESSORES_EMISSORES_IDENTIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstadosCivi", "Id1")
                        .WithMany("TbProfessores")
                        .HasForeignKey("IdCliente", "IdEstadoCivil")
                        .IsRequired()
                        .HasConstraintName("FK_PROFESSORES_ESTADOS_CIVIS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id2")
                        .WithMany("TbProfessoreId2s")
                        .HasForeignKey("IdCliente", "IdNacionalidade")
                        .IsRequired()
                        .HasConstraintName("FK_PROFESSORES_PAISES1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id3")
                        .WithMany("TbProfessoreId3s")
                        .HasForeignKey("IdCliente", "IdPais")
                        .IsRequired()
                        .HasConstraintName("FK_PROFESSORES_PAISES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbSexo", "Id4")
                        .WithMany("TbProfessores")
                        .HasForeignKey("IdCliente", "IdSexo")
                        .IsRequired()
                        .HasConstraintName("FK_PROFESSORES_SEXOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstado", "Id5")
                        .WithMany("TbProfessores")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado")
                        .IsRequired()
                        .HasConstraintName("FK_PROFESSORES_ESTADOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCidade", "Id6")
                        .WithMany("TbProfessores")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado", "IdCidade")
                        .IsRequired()
                        .HasConstraintName("FK_PROFESSORES_CIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("Id2");

                    b.Navigation("Id3");

                    b.Navigation("Id4");

                    b.Navigation("Id5");

                    b.Navigation("Id6");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbProfisso", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbProfissos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PROFISSOES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPromocoesArbitro", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbPromocoesArbitros")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PROMOCOES_ARBITROS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbArbitro", "Id")
                        .WithMany("TbPromocoesArbitros")
                        .HasForeignKey("IdCliente", "IdArbitro")
                        .IsRequired()
                        .HasConstraintName("FK_PROMOCOES_ARBITROS_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbNiveisArbitro", "IdNavigation")
                        .WithMany("TbPromocoesArbitroIdNavigations")
                        .HasForeignKey("IdCliente", "IdNivelArbitroAnterior")
                        .IsRequired()
                        .HasConstraintName("FK_PROMOCOES_ARBITROS_NIVEIS_ARBITROS1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbNiveisArbitro", "Id1")
                        .WithMany("TbPromocoesArbitroId1s")
                        .HasForeignKey("IdCliente", "IdNivelArbitroNovo")
                        .IsRequired()
                        .HasConstraintName("FK_PROMOCOES_ARBITROS_NIVEIS_ARBITROS2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposPromocoesArbitro", "Id2")
                        .WithMany("TbPromocoesArbitros")
                        .HasForeignKey("IdCliente", "IdTipoPromocaoArbitro")
                        .IsRequired()
                        .HasConstraintName("FK_PROMOCOES_ARBITROS_TIPOS_PROMOCOES_ARBITROS");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("Id2");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPromocoesAtleta", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbPromocoesAtleta")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_PROMOCOES_ATLETAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id")
                        .WithMany("TbPromocoesAtleta")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_PROMOCOES_ATLETAS_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFaixa", "IdNavigation")
                        .WithMany("TbPromocoesAtletaIdNavigations")
                        .HasForeignKey("IdCliente", "IdFaixaAnterior")
                        .IsRequired()
                        .HasConstraintName("FK_PROMOCOES_ATLETAS_FAIXAS1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFaixa", "Id1")
                        .WithMany("TbPromocoesAtletaId1s")
                        .HasForeignKey("IdCliente", "IdFaixaNova")
                        .IsRequired()
                        .HasConstraintName("FK_PROMOCOES_ATLETAS_FAIXAS2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposPromocoesAtleta", "Id2")
                        .WithMany("TbPromocoesAtleta")
                        .HasForeignKey("IdCliente", "IdTipoPromocaoAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_PROMOCOES_ATLETAS_TIPOS_PROMOCOES_ATLETAS");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("Id2");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbRecibo", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbRecibos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_RECIBOS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbRecibos")
                        .HasForeignKey("IdCliente", "IdAgremiacao")
                        .HasConstraintName("FK_RECIBOS_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "IdNavigation")
                        .WithMany("TbRecibos")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .HasConstraintName("FK_RECIBOS_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbUsuario", "Id1")
                        .WithMany("TbRecibos")
                        .HasForeignKey("IdCliente", "IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_RECIBOS_USUARIOS");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbRecibosIten", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbRecibosItens")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_RECIBOS_ITENS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFormasPagamento", "Id")
                        .WithMany("TbRecibosItens")
                        .HasForeignKey("IdCliente", "IdFormaPagamento")
                        .IsRequired()
                        .HasConstraintName("FK_RECIBOS_ITENS_FORMAS_PAGAMENTO");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbRecibo", "IdNavigation")
                        .WithMany("TbRecibosItens")
                        .HasForeignKey("IdCliente", "IdRecibo")
                        .IsRequired()
                        .HasConstraintName("FK_RECIBOS_ITENS_RECIBOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTabelaServico", "Id1")
                        .WithMany("TbRecibosItens")
                        .HasForeignKey("IdCliente", "IdServico")
                        .IsRequired()
                        .HasConstraintName("FK_RECIBOS_ITENS_SERVICOS");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbRegio", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbRegios")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_REGIOES_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id")
                        .WithMany("TbRegios")
                        .HasForeignKey("IdCliente", "IdPais")
                        .IsRequired()
                        .HasConstraintName("FK_REGIOES_PAISES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstado", "IdNavigation")
                        .WithMany("TbRegios")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado")
                        .IsRequired()
                        .HasConstraintName("FK_REGIOES_ESTADOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCidade", "Id1")
                        .WithMany("TbRegios")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado", "IdCidade")
                        .IsRequired()
                        .HasConstraintName("FK_REGIOES_CIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbRegistroEvento", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbRegistroEventos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_REGISTRO_EVENTOS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFuncoesMenu", "Id")
                        .WithMany("TbRegistroEventos")
                        .HasForeignKey("IdCliente", "IdFuncaoMenu")
                        .IsRequired()
                        .HasConstraintName("FK_REGISTRO_EVENTOS_FUNCOES_MENU");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposOperaco", "IdNavigation")
                        .WithMany("TbRegistroEventos")
                        .HasForeignKey("IdCliente", "IdTipoOperacao")
                        .IsRequired()
                        .HasConstraintName("FK_REGISTRO_EVENTOS_TIPOS_OPERACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbUsuario", "Id1")
                        .WithMany("TbRegistroEventos")
                        .HasForeignKey("IdCliente", "IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_REGISTRO_EVENTOS_USUARIOS");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbSistemasMensagen", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbSistema", "IdSistemaNavigation")
                        .WithMany("TbSistemasMensagens")
                        .HasForeignKey("IdSistema")
                        .IsRequired()
                        .HasConstraintName("FK_SISTEMAS_MENSAGENS_SISTEMAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbSistemasTiposMensagen", "Id")
                        .WithMany("TbSistemasMensagens")
                        .HasForeignKey("IdSistema", "IdTipoMensagem")
                        .IsRequired()
                        .HasConstraintName("FK_SISTEMAS_MENSAGENS_SISTEMAS_TIPOS_MENSAGENS");

                    b.Navigation("Id");

                    b.Navigation("IdSistemaNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbSistemasTiposMensagen", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbSistema", "IdSistemaNavigation")
                        .WithMany("TbSistemasTiposMensagens")
                        .HasForeignKey("IdSistema")
                        .IsRequired()
                        .HasConstraintName("FK_SISTEMAS_TIPOS_MENSAGENS_SISTEMAS");

                    b.Navigation("IdSistemaNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelaPeso", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTabelaPesos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TABELA_PESOS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCategoria", "IdC")
                        .WithMany("TbTabelaPesos")
                        .HasForeignKey("IdCliente", "IdCategoria")
                        .IsRequired()
                        .HasConstraintName("FK_TABELA_PESOS_CATEGORIAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbClass", "IdCl")
                        .WithMany("TbTabelaPesos")
                        .HasForeignKey("IdCliente", "IdClasse")
                        .IsRequired()
                        .HasConstraintName("FK_TABELA_PESOS_CLASSES");

                    b.Navigation("IdC");

                    b.Navigation("IdCl");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelasAnuidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTabelasAnuidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TABELAS_ANUIDADES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelasAnuidadesConfederacao", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTabelasAnuidadesConfederacaos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TABELAS_ANUIDADES_CONFEDERACAO_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelaServico", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTabelaServicos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TABELA_SERVICOS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelasMensalidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTabelasMensalidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TABELAS_MENSALIDADES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposAnuidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposAnuidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_ANUIDADES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposAnuidadesConfederacao", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposAnuidadesConfederacaos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_ANUIDADES_CONFEDERACAO_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposCurriculosAgremiaco", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposCurriculosAgremiacos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_CURRICULOS_AGREMIACOES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposCurriculosAtleta", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposCurriculosAtleta")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_CURRICULOS_ATLETAS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposDesfiliacoesAgremiaco", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposDesfiliacoesAgremiacos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_DESFILIACOES_AGREMIACOES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposDesfiliacoesAtleta", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposDesfiliacoesAtleta")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_DESFILIACOES_ATLETAS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposIsencoesAgremiaco", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposIsencoesAgremiacos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_ISENCOES_AGREMIACOES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposIsencoesAtleta", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposIsencoesAtleta")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_ISENCOES_ATLETAS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposItensRecibo", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposItensRecibos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_ITENS_RECIBOS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposOperaco", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposOperacos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_OPERACOES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPagamentosAnuidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposPagamentosAnuidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_PAGAMENTOS_ANUIDADES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPagamentosAnuidadesConfederacao", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposPagamentosAnuidadesConfederacaos")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPagamentosMensalidade", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposPagamentosMensalidades")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_PAGAMENTOS_MENSALIDADES_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPromocoesArbitro", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposPromocoesArbitros")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_PROMOCOES_ARBITROS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPromocoesAtleta", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposPromocoesAtleta")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_PROMOCOES_ATLETAS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposTransferencia", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTiposTransferencia")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TIPOS_TRANSFERENCIAS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTransferencia", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbTransferencia")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_TRANSFERENCIAS_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbTransferenciaIds")
                        .HasForeignKey("IdCliente", "IdAgremiacaoAnterior")
                        .IsRequired()
                        .HasConstraintName("FK_TRANSFERENCIAS_AGREMIACOES1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "IdNavigation")
                        .WithMany("TbTransferenciaIdNavigations")
                        .HasForeignKey("IdCliente", "IdAgremiacaoNova")
                        .IsRequired()
                        .HasConstraintName("FK_TRANSFERENCIAS_AGREMIACOES2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id1")
                        .WithMany("TbTransferencia")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .IsRequired()
                        .HasConstraintName("FK_TRANSFERENCIAS_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposTransferencia", "Id2")
                        .WithMany("TbTransferencia")
                        .HasForeignKey("IdCliente", "IdTipoTransferencia")
                        .IsRequired()
                        .HasConstraintName("FK_TRANSFERENCIAS_TIPOS_TRANSFERENCIAS");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("Id2");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbUsuario", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbUsuarios")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_USUARIOS_CLIENTES");

                    b.Navigation("IdClienteNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbValoresDefault", b =>
                {
                    b.HasOne("ProjetoJudo.Domain.Entities.TbCliente", "IdClienteNavigation")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente")
                        .IsRequired()
                        .HasConstraintName("FK_VALORES_DEFAULT_CLIENTES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id")
                        .WithMany("TbValoresDefaultIds")
                        .HasForeignKey("IdCliente", "IdAgremiacao")
                        .HasConstraintName("FK_VALORES_DEFAULT_AGREMIACOES1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "IdNavigation")
                        .WithMany("TbValoresDefaultIdNavigations")
                        .HasForeignKey("IdCliente", "IdAgremiacaoAnterior")
                        .HasConstraintName("FK_VALORES_DEFAULT_AGREMIACOES2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAgremiaco", "Id1")
                        .WithMany("TbValoresDefaultId1s")
                        .HasForeignKey("IdCliente", "IdAgremiacaoNova")
                        .HasConstraintName("FK_VALORES_DEFAULT_AGREMIACOES3");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPessoalApoio", "Id2")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdApoio")
                        .HasConstraintName("FK_VALORES_DEFAULT_PESSOAL_APOIO");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbArbitro", "Id3")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdArbitro")
                        .HasConstraintName("FK_VALORES_DEFAULT_ARBITROS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbAtleta", "Id4")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdAtleta")
                        .HasConstraintName("FK_VALORES_DEFAULT_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCategoria", "IdC")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdCategoria")
                        .HasConstraintName("FK_VALORES_DEFAULT_CATEGORIAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbClass", "IdCl")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdClasse")
                        .HasConstraintName("FK_VALORES_DEFAULT_CLASSES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCompetico", "IdCNavigation")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdCompeticao")
                        .HasConstraintName("FK_VALORES_DEFAULT_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEmissoresIdentidade", "Id5")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdEmissorIdentidade")
                        .HasConstraintName("FK_VALORES_DEFAULT_EMISSORES_IDENTIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstadosCivi", "Id6")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdEstadoCivil")
                        .HasConstraintName("FK_VALORES_DEFAULT_ESTADOS_CIVIS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFaixa", "Id7")
                        .WithMany("TbValoresDefaultId7s")
                        .HasForeignKey("IdCliente", "IdFaixa")
                        .HasConstraintName("FK_VALORES_DEFAULT_FAIXAS1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFaixa", "Id8")
                        .WithMany("TbValoresDefaultId8s")
                        .HasForeignKey("IdCliente", "IdFaixaAnterior")
                        .HasConstraintName("FK_VALORES_DEFAULT_FAIXAS2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFaixa", "Id9")
                        .WithMany("TbValoresDefaultId9s")
                        .HasForeignKey("IdCliente", "IdFaixaNova")
                        .HasConstraintName("FK_VALORES_DEFAULT_FAIXAS3");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbFormasPagamento", "Id10")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdFormaPagamento")
                        .HasConstraintName("FK_VALORES_DEFAULT_FORMAS_PAGAMENTO");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbLocaisCompetico", "Id11")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdLocal")
                        .HasConstraintName("FK_VALORES_DEFAULT_LOCAIS_COMPETICOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id12")
                        .WithMany("TbValoresDefaultId12s")
                        .HasForeignKey("IdCliente", "IdNacionalidade")
                        .HasConstraintName("FK_VALORES_DEFAULT_PAISES2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbNiveisArbitro", "Id13")
                        .WithMany("TbValoresDefaultId13s")
                        .HasForeignKey("IdCliente", "IdNivelAnterior")
                        .HasConstraintName("FK_VALORES_DEFAULT_NIVEIS_ARBITROS1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbNiveisArbitro", "Id14")
                        .WithMany("TbValoresDefaultId14s")
                        .HasForeignKey("IdCliente", "IdNivelNovo")
                        .HasConstraintName("FK_VALORES_DEFAULT_NIVEIS_ARBITROS2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPaise", "Id15")
                        .WithMany("TbValoresDefaultId15s")
                        .HasForeignKey("IdCliente", "IdPais")
                        .HasConstraintName("FK_VALORES_DEFAULT_PAISES1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPatrocinadore", "Id16")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdPatrocinador")
                        .HasConstraintName("FK_VALORES_DEFAULT_PATROCINADORES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPenalidade", "Id17")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdPenalidade")
                        .HasConstraintName("FK_VALORES_DEFAULT_PENALIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbPontuaco", "Id18")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdPontuacao")
                        .HasConstraintName("FK_VALORES_DEFAULT_PONTUACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbProfessore", "Id19")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdProfessor")
                        .HasConstraintName("FK_VALORES_DEFAULT_PROFESSORES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbProfisso", "Id20")
                        .WithMany("TbValoresDefaultId20s")
                        .HasForeignKey("IdCliente", "IdProfissaoAtleta")
                        .HasConstraintName("FK_VALORES_DEFAULT_PROFISSOES1");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbProfisso", "Id21")
                        .WithMany("TbValoresDefaultId21s")
                        .HasForeignKey("IdCliente", "IdProfissaoMae")
                        .HasConstraintName("FK_VALORES_DEFAULT_PROFISSOES3");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbProfisso", "Id22")
                        .WithMany("TbValoresDefaultId22s")
                        .HasForeignKey("IdCliente", "IdProfissaoPai")
                        .HasConstraintName("FK_VALORES_DEFAULT_PROFISSOES2");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbRegio", "Id23")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdRegiao")
                        .HasConstraintName("FK_VALORES_DEFAULT_REGIOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTabelaServico", "Id24")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdServico")
                        .HasConstraintName("FK_VALORES_DEFAULT_TABELA_SERVICOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbSexo", "Id25")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdSexo")
                        .HasConstraintName("FK_VALORES_DEFAULT_SEXOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTabelasAnuidade", "Id26")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTabelaAnuidade")
                        .HasConstraintName("FK_VALORES_DEFAULT_TABELAS_ANUIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTabelasMensalidade", "Id27")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTabelaMensalidade")
                        .HasConstraintName("FK_VALORES_DEFAULT_TABELAS_MENSALIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposAnuidade", "Id28")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoAnuidade")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_ANUIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposCurriculosAgremiaco", "Id29")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoCurriculoAgremiacao")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_CURRICULOS_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposCurriculosAtleta", "Id30")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoCurriculoAtleta")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_CURRICULOS_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposDesfiliacoesAgremiaco", "Id31")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoDesfiliacaoAgremiacao")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_DESFILIACOES_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposDesfiliacoesAtleta", "Id32")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoDesfiliacaoAtleta")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_DESFILIACOES_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposIsencoesAgremiaco", "Id33")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoIsencaoAgremiacao")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_ISENCOES_AGREMIACOES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposIsencoesAtleta", "Id34")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoIsencaoAtleta")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_ISENCOES_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposPagamentosAnuidade", "Id35")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoPagamentoAnuidade")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PAGAMENTOS_ANUIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposPagamentosMensalidade", "Id36")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoPagamentoMensalidade")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PAGAMENTOS_MENSALIDADES");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposPromocoesArbitro", "Id37")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoPromocaoArbitro")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PROMOCOES_ARBITROS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposPromocoesAtleta", "Id38")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoPromocaoAtleta")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_PROMOCOES_ATLETAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbTiposTransferencia", "Id39")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdTipoTransferencia")
                        .HasConstraintName("FK_VALORES_DEFAULT_TIPOS_TRANSFERENCIAS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbEstado", "Id40")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado")
                        .HasConstraintName("FK_VALORES_DEFAULT_ESTADOS");

                    b.HasOne("ProjetoJudo.Domain.Entities.TbCidade", "Id41")
                        .WithMany("TbValoresDefaults")
                        .HasForeignKey("IdCliente", "IdPais", "IdEstado", "IdCidade")
                        .HasConstraintName("FK_VALORES_DEFAULT_CIDADES");

                    b.Navigation("Id");

                    b.Navigation("Id1");

                    b.Navigation("Id10");

                    b.Navigation("Id11");

                    b.Navigation("Id12");

                    b.Navigation("Id13");

                    b.Navigation("Id14");

                    b.Navigation("Id15");

                    b.Navigation("Id16");

                    b.Navigation("Id17");

                    b.Navigation("Id18");

                    b.Navigation("Id19");

                    b.Navigation("Id2");

                    b.Navigation("Id20");

                    b.Navigation("Id21");

                    b.Navigation("Id22");

                    b.Navigation("Id23");

                    b.Navigation("Id24");

                    b.Navigation("Id25");

                    b.Navigation("Id26");

                    b.Navigation("Id27");

                    b.Navigation("Id28");

                    b.Navigation("Id29");

                    b.Navigation("Id3");

                    b.Navigation("Id30");

                    b.Navigation("Id31");

                    b.Navigation("Id32");

                    b.Navigation("Id33");

                    b.Navigation("Id34");

                    b.Navigation("Id35");

                    b.Navigation("Id36");

                    b.Navigation("Id37");

                    b.Navigation("Id38");

                    b.Navigation("Id39");

                    b.Navigation("Id4");

                    b.Navigation("Id40");

                    b.Navigation("Id41");

                    b.Navigation("Id5");

                    b.Navigation("Id6");

                    b.Navigation("Id7");

                    b.Navigation("Id8");

                    b.Navigation("Id9");

                    b.Navigation("IdC");

                    b.Navigation("IdCNavigation");

                    b.Navigation("IdCl");

                    b.Navigation("IdClienteNavigation");

                    b.Navigation("IdNavigation");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAgremiaco", b =>
                {
                    b.Navigation("TbAgremiacoesProfessores");

                    b.Navigation("TbAtleta");

                    b.Navigation("TbCobrancas");

                    b.Navigation("TbCompeticoesInscricos");

                    b.Navigation("TbCompeticoesTecnicos");

                    b.Navigation("TbCurriculosAgremiacos");

                    b.Navigation("TbDesfiliacoesAgremiacos");

                    b.Navigation("TbIsencoesAgremiacos");

                    b.Navigation("TbMensalidades");

                    b.Navigation("TbRecibos");

                    b.Navigation("TbTransferenciaIdNavigations");

                    b.Navigation("TbTransferenciaIds");

                    b.Navigation("TbValoresDefaultId1s");

                    b.Navigation("TbValoresDefaultIdNavigations");

                    b.Navigation("TbValoresDefaultIds");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbArbitro", b =>
                {
                    b.Navigation("TbCompeticoesArbitros");

                    b.Navigation("TbPromocoesArbitros");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbAtleta", b =>
                {
                    b.Navigation("TbAnuidades");

                    b.Navigation("TbAnuidadesConfederacaos");

                    b.Navigation("TbArbitros");

                    b.Navigation("TbCompeticoesInscricos");

                    b.Navigation("TbCompeticoesLutaId1s");

                    b.Navigation("TbCompeticoesLutaIdNavigations");

                    b.Navigation("TbCompeticoesLutaIds");

                    b.Navigation("TbCompeticoesLutasPenalidades");

                    b.Navigation("TbCompeticoesLutasPontuacos");

                    b.Navigation("TbCompeticoesResultados");

                    b.Navigation("TbCurriculosAtleta");

                    b.Navigation("TbDesfiliacoesAtleta");

                    b.Navigation("TbIsencoesAtleta");

                    b.Navigation("TbPessoalApoios");

                    b.Navigation("TbProfessores");

                    b.Navigation("TbPromocoesAtleta");

                    b.Navigation("TbRecibos");

                    b.Navigation("TbTransferencia");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCategoria", b =>
                {
                    b.Navigation("TbTabelaPesos");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCidade", b =>
                {
                    b.Navigation("TbAgremiacos");

                    b.Navigation("TbArbitros");

                    b.Navigation("TbAtleta");

                    b.Navigation("TbLocaisCompeticos");

                    b.Navigation("TbPatrocinadores");

                    b.Navigation("TbPessoalApoios");

                    b.Navigation("TbProfessores");

                    b.Navigation("TbRegios");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbClass", b =>
                {
                    b.Navigation("TbTabelaPesos");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCliente", b =>
                {
                    b.Navigation("TbAgremiacoesProfessores");

                    b.Navigation("TbAgremiacos");

                    b.Navigation("TbAnuidades");

                    b.Navigation("TbAnuidadesConfederacaos");

                    b.Navigation("TbArbitros");

                    b.Navigation("TbAtleta");

                    b.Navigation("TbCategoria");

                    b.Navigation("TbCidades");

                    b.Navigation("TbClasses");

                    b.Navigation("TbCobrancas");

                    b.Navigation("TbCompeticoesArbitros");

                    b.Navigation("TbCompeticoesAreas");

                    b.Navigation("TbCompeticoesCategoria");

                    b.Navigation("TbCompeticoesChaves");

                    b.Navigation("TbCompeticoesClasses");

                    b.Navigation("TbCompeticoesClassesRegras");

                    b.Navigation("TbCompeticoesFaixas");

                    b.Navigation("TbCompeticoesInscricos");

                    b.Navigation("TbCompeticoesLuta");

                    b.Navigation("TbCompeticoesLutasPenalidades");

                    b.Navigation("TbCompeticoesLutasPontuacos");

                    b.Navigation("TbCompeticoesPatrocinadores");

                    b.Navigation("TbCompeticoesPenalidades");

                    b.Navigation("TbCompeticoesPessoalApoios");

                    b.Navigation("TbCompeticoesPontuacos");

                    b.Navigation("TbCompeticoesResultados");

                    b.Navigation("TbCompeticoesTabelasPesos");

                    b.Navigation("TbCompeticoesTecnicos");

                    b.Navigation("TbCompeticoesTipos");

                    b.Navigation("TbCompeticos");

                    b.Navigation("TbCurriculosAgremiacos");

                    b.Navigation("TbCurriculosAtleta");

                    b.Navigation("TbDesfiliacoesAgremiacos");

                    b.Navigation("TbDesfiliacoesAtleta");

                    b.Navigation("TbEmissoresIdentidades");

                    b.Navigation("TbEstados");

                    b.Navigation("TbFaixas");

                    b.Navigation("TbFormasPagamentos");

                    b.Navigation("TbFuncoesApoioPessoalApoios");

                    b.Navigation("TbFuncoesApoios");

                    b.Navigation("TbFuncoesMenus");

                    b.Navigation("TbIsencoesAgremiacos");

                    b.Navigation("TbIsencoesAtleta");

                    b.Navigation("TbLocaisCompeticos");

                    b.Navigation("TbMensalidades");

                    b.Navigation("TbNiveisArbitros");

                    b.Navigation("TbPaises");

                    b.Navigation("TbPatrocinadores");

                    b.Navigation("TbPenalidades");

                    b.Navigation("TbPerfis");

                    b.Navigation("TbPerfisUsuarios");

                    b.Navigation("TbPermissos");

                    b.Navigation("TbPessoalApoios");

                    b.Navigation("TbPontuacos");

                    b.Navigation("TbProfessores");

                    b.Navigation("TbProfissos");

                    b.Navigation("TbPromocoesArbitros");

                    b.Navigation("TbPromocoesAtleta");

                    b.Navigation("TbRecibos");

                    b.Navigation("TbRecibosItens");

                    b.Navigation("TbRegios");

                    b.Navigation("TbRegistroEventos");

                    b.Navigation("TbTabelaPesos");

                    b.Navigation("TbTabelaServicos");

                    b.Navigation("TbTabelasAnuidades");

                    b.Navigation("TbTabelasAnuidadesConfederacaos");

                    b.Navigation("TbTabelasMensalidades");

                    b.Navigation("TbTiposAnuidades");

                    b.Navigation("TbTiposAnuidadesConfederacaos");

                    b.Navigation("TbTiposCurriculosAgremiacos");

                    b.Navigation("TbTiposCurriculosAtleta");

                    b.Navigation("TbTiposDesfiliacoesAgremiacos");

                    b.Navigation("TbTiposDesfiliacoesAtleta");

                    b.Navigation("TbTiposIsencoesAgremiacos");

                    b.Navigation("TbTiposIsencoesAtleta");

                    b.Navigation("TbTiposItensRecibos");

                    b.Navigation("TbTiposOperacos");

                    b.Navigation("TbTiposPagamentosAnuidades");

                    b.Navigation("TbTiposPagamentosAnuidadesConfederacaos");

                    b.Navigation("TbTiposPagamentosMensalidades");

                    b.Navigation("TbTiposPromocoesArbitros");

                    b.Navigation("TbTiposPromocoesAtleta");

                    b.Navigation("TbTiposTransferencia");

                    b.Navigation("TbTransferencia");

                    b.Navigation("TbUsuarios");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompetico", b =>
                {
                    b.Navigation("TbCompeticoesArbitros");

                    b.Navigation("TbCompeticoesAreas");

                    b.Navigation("TbCompeticoesCategoria");

                    b.Navigation("TbCompeticoesChaves");

                    b.Navigation("TbCompeticoesClasses");

                    b.Navigation("TbCompeticoesClassesRegras");

                    b.Navigation("TbCompeticoesFaixas");

                    b.Navigation("TbCompeticoesInscricos");

                    b.Navigation("TbCompeticoesLuta");

                    b.Navigation("TbCompeticoesLutasPenalidades");

                    b.Navigation("TbCompeticoesLutasPontuacos");

                    b.Navigation("TbCompeticoesPatrocinadores");

                    b.Navigation("TbCompeticoesPenalidades");

                    b.Navigation("TbCompeticoesPessoalApoios");

                    b.Navigation("TbCompeticoesPontuacos");

                    b.Navigation("TbCompeticoesResultados");

                    b.Navigation("TbCompeticoesTabelasPesos");

                    b.Navigation("TbCompeticoesTecnicos");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesCategoria", b =>
                {
                    b.Navigation("TbCompeticoesChaves");

                    b.Navigation("TbCompeticoesTabelasPesos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesChafe", b =>
                {
                    b.Navigation("TbCompeticoesInscricos");

                    b.Navigation("TbCompeticoesLuta");

                    b.Navigation("TbCompeticoesResultados");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesClass", b =>
                {
                    b.Navigation("TbCompeticoesChaves");

                    b.Navigation("TbCompeticoesClassesRegraIdC1s");

                    b.Navigation("TbCompeticoesClassesRegraIdCNavigations");

                    b.Navigation("TbCompeticoesTabelasPesos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesFaixa", b =>
                {
                    b.Navigation("TbCompeticoesChafeId1s");

                    b.Navigation("TbCompeticoesChafeIdNavigations");

                    b.Navigation("TbCompeticoesInscricos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesLuta", b =>
                {
                    b.Navigation("TbCompeticoesLutasPenalidades");

                    b.Navigation("TbCompeticoesLutasPontuacos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesPenalidade", b =>
                {
                    b.Navigation("TbCompeticoesLutasPenalidades");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesPontuaco", b =>
                {
                    b.Navigation("TbCompeticoesLutasPontuacos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbCompeticoesTipo", b =>
                {
                    b.Navigation("TbCompeticos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbEmissoresIdentidade", b =>
                {
                    b.Navigation("TbArbitros");

                    b.Navigation("TbAtleta");

                    b.Navigation("TbPessoalApoios");

                    b.Navigation("TbProfessores");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbEstado", b =>
                {
                    b.Navigation("TbAgremiacos");

                    b.Navigation("TbArbitros");

                    b.Navigation("TbAtleta");

                    b.Navigation("TbCidades");

                    b.Navigation("TbLocaisCompeticos");

                    b.Navigation("TbPatrocinadores");

                    b.Navigation("TbPessoalApoios");

                    b.Navigation("TbProfessores");

                    b.Navigation("TbRegios");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbEstadosCivi", b =>
                {
                    b.Navigation("TbArbitros");

                    b.Navigation("TbAtleta");

                    b.Navigation("TbPessoalApoios");

                    b.Navigation("TbProfessores");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFaixa", b =>
                {
                    b.Navigation("TbAtleta");

                    b.Navigation("TbPromocoesAtletaId1s");

                    b.Navigation("TbPromocoesAtletaIdNavigations");

                    b.Navigation("TbValoresDefaultId7s");

                    b.Navigation("TbValoresDefaultId8s");

                    b.Navigation("TbValoresDefaultId9s");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFormasPagamento", b =>
                {
                    b.Navigation("TbRecibosItens");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFuncoesApoio", b =>
                {
                    b.Navigation("TbCompeticoesPessoalApoios");

                    b.Navigation("TbFuncoesApoioPessoalApoios");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbFuncoesMenu", b =>
                {
                    b.Navigation("TbPermissos");

                    b.Navigation("TbRegistroEventos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbLocaisCompetico", b =>
                {
                    b.Navigation("TbCompeticos");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbNiveisArbitro", b =>
                {
                    b.Navigation("TbArbitros");

                    b.Navigation("TbPromocoesArbitroId1s");

                    b.Navigation("TbPromocoesArbitroIdNavigations");

                    b.Navigation("TbValoresDefaultId13s");

                    b.Navigation("TbValoresDefaultId14s");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPaise", b =>
                {
                    b.Navigation("TbAgremiacos");

                    b.Navigation("TbArbitroId2s");

                    b.Navigation("TbArbitroId4s");

                    b.Navigation("TbAtletaId3s");

                    b.Navigation("TbAtletaId4s");

                    b.Navigation("TbCidades");

                    b.Navigation("TbEstados");

                    b.Navigation("TbLocaisCompeticos");

                    b.Navigation("TbPatrocinadores");

                    b.Navigation("TbPessoalApoioId2s");

                    b.Navigation("TbPessoalApoioId3s");

                    b.Navigation("TbProfessoreId2s");

                    b.Navigation("TbProfessoreId3s");

                    b.Navigation("TbRegios");

                    b.Navigation("TbValoresDefaultId12s");

                    b.Navigation("TbValoresDefaultId15s");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPatrocinadore", b =>
                {
                    b.Navigation("TbCompeticoesPatrocinadores");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPenalidade", b =>
                {
                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPerfi", b =>
                {
                    b.Navigation("TbPerfisUsuarios");

                    b.Navigation("TbPermissos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPessoalApoio", b =>
                {
                    b.Navigation("TbCompeticoesPessoalApoios");

                    b.Navigation("TbFuncoesApoioPessoalApoios");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbPontuaco", b =>
                {
                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbProfessore", b =>
                {
                    b.Navigation("TbAgremiacoesProfessores");

                    b.Navigation("TbCompeticoesTecnicos");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbProfisso", b =>
                {
                    b.Navigation("TbAtletaId5s");

                    b.Navigation("TbAtletaId6s");

                    b.Navigation("TbAtletaId7s");

                    b.Navigation("TbValoresDefaultId20s");

                    b.Navigation("TbValoresDefaultId21s");

                    b.Navigation("TbValoresDefaultId22s");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbRecibo", b =>
                {
                    b.Navigation("TbRecibosItens");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbRegio", b =>
                {
                    b.Navigation("TbAgremiacos");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbSexo", b =>
                {
                    b.Navigation("TbArbitros");

                    b.Navigation("TbAtleta");

                    b.Navigation("TbClasses");

                    b.Navigation("TbCompeticoesChaves");

                    b.Navigation("TbCompeticoesClasses");

                    b.Navigation("TbCompeticoesTabelasPesos");

                    b.Navigation("TbPessoalApoios");

                    b.Navigation("TbProfessores");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbSistema", b =>
                {
                    b.Navigation("TbClientes");

                    b.Navigation("TbSistemasMensagens");

                    b.Navigation("TbSistemasTiposMensagens");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbSistemasTiposMensagen", b =>
                {
                    b.Navigation("TbSistemasMensagens");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelasAnuidade", b =>
                {
                    b.Navigation("TbAnuidades");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelasAnuidadesConfederacao", b =>
                {
                    b.Navigation("TbAnuidadesConfederacaos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelaServico", b =>
                {
                    b.Navigation("TbRecibosItens");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTabelasMensalidade", b =>
                {
                    b.Navigation("TbMensalidades");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposAnuidade", b =>
                {
                    b.Navigation("TbAnuidades");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposAnuidadesConfederacao", b =>
                {
                    b.Navigation("TbAnuidadesConfederacaos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposCurriculosAgremiaco", b =>
                {
                    b.Navigation("TbCurriculosAgremiacos");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposCurriculosAtleta", b =>
                {
                    b.Navigation("TbCurriculosAtleta");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposDesfiliacoesAgremiaco", b =>
                {
                    b.Navigation("TbDesfiliacoesAgremiacos");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposDesfiliacoesAtleta", b =>
                {
                    b.Navigation("TbDesfiliacoesAtleta");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposIsencoesAgremiaco", b =>
                {
                    b.Navigation("TbIsencoesAgremiacos");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposIsencoesAtleta", b =>
                {
                    b.Navigation("TbIsencoesAtleta");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposOperaco", b =>
                {
                    b.Navigation("TbPermissos");

                    b.Navigation("TbRegistroEventos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPagamentosAnuidade", b =>
                {
                    b.Navigation("TbAnuidades");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPagamentosAnuidadesConfederacao", b =>
                {
                    b.Navigation("TbAnuidadesConfederacaos");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPagamentosMensalidade", b =>
                {
                    b.Navigation("TbMensalidades");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPromocoesArbitro", b =>
                {
                    b.Navigation("TbPromocoesArbitros");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposPromocoesAtleta", b =>
                {
                    b.Navigation("TbPromocoesAtleta");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbTiposTransferencia", b =>
                {
                    b.Navigation("TbTransferencia");

                    b.Navigation("TbValoresDefaults");
                });

            modelBuilder.Entity("ProjetoJudo.Domain.Entities.TbUsuario", b =>
                {
                    b.Navigation("TbPerfisUsuarios");

                    b.Navigation("TbRecibos");

                    b.Navigation("TbRegistroEventos");
                });
#pragma warning restore 612, 618
        }
    }
}
