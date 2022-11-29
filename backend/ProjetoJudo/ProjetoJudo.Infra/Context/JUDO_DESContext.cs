using System.Reflection;
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
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
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
