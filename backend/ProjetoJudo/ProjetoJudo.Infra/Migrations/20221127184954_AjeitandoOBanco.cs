using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoJudo.Infra.Migrations
{
    public partial class AjeitandoOBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ESTADOS_CIVIS",
                columns: table => new
                {
                    ID_ESTADO_CIVIL = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTADO_CIVIL", x => new { x.ID_CLIENTE, x.ID_ESTADO_CIVIL })
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "TB_SEXOS",
                columns: table => new
                {
                    ID_SEXO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SEXOS", x => new { x.ID_CLIENTE, x.ID_SEXO })
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "TB_SISTEMAS",
                columns: table => new
                {
                    ID_SISTEMA = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    VERSAO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SISTEMA", x => x.ID_SISTEMA)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "TB_CLIENTES",
                columns: table => new
                {
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NOME = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    PASTA_ARQUIVOS = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    ID_SISTEMA = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTES", x => x.ID_CLIENTE)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CLIENTES_SISTEMAS",
                        column: x => x.ID_SISTEMA,
                        principalTable: "TB_SISTEMAS",
                        principalColumn: "ID_SISTEMA");
                });

            migrationBuilder.CreateTable(
                name: "TB_SISTEMAS_TIPOS_MENSAGENS",
                columns: table => new
                {
                    ID_TIPO_MENSAGEM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_SISTEMA = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SISTEMAS_TIPOS_MENSAGENS", x => new { x.ID_SISTEMA, x.ID_TIPO_MENSAGEM })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_SISTEMAS_TIPOS_MENSAGENS_SISTEMAS",
                        column: x => x.ID_SISTEMA,
                        principalTable: "TB_SISTEMAS",
                        principalColumn: "ID_SISTEMA");
                });

            migrationBuilder.CreateTable(
                name: "TB_CATEGORIAS",
                columns: table => new
                {
                    ID_CATEGORIA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    ORDEM_EXIBICAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAS", x => new { x.ID_CLIENTE, x.ID_CATEGORIA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CATEGORIAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_CLASSES",
                columns: table => new
                {
                    ID_CLASSE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ID_SEXO = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO1 = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    DESCRICAO2 = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    IDADE_INICIAL = table.Column<short>(type: "smallint", nullable: false),
                    IDADE_FINAL = table.Column<short>(type: "smallint", nullable: false),
                    ORDEM_EXIBICAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLASSES", x => new { x.ID_CLIENTE, x.ID_CLASSE })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CLASSES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_CLASSES_SEXOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_SEXO },
                        principalTable: "TB_SEXOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_SEXO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_TIPOS",
                columns: table => new
                {
                    ID_TIPO_COMPETICAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_TIPOS", x => new { x.ID_CLIENTE, x.ID_TIPO_COMPETICAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_TIPOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_EMISSORES_IDENTIDADES",
                columns: table => new
                {
                    ID_EMISSOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMISSORES_IDENTIDADES", x => new { x.ID_CLIENTE, x.ID_EMISSOR })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_EMISSORES_IDENTIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_FAIXAS",
                columns: table => new
                {
                    ID_FAIXA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    MESES_CARENCIA = table.Column<short>(type: "smallint", nullable: false),
                    IDADE_MINIMA = table.Column<short>(type: "smallint", nullable: false),
                    ORDEM_EXIBICAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAIXAS", x => new { x.ID_CLIENTE, x.ID_FAIXA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_FAIXAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_FORMAS_PAGAMENTOS",
                columns: table => new
                {
                    ID_FORMA_PAGAMENTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORMAS_PAGAMENTOS", x => new { x.ID_CLIENTE, x.ID_FORMA_PAGAMENTO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_FORMAS_PAGAMENTOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_FUNCOES_APOIO",
                columns: table => new
                {
                    ID_FUNCAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCOES_APOIO", x => new { x.ID_CLIENTE, x.ID_FUNCAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_FUNCOES_APOIO_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_FUNCOES_MENU",
                columns: table => new
                {
                    ID_FUNCAO_MENU = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    FOTO = table.Column<bool>(type: "bit", nullable: false),
                    ANEXO = table.Column<bool>(type: "bit", nullable: false),
                    ANOTACOES = table.Column<bool>(type: "bit", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNCOES_MENU", x => new { x.ID_CLIENTE, x.ID_FUNCAO_MENU })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_FUNCOES_MENU_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_NIVEIS_ARBITROS",
                columns: table => new
                {
                    ID_NIVEL_ARBITRO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    ORDEM_EXIBICAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NIVEIS_ARBITROS", x => new { x.ID_CLIENTE, x.ID_NIVEL_ARBITRO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_NIVEIS_ARBITROS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_PAISES",
                columns: table => new
                {
                    ID_PAIS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SIGLA_3 = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: false),
                    SIGLA_2 = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    NACIONALIDADE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAISES", x => new { x.ID_CLIENTE, x.ID_PAIS })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PAISES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_PENALIDADES",
                columns: table => new
                {
                    ID_PENALIDADE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    ORDEM_EXIBICAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PENALIDADES", x => new { x.ID_CLIENTE, x.ID_PENALIDADE })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PENALIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_PERFIS",
                columns: table => new
                {
                    ID_PERFIL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERFIS", x => new { x.ID_CLIENTE, x.ID_PERFIL })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PERFIS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_PONTUACOES",
                columns: table => new
                {
                    ID_PONTUACAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    ORDEM_EXIBICAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PONTUACOES", x => new { x.ID_CLIENTE, x.ID_PONTUACAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PONTUACOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_PROFISSOES",
                columns: table => new
                {
                    ID_PROFISSAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROFISSOES", x => new { x.ID_CLIENTE, x.ID_PROFISSAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PROFISSOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TABELA_SERVICOS",
                columns: table => new
                {
                    ID_SERVICO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    VALOR = table.Column<decimal>(type: "money", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABELA_SERVICOS", x => new { x.ID_CLIENTE, x.ID_SERVICO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TABELA_SERVICOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TABELAS_ANUIDADES",
                columns: table => new
                {
                    ID_TABELA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    VALOR_ANUIDADE = table.Column<decimal>(type: "money", nullable: false),
                    VALOR_REGISTRO = table.Column<decimal>(type: "money", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABELAS_ANUIDADES", x => new { x.ID_CLIENTE, x.ID_TABELA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TABELAS_ANUIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TABELAS_ANUIDADES_CONFEDERACAO",
                columns: table => new
                {
                    ID_TABELA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    VALOR_ANUIDADE = table.Column<decimal>(type: "money", nullable: false),
                    VALOR_REGISTRO = table.Column<decimal>(type: "money", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABELAS_ANUIDADES_CONFEDERACAO", x => new { x.ID_CLIENTE, x.ID_TABELA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TABELAS_ANUIDADES_CONFEDERACAO_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TABELAS_MENSALIDADES",
                columns: table => new
                {
                    ID_TABELA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    VALOR_MENSALIDADE = table.Column<decimal>(type: "money", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABELAS_MENSALIDADES", x => new { x.ID_CLIENTE, x.ID_TABELA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TABELAS_MENSALIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_ANUIDADES",
                columns: table => new
                {
                    ID_TIPO_ANUIDADE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_ANUIDADES", x => new { x.ID_CLIENTE, x.ID_TIPO_ANUIDADE })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_ANUIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_ANUIDADES_CONFEDERACAO",
                columns: table => new
                {
                    ID_TIPO_ANUIDADE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_ANUIDADES_CONFEDERACAO", x => new { x.ID_CLIENTE, x.ID_TIPO_ANUIDADE })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_ANUIDADES_CONFEDERACAO_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_CURRICULOS_AGREMIACOES",
                columns: table => new
                {
                    ID_TIPO_CURRICULO_AGREMIACAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_CURRICULOS_AGREMIACOES", x => new { x.ID_CLIENTE, x.ID_TIPO_CURRICULO_AGREMIACAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_CURRICULOS_AGREMIACOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_CURRICULOS_ATLETAS",
                columns: table => new
                {
                    ID_TIPO_CURRICULO_ATLETA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_CURRICULOS_ATLETAS", x => new { x.ID_CLIENTE, x.ID_TIPO_CURRICULO_ATLETA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_CURRICULOS_ATLETAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_DESFILIACOES_AGREMIACOES",
                columns: table => new
                {
                    ID_TIPO_DESFILIACAO_AGREMIACAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_DESFILIACOES_AGREMIACOES", x => new { x.ID_CLIENTE, x.ID_TIPO_DESFILIACAO_AGREMIACAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_DESFILIACOES_AGREMIACOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_DESFILIACOES_ATLETAS",
                columns: table => new
                {
                    ID_TIPO_DESFILIACAO_ATLETA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_DESFILIACOES_ATLETAS", x => new { x.ID_CLIENTE, x.ID_TIPO_DESFILIACAO_ATLETA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_DESFILIACOES_ATLETAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_ISENCOES_AGREMIACOES",
                columns: table => new
                {
                    ID_TIPO_ISENCAO_AGREMIACAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_ISENCOES_AGREMIACOES", x => new { x.ID_CLIENTE, x.ID_TIPO_ISENCAO_AGREMIACAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_ISENCOES_AGREMIACOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_ISENCOES_ATLETAS",
                columns: table => new
                {
                    ID_TIPO_ISENCAO_ATLETA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_ISENCOES_ATLETAS", x => new { x.ID_CLIENTE, x.ID_TIPO_ISENCAO_ATLETA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_ISENCOES_ATLETAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_ITENS_RECIBOS",
                columns: table => new
                {
                    ID_TIPO_ITEM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_ITENS_RECIBOS", x => new { x.ID_CLIENTE, x.ID_TIPO_ITEM })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_ITENS_RECIBOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_OPERACOES",
                columns: table => new
                {
                    ID_TIPO_OPERACAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_OPERACOES", x => new { x.ID_CLIENTE, x.ID_TIPO_OPERACAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_OPERACOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_PAGAMENTOS_ANUIDADES",
                columns: table => new
                {
                    ID_TIPO_PAGAMENTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_PAGAMENTOS_ANUIDADES", x => new { x.ID_CLIENTE, x.ID_TIPO_PAGAMENTO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_PAGAMENTOS_ANUIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO",
                columns: table => new
                {
                    ID_TIPO_PAGAMENTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO", x => new { x.ID_CLIENTE, x.ID_TIPO_PAGAMENTO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_PAGAMENTOS_MENSALIDADES",
                columns: table => new
                {
                    ID_TIPO_PAGAMENTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_PAGAMENTOS_MENSALIDADES", x => new { x.ID_CLIENTE, x.ID_TIPO_PAGAMENTO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_PAGAMENTOS_MENSALIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_PROMOCOES_ARBITROS",
                columns: table => new
                {
                    ID_TIPO_PROMOCAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_PROMOCOES_ARBITROS", x => new { x.ID_CLIENTE, x.ID_TIPO_PROMOCAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_PROMOCOES_ARBITROS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_PROMOCOES_ATLETAS",
                columns: table => new
                {
                    ID_TIPO_PROMOCAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_PROMOCOES", x => new { x.ID_CLIENTE, x.ID_TIPO_PROMOCAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_PROMOCOES_ATLETAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPOS_TRANSFERENCIAS",
                columns: table => new
                {
                    ID_TIPO_TRANSFERENCIA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPOS_TRANSFERENCIAS", x => new { x.ID_CLIENTE, x.ID_TIPO_TRANSFERENCIA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TIPOS_TRANSFERENCIAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    NOME = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    LOGIN_USUARIO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    DATA_CRIACAO = table.Column<DateTime>(type: "date", nullable: false),
                    DATA_ULTIMO_LOGIN = table.Column<DateTime>(type: "date", nullable: true),
                    DATA_EXPIRACAO = table.Column<DateTime>(type: "date", nullable: true),
                    SENHA = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    SITUACAO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('A')"),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => new { x.ID_CLIENTE, x.ID_USUARIO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_USUARIOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_SISTEMAS_MENSAGENS",
                columns: table => new
                {
                    ID_MENSAGEM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_SISTEMA = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    ID_TIPO_MENSAGEM = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SISTEMAS_MENSAGENS", x => new { x.ID_SISTEMA, x.ID_MENSAGEM })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_SISTEMAS_MENSAGENS_SISTEMAS",
                        column: x => x.ID_SISTEMA,
                        principalTable: "TB_SISTEMAS",
                        principalColumn: "ID_SISTEMA");
                    table.ForeignKey(
                        name: "FK_SISTEMAS_MENSAGENS_SISTEMAS_TIPOS_MENSAGENS",
                        columns: x => new { x.ID_SISTEMA, x.ID_TIPO_MENSAGEM },
                        principalTable: "TB_SISTEMAS_TIPOS_MENSAGENS",
                        principalColumns: new[] { "ID_SISTEMA", "ID_TIPO_MENSAGEM" });
                });

            migrationBuilder.CreateTable(
                name: "TB_TABELA_PESOS",
                columns: table => new
                {
                    ID_CLASSE = table.Column<int>(type: "int", nullable: false),
                    ID_CATEGORIA = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_SEXO = table.Column<int>(type: "int", nullable: false),
                    PESO_INICIAL = table.Column<double>(type: "float", nullable: false),
                    PESO_FINAL = table.Column<double>(type: "float", nullable: false),
                    ORDEM_EXIBICAO_CLASSE = table.Column<int>(type: "int", nullable: false),
                    ORDEM_EXIBICAO_CATEGORIA = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TABELA_PESOS", x => new { x.ID_CLIENTE, x.ID_CLASSE, x.ID_CATEGORIA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TABELA_PESOS_CATEGORIAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_CATEGORIA },
                        principalTable: "TB_CATEGORIAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_CATEGORIA" });
                    table.ForeignKey(
                        name: "FK_TABELA_PESOS_CLASSES",
                        columns: x => new { x.ID_CLIENTE, x.ID_CLASSE },
                        principalTable: "TB_CLASSES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_CLASSE" });
                    table.ForeignKey(
                        name: "FK_TABELA_PESOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_ESTADOS",
                columns: table => new
                {
                    ID_ESTADO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PAIS = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESTADOS", x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_ESTADOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_ESTADOS_PAISES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                });

            migrationBuilder.CreateTable(
                name: "TB_PERMISSOES",
                columns: table => new
                {
                    ID_PERFIL = table.Column<int>(type: "int", nullable: false),
                    ID_FUNCAO_MENU = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_OPERACAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERMISSOES", x => new { x.ID_CLIENTE, x.ID_PERFIL, x.ID_FUNCAO_MENU, x.ID_TIPO_OPERACAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PERMISSOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_PERMISSOES_FUNCOES_MENU",
                        columns: x => new { x.ID_CLIENTE, x.ID_FUNCAO_MENU },
                        principalTable: "TB_FUNCOES_MENU",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FUNCAO_MENU" });
                    table.ForeignKey(
                        name: "FK_PERMISSOES_PERFIS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PERFIL },
                        principalTable: "TB_PERFIS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PERFIL" });
                    table.ForeignKey(
                        name: "FK_PERMISSOES_TIPOS_OPERACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_OPERACAO },
                        principalTable: "TB_TIPOS_OPERACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_OPERACAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_PERFIS_USUARIOS",
                columns: table => new
                {
                    ID_PERFIL = table.Column<int>(type: "int", nullable: false),
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERFIS_USUARIOS", x => new { x.ID_CLIENTE, x.ID_PERFIL, x.ID_USUARIO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PERFIS_USUARIOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_PERFIS_USUARIOS_PERFIS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PERFIL },
                        principalTable: "TB_PERFIS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PERFIL" });
                    table.ForeignKey(
                        name: "FK_PERFIS_USUARIOS_USUARIOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_USUARIO },
                        principalTable: "TB_USUARIOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_USUARIO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_REGISTRO_EVENTOS",
                columns: table => new
                {
                    ID_EVENTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DATA_HORA_EVENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false),
                    ID_FUNCAO_MENU = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_OPERACAO = table.Column<int>(type: "int", nullable: false),
                    ID_COMPUTADOR = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REGISTRO_EVENTOS", x => new { x.ID_CLIENTE, x.ID_EVENTO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_REGISTRO_EVENTOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_REGISTRO_EVENTOS_FUNCOES_MENU",
                        columns: x => new { x.ID_CLIENTE, x.ID_FUNCAO_MENU },
                        principalTable: "TB_FUNCOES_MENU",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FUNCAO_MENU" });
                    table.ForeignKey(
                        name: "FK_REGISTRO_EVENTOS_TIPOS_OPERACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_OPERACAO },
                        principalTable: "TB_TIPOS_OPERACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_OPERACAO" });
                    table.ForeignKey(
                        name: "FK_REGISTRO_EVENTOS_USUARIOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_USUARIO },
                        principalTable: "TB_USUARIOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_USUARIO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_CIDADES",
                columns: table => new
                {
                    ID_CIDADE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PAIS = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIDADES", x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO, x.ID_CIDADE })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_CIDADES_ESTADOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO },
                        principalTable: "TB_ESTADOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO" });
                    table.ForeignKey(
                        name: "FK_CIDADES_PAIS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                });

            migrationBuilder.CreateTable(
                name: "TB_LOCAIS_COMPETICOES",
                columns: table => new
                {
                    ID_LOCAL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NOME = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    RESPONSAVEL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    QTD_LUGARES = table.Column<int>(type: "int", nullable: true),
                    CEP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    ENDERECO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    BAIRRO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ID_CIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO = table.Column<int>(type: "int", nullable: false),
                    ID_PAIS = table.Column<int>(type: "int", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    INSCRICAO_MUNICIPAL = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    INSCRICAO_ESTADUAL = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    ANOTACOES = table.Column<string>(type: "text", nullable: true),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOCAIS_COMPETICOES", x => new { x.ID_CLIENTE, x.ID_LOCAL })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_LOCAIS_COMPETICOES_CIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO, x.ID_CIDADE },
                        principalTable: "TB_CIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });
                    table.ForeignKey(
                        name: "FK_LOCAIS_COMPETICOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_LOCAIS_COMPETICOES_ESTADOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO },
                        principalTable: "TB_ESTADOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO" });
                    table.ForeignKey(
                        name: "FK_LOCAIS_COMPETICOES_PAISES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                });

            migrationBuilder.CreateTable(
                name: "TB_PATROCINADORES",
                columns: table => new
                {
                    ID_PATROCINADOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NOME = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    FANTASIA = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    RESPONSAVEL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CEP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    ENDERECO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    BAIRRO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ID_CIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO = table.Column<int>(type: "int", nullable: false),
                    ID_PAIS = table.Column<int>(type: "int", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    INSCRICAO_MUNICIPAL = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    INSCRICAO_ESTADUAL = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    ANOTACOES = table.Column<string>(type: "text", nullable: true),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PATROCINADORES", x => new { x.ID_CLIENTE, x.ID_PATROCINADOR })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PATROCINADORES_CIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO, x.ID_CIDADE },
                        principalTable: "TB_CIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });
                    table.ForeignKey(
                        name: "FK_PATROCINADORES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_PATROCINADORES_ESTADOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO },
                        principalTable: "TB_ESTADOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO" });
                    table.ForeignKey(
                        name: "FK_PATROCINADORES_PAISES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                });

            migrationBuilder.CreateTable(
                name: "TB_REGIOES",
                columns: table => new
                {
                    ID_REGIAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    RESPONSAVEL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CEP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    ENDERECO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    BAIRRO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ID_CIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO = table.Column<int>(type: "int", nullable: false),
                    ID_PAIS = table.Column<int>(type: "int", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ANOTACOES = table.Column<string>(type: "text", nullable: true),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REGIOES", x => new { x.ID_CLIENTE, x.ID_REGIAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_REGIOES_CIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO, x.ID_CIDADE },
                        principalTable: "TB_CIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });
                    table.ForeignKey(
                        name: "FK_REGIOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_REGIOES_ESTADOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO },
                        principalTable: "TB_ESTADOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO" });
                    table.ForeignKey(
                        name: "FK_REGIOES_PAISES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES",
                columns: table => new
                {
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO1 = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    DESCRICAO2 = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    DATA_INICIO = table.Column<DateTime>(type: "date", nullable: false),
                    DATA_FINAL = table.Column<DateTime>(type: "date", nullable: false),
                    ID_LOCAL = table.Column<int>(type: "int", nullable: false),
                    IDADE_MINIMA = table.Column<int>(type: "int", nullable: false),
                    IDADE_MAXIMA = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    PESO_RANKING = table.Column<int>(type: "int", nullable: false),
                    ANOTACOES = table.Column<string>(type: "text", nullable: true),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES", x => new { x.ID_CLIENTE, x.ID_COMPETICAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_COMPETICOES_TIPO",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_COMPETICAO },
                        principalTable: "TB_COMPETICOES_TIPOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LOCAIS_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_LOCAL },
                        principalTable: "TB_LOCAIS_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_LOCAL" });
                });

            migrationBuilder.CreateTable(
                name: "TB_AGREMIACOES",
                columns: table => new
                {
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    NOME = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    FANTASIA = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    RESPONSAVEL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    REPRESENTANTE = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    DATA_FILIACAO = table.Column<DateTime>(type: "date", nullable: false),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "date", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    ENDERECO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    BAIRRO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    COMPLEMENTO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    ID_CIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO = table.Column<int>(type: "int", nullable: false),
                    ID_PAIS = table.Column<int>(type: "int", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false),
                    INSCRICAO_MUNICIPAL = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    INSCRICAO_ESTADUAL = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    DATA_CNPJ = table.Column<DateTime>(type: "date", nullable: true),
                    DATA_ATA = table.Column<DateTime>(type: "date", nullable: true),
                    ALVARA_LOCACAO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ESTATUTO = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    CONTRATO_SOCIAL = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    DOCUMENTACAO_ATUALIZADA = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    ID_REGIAO = table.Column<int>(type: "int", nullable: false),
                    ANOTACOES = table.Column<string>(type: "text", nullable: true),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGREMIACOES", x => new { x.ID_CLIENTE, x.ID_AGREMIACAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_AGREMIACOES_CIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO, x.ID_CIDADE },
                        principalTable: "TB_CIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });
                    table.ForeignKey(
                        name: "FK_AGREMIACOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_AGREMIACOES_ESTADOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO },
                        principalTable: "TB_ESTADOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO" });
                    table.ForeignKey(
                        name: "FK_AGREMIACOES_PAISES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                    table.ForeignKey(
                        name: "FK_AGREMIACOES_REGIOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_REGIAO },
                        principalTable: "TB_REGIOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_REGIAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_AREAS",
                columns: table => new
                {
                    ID_AREA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_AREAS", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_AREA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_AREAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_AREAS_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_CATEGORIAS",
                columns: table => new
                {
                    ID_CATEGORIA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    ORDEM_EXIBICAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_CATEGORIAS", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CATEGORIA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CATEGORIAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CATEGORIAS_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_CLASSES",
                columns: table => new
                {
                    ID_CLASSE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_SEXO = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO1 = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    DESCRICAO2 = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    IDADE_INICIAL = table.Column<short>(type: "smallint", nullable: false),
                    IDADE_FINAL = table.Column<short>(type: "smallint", nullable: false),
                    ORDEM_EXIBICAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_CLASSES", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CLASSE })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CLASSES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CLASSES_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CLASSES_SEXOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_SEXO },
                        principalTable: "TB_SEXOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_SEXO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_FAIXAS",
                columns: table => new
                {
                    ID_FAIXA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    ORDEM_EXIBICAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_FAIXAS", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_FAIXA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_FAIXAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_FAIXAS_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_PATROCINADORES",
                columns: table => new
                {
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_PATROCINADOR = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_PATROCINADORES", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_PATROCINADOR })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_PATROCINADORES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_PATROCINADORES_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_PATROCINADORES_PATROCINADORES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PATROCINADOR },
                        principalTable: "TB_PATROCINADORES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PATROCINADOR" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_PENALIDADES",
                columns: table => new
                {
                    ID_PENALIDADE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    ORDEM_EXIBICAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_PENALIDADES", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_PENALIDADE })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_PENALIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_PENALIDADES_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_PONTUACOES",
                columns: table => new
                {
                    ID_PONTUACAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SIGLA = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    DSC_PONTUACAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    ORDEM_EXIBICAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_PONTUACOES", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_PONTUACAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_PONTUACOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_PONTUACOES_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_ATLETAS",
                columns: table => new
                {
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    REGISTRO_FEDERACAO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    REGISTRO_CONFEDERACAO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NOME = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "date", nullable: false),
                    DATA_FILIACAO = table.Column<DateTime>(type: "date", nullable: false),
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    ENDERECO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    BAIRRO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ID_CIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO = table.Column<int>(type: "int", nullable: false),
                    ID_PAIS = table.Column<int>(type: "int", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    IDENTIDADE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DATA_IDENTIDADE = table.Column<DateTime>(type: "date", nullable: false),
                    ID_EMISSOR = table.Column<int>(type: "int", nullable: false),
                    ID_NACIONALIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_PROFISSAO_ATLETA = table.Column<int>(type: "int", nullable: false),
                    NOME_PAI = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ID_PROFISSAO_PAI = table.Column<int>(type: "int", nullable: true),
                    NOME_MAE = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ID_PROFISSAO_MAE = table.Column<int>(type: "int", nullable: true),
                    ID_FAIXA = table.Column<int>(type: "int", nullable: false),
                    ID_SEXO = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO_CIVIL = table.Column<int>(type: "int", nullable: false),
                    ANOTACOES = table.Column<string>(type: "text", nullable: true),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATLETAS", x => new { x.ID_CLIENTE, x.ID_ATLETA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_ATLETAS_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_ATLETAS_CIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO, x.ID_CIDADE },
                        principalTable: "TB_CIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });
                    table.ForeignKey(
                        name: "FK_ATLETAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_ATLETAS_EMISSORES_IDENTIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_EMISSOR },
                        principalTable: "TB_EMISSORES_IDENTIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_EMISSOR" });
                    table.ForeignKey(
                        name: "FK_ATLETAS_ESTADOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO },
                        principalTable: "TB_ESTADOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO" });
                    table.ForeignKey(
                        name: "FK_ATLETAS_ESTADOS_CIVIS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ESTADO_CIVIL },
                        principalTable: "TB_ESTADOS_CIVIS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ESTADO_CIVIL" });
                    table.ForeignKey(
                        name: "FK_ATLETAS_FAIXAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_FAIXA },
                        principalTable: "TB_FAIXAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FAIXA" });
                    table.ForeignKey(
                        name: "FK_ATLETAS_PAISES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                    table.ForeignKey(
                        name: "FK_ATLETAS_PAISES1",
                        columns: x => new { x.ID_CLIENTE, x.ID_NACIONALIDADE },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                    table.ForeignKey(
                        name: "FK_ATLETAS_PROFISSOES1",
                        columns: x => new { x.ID_CLIENTE, x.ID_PROFISSAO_ATLETA },
                        principalTable: "TB_PROFISSOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PROFISSAO" });
                    table.ForeignKey(
                        name: "FK_ATLETAS_PROFISSOES2",
                        columns: x => new { x.ID_CLIENTE, x.ID_PROFISSAO_PAI },
                        principalTable: "TB_PROFISSOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PROFISSAO" });
                    table.ForeignKey(
                        name: "FK_ATLETAS_PROFISSOES3",
                        columns: x => new { x.ID_CLIENTE, x.ID_PROFISSAO_MAE },
                        principalTable: "TB_PROFISSOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PROFISSAO" });
                    table.ForeignKey(
                        name: "FK_ATLETAS_SEXOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_SEXO },
                        principalTable: "TB_SEXOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_SEXO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COBRANCAS",
                columns: table => new
                {
                    ID_COBRANCA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    OFICIO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    MES_BASE = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    DATA_COBRANCA = table.Column<DateTime>(type: "date", nullable: false),
                    DATA_VENCIMENTO = table.Column<DateTime>(type: "date", nullable: false),
                    VALOR_COBRANCA = table.Column<decimal>(type: "money", nullable: false),
                    VALOR_DESCONTO = table.Column<decimal>(type: "money", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COBRANCAS", x => new { x.ID_CLIENTE, x.ID_COBRANCA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COBRANCAS_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_COBRANCAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_CURRICULOS_AGREMIACOES",
                columns: table => new
                {
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    DATA_EVENTO = table.Column<DateTime>(type: "date", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_CURRICULO_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CURRICULOS_AGREMIACOES", x => new { x.ID_CLIENTE, x.ID_AGREMIACAO, x.DATA_EVENTO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CURRICULOS_AGREMIACOES_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_CURRICULOS_AGREMIACOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_CURRICULOS_AGREMIACOES_TIPOS_CURRICULOS_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_CURRICULO_AGREMIACAO },
                        principalTable: "TB_TIPOS_CURRICULOS_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_CURRICULO_AGREMIACAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_DESFILIACOES_AGREMIACOES",
                columns: table => new
                {
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    DATA_DESFILIACAO = table.Column<DateTime>(type: "date", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DATA_REFILIACAO = table.Column<DateTime>(type: "date", nullable: true),
                    ID_TIPO_DESFILIACAO_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESFILIACOES_AGREMIACOES", x => new { x.ID_CLIENTE, x.ID_AGREMIACAO, x.DATA_DESFILIACAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_DESFILIACOES_AGREMIACOES_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_DESFILIACOES_AGREMIACOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_DESFILIACOES_AGREMIACOES_TIPOS_DESFILIACOES_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_DESFILIACAO_AGREMIACAO },
                        principalTable: "TB_TIPOS_DESFILIACOES_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_DESFILIACAO_AGREMIACAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_ISENCOES_AGREMIACOES",
                columns: table => new
                {
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    DATA_INICIO = table.Column<DateTime>(type: "date", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DATA_FIM = table.Column<DateTime>(type: "date", nullable: false),
                    ID_TIPO_ISENCAO_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISENCOES_AGREMIACOES", x => new { x.ID_CLIENTE, x.ID_AGREMIACAO, x.DATA_INICIO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_ISENCOES_AGREMIACOES_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_ISENCOES_AGREMIACOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_ISENCOES_AGREMIACOES_TIPOS_ISENCOES_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_ISENCAO_AGREMIACAO },
                        principalTable: "TB_TIPOS_ISENCOES_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_ISENCAO_AGREMIACAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_MENSALIDADES",
                columns: table => new
                {
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    MES_BASE = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_PAGAMENTO = table.Column<int>(type: "int", nullable: false),
                    ID_TABELA_MENSALIDADES = table.Column<int>(type: "int", nullable: false),
                    DATA_PAGAMENTO = table.Column<int>(type: "int", nullable: false),
                    VALOR_PAGO = table.Column<decimal>(type: "money", nullable: false),
                    VALOR_DESCONTO = table.Column<decimal>(type: "money", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MENSALIDADES", x => new { x.ID_CLIENTE, x.ID_AGREMIACAO, x.MES_BASE })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_MENSALIDADES_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_MENSALIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_MENSALIDADES_TABELAS_MENSALIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TABELA_MENSALIDADES },
                        principalTable: "TB_TABELAS_MENSALIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TABELA" });
                    table.ForeignKey(
                        name: "FK_MENSALIDADES_TIPOS_PAGAMENTOS_MENSALIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_PAGAMENTO },
                        principalTable: "TB_TIPOS_PAGAMENTOS_MENSALIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_PAGAMENTO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_CLASSES_REGRAS",
                columns: table => new
                {
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLASSE_REAL = table.Column<int>(type: "int", nullable: false),
                    ID_CLASSE_INSCRICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_CLASSES_REGRAS", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CLASSE_REAL, x.ID_CLASSE_INSCRICAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CLASSES_REGRAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES_CLASSES1",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CLASSE_REAL },
                        principalTable: "TB_COMPETICOES_CLASSES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CLASSE" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CLASSES_REGRAS_COMPETICOES_CLASSES2",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CLASSE_INSCRICAO },
                        principalTable: "TB_COMPETICOES_CLASSES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CLASSE" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_TABELAS_PESOS",
                columns: table => new
                {
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLASSE = table.Column<int>(type: "int", nullable: false),
                    ID_CATEGORIA = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_SEXO = table.Column<int>(type: "int", nullable: false),
                    PESO_INICIAL = table.Column<double>(type: "float", nullable: false),
                    PESO_FINAL = table.Column<double>(type: "float", nullable: false),
                    ORDEM_EXIBICAO_CLASSE = table.Column<int>(type: "int", nullable: false),
                    ORDEM_EXIBICAO_CATEGORIA = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_TABELAS_PESOS", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CLASSE, x.ID_CATEGORIA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_TABELAS_PESOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_TABELAS_PESOS_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_TABELAS_PESOS_COMPETICOES_CATEGORIAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CATEGORIA },
                        principalTable: "TB_COMPETICOES_CATEGORIAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CATEGORIA" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_TABELAS_PESOS_COMPETICOES_CLASSES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CLASSE },
                        principalTable: "TB_COMPETICOES_CLASSES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CLASSE" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_TABELAS_PESOS_SEXOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_SEXO },
                        principalTable: "TB_SEXOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_SEXO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_CHAVES",
                columns: table => new
                {
                    ID_CHAVE = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_SEXO = table.Column<int>(type: "int", nullable: false),
                    ID_CLASSE = table.Column<int>(type: "int", nullable: false),
                    ID_CATEGORIA = table.Column<int>(type: "int", nullable: false),
                    ID_FAIXA_INICIAL = table.Column<int>(type: "int", nullable: false),
                    ID_FAIXA_FINAL = table.Column<int>(type: "int", nullable: false),
                    ORDEM_EXIBICAO_CHAVE = table.Column<short>(type: "smallint", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    PESO_RANKING = table.Column<short>(type: "smallint", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_CHAVES", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CHAVE })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CHAVES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CHAVES_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CHAVES_COMPETICOES_CATEGORIAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CATEGORIA },
                        principalTable: "TB_COMPETICOES_CATEGORIAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CATEGORIA" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CHAVES_COMPETICOES_CLASSES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CLASSE },
                        principalTable: "TB_COMPETICOES_CLASSES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CLASSE" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CHAVES_COMPETICOES_FAIXAS1",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_FAIXA_INICIAL },
                        principalTable: "TB_COMPETICOES_FAIXAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_FAIXA" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CHAVES_COMPETICOES_FAIXAS2",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_FAIXA_FINAL },
                        principalTable: "TB_COMPETICOES_FAIXAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_FAIXA" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_CHAVES_SEXOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_SEXO },
                        principalTable: "TB_SEXOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_SEXO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_ANUIDADES",
                columns: table => new
                {
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    ANO_BASE = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_PAGAMENTO = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_ANUIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_TABELA_ANUIDADES = table.Column<int>(type: "int", nullable: false),
                    DATA_PAGAMENTO = table.Column<int>(type: "int", nullable: false),
                    VALOR_PAGO = table.Column<decimal>(type: "money", nullable: false),
                    VALOR_DESCONTO = table.Column<decimal>(type: "money", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANUIDADES", x => new { x.ID_CLIENTE, x.ID_ATLETA, x.ANO_BASE })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_ANUIDADES_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_ANUIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_ANUIDADES_TABELAS_ANUIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TABELA_ANUIDADES },
                        principalTable: "TB_TABELAS_ANUIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TABELA" });
                    table.ForeignKey(
                        name: "FK_ANUIDADES_TIPOS_ANUIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_ANUIDADE },
                        principalTable: "TB_TIPOS_ANUIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_ANUIDADE" });
                    table.ForeignKey(
                        name: "FK_ANUIDADES_TIPOS_PAGAMENTOS_ANUIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_PAGAMENTO },
                        principalTable: "TB_TIPOS_PAGAMENTOS_ANUIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_PAGAMENTO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_ANUIDADES_CONFEDERACAO",
                columns: table => new
                {
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    ANO_BASE = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_PAGAMENTO = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_ANUIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_TABELA_ANUIDADES = table.Column<int>(type: "int", nullable: false),
                    DATA_PAGAMENTO = table.Column<int>(type: "int", nullable: false),
                    VALOR_PAGO = table.Column<decimal>(type: "money", nullable: false),
                    VALOR_DESCONTO = table.Column<decimal>(type: "money", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ANUIDADES_CONFEDERACAO", x => new { x.ID_CLIENTE, x.ID_ATLETA, x.ANO_BASE })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_ANUIDADES_CONFEDERACAO_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_ANUIDADES_CONFEDERACAO_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_ANUIDADES_CONFEDERACAO_TABELAS_ANUIDADES_CONFEDERACAO",
                        columns: x => new { x.ID_CLIENTE, x.ID_TABELA_ANUIDADES },
                        principalTable: "TB_TABELAS_ANUIDADES_CONFEDERACAO",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TABELA" });
                    table.ForeignKey(
                        name: "FK_ANUIDADES_CONFEDERACAO_TIPOS_ANUIDADES_CONFEDERACAO",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_ANUIDADE },
                        principalTable: "TB_TIPOS_ANUIDADES_CONFEDERACAO",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_ANUIDADE" });
                    table.ForeignKey(
                        name: "FK_ANUIDADES_CONFEDERACAO_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_PAGAMENTO },
                        principalTable: "TB_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_PAGAMENTO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_ARBITROS",
                columns: table => new
                {
                    ID_ARBITRO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    APELIDO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    NOME = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "date", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    ENDERECO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    BAIRRO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ID_CIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO = table.Column<int>(type: "int", nullable: false),
                    ID_PAIS = table.Column<int>(type: "int", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    IDENTIDADE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DATA_IDENTIDADE = table.Column<DateTime>(type: "date", nullable: false),
                    ID_EMISSOR = table.Column<int>(type: "int", nullable: false),
                    ID_NACIONALIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_NIVEL = table.Column<int>(type: "int", nullable: false),
                    ID_SEXO = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO_CIVIL = table.Column<int>(type: "int", nullable: false),
                    ANOTACOES = table.Column<string>(type: "text", nullable: true),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARBITROS", x => new { x.ID_CLIENTE, x.ID_ARBITRO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_ARBITROS_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_ARBITROS_CIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO, x.ID_CIDADE },
                        principalTable: "TB_CIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });
                    table.ForeignKey(
                        name: "FK_ARBITROS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_ARBITROS_EMISSORES_IDENTIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_EMISSOR },
                        principalTable: "TB_EMISSORES_IDENTIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_EMISSOR" });
                    table.ForeignKey(
                        name: "FK_ARBITROS_ESTADOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO },
                        principalTable: "TB_ESTADOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO" });
                    table.ForeignKey(
                        name: "FK_ARBITROS_ESTADOS_CIVIS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ESTADO_CIVIL },
                        principalTable: "TB_ESTADOS_CIVIS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ESTADO_CIVIL" });
                    table.ForeignKey(
                        name: "FK_ARBITROS_NIVEIS_ARBITROS",
                        columns: x => new { x.ID_CLIENTE, x.ID_NIVEL },
                        principalTable: "TB_NIVEIS_ARBITROS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_NIVEL_ARBITRO" });
                    table.ForeignKey(
                        name: "FK_ARBITROS_PAISES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                    table.ForeignKey(
                        name: "FK_ARBITROS_PAISES1",
                        columns: x => new { x.ID_CLIENTE, x.ID_NACIONALIDADE },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                    table.ForeignKey(
                        name: "FK_ARBITROS_SEXOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_SEXO },
                        principalTable: "TB_SEXOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_SEXO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_CURRICULOS_ATLETAS",
                columns: table => new
                {
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    DATA_EVENTO = table.Column<DateTime>(type: "date", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_CURRICULO_ATLETA = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CURRICULOS_ATLETAS", x => new { x.ID_CLIENTE, x.ID_ATLETA, x.DATA_EVENTO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CURRICULOS_ATLETAS_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_CURRICULOS_ATLETAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_CURRICULOS_ATLETAS_TIPOS_CURRICULOS_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_CURRICULO_ATLETA },
                        principalTable: "TB_TIPOS_CURRICULOS_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_CURRICULO_ATLETA" });
                });

            migrationBuilder.CreateTable(
                name: "TB_DESFILIACOES_ATLETAS",
                columns: table => new
                {
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    DATA_DESFILIACAO = table.Column<DateTime>(type: "date", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DATA_REFILIACAO = table.Column<DateTime>(type: "date", nullable: true),
                    ID_TIPO_DESFILIACAO_ATLETA = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DESFILIACOES_ATLETAS", x => new { x.ID_CLIENTE, x.ID_ATLETA, x.DATA_DESFILIACAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_DESFILIACOES_ATLETAS_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_DESFILIACOES_ATLETAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_DESFILIACOES_ATLETAS_TIPOS_DESFILIACOES_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_DESFILIACAO_ATLETA },
                        principalTable: "TB_TIPOS_DESFILIACOES_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_DESFILIACAO_ATLETA" });
                });

            migrationBuilder.CreateTable(
                name: "TB_ISENCOES_ATLETAS",
                columns: table => new
                {
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    DATA_INICIO = table.Column<DateTime>(type: "date", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DATA_FIM = table.Column<DateTime>(type: "date", nullable: false),
                    ID_TIPO_ISENCAO_ATLETA = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ISENCOES_ATLETAS", x => new { x.ID_CLIENTE, x.ID_ATLETA, x.DATA_INICIO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_ISENCOES_ATLETAS_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_ISENCOES_ATLETAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_ISENCOES_ATLETAS_TIPOS_ISENCOES_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_ISENCAO_ATLETA },
                        principalTable: "TB_TIPOS_ISENCOES_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_ISENCAO_ATLETA" });
                });

            migrationBuilder.CreateTable(
                name: "TB_PESSOAL_APOIO",
                columns: table => new
                {
                    ID_APOIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    APELIDO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    NOME = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "date", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    ENDERECO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    BAIRRO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ID_CIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO = table.Column<int>(type: "int", nullable: false),
                    ID_PAIS = table.Column<int>(type: "int", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    IDENTIDADE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DATA_IDENTIDADE = table.Column<DateTime>(type: "date", nullable: false),
                    ID_EMISSOR = table.Column<int>(type: "int", nullable: false),
                    ID_NACIONALIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_SEXO = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO_CIVIL = table.Column<int>(type: "int", nullable: false),
                    ANOTACOES = table.Column<string>(type: "text", nullable: true),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOAL_APOIO", x => new { x.ID_CLIENTE, x.ID_APOIO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PESSOAL_APOIO_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_PESSOAL_APOIO_CIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO, x.ID_CIDADE },
                        principalTable: "TB_CIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });
                    table.ForeignKey(
                        name: "FK_PESSOAL_APOIO_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_PESSOAL_APOIO_EMISSORES_IDENTIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_EMISSOR },
                        principalTable: "TB_EMISSORES_IDENTIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_EMISSOR" });
                    table.ForeignKey(
                        name: "FK_PESSOAL_APOIO_ESTADOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO },
                        principalTable: "TB_ESTADOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO" });
                    table.ForeignKey(
                        name: "FK_PESSOAL_APOIO_ESTADOS_CIVIS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ESTADO_CIVIL },
                        principalTable: "TB_ESTADOS_CIVIS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ESTADO_CIVIL" });
                    table.ForeignKey(
                        name: "FK_PESSOAL_APOIO_PAISES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                    table.ForeignKey(
                        name: "FK_PESSOAL_APOIO_PAISES1",
                        columns: x => new { x.ID_CLIENTE, x.ID_NACIONALIDADE },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                    table.ForeignKey(
                        name: "FK_PESSOAL_APOIO_SEXOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_SEXO },
                        principalTable: "TB_SEXOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_SEXO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_PROFESSORES",
                columns: table => new
                {
                    ID_PROFESSOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    APELIDO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    NOME = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "date", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    ENDERECO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    BAIRRO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    COMPLEMENTO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ID_CIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO = table.Column<int>(type: "int", nullable: false),
                    ID_PAIS = table.Column<int>(type: "int", nullable: false),
                    TELEFONE = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    EMAIL = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    IDENTIDADE = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    DATA_IDENTIDADE = table.Column<DateTime>(type: "date", nullable: false),
                    ID_EMISSOR = table.Column<int>(type: "int", nullable: false),
                    ID_NACIONALIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_NIVEL = table.Column<int>(type: "int", nullable: false),
                    ID_SEXO = table.Column<int>(type: "int", nullable: false),
                    ID_ESTADO_CIVIL = table.Column<int>(type: "int", nullable: false),
                    ANOTACOES = table.Column<string>(type: "text", nullable: true),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROFESSORES", x => new { x.ID_CLIENTE, x.ID_PROFESSOR })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PROFESSORES_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_PROFESSORES_CIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO, x.ID_CIDADE },
                        principalTable: "TB_CIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });
                    table.ForeignKey(
                        name: "FK_PROFESSORES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_PROFESSORES_EMISSORES_IDENTIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_EMISSOR },
                        principalTable: "TB_EMISSORES_IDENTIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_EMISSOR" });
                    table.ForeignKey(
                        name: "FK_PROFESSORES_ESTADOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO },
                        principalTable: "TB_ESTADOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO" });
                    table.ForeignKey(
                        name: "FK_PROFESSORES_ESTADOS_CIVIS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ESTADO_CIVIL },
                        principalTable: "TB_ESTADOS_CIVIS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ESTADO_CIVIL" });
                    table.ForeignKey(
                        name: "FK_PROFESSORES_PAISES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                    table.ForeignKey(
                        name: "FK_PROFESSORES_PAISES1",
                        columns: x => new { x.ID_CLIENTE, x.ID_NACIONALIDADE },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                    table.ForeignKey(
                        name: "FK_PROFESSORES_SEXOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_SEXO },
                        principalTable: "TB_SEXOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_SEXO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_PROMOCOES_ATLETAS",
                columns: table => new
                {
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    DATA_PROMOCAO = table.Column<DateTime>(type: "date", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_FAIXA_ANTERIOR = table.Column<int>(type: "int", nullable: false),
                    ID_FAIXA_NOVA = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_PROMOCAO_ATLETA = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROMOCOES_ATLETAS", x => new { x.ID_CLIENTE, x.ID_ATLETA, x.DATA_PROMOCAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PROMOCOES_ATLETAS_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_PROMOCOES_ATLETAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_PROMOCOES_ATLETAS_FAIXAS1",
                        columns: x => new { x.ID_CLIENTE, x.ID_FAIXA_ANTERIOR },
                        principalTable: "TB_FAIXAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FAIXA" });
                    table.ForeignKey(
                        name: "FK_PROMOCOES_ATLETAS_FAIXAS2",
                        columns: x => new { x.ID_CLIENTE, x.ID_FAIXA_NOVA },
                        principalTable: "TB_FAIXAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FAIXA" });
                    table.ForeignKey(
                        name: "FK_PROMOCOES_ATLETAS_TIPOS_PROMOCOES_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_PROMOCAO_ATLETA },
                        principalTable: "TB_TIPOS_PROMOCOES_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_PROMOCAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_RECIBOS",
                columns: table => new
                {
                    NUMERO_RECIBO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ORIGEM = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: false, defaultValueSql: "('G')"),
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: true),
                    ID_ATLETA = table.Column<int>(type: "int", nullable: true),
                    NOME = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    DATA_PAGAMENTO = table.Column<DateTime>(type: "date", nullable: false),
                    VALOR_DINHEIRO = table.Column<decimal>(type: "money", nullable: true),
                    VALOR_CHEQUE = table.Column<decimal>(type: "money", nullable: true),
                    VALOR_CARTAO_CREDITO = table.Column<decimal>(type: "money", nullable: true),
                    VALOR_CARTAO_DEBITO = table.Column<decimal>(type: "money", nullable: true),
                    VALOR_DEBITO_AUTOMATICO = table.Column<decimal>(type: "money", nullable: true),
                    VALOR_PIX = table.Column<decimal>(type: "money", nullable: true),
                    VALOR_BONIFICACAO = table.Column<decimal>(type: "money", nullable: true),
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECIBOS", x => new { x.ID_CLIENTE, x.NUMERO_RECIBO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_RECIBOS_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_RECIBOS_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_RECIBOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_RECIBOS_USUARIOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_USUARIO },
                        principalTable: "TB_USUARIOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_USUARIO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_TRANSFERENCIAS",
                columns: table => new
                {
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    DATA_TRANSFERENCIA = table.Column<DateTime>(type: "date", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_AGREMIACAO_ANTERIOR = table.Column<int>(type: "int", nullable: false),
                    ID_AGREMIACAO_NOVA = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_TRANSFERENCIA = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRANSFERENCIAS", x => new { x.ID_CLIENTE, x.ID_ATLETA, x.DATA_TRANSFERENCIA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_TRANSFERENCIAS_AGREMIACOES1",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO_ANTERIOR },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_TRANSFERENCIAS_AGREMIACOES2",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO_NOVA },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_TRANSFERENCIAS_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_TRANSFERENCIAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_TRANSFERENCIAS_TIPOS_TRANSFERENCIAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_TRANSFERENCIA },
                        principalTable: "TB_TIPOS_TRANSFERENCIAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_TRANSFERENCIA" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_INSCRICOES",
                columns: table => new
                {
                    ID_INSCRICAO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    DATA_INSCRICAO = table.Column<DateTime>(type: "date", nullable: false),
                    ID_FAIXA = table.Column<int>(type: "int", nullable: false),
                    ID_CHAVE = table.Column<int>(type: "int", nullable: false),
                    PESO = table.Column<double>(type: "float", nullable: false),
                    PRESENTE = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_INSCRICOES", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_INSCRICAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_INSCRICOES_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_INSCRICOES_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_INSCRICOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_INSCRICOES_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_INSCRICOES_COMPETICOES_CHAVES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CHAVE },
                        principalTable: "TB_COMPETICOES_CHAVES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CHAVE" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_INSCRICOES_COMPETICOES_FAIXAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_FAIXA },
                        principalTable: "TB_COMPETICOES_FAIXAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_FAIXA" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_LUTAS",
                columns: table => new
                {
                    ID_LUTA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_CHAVE = table.Column<int>(type: "int", nullable: false),
                    ORDEM_ATLETA1_CHAVE = table.Column<int>(type: "int", nullable: false),
                    ORDEM_ATLETA2_CHAVE = table.Column<int>(type: "int", nullable: false),
                    ID_ATLETA1 = table.Column<int>(type: "int", nullable: false),
                    ID_ATLETA2 = table.Column<int>(type: "int", nullable: false),
                    DATA_INICIO = table.Column<DateTime>(type: "date", nullable: false),
                    DATA_FINAL = table.Column<DateTime>(type: "date", nullable: false),
                    ID_ATLETA_VENCEDOR = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_LUTAS", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_LUTA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_ATLETAS1",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA1 },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_ATLETAS2",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA2 },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_ATLETAS3",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA_VENCEDOR },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_COMPETICOES_CHAVES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CHAVE },
                        principalTable: "TB_COMPETICOES_CHAVES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CHAVE" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_RESULTADOS",
                columns: table => new
                {
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_CHAVE = table.Column<int>(type: "int", nullable: false),
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DESCRICAO = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    DATA_RESULTADO = table.Column<DateTime>(type: "date", nullable: false),
                    COLOCACAO = table.Column<short>(type: "smallint", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_RESULTADOS", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CHAVE, x.ID_ATLETA })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_RESULTADOS_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_RESULTADOS_CHAVES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_CHAVE },
                        principalTable: "TB_COMPETICOES_CHAVES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CHAVE" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_RESULTADOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_RESULTADOS_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_ARBITROS",
                columns: table => new
                {
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_ARBITRO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    PRESENTE = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_ARBITROS", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_ARBITRO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_ARBITROS_ARBITROS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ARBITRO },
                        principalTable: "TB_ARBITROS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ARBITRO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_ARBITROS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_ARBITROS_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_PROMOCOES_ARBITROS",
                columns: table => new
                {
                    ID_ARBITRO = table.Column<int>(type: "int", nullable: false),
                    DATA_PROMOCAO = table.Column<DateTime>(type: "date", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_NIVEL_ARBITRO_ANTERIOR = table.Column<int>(type: "int", nullable: false),
                    ID_NIVEL_ARBITRO_NOVO = table.Column<int>(type: "int", nullable: false),
                    ID_TIPO_PROMOCAO_ARBITRO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROMOCOES_ARBITROS", x => new { x.ID_CLIENTE, x.ID_ARBITRO, x.DATA_PROMOCAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_PROMOCOES_ARBITROS_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ARBITRO },
                        principalTable: "TB_ARBITROS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ARBITRO" });
                    table.ForeignKey(
                        name: "FK_PROMOCOES_ARBITROS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_PROMOCOES_ARBITROS_NIVEIS_ARBITROS1",
                        columns: x => new { x.ID_CLIENTE, x.ID_NIVEL_ARBITRO_ANTERIOR },
                        principalTable: "TB_NIVEIS_ARBITROS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_NIVEL_ARBITRO" });
                    table.ForeignKey(
                        name: "FK_PROMOCOES_ARBITROS_NIVEIS_ARBITROS2",
                        columns: x => new { x.ID_CLIENTE, x.ID_NIVEL_ARBITRO_NOVO },
                        principalTable: "TB_NIVEIS_ARBITROS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_NIVEL_ARBITRO" });
                    table.ForeignKey(
                        name: "FK_PROMOCOES_ARBITROS_TIPOS_PROMOCOES_ARBITROS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_PROMOCAO_ARBITRO },
                        principalTable: "TB_TIPOS_PROMOCOES_ARBITROS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_PROMOCAO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_PESSOAL_APOIO",
                columns: table => new
                {
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_APOIO = table.Column<int>(type: "int", nullable: false),
                    ID_FUNCAO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    PRESENTE = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_PESSOAL_APOIO", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_APOIO, x.ID_FUNCAO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_PESSOAL_APOIO_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_PESSOAL_APOIO_FUNCOES_APOIO",
                        columns: x => new { x.ID_CLIENTE, x.ID_FUNCAO },
                        principalTable: "TB_FUNCOES_APOIO",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FUNCAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_PESSOAL_APOIO_PESSOAL_APOIO",
                        columns: x => new { x.ID_CLIENTE, x.ID_APOIO },
                        principalTable: "TB_PESSOAL_APOIO",
                        principalColumns: new[] { "ID_CLIENTE", "ID_APOIO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_PESSOAL_APOIOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                });

            migrationBuilder.CreateTable(
                name: "TB_FUNCOES_APOIO_PESSOAL_APOIO",
                columns: table => new
                {
                    ID_FUNCAO = table.Column<int>(type: "int", nullable: false),
                    ID_APOIO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FUNCOES_APOIO_PESSOAL_APOIO", x => new { x.ID_CLIENTE, x.ID_FUNCAO, x.ID_APOIO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_FUNCOES_APOIO_PESSOAL_APOIO_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_FUNCOES_APOIO_PESSOAL_APOIO_FUNCOES_APOIO",
                        columns: x => new { x.ID_CLIENTE, x.ID_FUNCAO },
                        principalTable: "TB_FUNCOES_APOIO",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FUNCAO" });
                    table.ForeignKey(
                        name: "FK_FUNCOES_APOIO_PESSOAL_APOIO_PESSOAL_APOIO",
                        columns: x => new { x.ID_CLIENTE, x.ID_APOIO },
                        principalTable: "TB_PESSOAL_APOIO",
                        principalColumns: new[] { "ID_CLIENTE", "ID_APOIO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_AGREMIACOES_PROFESSORES",
                columns: table => new
                {
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    ID_PROFESSOR = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    DATA_INICIO = table.Column<DateTime>(type: "date", nullable: false),
                    ID_TIPO_PROFESSOR = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGREMIACOES_PROFESSORES", x => new { x.ID_CLIENTE, x.ID_AGREMIACAO, x.ID_PROFESSOR })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_AGREMIACOES_PROFESSORES_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_AGREMIACOES_PROFESSORES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_AGREMIACOES_PROFESSORES_PROFESSORES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PROFESSOR },
                        principalTable: "TB_PROFESSORES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PROFESSOR" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_TECNICOS",
                columns: table => new
                {
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: false),
                    ID_PROFESSOR = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_TECNICOS", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_AGREMIACAO, x.ID_PROFESSOR })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_TECNICOS_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_TECNICOS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_TECNICOS_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_TECNICOS_PROFESSORES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PROFESSOR },
                        principalTable: "TB_PROFESSORES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PROFESSOR" });
                });

            migrationBuilder.CreateTable(
                name: "TB_VALORES_DEFAULT",
                columns: table => new
                {
                    ID_DEFAULT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_ATLETA = table.Column<int>(type: "int", nullable: true),
                    ID_AGREMIACAO = table.Column<int>(type: "int", nullable: true),
                    ID_REGIAO = table.Column<int>(type: "int", nullable: true),
                    ID_PROFESSOR = table.Column<int>(type: "int", nullable: true),
                    ID_ARBITRO = table.Column<int>(type: "int", nullable: true),
                    ID_APOIO = table.Column<int>(type: "int", nullable: true),
                    ID_SEXO = table.Column<int>(type: "int", nullable: true),
                    ID_ESTADO_CIVIL = table.Column<int>(type: "int", nullable: true),
                    ID_PAIS = table.Column<int>(type: "int", nullable: true),
                    ID_ESTADO = table.Column<int>(type: "int", nullable: true),
                    ID_CIDADE = table.Column<int>(type: "int", nullable: true),
                    BAIRRO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ID_NACIONALIDADE = table.Column<int>(type: "int", nullable: true),
                    ID_PROFISSAO_ATLETA = table.Column<int>(type: "int", nullable: true),
                    ID_PROFISSAO_PAI = table.Column<int>(type: "int", nullable: true),
                    ID_PROFISSAO_MAE = table.Column<int>(type: "int", nullable: true),
                    ID_EMISSOR_IDENTIDADE = table.Column<int>(type: "int", nullable: true),
                    DATA_FILIACAO = table.Column<DateTime>(type: "date", nullable: true),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "date", nullable: true),
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: true),
                    ID_LOCAL = table.Column<int>(type: "int", nullable: true),
                    ID_PATROCINADOR = table.Column<int>(type: "int", nullable: true),
                    ID_FAIXA = table.Column<int>(type: "int", nullable: true),
                    ID_CATEGORIA = table.Column<int>(type: "int", nullable: true),
                    ID_CLASSE = table.Column<int>(type: "int", nullable: true),
                    ID_PONTUACAO = table.Column<int>(type: "int", nullable: true),
                    ID_PENALIDADE = table.Column<int>(type: "int", nullable: true),
                    DATA_INSCRICAO = table.Column<DateTime>(type: "date", nullable: true),
                    ANO_BASE = table.Column<string>(type: "char(4)", unicode: false, fixedLength: true, maxLength: 4, nullable: true),
                    ID_TIPO_ANUIDADE = table.Column<int>(type: "int", nullable: true),
                    ID_TABELA_ANUIDADE = table.Column<int>(type: "int", nullable: true),
                    ID_TIPO_PAGAMENTO_ANUIDADE = table.Column<int>(type: "int", nullable: true),
                    DATA_PAGAMENTO_ANUIDADE = table.Column<DateTime>(type: "date", nullable: true),
                    VALOR_ANUIDADE = table.Column<decimal>(type: "money", nullable: true),
                    VALOR_DESCONTO_ANUIDADE = table.Column<decimal>(type: "money", nullable: true),
                    MES_BASE = table.Column<string>(type: "char(6)", unicode: false, fixedLength: true, maxLength: 6, nullable: true),
                    ID_TABELA_MENSALIDADE = table.Column<int>(type: "int", nullable: true),
                    ID_TIPO_PAGAMENTO_MENSALIDADE = table.Column<int>(type: "int", nullable: true),
                    DATA_PAGAMENTO_MENSALIDADE = table.Column<DateTime>(type: "date", nullable: true),
                    VALOR_MENSALIDADE = table.Column<decimal>(type: "money", nullable: true),
                    VALOR_DESCONTO_MENSALIDADE = table.Column<decimal>(type: "money", nullable: true),
                    DATA_PROMOCAO_ATLETA = table.Column<DateTime>(type: "date", nullable: true),
                    ID_TIPO_PROMOCAO_ATLETA = table.Column<int>(type: "int", nullable: true),
                    ID_FAIXA_ANTERIOR = table.Column<int>(type: "int", nullable: true),
                    ID_FAIXA_NOVA = table.Column<int>(type: "int", nullable: true),
                    DATA_PROMOCAO_ARBITRO = table.Column<DateTime>(type: "date", nullable: true),
                    ID_TIPO_PROMOCAO_ARBITRO = table.Column<int>(type: "int", nullable: true),
                    ID_NIVEL_ANTERIOR = table.Column<int>(type: "int", nullable: true),
                    ID_NIVEL_NOVO = table.Column<int>(type: "int", nullable: true),
                    DATA_TRANSFERENCIA = table.Column<DateTime>(type: "date", nullable: true),
                    ID_TIPO_TRANSFERENCIA = table.Column<int>(type: "int", nullable: true),
                    ID_AGREMIACAO_ANTERIOR = table.Column<int>(type: "int", nullable: true),
                    ID_AGREMIACAO_NOVA = table.Column<int>(type: "int", nullable: true),
                    ORIGEM = table.Column<string>(type: "char(1)", unicode: false, fixedLength: true, maxLength: 1, nullable: true),
                    DATA_PAGAMENTO_RECIBO = table.Column<DateTime>(type: "date", nullable: true),
                    ID_SERVICO = table.Column<int>(type: "int", nullable: true),
                    QUANTIDADE = table.Column<int>(type: "int", nullable: true),
                    ID_FORMA_PAGAMENTO = table.Column<int>(type: "int", nullable: true),
                    DATA_DESFILIACAO_ATLETA = table.Column<DateTime>(type: "date", nullable: true),
                    ID_TIPO_DESFILIACAO_ATLETA = table.Column<int>(type: "int", nullable: true),
                    DATA_DESFILIACAO_AGREMIACAO = table.Column<DateTime>(type: "date", nullable: true),
                    ID_TIPO_DESFILIACAO_AGREMIACAO = table.Column<int>(type: "int", nullable: true),
                    DATA_EVENTO_CURRICULO_ATLETA = table.Column<int>(type: "int", nullable: true),
                    ID_TIPO_CURRICULO_ATLETA = table.Column<int>(type: "int", nullable: true),
                    DATA_EVENTO_CURRICULO_AGREMIACAO = table.Column<int>(type: "int", nullable: true),
                    ID_TIPO_CURRICULO_AGREMIACAO = table.Column<int>(type: "int", nullable: true),
                    ID_TIPO_ISENCAO_ATLETA = table.Column<int>(type: "int", nullable: true),
                    ID_TIPO_ISENCAO_AGREMIACAO = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VALORES_DEFAULT", x => new { x.ID_CLIENTE, x.ID_DEFAULT })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_AGREMIACOES1",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_AGREMIACOES2",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO_ANTERIOR },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_AGREMIACOES3",
                        columns: x => new { x.ID_CLIENTE, x.ID_AGREMIACAO_NOVA },
                        principalTable: "TB_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_ARBITROS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ARBITRO },
                        principalTable: "TB_ARBITROS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ARBITRO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_CATEGORIAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_CATEGORIA },
                        principalTable: "TB_CATEGORIAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_CATEGORIA" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_CIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO, x.ID_CIDADE },
                        principalTable: "TB_CIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_CLASSES",
                        columns: x => new { x.ID_CLIENTE, x.ID_CLASSE },
                        principalTable: "TB_CLASSES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_CLASSE" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_EMISSORES_IDENTIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_EMISSOR_IDENTIDADE },
                        principalTable: "TB_EMISSORES_IDENTIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_EMISSOR" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_ESTADOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS, x.ID_ESTADO },
                        principalTable: "TB_ESTADOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_ESTADOS_CIVIS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ESTADO_CIVIL },
                        principalTable: "TB_ESTADOS_CIVIS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ESTADO_CIVIL" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_FAIXAS1",
                        columns: x => new { x.ID_CLIENTE, x.ID_FAIXA },
                        principalTable: "TB_FAIXAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FAIXA" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_FAIXAS2",
                        columns: x => new { x.ID_CLIENTE, x.ID_FAIXA_ANTERIOR },
                        principalTable: "TB_FAIXAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FAIXA" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_FAIXAS3",
                        columns: x => new { x.ID_CLIENTE, x.ID_FAIXA_NOVA },
                        principalTable: "TB_FAIXAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FAIXA" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_FORMAS_PAGAMENTO",
                        columns: x => new { x.ID_CLIENTE, x.ID_FORMA_PAGAMENTO },
                        principalTable: "TB_FORMAS_PAGAMENTOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FORMA_PAGAMENTO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_LOCAIS_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_LOCAL },
                        principalTable: "TB_LOCAIS_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_LOCAL" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_NIVEIS_ARBITROS1",
                        columns: x => new { x.ID_CLIENTE, x.ID_NIVEL_ANTERIOR },
                        principalTable: "TB_NIVEIS_ARBITROS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_NIVEL_ARBITRO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_NIVEIS_ARBITROS2",
                        columns: x => new { x.ID_CLIENTE, x.ID_NIVEL_NOVO },
                        principalTable: "TB_NIVEIS_ARBITROS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_NIVEL_ARBITRO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_PAISES1",
                        columns: x => new { x.ID_CLIENTE, x.ID_PAIS },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_PAISES2",
                        columns: x => new { x.ID_CLIENTE, x.ID_NACIONALIDADE },
                        principalTable: "TB_PAISES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PAIS" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_PATROCINADORES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PATROCINADOR },
                        principalTable: "TB_PATROCINADORES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PATROCINADOR" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_PENALIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PENALIDADE },
                        principalTable: "TB_PENALIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PENALIDADE" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_PESSOAL_APOIO",
                        columns: x => new { x.ID_CLIENTE, x.ID_APOIO },
                        principalTable: "TB_PESSOAL_APOIO",
                        principalColumns: new[] { "ID_CLIENTE", "ID_APOIO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_PONTUACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PONTUACAO },
                        principalTable: "TB_PONTUACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PONTUACAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_PROFESSORES",
                        columns: x => new { x.ID_CLIENTE, x.ID_PROFESSOR },
                        principalTable: "TB_PROFESSORES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PROFESSOR" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_PROFISSOES1",
                        columns: x => new { x.ID_CLIENTE, x.ID_PROFISSAO_ATLETA },
                        principalTable: "TB_PROFISSOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PROFISSAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_PROFISSOES2",
                        columns: x => new { x.ID_CLIENTE, x.ID_PROFISSAO_PAI },
                        principalTable: "TB_PROFISSOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PROFISSAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_PROFISSOES3",
                        columns: x => new { x.ID_CLIENTE, x.ID_PROFISSAO_MAE },
                        principalTable: "TB_PROFISSOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_PROFISSAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_REGIOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_REGIAO },
                        principalTable: "TB_REGIOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_REGIAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_SEXOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_SEXO },
                        principalTable: "TB_SEXOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_SEXO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TABELA_SERVICOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_SERVICO },
                        principalTable: "TB_TABELA_SERVICOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_SERVICO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TABELAS_ANUIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TABELA_ANUIDADE },
                        principalTable: "TB_TABELAS_ANUIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TABELA" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TABELAS_MENSALIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TABELA_MENSALIDADE },
                        principalTable: "TB_TABELAS_MENSALIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TABELA" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_ANUIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_ANUIDADE },
                        principalTable: "TB_TIPOS_ANUIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_ANUIDADE" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_CURRICULOS_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_CURRICULO_AGREMIACAO },
                        principalTable: "TB_TIPOS_CURRICULOS_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_CURRICULO_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_CURRICULOS_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_CURRICULO_ATLETA },
                        principalTable: "TB_TIPOS_CURRICULOS_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_CURRICULO_ATLETA" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_DESFILIACOES_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_DESFILIACAO_AGREMIACAO },
                        principalTable: "TB_TIPOS_DESFILIACOES_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_DESFILIACAO_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_DESFILIACOES_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_DESFILIACAO_ATLETA },
                        principalTable: "TB_TIPOS_DESFILIACOES_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_DESFILIACAO_ATLETA" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_ISENCOES_AGREMIACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_ISENCAO_AGREMIACAO },
                        principalTable: "TB_TIPOS_ISENCOES_AGREMIACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_ISENCAO_AGREMIACAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_ISENCOES_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_ISENCAO_ATLETA },
                        principalTable: "TB_TIPOS_ISENCOES_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_ISENCAO_ATLETA" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_PAGAMENTOS_ANUIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_PAGAMENTO_ANUIDADE },
                        principalTable: "TB_TIPOS_PAGAMENTOS_ANUIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_PAGAMENTO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_PAGAMENTOS_MENSALIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_PAGAMENTO_MENSALIDADE },
                        principalTable: "TB_TIPOS_PAGAMENTOS_MENSALIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_PAGAMENTO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_PROMOCOES_ARBITROS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_PROMOCAO_ARBITRO },
                        principalTable: "TB_TIPOS_PROMOCOES_ARBITROS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_PROMOCAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_PROMOCOES_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_PROMOCAO_ATLETA },
                        principalTable: "TB_TIPOS_PROMOCOES_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_PROMOCAO" });
                    table.ForeignKey(
                        name: "FK_VALORES_DEFAULT_TIPOS_TRANSFERENCIAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_TIPO_TRANSFERENCIA },
                        principalTable: "TB_TIPOS_TRANSFERENCIAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_TIPO_TRANSFERENCIA" });
                });

            migrationBuilder.CreateTable(
                name: "TB_RECIBOS_ITENS",
                columns: table => new
                {
                    ID_RECIBO = table.Column<int>(type: "int", nullable: false),
                    ID_ITEM_RECIBO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_SERVICO = table.Column<int>(type: "int", nullable: false),
                    QUANTIDADE = table.Column<int>(type: "int", nullable: false),
                    ID_FORMA_PAGAMENTO = table.Column<int>(type: "int", nullable: false),
                    VALOR_UNITARIO = table.Column<decimal>(type: "money", nullable: false),
                    VALOR_DESCONTO = table.Column<decimal>(type: "money", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RECIBOS_ITENS", x => new { x.ID_CLIENTE, x.ID_RECIBO, x.ID_ITEM_RECIBO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_RECIBOS_ITENS_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_RECIBOS_ITENS_FORMAS_PAGAMENTO",
                        columns: x => new { x.ID_CLIENTE, x.ID_FORMA_PAGAMENTO },
                        principalTable: "TB_FORMAS_PAGAMENTOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_FORMA_PAGAMENTO" });
                    table.ForeignKey(
                        name: "FK_RECIBOS_ITENS_RECIBOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_RECIBO },
                        principalTable: "TB_RECIBOS",
                        principalColumns: new[] { "ID_CLIENTE", "NUMERO_RECIBO" });
                    table.ForeignKey(
                        name: "FK_RECIBOS_ITENS_SERVICOS",
                        columns: x => new { x.ID_CLIENTE, x.ID_SERVICO },
                        principalTable: "TB_TABELA_SERVICOS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_SERVICO" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_LUTAS_PENALIDADES",
                columns: table => new
                {
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_LUTA = table.Column<int>(type: "int", nullable: false),
                    TEMPO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    ID_PENALIDADE = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_LUTAS_PENALIDADES", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_LUTA, x.TEMPO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_PENALIDADES_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_PENALIDADES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_PENALIDADES_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_PENALIDADES_COMPETICOES_PENALIDADES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_PENALIDADE },
                        principalTable: "TB_COMPETICOES_PENALIDADES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_PENALIDADE" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_PENALIDADES_LUTAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_LUTA },
                        principalTable: "TB_COMPETICOES_LUTAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_LUTA" });
                });

            migrationBuilder.CreateTable(
                name: "TB_COMPETICOES_LUTAS_PONTUACOES",
                columns: table => new
                {
                    ID_COMPETICAO = table.Column<int>(type: "int", nullable: false),
                    ID_LUTA = table.Column<int>(type: "int", nullable: false),
                    TEMPO = table.Column<int>(type: "int", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: false),
                    ID_ATLETA = table.Column<int>(type: "int", nullable: false),
                    ID_PONTUACAO = table.Column<int>(type: "int", nullable: false),
                    SELECAO = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPETICOES_LUTAS_PONTUACOES", x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_LUTA, x.TEMPO })
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_PONTUACOES_ATLETAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_ATLETA },
                        principalTable: "TB_ATLETAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_ATLETA" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_PONTUACOES_CLIENTES",
                        column: x => x.ID_CLIENTE,
                        principalTable: "TB_CLIENTES",
                        principalColumn: "ID_CLIENTE");
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_PONTUACOES_COMPETICOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO },
                        principalTable: "TB_COMPETICOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_PONTUACOES_COMPETICOES_PONTUACOES",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_PONTUACAO },
                        principalTable: "TB_COMPETICOES_PONTUACOES",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_PONTUACAO" });
                    table.ForeignKey(
                        name: "FK_COMPETICOES_LUTAS_PONTUACOES_LUTAS",
                        columns: x => new { x.ID_CLIENTE, x.ID_COMPETICAO, x.ID_LUTA },
                        principalTable: "TB_COMPETICOES_LUTAS",
                        principalColumns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_LUTA" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_AGREMIACOES_ID_CLIENTE_ID_PAIS_ID_ESTADO_ID_CIDADE",
                table: "TB_AGREMIACOES",
                columns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_AGREMIACOES_ID_CLIENTE_ID_REGIAO",
                table: "TB_AGREMIACOES",
                columns: new[] { "ID_CLIENTE", "ID_REGIAO" });

            migrationBuilder.CreateIndex(
                name: "UK_AGREMIACOES_CNPJ",
                table: "TB_AGREMIACOES",
                columns: new[] { "ID_CLIENTE", "CNPJ" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_AGREMIACOES_SIGLAS",
                table: "TB_AGREMIACOES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_AGREMIACOES_PROFESSORES_ID_CLIENTE_ID_PROFESSOR",
                table: "TB_AGREMIACOES_PROFESSORES",
                columns: new[] { "ID_CLIENTE", "ID_PROFESSOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ANUIDADES_ID_CLIENTE_ID_TABELA_ANUIDADES",
                table: "TB_ANUIDADES",
                columns: new[] { "ID_CLIENTE", "ID_TABELA_ANUIDADES" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ANUIDADES_ID_CLIENTE_ID_TIPO_ANUIDADE",
                table: "TB_ANUIDADES",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_ANUIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ANUIDADES_ID_CLIENTE_ID_TIPO_PAGAMENTO",
                table: "TB_ANUIDADES",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_PAGAMENTO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ANUIDADES_CONFEDERACAO_ID_CLIENTE_ID_TABELA_ANUIDADES",
                table: "TB_ANUIDADES_CONFEDERACAO",
                columns: new[] { "ID_CLIENTE", "ID_TABELA_ANUIDADES" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ANUIDADES_CONFEDERACAO_ID_CLIENTE_ID_TIPO_ANUIDADE",
                table: "TB_ANUIDADES_CONFEDERACAO",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_ANUIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ANUIDADES_CONFEDERACAO_ID_CLIENTE_ID_TIPO_PAGAMENTO",
                table: "TB_ANUIDADES_CONFEDERACAO",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_PAGAMENTO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARBITROS_ID_CLIENTE_ID_ATLETA",
                table: "TB_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARBITROS_ID_CLIENTE_ID_EMISSOR",
                table: "TB_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ID_EMISSOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARBITROS_ID_CLIENTE_ID_ESTADO_CIVIL",
                table: "TB_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ID_ESTADO_CIVIL" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARBITROS_ID_CLIENTE_ID_NACIONALIDADE",
                table: "TB_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ID_NACIONALIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARBITROS_ID_CLIENTE_ID_NIVEL",
                table: "TB_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ID_NIVEL" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARBITROS_ID_CLIENTE_ID_PAIS_ID_ESTADO_ID_CIDADE",
                table: "TB_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARBITROS_ID_CLIENTE_ID_SEXO",
                table: "TB_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ID_SEXO" });

            migrationBuilder.CreateIndex(
                name: "UK_ARBITROS_APELIDOS",
                table: "TB_ARBITROS",
                columns: new[] { "ID_CLIENTE", "APELIDO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ARBITROS_CPF",
                table: "TB_ARBITROS",
                columns: new[] { "ID_CLIENTE", "CPF" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_ATLETAS_ID_CLIENTE_ID_AGREMIACAO",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ATLETAS_ID_CLIENTE_ID_EMISSOR",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_EMISSOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ATLETAS_ID_CLIENTE_ID_ESTADO_CIVIL",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_ESTADO_CIVIL" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ATLETAS_ID_CLIENTE_ID_FAIXA",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_FAIXA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ATLETAS_ID_CLIENTE_ID_NACIONALIDADE",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_NACIONALIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ATLETAS_ID_CLIENTE_ID_PAIS_ID_ESTADO_ID_CIDADE",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ATLETAS_ID_CLIENTE_ID_PROFISSAO_ATLETA",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_PROFISSAO_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ATLETAS_ID_CLIENTE_ID_PROFISSAO_MAE",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_PROFISSAO_MAE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ATLETAS_ID_CLIENTE_ID_PROFISSAO_PAI",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_PROFISSAO_PAI" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ATLETAS_ID_CLIENTE_ID_SEXO",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_SEXO" });

            migrationBuilder.CreateIndex(
                name: "UK_ATLETAS_CPF",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "CPF" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_ATLETAS_REGISTRO_CONFEDERACAO",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "REGISTRO_CONFEDERACAO" },
                unique: true,
                filter: "[REGISTRO_CONFEDERACAO] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UK_ATLETAS_REGISTRO_FEDERACAO",
                table: "TB_ATLETAS",
                columns: new[] { "ID_CLIENTE", "REGISTRO_FEDERACAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_CATEGORIAS_ORDENS_EXIBICAO",
                table: "TB_CATEGORIAS",
                columns: new[] { "ID_CLIENTE", "ORDEM_EXIBICAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_CATEGORIAS_SIGLAS",
                table: "TB_CATEGORIAS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLASSES_ID_CLIENTE_ID_SEXO",
                table: "TB_CLASSES",
                columns: new[] { "ID_CLIENTE", "ID_SEXO" });

            migrationBuilder.CreateIndex(
                name: "UK_CLASSES_ORDENS_EXIBICAO",
                table: "TB_CLASSES",
                columns: new[] { "ID_CLIENTE", "ORDEM_EXIBICAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_CLASSES_SIGLAS",
                table: "TB_CLASSES",
                columns: new[] { "ID_CLIENTE", "SIGLA", "ID_SEXO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_CLIENTES_ID_SISTEMA",
                table: "TB_CLIENTES",
                column: "ID_SISTEMA");

            migrationBuilder.CreateIndex(
                name: "IX_TB_COBRANCAS_ID_CLIENTE_ID_AGREMIACAO",
                table: "TB_COBRANCAS",
                columns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_ID_CLIENTE_ID_LOCAL",
                table: "TB_COMPETICOES",
                columns: new[] { "ID_CLIENTE", "ID_LOCAL" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_ID_CLIENTE_ID_TIPO_COMPETICAO",
                table: "TB_COMPETICOES",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_COMPETICAO" });

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_SIGLAS",
                table: "TB_COMPETICOES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_ARBITROS_ID_CLIENTE_ID_ARBITRO",
                table: "TB_COMPETICOES_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ID_ARBITRO" });

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_AREAS_SIGLAS",
                table: "TB_COMPETICOES_AREAS",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_CATEGORIAS_ORDENS_EXIBICAO",
                table: "TB_COMPETICOES_CATEGORIAS",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ORDEM_EXIBICAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_CHAVES_ID_CLIENTE_ID_COMPETICAO_ID_CATEGORIA",
                table: "TB_COMPETICOES_CHAVES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CATEGORIA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_CHAVES_ID_CLIENTE_ID_COMPETICAO_ID_CLASSE",
                table: "TB_COMPETICOES_CHAVES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CLASSE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_CHAVES_ID_CLIENTE_ID_COMPETICAO_ID_FAIXA_FINAL",
                table: "TB_COMPETICOES_CHAVES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_FAIXA_FINAL" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_CHAVES_ID_CLIENTE_ID_COMPETICAO_ID_FAIXA_INICIAL",
                table: "TB_COMPETICOES_CHAVES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_FAIXA_INICIAL" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_CHAVES_ID_CLIENTE_ID_SEXO",
                table: "TB_COMPETICOES_CHAVES",
                columns: new[] { "ID_CLIENTE", "ID_SEXO" });

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_CHAVES_ORDENS_EXIBICAO_CHAVES",
                table: "TB_COMPETICOES_CHAVES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ORDEM_EXIBICAO_CHAVE" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_CLASSES_ID_CLIENTE_ID_SEXO",
                table: "TB_COMPETICOES_CLASSES",
                columns: new[] { "ID_CLIENTE", "ID_SEXO" });

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_CLASSES_ORDENS_EXIBICAO",
                table: "TB_COMPETICOES_CLASSES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ORDEM_EXIBICAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_CLASSES_SIGLAS",
                table: "TB_COMPETICOES_CLASSES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "SIGLA", "ID_SEXO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_CLASSES_REGRAS_ID_CLIENTE_ID_COMPETICAO_ID_CLASSE_INSCRICAO",
                table: "TB_COMPETICOES_CLASSES_REGRAS",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CLASSE_INSCRICAO" });

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_FAIXAS_ORDENS_EXIBICAO",
                table: "TB_COMPETICOES_FAIXAS",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ORDEM_EXIBICAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_FAIXAS_SIGLAS",
                table: "TB_COMPETICOES_FAIXAS",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_INSCRICOES_ID_CLIENTE_ID_AGREMIACAO",
                table: "TB_COMPETICOES_INSCRICOES",
                columns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_INSCRICOES_ID_CLIENTE_ID_ATLETA",
                table: "TB_COMPETICOES_INSCRICOES",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_INSCRICOES_ID_CLIENTE_ID_COMPETICAO_ID_CHAVE",
                table: "TB_COMPETICOES_INSCRICOES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CHAVE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_INSCRICOES_ID_CLIENTE_ID_COMPETICAO_ID_FAIXA",
                table: "TB_COMPETICOES_INSCRICOES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_FAIXA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_LUTAS_ID_CLIENTE_ID_ATLETA_VENCEDOR",
                table: "TB_COMPETICOES_LUTAS",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA_VENCEDOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_LUTAS_ID_CLIENTE_ID_ATLETA1",
                table: "TB_COMPETICOES_LUTAS",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA1" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_LUTAS_ID_CLIENTE_ID_ATLETA2",
                table: "TB_COMPETICOES_LUTAS",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA2" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_LUTAS_ID_CLIENTE_ID_COMPETICAO_ID_CHAVE",
                table: "TB_COMPETICOES_LUTAS",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CHAVE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_LUTAS_PENALIDADES_ID_CLIENTE_ID_ATLETA",
                table: "TB_COMPETICOES_LUTAS_PENALIDADES",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_LUTAS_PENALIDADES_ID_CLIENTE_ID_COMPETICAO_ID_PENALIDADE",
                table: "TB_COMPETICOES_LUTAS_PENALIDADES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_PENALIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_LUTAS_PONTUACOES_ID_CLIENTE_ID_ATLETA",
                table: "TB_COMPETICOES_LUTAS_PONTUACOES",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_LUTAS_PONTUACOES_ID_CLIENTE_ID_COMPETICAO_ID_PONTUACAO",
                table: "TB_COMPETICOES_LUTAS_PONTUACOES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_PONTUACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_PATROCINADORES_ID_CLIENTE_ID_PATROCINADOR",
                table: "TB_COMPETICOES_PATROCINADORES",
                columns: new[] { "ID_CLIENTE", "ID_PATROCINADOR" });

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_PENALIDADES_ORDENS_EXIBICAO",
                table: "TB_COMPETICOES_PENALIDADES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ORDEM_EXIBICAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_PENALIDADES_SIGLAS",
                table: "TB_COMPETICOES_PENALIDADES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_PESSOAL_APOIO_ID_CLIENTE_ID_APOIO",
                table: "TB_COMPETICOES_PESSOAL_APOIO",
                columns: new[] { "ID_CLIENTE", "ID_APOIO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_PESSOAL_APOIO_ID_CLIENTE_ID_FUNCAO",
                table: "TB_COMPETICOES_PESSOAL_APOIO",
                columns: new[] { "ID_CLIENTE", "ID_FUNCAO" });

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_PONTUACOES_ORDENS_EXIBICAO",
                table: "TB_COMPETICOES_PONTUACOES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ORDEM_EXIBICAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_PONTUACOES_SIGLAS",
                table: "TB_COMPETICOES_PONTUACOES",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_RESULTADOS_ID_CLIENTE_ID_ATLETA",
                table: "TB_COMPETICOES_RESULTADOS",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_TABELAS_PESOS_ID_CLIENTE_ID_COMPETICAO_ID_CATEGORIA",
                table: "TB_COMPETICOES_TABELAS_PESOS",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ID_CATEGORIA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_TABELAS_PESOS_ID_CLIENTE_ID_SEXO",
                table: "TB_COMPETICOES_TABELAS_PESOS",
                columns: new[] { "ID_CLIENTE", "ID_SEXO" });

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_TABELAS_PESOS_ORDENS_EXIBICAO_CATEGORIAS",
                table: "TB_COMPETICOES_TABELAS_PESOS",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ORDEM_EXIBICAO_CATEGORIA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_TABELAS_PESOS_ORDENS_EXIBICAO_CLASSES",
                table: "TB_COMPETICOES_TABELAS_PESOS",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO", "ORDEM_EXIBICAO_CLASSE" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_TECNICOS_ID_CLIENTE_ID_AGREMIACAO",
                table: "TB_COMPETICOES_TECNICOS",
                columns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_COMPETICOES_TECNICOS_ID_CLIENTE_ID_PROFESSOR",
                table: "TB_COMPETICOES_TECNICOS",
                columns: new[] { "ID_CLIENTE", "ID_PROFESSOR" });

            migrationBuilder.CreateIndex(
                name: "UK_COMPETICOES_TIPOS_SIGLAS",
                table: "TB_COMPETICOES_TIPOS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_CURRICULOS_AGREMIACOES_ID_CLIENTE_ID_TIPO_CURRICULO_AGREMIACAO",
                table: "TB_CURRICULOS_AGREMIACOES",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_CURRICULO_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CURRICULOS_ATLETAS_ID_CLIENTE_ID_TIPO_CURRICULO_ATLETA",
                table: "TB_CURRICULOS_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_CURRICULO_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_DESFILIACOES_AGREMIACOES_ID_CLIENTE_ID_TIPO_DESFILIACAO_AGREMIACAO",
                table: "TB_DESFILIACOES_AGREMIACOES",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_DESFILIACAO_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_DESFILIACOES_ATLETAS_ID_CLIENTE_ID_TIPO_DESFILIACAO_ATLETA",
                table: "TB_DESFILIACOES_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_DESFILIACAO_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "UK_EMISSORES_IDENTIDADES_SIGLAS",
                table: "TB_EMISSORES_IDENTIDADES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_FAIXAS_ORDENS_EXIBICAO",
                table: "TB_FAIXAS",
                columns: new[] { "ID_CLIENTE", "ORDEM_EXIBICAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_FAIXAS_SIGLAS",
                table: "TB_FAIXAS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_FORMAS_PAGAMENTOS_SIGLAS",
                table: "TB_FORMAS_PAGAMENTOS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_FUNCOES_APOIO_SIGLAS",
                table: "TB_FUNCOES_APOIO",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_FUNCOES_APOIO_PESSOAL_APOIO_ID_CLIENTE_ID_APOIO",
                table: "TB_FUNCOES_APOIO_PESSOAL_APOIO",
                columns: new[] { "ID_CLIENTE", "ID_APOIO" });

            migrationBuilder.CreateIndex(
                name: "UK_FUNCOES_MENU_SIGLAS",
                table: "TB_FUNCOES_MENU",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_ISENCOES_AGREMIACOES_ID_CLIENTE_ID_TIPO_ISENCAO_AGREMIACAO",
                table: "TB_ISENCOES_AGREMIACOES",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_ISENCAO_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ISENCOES_ATLETAS_ID_CLIENTE_ID_TIPO_ISENCAO_ATLETA",
                table: "TB_ISENCOES_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_ISENCAO_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_LOCAIS_COMPETICOES_ID_CLIENTE_ID_PAIS_ID_ESTADO_ID_CIDADE",
                table: "TB_LOCAIS_COMPETICOES",
                columns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });

            migrationBuilder.CreateIndex(
                name: "UK_LOCAIS_COMPETICOES_CNPJ",
                table: "TB_LOCAIS_COMPETICOES",
                columns: new[] { "ID_CLIENTE", "CNPJ" },
                unique: true,
                filter: "[CNPJ] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UK_LOCAIS_COMPETICOES_SIGLAS",
                table: "TB_LOCAIS_COMPETICOES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_MENSALIDADES_ID_CLIENTE_ID_TABELA_MENSALIDADES",
                table: "TB_MENSALIDADES",
                columns: new[] { "ID_CLIENTE", "ID_TABELA_MENSALIDADES" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_MENSALIDADES_ID_CLIENTE_ID_TIPO_PAGAMENTO",
                table: "TB_MENSALIDADES",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_PAGAMENTO" });

            migrationBuilder.CreateIndex(
                name: "UK_NIVEIS_ARBITROS_ORDENS_EXIBICAO",
                table: "TB_NIVEIS_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ORDEM_EXIBICAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_NIVEIS_ARBITROS_SIGLAS",
                table: "TB_NIVEIS_ARBITROS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PAISES_SIGLAS_2",
                table: "TB_PAISES",
                columns: new[] { "ID_CLIENTE", "SIGLA_2" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PAISES_SIGLAS_3",
                table: "TB_PAISES",
                columns: new[] { "ID_CLIENTE", "SIGLA_3" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_PATROCINADORES_ID_CLIENTE_ID_PAIS_ID_ESTADO_ID_CIDADE",
                table: "TB_PATROCINADORES",
                columns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });

            migrationBuilder.CreateIndex(
                name: "UK_PATROCINADORES_SIGLAS",
                table: "TB_PATROCINADORES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PENALIDADES_ORDENS_EXIBICAO",
                table: "TB_PENALIDADES",
                columns: new[] { "ID_CLIENTE", "ORDEM_EXIBICAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PENALIDADES_SIGLAS",
                table: "TB_PENALIDADES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PERFIS_SIGLAS",
                table: "TB_PERFIS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERFIS_USUARIOS_ID_CLIENTE_ID_USUARIO",
                table: "TB_PERFIS_USUARIOS",
                columns: new[] { "ID_CLIENTE", "ID_USUARIO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERMISSOES_ID_CLIENTE_ID_FUNCAO_MENU",
                table: "TB_PERMISSOES",
                columns: new[] { "ID_CLIENTE", "ID_FUNCAO_MENU" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERMISSOES_ID_CLIENTE_ID_TIPO_OPERACAO",
                table: "TB_PERMISSOES",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_OPERACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PESSOAL_APOIO_ID_CLIENTE_ID_ATLETA",
                table: "TB_PESSOAL_APOIO",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PESSOAL_APOIO_ID_CLIENTE_ID_EMISSOR",
                table: "TB_PESSOAL_APOIO",
                columns: new[] { "ID_CLIENTE", "ID_EMISSOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PESSOAL_APOIO_ID_CLIENTE_ID_ESTADO_CIVIL",
                table: "TB_PESSOAL_APOIO",
                columns: new[] { "ID_CLIENTE", "ID_ESTADO_CIVIL" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PESSOAL_APOIO_ID_CLIENTE_ID_NACIONALIDADE",
                table: "TB_PESSOAL_APOIO",
                columns: new[] { "ID_CLIENTE", "ID_NACIONALIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PESSOAL_APOIO_ID_CLIENTE_ID_PAIS_ID_ESTADO_ID_CIDADE",
                table: "TB_PESSOAL_APOIO",
                columns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PESSOAL_APOIO_ID_CLIENTE_ID_SEXO",
                table: "TB_PESSOAL_APOIO",
                columns: new[] { "ID_CLIENTE", "ID_SEXO" });

            migrationBuilder.CreateIndex(
                name: "UK_PESSOAL_APOIO_APELIDOS",
                table: "TB_PESSOAL_APOIO",
                columns: new[] { "ID_CLIENTE", "APELIDO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PESSOAL_APOIO_CPF",
                table: "TB_PESSOAL_APOIO",
                columns: new[] { "ID_CLIENTE", "CPF" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PONTUACOES_ORDENS_EXIBICAO",
                table: "TB_PONTUACOES",
                columns: new[] { "ID_CLIENTE", "ORDEM_EXIBICAO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PONTUACOES_SIGLAS",
                table: "TB_PONTUACOES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROFESSORES_ID_CLIENTE_ID_ATLETA",
                table: "TB_PROFESSORES",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROFESSORES_ID_CLIENTE_ID_EMISSOR",
                table: "TB_PROFESSORES",
                columns: new[] { "ID_CLIENTE", "ID_EMISSOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROFESSORES_ID_CLIENTE_ID_ESTADO_CIVIL",
                table: "TB_PROFESSORES",
                columns: new[] { "ID_CLIENTE", "ID_ESTADO_CIVIL" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROFESSORES_ID_CLIENTE_ID_NACIONALIDADE",
                table: "TB_PROFESSORES",
                columns: new[] { "ID_CLIENTE", "ID_NACIONALIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROFESSORES_ID_CLIENTE_ID_PAIS_ID_ESTADO_ID_CIDADE",
                table: "TB_PROFESSORES",
                columns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROFESSORES_ID_CLIENTE_ID_SEXO",
                table: "TB_PROFESSORES",
                columns: new[] { "ID_CLIENTE", "ID_SEXO" });

            migrationBuilder.CreateIndex(
                name: "UK_PROFESSORES_APELIDOS",
                table: "TB_PROFESSORES",
                columns: new[] { "ID_CLIENTE", "APELIDO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PROFESSORES_CPF",
                table: "TB_PROFESSORES",
                columns: new[] { "ID_CLIENTE", "CPF" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_PROFISSOES_SIGLAS",
                table: "TB_PROFISSOES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROMOCOES_ARBITROS_ID_CLIENTE_ID_NIVEL_ARBITRO_ANTERIOR",
                table: "TB_PROMOCOES_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ID_NIVEL_ARBITRO_ANTERIOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROMOCOES_ARBITROS_ID_CLIENTE_ID_NIVEL_ARBITRO_NOVO",
                table: "TB_PROMOCOES_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ID_NIVEL_ARBITRO_NOVO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROMOCOES_ARBITROS_ID_CLIENTE_ID_TIPO_PROMOCAO_ARBITRO",
                table: "TB_PROMOCOES_ARBITROS",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_PROMOCAO_ARBITRO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROMOCOES_ATLETAS_ID_CLIENTE_ID_FAIXA_ANTERIOR",
                table: "TB_PROMOCOES_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_FAIXA_ANTERIOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROMOCOES_ATLETAS_ID_CLIENTE_ID_FAIXA_NOVA",
                table: "TB_PROMOCOES_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_FAIXA_NOVA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PROMOCOES_ATLETAS_ID_CLIENTE_ID_TIPO_PROMOCAO_ATLETA",
                table: "TB_PROMOCOES_ATLETAS",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_PROMOCAO_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_RECIBOS_ID_CLIENTE_ID_AGREMIACAO",
                table: "TB_RECIBOS",
                columns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_RECIBOS_ID_CLIENTE_ID_ATLETA",
                table: "TB_RECIBOS",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_RECIBOS_ID_CLIENTE_ID_USUARIO",
                table: "TB_RECIBOS",
                columns: new[] { "ID_CLIENTE", "ID_USUARIO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_RECIBOS_ITENS_ID_CLIENTE_ID_FORMA_PAGAMENTO",
                table: "TB_RECIBOS_ITENS",
                columns: new[] { "ID_CLIENTE", "ID_FORMA_PAGAMENTO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_RECIBOS_ITENS_ID_CLIENTE_ID_SERVICO",
                table: "TB_RECIBOS_ITENS",
                columns: new[] { "ID_CLIENTE", "ID_SERVICO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_REGIOES_ID_CLIENTE_ID_PAIS_ID_ESTADO_ID_CIDADE",
                table: "TB_REGIOES",
                columns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });

            migrationBuilder.CreateIndex(
                name: "UK_REGIOES_SIGLAS",
                table: "TB_REGIOES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_REGISTRO_EVENTOS_ID_CLIENTE_ID_FUNCAO_MENU",
                table: "TB_REGISTRO_EVENTOS",
                columns: new[] { "ID_CLIENTE", "ID_FUNCAO_MENU" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_REGISTRO_EVENTOS_ID_CLIENTE_ID_TIPO_OPERACAO",
                table: "TB_REGISTRO_EVENTOS",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_OPERACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_REGISTRO_EVENTOS_ID_CLIENTE_ID_USUARIO",
                table: "TB_REGISTRO_EVENTOS",
                columns: new[] { "ID_CLIENTE", "ID_USUARIO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_SISTEMAS_MENSAGENS_ID_SISTEMA_ID_TIPO_MENSAGEM",
                table: "TB_SISTEMAS_MENSAGENS",
                columns: new[] { "ID_SISTEMA", "ID_TIPO_MENSAGEM" });

            migrationBuilder.CreateIndex(
                name: "UK_SISTEMAS_MENSAGENS_SIGLAS",
                table: "TB_SISTEMAS_MENSAGENS",
                columns: new[] { "ID_SISTEMA", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_SISTEMAS_TIPOS_MENSAGENS_SIGLAS",
                table: "TB_SISTEMAS_TIPOS_MENSAGENS",
                columns: new[] { "ID_SISTEMA", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_TABELA_PESOS_ID_CLIENTE_ID_CATEGORIA",
                table: "TB_TABELA_PESOS",
                columns: new[] { "ID_CLIENTE", "ID_CATEGORIA" });

            migrationBuilder.CreateIndex(
                name: "UK_TABELA_PESOS_ORDENS_EXIBICAO_CATEGORIAS",
                table: "TB_TABELA_PESOS",
                columns: new[] { "ID_CLIENTE", "ORDEM_EXIBICAO_CATEGORIA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TABELA_PESOS_ORDENS_EXIBICAO_CLASSES",
                table: "TB_TABELA_PESOS",
                columns: new[] { "ID_CLIENTE", "ORDEM_EXIBICAO_CLASSE" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TABELA_SERVICOS_SIGLAS",
                table: "TB_TABELA_SERVICOS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_ANUIDADES_SIGLAS",
                table: "TB_TIPOS_ANUIDADES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_ANUIDADES_CONFEDERACAO_SIGLAS",
                table: "TB_TIPOS_ANUIDADES_CONFEDERACAO",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_CURRICULOS_AGREMIACOES_SIGLAS",
                table: "TB_TIPOS_CURRICULOS_AGREMIACOES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_CURRICULOS_ATLETAS_SIGLAS",
                table: "TB_TIPOS_CURRICULOS_ATLETAS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_DESFILIACOES_AGREMIACOES_SIGLAS",
                table: "TB_TIPOS_DESFILIACOES_AGREMIACOES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_DESFILIACOES_ATLETAS_SIGLAS",
                table: "TB_TIPOS_DESFILIACOES_ATLETAS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_ISENCOES_AGREMIACOES_SIGLAS",
                table: "TB_TIPOS_ISENCOES_AGREMIACOES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_ISENCOES_ATLETAS_SIGLAS",
                table: "TB_TIPOS_ISENCOES_ATLETAS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_ITENS_RECIBOS_SIGLAS",
                table: "TB_TIPOS_ITENS_RECIBOS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_OPERACOES_SIGLAS",
                table: "TB_TIPOS_OPERACOES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_PAGAMENTOS_ANUIDADES_SIGLAS",
                table: "TB_TIPOS_PAGAMENTOS_ANUIDADES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO_SIGLAS",
                table: "TB_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_PAGAMENTOS_MENSALIDADES_SIGLAS",
                table: "TB_TIPOS_PAGAMENTOS_MENSALIDADES",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_PROMOCOES_ARBITROS_SIGLAS",
                table: "TB_TIPOS_PROMOCOES_ARBITROS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_PROMOCOES_ATLETAS_SIGLAS",
                table: "TB_TIPOS_PROMOCOES_ATLETAS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_TIPOS_TRANSFERENCIAS_SIGLAS",
                table: "TB_TIPOS_TRANSFERENCIAS",
                columns: new[] { "ID_CLIENTE", "SIGLA" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_TRANSFERENCIAS_ID_CLIENTE_ID_AGREMIACAO_ANTERIOR",
                table: "TB_TRANSFERENCIAS",
                columns: new[] { "ID_CLIENTE", "ID_AGREMIACAO_ANTERIOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_TRANSFERENCIAS_ID_CLIENTE_ID_AGREMIACAO_NOVA",
                table: "TB_TRANSFERENCIAS",
                columns: new[] { "ID_CLIENTE", "ID_AGREMIACAO_NOVA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_TRANSFERENCIAS_ID_CLIENTE_ID_TIPO_TRANSFERENCIA",
                table: "TB_TRANSFERENCIAS",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_TRANSFERENCIA" });

            migrationBuilder.CreateIndex(
                name: "UK_USUARIOS_LOGIN_USUARIO",
                table: "TB_USUARIOS",
                columns: new[] { "ID_CLIENTE", "LOGIN_USUARIO" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_AGREMIACAO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_AGREMIACAO_ANTERIOR",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_AGREMIACAO_ANTERIOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_AGREMIACAO_NOVA",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_AGREMIACAO_NOVA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_APOIO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_APOIO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_ARBITRO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_ARBITRO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_ATLETA",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_CATEGORIA",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_CATEGORIA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_CLASSE",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_CLASSE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_COMPETICAO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_COMPETICAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_EMISSOR_IDENTIDADE",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_EMISSOR_IDENTIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_ESTADO_CIVIL",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_ESTADO_CIVIL" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_FAIXA",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_FAIXA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_FAIXA_ANTERIOR",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_FAIXA_ANTERIOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_FAIXA_NOVA",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_FAIXA_NOVA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_FORMA_PAGAMENTO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_FORMA_PAGAMENTO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_LOCAL",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_LOCAL" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_NACIONALIDADE",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_NACIONALIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_NIVEL_ANTERIOR",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_NIVEL_ANTERIOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_NIVEL_NOVO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_NIVEL_NOVO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_PAIS_ID_ESTADO_ID_CIDADE",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_PAIS", "ID_ESTADO", "ID_CIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_PATROCINADOR",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_PATROCINADOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_PENALIDADE",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_PENALIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_PONTUACAO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_PONTUACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_PROFESSOR",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_PROFESSOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_PROFISSAO_ATLETA",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_PROFISSAO_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_PROFISSAO_MAE",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_PROFISSAO_MAE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_PROFISSAO_PAI",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_PROFISSAO_PAI" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_REGIAO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_REGIAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_SERVICO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_SERVICO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_SEXO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_SEXO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TABELA_ANUIDADE",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TABELA_ANUIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TABELA_MENSALIDADE",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TABELA_MENSALIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_ANUIDADE",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_ANUIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_CURRICULO_AGREMIACAO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_CURRICULO_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_CURRICULO_ATLETA",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_CURRICULO_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_DESFILIACAO_AGREMIACAO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_DESFILIACAO_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_DESFILIACAO_ATLETA",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_DESFILIACAO_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_ISENCAO_AGREMIACAO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_ISENCAO_AGREMIACAO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_ISENCAO_ATLETA",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_ISENCAO_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_PAGAMENTO_ANUIDADE",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_PAGAMENTO_ANUIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_PAGAMENTO_MENSALIDADE",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_PAGAMENTO_MENSALIDADE" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_PROMOCAO_ARBITRO",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_PROMOCAO_ARBITRO" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_PROMOCAO_ATLETA",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_PROMOCAO_ATLETA" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_VALORES_DEFAULT_ID_CLIENTE_ID_TIPO_TRANSFERENCIA",
                table: "TB_VALORES_DEFAULT",
                columns: new[] { "ID_CLIENTE", "ID_TIPO_TRANSFERENCIA" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_AGREMIACOES_PROFESSORES");

            migrationBuilder.DropTable(
                name: "TB_ANUIDADES");

            migrationBuilder.DropTable(
                name: "TB_ANUIDADES_CONFEDERACAO");

            migrationBuilder.DropTable(
                name: "TB_COBRANCAS");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_ARBITROS");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_AREAS");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_CLASSES_REGRAS");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_INSCRICOES");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_LUTAS_PENALIDADES");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_LUTAS_PONTUACOES");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_PATROCINADORES");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_PESSOAL_APOIO");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_RESULTADOS");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_TABELAS_PESOS");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_TECNICOS");

            migrationBuilder.DropTable(
                name: "TB_CURRICULOS_AGREMIACOES");

            migrationBuilder.DropTable(
                name: "TB_CURRICULOS_ATLETAS");

            migrationBuilder.DropTable(
                name: "TB_DESFILIACOES_AGREMIACOES");

            migrationBuilder.DropTable(
                name: "TB_DESFILIACOES_ATLETAS");

            migrationBuilder.DropTable(
                name: "TB_FUNCOES_APOIO_PESSOAL_APOIO");

            migrationBuilder.DropTable(
                name: "TB_ISENCOES_AGREMIACOES");

            migrationBuilder.DropTable(
                name: "TB_ISENCOES_ATLETAS");

            migrationBuilder.DropTable(
                name: "TB_MENSALIDADES");

            migrationBuilder.DropTable(
                name: "TB_PERFIS_USUARIOS");

            migrationBuilder.DropTable(
                name: "TB_PERMISSOES");

            migrationBuilder.DropTable(
                name: "TB_PROMOCOES_ARBITROS");

            migrationBuilder.DropTable(
                name: "TB_PROMOCOES_ATLETAS");

            migrationBuilder.DropTable(
                name: "TB_RECIBOS_ITENS");

            migrationBuilder.DropTable(
                name: "TB_REGISTRO_EVENTOS");

            migrationBuilder.DropTable(
                name: "TB_SISTEMAS_MENSAGENS");

            migrationBuilder.DropTable(
                name: "TB_TABELA_PESOS");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_ITENS_RECIBOS");

            migrationBuilder.DropTable(
                name: "TB_TRANSFERENCIAS");

            migrationBuilder.DropTable(
                name: "TB_VALORES_DEFAULT");

            migrationBuilder.DropTable(
                name: "TB_TABELAS_ANUIDADES_CONFEDERACAO");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_ANUIDADES_CONFEDERACAO");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_PENALIDADES");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_PONTUACOES");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_LUTAS");

            migrationBuilder.DropTable(
                name: "TB_FUNCOES_APOIO");

            migrationBuilder.DropTable(
                name: "TB_PERFIS");

            migrationBuilder.DropTable(
                name: "TB_RECIBOS");

            migrationBuilder.DropTable(
                name: "TB_FUNCOES_MENU");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_OPERACOES");

            migrationBuilder.DropTable(
                name: "TB_SISTEMAS_TIPOS_MENSAGENS");

            migrationBuilder.DropTable(
                name: "TB_ARBITROS");

            migrationBuilder.DropTable(
                name: "TB_CATEGORIAS");

            migrationBuilder.DropTable(
                name: "TB_CLASSES");

            migrationBuilder.DropTable(
                name: "TB_FORMAS_PAGAMENTOS");

            migrationBuilder.DropTable(
                name: "TB_PATROCINADORES");

            migrationBuilder.DropTable(
                name: "TB_PENALIDADES");

            migrationBuilder.DropTable(
                name: "TB_PESSOAL_APOIO");

            migrationBuilder.DropTable(
                name: "TB_PONTUACOES");

            migrationBuilder.DropTable(
                name: "TB_PROFESSORES");

            migrationBuilder.DropTable(
                name: "TB_TABELA_SERVICOS");

            migrationBuilder.DropTable(
                name: "TB_TABELAS_ANUIDADES");

            migrationBuilder.DropTable(
                name: "TB_TABELAS_MENSALIDADES");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_ANUIDADES");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_CURRICULOS_AGREMIACOES");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_CURRICULOS_ATLETAS");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_DESFILIACOES_AGREMIACOES");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_DESFILIACOES_ATLETAS");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_ISENCOES_AGREMIACOES");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_ISENCOES_ATLETAS");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_PAGAMENTOS_ANUIDADES");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_PAGAMENTOS_MENSALIDADES");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_PROMOCOES_ARBITROS");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_PROMOCOES_ATLETAS");

            migrationBuilder.DropTable(
                name: "TB_TIPOS_TRANSFERENCIAS");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_CHAVES");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS");

            migrationBuilder.DropTable(
                name: "TB_NIVEIS_ARBITROS");

            migrationBuilder.DropTable(
                name: "TB_ATLETAS");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_CATEGORIAS");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_CLASSES");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_FAIXAS");

            migrationBuilder.DropTable(
                name: "TB_AGREMIACOES");

            migrationBuilder.DropTable(
                name: "TB_EMISSORES_IDENTIDADES");

            migrationBuilder.DropTable(
                name: "TB_ESTADOS_CIVIS");

            migrationBuilder.DropTable(
                name: "TB_FAIXAS");

            migrationBuilder.DropTable(
                name: "TB_PROFISSOES");

            migrationBuilder.DropTable(
                name: "TB_SEXOS");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES");

            migrationBuilder.DropTable(
                name: "TB_REGIOES");

            migrationBuilder.DropTable(
                name: "TB_COMPETICOES_TIPOS");

            migrationBuilder.DropTable(
                name: "TB_LOCAIS_COMPETICOES");

            migrationBuilder.DropTable(
                name: "TB_CIDADES");

            migrationBuilder.DropTable(
                name: "TB_ESTADOS");

            migrationBuilder.DropTable(
                name: "TB_PAISES");

            migrationBuilder.DropTable(
                name: "TB_CLIENTES");

            migrationBuilder.DropTable(
                name: "TB_SISTEMAS");
        }
    }
}
