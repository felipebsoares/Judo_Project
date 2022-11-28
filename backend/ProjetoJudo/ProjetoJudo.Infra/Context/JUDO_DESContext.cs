using Microsoft.EntityFrameworkCore;
using ProjetoJudo.Domain.Contracts;
using ProjetoJudo.Domain.Entities;

namespace ProjetoJudo.Infra.Context
{
    public partial class JudoDesContext : DbContext, IUnitOfWork
    {
        public JudoDesContext() { }

        public JudoDesContext(DbContextOptions<JudoDesContext> options) : base(options) { }

        public virtual DbSet<TbAgremiaco> TbAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbAgremiacoesProfessore> TbAgremiacoesProfessores { get; set; } = null!;
        public virtual DbSet<TbAnuidade> TbAnuidades { get; set; } = null!;
        public virtual DbSet<TbAnuidadesConfederacao> TbAnuidadesConfederacaos { get; set; } = null!;
        public virtual DbSet<TbArbitro> TbArbitros { get; set; } = null!;
        public virtual DbSet<TbAtleta> TbAtletas { get; set; } = null!;
        public virtual DbSet<TbCategoria> TbCategorias { get; set; } = null!;
        public virtual DbSet<TbCidade> TbCidades { get; set; } = null!;
        public virtual DbSet<TbClass> TbClasses { get; set; } = null!;
        public virtual DbSet<TbCliente> TbClientes { get; set; } = null!;
        public virtual DbSet<TbCobranca> TbCobrancas { get; set; } = null!;
        public virtual DbSet<TbCompetico> TbCompeticoes { get; set; } = null!;
        public virtual DbSet<TbCompeticoesArbitro> TbCompeticoesArbitros { get; set; } = null!;
        public virtual DbSet<TbCompeticoesArea> TbCompeticoesAreas { get; set; } = null!;
        public virtual DbSet<TbCompeticoesCategoria> TbCompeticoesCategorias { get; set; } = null!;
        public virtual DbSet<TbCompeticoesChafe> TbCompeticoesChaves { get; set; } = null!;
        public virtual DbSet<TbCompeticoesClass> TbCompeticoesClasses { get; set; } = null!;
        public virtual DbSet<TbCompeticoesClassesRegra> TbCompeticoesClassesRegras { get; set; } = null!;
        public virtual DbSet<TbCompeticoesFaixa> TbCompeticoesFaixas { get; set; } = null!;
        public virtual DbSet<TbCompeticoesInscrico> TbCompeticoesInscricoes { get; set; } = null!;
        public virtual DbSet<TbCompeticoesLuta> TbCompeticoesLutas { get; set; } = null!;
        public virtual DbSet<TbCompeticoesLutasPenalidade> TbCompeticoesLutasPenalidades { get; set; } = null!;
        public virtual DbSet<TbCompeticoesLutasPontuaco> TbCompeticoesLutasPontuacoes { get; set; } = null!;
        public virtual DbSet<TbCompeticoesPatrocinadore> TbCompeticoesPatrocinadores { get; set; } = null!;
        public virtual DbSet<TbCompeticoesPenalidade> TbCompeticoesPenalidades { get; set; } = null!;
        public virtual DbSet<TbCompeticoesPessoalApoio> TbCompeticoesPessoalApoios { get; set; } = null!;
        public virtual DbSet<TbCompeticoesPontuaco> TbCompeticoesPontuacoes { get; set; } = null!;
        public virtual DbSet<TbCompeticoesResultado> TbCompeticoesResultados { get; set; } = null!;
        public virtual DbSet<TbCompeticoesTabelasPeso> TbCompeticoesTabelasPesos { get; set; } = null!;
        public virtual DbSet<TbCompeticoesTecnico> TbCompeticoesTecnicos { get; set; } = null!;
        public virtual DbSet<TbCompeticoesTipo> TbCompeticoesTipos { get; set; } = null!;
        public virtual DbSet<TbCurriculosAgremiaco> TbCurriculosAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbCurriculosAtleta> TbCurriculosAtletas { get; set; } = null!;
        public virtual DbSet<TbDesfiliacoesAgremiaco> TbDesfiliacoesAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbDesfiliacoesAtleta> TbDesfiliacoesAtletas { get; set; } = null!;
        public virtual DbSet<TbEmissoresIdentidade> TbEmissoresIdentidades { get; set; } = null!;
        public virtual DbSet<TbEstado> TbEstados { get; set; } = null!;
        public virtual DbSet<TbEstadosCivi> TbEstadosCivis { get; set; } = null!;
        public virtual DbSet<TbFaixa> TbFaixas { get; set; } = null!;
        public virtual DbSet<TbFormasPagamento> TbFormasPagamentos { get; set; } = null!;
        public virtual DbSet<TbFuncoesApoio> TbFuncoesApoios { get; set; } = null!;
        public virtual DbSet<TbFuncoesApoioPessoalApoio> TbFuncoesApoioPessoalApoios { get; set; } = null!;
        public virtual DbSet<TbFuncoesMenu> TbFuncoesMenus { get; set; } = null!;
        public virtual DbSet<TbIsencoesAgremiaco> TbIsencoesAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbIsencoesAtleta> TbIsencoesAtletas { get; set; } = null!;
        public virtual DbSet<TbLocaisCompetico> TbLocaisCompeticoes { get; set; } = null!;
        public virtual DbSet<TbMensalidade> TbMensalidades { get; set; } = null!;
        public virtual DbSet<TbNiveisArbitro> TbNiveisArbitros { get; set; } = null!;
        public virtual DbSet<TbPaise> TbPaises { get; set; } = null!;
        public virtual DbSet<TbPatrocinadore> TbPatrocinadores { get; set; } = null!;
        public virtual DbSet<TbPenalidade> TbPenalidades { get; set; } = null!;
        public virtual DbSet<TbPerfi> TbPerfis { get; set; } = null!;
        public virtual DbSet<TbPerfisUsuario> TbPerfisUsuarios { get; set; } = null!;
        public virtual DbSet<TbPermisso> TbPermissoes { get; set; } = null!;
        public virtual DbSet<TbPessoalApoio> TbPessoalApoios { get; set; } = null!;
        public virtual DbSet<TbPontuaco> TbPontuacoes { get; set; } = null!;
        public virtual DbSet<TbProfessore> TbProfessores { get; set; } = null!;
        public virtual DbSet<TbProfisso> TbProfissoes { get; set; } = null!;
        public virtual DbSet<TbPromocoesArbitro> TbPromocoesArbitros { get; set; } = null!;
        public virtual DbSet<TbPromocoesAtleta> TbPromocoesAtletas { get; set; } = null!;
        public virtual DbSet<TbRecibo> TbRecibos { get; set; } = null!;
        public virtual DbSet<TbRecibosIten> TbRecibosItens { get; set; } = null!;
        public virtual DbSet<TbRegio> TbRegioes { get; set; } = null!;
        public virtual DbSet<TbRegistroEvento> TbRegistroEventos { get; set; } = null!;
        public virtual DbSet<TbSexo> TbSexos { get; set; } = null!;
        public virtual DbSet<TbSistema> TbSistemas { get; set; } = null!;
        public virtual DbSet<TbSistemasMensagen> TbSistemasMensagens { get; set; } = null!;
        public virtual DbSet<TbSistemasTiposMensagen> TbSistemasTiposMensagens { get; set; } = null!;
        public virtual DbSet<TbTabelaPeso> TbTabelaPesos { get; set; } = null!;
        public virtual DbSet<TbTabelaServico> TbTabelaServicos { get; set; } = null!;
        public virtual DbSet<TbTabelasAnuidade> TbTabelasAnuidades { get; set; } = null!;
        public virtual DbSet<TbTabelasAnuidadesConfederacao> TbTabelasAnuidadesConfederacaos { get; set; } = null!;
        public virtual DbSet<TbTabelasMensalidade> TbTabelasMensalidades { get; set; } = null!;
        public virtual DbSet<TbTiposAnuidade> TbTiposAnuidades { get; set; } = null!;
        public virtual DbSet<TbTiposAnuidadesConfederacao> TbTiposAnuidadesConfederacaos { get; set; } = null!;
        public virtual DbSet<TbTiposCurriculosAgremiaco> TbTiposCurriculosAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbTiposCurriculosAtleta> TbTiposCurriculosAtletas { get; set; } = null!;
        public virtual DbSet<TbTiposDesfiliacoesAgremiaco> TbTiposDesfiliacoesAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbTiposDesfiliacoesAtleta> TbTiposDesfiliacoesAtletas { get; set; } = null!;
        public virtual DbSet<TbTiposIsencoesAgremiaco> TbTiposIsencoesAgremiacoes { get; set; } = null!;
        public virtual DbSet<TbTiposIsencoesAtleta> TbTiposIsencoesAtletas { get; set; } = null!;
        public virtual DbSet<TbTiposItensRecibo> TbTiposItensRecibos { get; set; } = null!;
        public virtual DbSet<TbTiposOperaco> TbTiposOperacoes { get; set; } = null!;
        public virtual DbSet<TbTiposPagamentosAnuidade> TbTiposPagamentosAnuidades { get; set; } = null!;
        public virtual DbSet<TbTiposPagamentosAnuidadesConfederacao> TbTiposPagamentosAnuidadesConfederacaos { get; set; } = null!;
        public virtual DbSet<TbTiposPagamentosMensalidade> TbTiposPagamentosMensalidades { get; set; } = null!;
        public virtual DbSet<TbTiposPromocoesArbitro> TbTiposPromocoesArbitros { get; set; } = null!;
        public virtual DbSet<TbTiposPromocoesAtleta> TbTiposPromocoesAtletas { get; set; } = null!;
        public virtual DbSet<TbTiposTransferencia> TbTiposTransferencias { get; set; } = null!;
        public virtual DbSet<TbTransferencia> TbTransferencias { get; set; } = null!;
        public virtual DbSet<TbUsuario> TbUsuarios { get; set; } = null!;
        public virtual DbSet<TbValoresDefault> TbValoresDefaults { get; set; } = null!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao })
                    .HasName("PK_AGREMIACOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbAgremiacoesProfessore>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.IdProfessor })
                    .HasName("PK_AGREMIACOES_PROFESSORES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbAnuidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.AnoBase })
                    .HasName("PK_ANUIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbAnuidadesConfederacao>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.AnoBase })
                    .HasName("PK_ANUIDADES_CONFEDERACAO")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbArbitro>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdArbitro })
                    .HasName("PK_ARBITROS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta })
                    .HasName("PK_ATLETAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCategoria>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCategoria })
                    .HasName("PK_CATEGORIAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPais, e.IdEstado, e.IdCidade })
                    .HasName("PK_CIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbClass>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdClasse })
                    .HasName("PK_CLASSES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_CLIENTES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCobranca>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCobranca })
                    .HasName("PK_COBRANCAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompetico>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao })
                    .HasName("PK_COMPETICOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesArbitro>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdArbitro })
                    .HasName("PK_COMPETICOES_ARBITROS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesArea>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdArea })
                    .HasName("PK_COMPETICOES_AREAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesCategoria>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdCategoria })
                    .HasName("PK_COMPETICOES_CATEGORIAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesChafe>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdChave })
                    .HasName("PK_COMPETICOES_CHAVES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesClass>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdClasse })
                    .HasName("PK_COMPETICOES_CLASSES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesClassesRegra>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdClasseReal, e.IdClasseInscricao })
                    .HasName("PK_COMPETICOES_CLASSES_REGRAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesFaixa>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdFaixa })
                    .HasName("PK_COMPETICOES_FAIXAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesInscrico>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdInscricao })
                    .HasName("PK_COMPETICOES_INSCRICOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesLuta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdLuta })
                    .HasName("PK_COMPETICOES_LUTAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesLutasPenalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdLuta, e.Tempo })
                    .HasName("PK_COMPETICOES_LUTAS_PENALIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesLutasPontuaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdLuta, e.Tempo })
                    .HasName("PK_COMPETICOES_LUTAS_PONTUACOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesPatrocinadore>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdPatrocinador })
                    .HasName("PK_COMPETICOES_PATROCINADORES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesPenalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdPenalidade })
                    .HasName("PK_COMPETICOES_PENALIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesPessoalApoio>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdApoio, e.IdFuncao })
                    .HasName("PK_COMPETICOES_PESSOAL_APOIO")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesPontuaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdPontuacao })
                    .HasName("PK_COMPETICOES_PONTUACOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesResultado>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdChave, e.IdAtleta })
                    .HasName("PK_COMPETICOES_RESULTADOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesTabelasPeso>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdClasse, e.IdCategoria })
                    .HasName("PK_COMPETICOES_TABELAS_PESOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesTecnico>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdCompeticao, e.IdAgremiacao, e.IdProfessor })
                    .HasName("PK_COMPETICOES_TECNICOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCompeticoesTipo>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoCompeticao })
                    .HasName("PK_COMPETICOES_TIPOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCurriculosAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.DataEvento })
                    .HasName("PK_CURRICULOS_AGREMIACOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbCurriculosAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataEvento })
                    .HasName("PK_CURRICULOS_ATLETAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbDesfiliacoesAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.DataDesfiliacao })
                    .HasName("PK_DESFILIACOES_AGREMIACOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbDesfiliacoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataDesfiliacao })
                    .HasName("PK_DESFILIACOES_ATLETAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbEmissoresIdentidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdEmissor })
                    .HasName("PK_EMISSORES_IDENTIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbEstado>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPais, e.IdEstado })
                    .HasName("PK_ESTADOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbEstadosCivi>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdEstadoCivil })
                    .HasName("PK_ESTADO_CIVIL")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbFaixa>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdFaixa })
                    .HasName("PK_FAIXAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbFormasPagamento>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdFormaPagamento })
                    .HasName("PK_FORMAS_PAGAMENTOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbFuncoesApoio>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdFuncao })
                    .HasName("PK_FUNCOES_APOIO")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbFuncoesApoioPessoalApoio>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdFuncao, e.IdApoio })
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbFuncoesMenu>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdFuncaoMenu })
                    .HasName("PK_FUNCOES_MENU")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbIsencoesAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.DataInicio })
                    .HasName("PK_ISENCOES_AGREMIACOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbIsencoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataInicio })
                    .HasName("PK_ISENCOES_ATLETAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbLocaisCompetico>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdLocal })
                    .HasName("PK_LOCAIS_COMPETICOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbMensalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAgremiacao, e.MesBase })
                    .HasName("PK_MENSALIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbNiveisArbitro>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdNivelArbitro })
                    .HasName("PK_NIVEIS_ARBITROS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbPaise>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPais })
                    .HasName("PK_PAISES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbPatrocinadore>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPatrocinador })
                    .HasName("PK_PATROCINADORES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbPenalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPenalidade })
                    .HasName("PK_PENALIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbPerfi>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPerfil })
                    .HasName("PK_PERFIS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbPerfisUsuario>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPerfil, e.IdUsuario })
                    .HasName("PK_PERFIS_USUARIOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbPermisso>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPerfil, e.IdFuncaoMenu, e.IdTipoOperacao })
                    .HasName("PK_PERMISSOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbPessoalApoio>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdApoio })
                    .HasName("PK_PESSOAL_APOIO")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbPontuaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdPontuacao })
                    .HasName("PK_PONTUACOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbProfessore>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdProfessor })
                    .HasName("PK_PROFESSORES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbProfisso>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdProfissao })
                    .HasName("PK_PROFISSOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbPromocoesArbitro>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdArbitro, e.DataPromocao })
                    .HasName("PK_PROMOCOES_ARBITROS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbPromocoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataPromocao })
                    .HasName("PK_PROMOCOES_ATLETAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbRecibo>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.NumeroRecibo })
                    .HasName("PK_RECIBOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbRecibosIten>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdRecibo, e.IdItemRecibo })
                    .HasName("PK_RECIBOS_ITENS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbRegio>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdRegiao })
                    .HasName("PK_REGIOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbRegistroEvento>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdEvento })
                    .HasName("PK_REGISTRO_EVENTOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbSexo>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdSexo })
                    .HasName("PK_SEXOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbSistema>(entity =>
            {
                entity.HasKey(e => e.IdSistema)
                    .HasName("PK_SISTEMA")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbSistemasMensagen>(entity =>
            {
                entity.HasKey(e => new { e.IdSistema, e.IdMensagem })
                    .HasName("PK_SISTEMAS_MENSAGENS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbSistemasTiposMensagen>(entity =>
            {
                entity.HasKey(e => new { e.IdSistema, e.IdTipoMensagem })
                    .HasName("PK_SISTEMAS_TIPOS_MENSAGENS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTabelaPeso>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdClasse, e.IdCategoria })
                    .HasName("PK_TABELA_PESOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTabelaServico>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdServico })
                    .HasName("PK_TABELA_SERVICOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTabelasAnuidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTabela })
                    .HasName("PK_TABELAS_ANUIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTabelasAnuidadesConfederacao>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTabela })
                    .HasName("PK_TABELAS_ANUIDADES_CONFEDERACAO")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTabelasMensalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTabela })
                    .HasName("PK_TABELAS_MENSALIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposAnuidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoAnuidade })
                    .HasName("PK_TIPOS_ANUIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposAnuidadesConfederacao>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoAnuidade })
                    .HasName("PK_TIPOS_ANUIDADES_CONFEDERACAO")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposCurriculosAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoCurriculoAgremiacao })
                    .HasName("PK_TIPOS_CURRICULOS_AGREMIACOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposCurriculosAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoCurriculoAtleta })
                    .HasName("PK_TIPOS_CURRICULOS_ATLETAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposDesfiliacoesAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoDesfiliacaoAgremiacao })
                    .HasName("PK_TIPOS_DESFILIACOES_AGREMIACOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposDesfiliacoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoDesfiliacaoAtleta })
                    .HasName("PK_TIPOS_DESFILIACOES_ATLETAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposIsencoesAgremiaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoIsencaoAgremiacao })
                    .HasName("PK_TIPOS_ISENCOES_AGREMIACOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposIsencoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoIsencaoAtleta })
                    .HasName("PK_TIPOS_ISENCOES_ATLETAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposItensRecibo>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoItem })
                    .HasName("PK_TIPOS_ITENS_RECIBOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposOperaco>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoOperacao })
                    .HasName("PK_TIPOS_OPERACOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposPagamentosAnuidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoPagamento })
                    .HasName("PK_TIPOS_PAGAMENTOS_ANUIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposPagamentosAnuidadesConfederacao>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoPagamento })
                    .HasName("PK_TIPOS_PAGAMENTOS_ANUIDADES_CONFEDERACAO")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposPagamentosMensalidade>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoPagamento })
                    .HasName("PK_TIPOS_PAGAMENTOS_MENSALIDADES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposPromocoesArbitro>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoPromocao })
                    .HasName("PK_TIPOS_PROMOCOES_ARBITROS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposPromocoesAtleta>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoPromocao })
                    .HasName("PK_TIPOS_PROMOCOES")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTiposTransferencia>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoTransferencia })
                    .HasName("PK_TIPOS_TRANSFERENCIAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbTransferencia>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdAtleta, e.DataTransferencia })
                    .HasName("PK_TRANSFERENCIAS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbUsuario>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdUsuario })
                    .HasName("PK_USUARIOS")
                    .IsClustered(false);
            });

            modelBuilder.Entity<TbValoresDefault>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdDefault })
                    .HasName("PK_VALORES_DEFAULT")
                    .IsClustered(false);
            });
            
            OnModelCreatingPartial(modelBuilder);
        }
        
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
        public async Task<bool> Commit() => await SaveChangesAsync() > 0;
    }
}
