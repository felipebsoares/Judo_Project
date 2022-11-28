namespace ProjetoJudo.Domain.Entities
{
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbAgremiacoesProfessores = new HashSet<TbAgremiacoesProfessore>();
            TbAgremiacos = new HashSet<TbAgremiaco>();
            TbAnuidades = new HashSet<TbAnuidade>();
            TbAnuidadesConfederacaos = new HashSet<TbAnuidadesConfederacao>();
            TbArbitros = new HashSet<TbArbitro>();
            TbAtleta = new HashSet<TbAtleta>();
            TbCategoria = new HashSet<TbCategoria>();
            TbCidades = new HashSet<TbCidade>();
            TbClasses = new HashSet<TbClass>();
            TbCobrancas = new HashSet<TbCobranca>();
            TbCompeticoesArbitros = new HashSet<TbCompeticoesArbitro>();
            TbCompeticoesAreas = new HashSet<TbCompeticoesArea>();
            TbCompeticoesCategoria = new HashSet<TbCompeticoesCategoria>();
            TbCompeticoesChaves = new HashSet<TbCompeticoesChafe>();
            TbCompeticoesClasses = new HashSet<TbCompeticoesClass>();
            TbCompeticoesClassesRegras = new HashSet<TbCompeticoesClassesRegra>();
            TbCompeticoesFaixas = new HashSet<TbCompeticoesFaixa>();
            TbCompeticoesInscricos = new HashSet<TbCompeticoesInscrico>();
            TbCompeticoesLuta = new HashSet<TbCompeticoesLuta>();
            TbCompeticoesLutasPenalidades = new HashSet<TbCompeticoesLutasPenalidade>();
            TbCompeticoesLutasPontuacos = new HashSet<TbCompeticoesLutasPontuaco>();
            TbCompeticoesPatrocinadores = new HashSet<TbCompeticoesPatrocinadore>();
            TbCompeticoesPenalidades = new HashSet<TbCompeticoesPenalidade>();
            TbCompeticoesPessoalApoios = new HashSet<TbCompeticoesPessoalApoio>();
            TbCompeticoesPontuacos = new HashSet<TbCompeticoesPontuaco>();
            TbCompeticoesResultados = new HashSet<TbCompeticoesResultado>();
            TbCompeticoesTabelasPesos = new HashSet<TbCompeticoesTabelasPeso>();
            TbCompeticoesTecnicos = new HashSet<TbCompeticoesTecnico>();
            TbCompeticoesTipos = new HashSet<TbCompeticoesTipo>();
            TbCompeticos = new HashSet<TbCompetico>();
            TbCurriculosAgremiacos = new HashSet<TbCurriculosAgremiaco>();
            TbCurriculosAtleta = new HashSet<TbCurriculosAtleta>();
            TbDesfiliacoesAgremiacos = new HashSet<TbDesfiliacoesAgremiaco>();
            TbDesfiliacoesAtleta = new HashSet<TbDesfiliacoesAtleta>();
            TbEmissoresIdentidades = new HashSet<TbEmissoresIdentidade>();
            TbEstados = new HashSet<TbEstado>();
            TbFaixas = new HashSet<TbFaixa>();
            TbFormasPagamentos = new HashSet<TbFormasPagamento>();
            TbFuncoesApoioPessoalApoios = new HashSet<TbFuncoesApoioPessoalApoio>();
            TbFuncoesApoios = new HashSet<TbFuncoesApoio>();
            TbFuncoesMenus = new HashSet<TbFuncoesMenu>();
            TbIsencoesAgremiacos = new HashSet<TbIsencoesAgremiaco>();
            TbIsencoesAtleta = new HashSet<TbIsencoesAtleta>();
            TbLocaisCompeticos = new HashSet<TbLocaisCompetico>();
            TbMensalidades = new HashSet<TbMensalidade>();
            TbNiveisArbitros = new HashSet<TbNiveisArbitro>();
            TbPaises = new HashSet<TbPaise>();
            TbPatrocinadores = new HashSet<TbPatrocinadore>();
            TbPenalidades = new HashSet<TbPenalidade>();
            TbPerfis = new HashSet<TbPerfi>();
            TbPerfisUsuarios = new HashSet<TbPerfisUsuario>();
            TbPermissos = new HashSet<TbPermisso>();
            TbPessoalApoios = new HashSet<TbPessoalApoio>();
            TbPontuacos = new HashSet<TbPontuaco>();
            TbProfessores = new HashSet<TbProfessore>();
            TbProfissos = new HashSet<TbProfisso>();
            TbPromocoesArbitros = new HashSet<TbPromocoesArbitro>();
            TbPromocoesAtleta = new HashSet<TbPromocoesAtleta>();
            TbRecibos = new HashSet<TbRecibo>();
            TbRecibosItens = new HashSet<TbRecibosIten>();
            TbRegios = new HashSet<TbRegio>();
            TbRegistroEventos = new HashSet<TbRegistroEvento>();
            TbTabelaPesos = new HashSet<TbTabelaPeso>();
            TbTabelaServicos = new HashSet<TbTabelaServico>();
            TbTabelasAnuidades = new HashSet<TbTabelasAnuidade>();
            TbTabelasAnuidadesConfederacaos = new HashSet<TbTabelasAnuidadesConfederacao>();
            TbTabelasMensalidades = new HashSet<TbTabelasMensalidade>();
            TbTiposAnuidades = new HashSet<TbTiposAnuidade>();
            TbTiposAnuidadesConfederacaos = new HashSet<TbTiposAnuidadesConfederacao>();
            TbTiposCurriculosAgremiacos = new HashSet<TbTiposCurriculosAgremiaco>();
            TbTiposCurriculosAtleta = new HashSet<TbTiposCurriculosAtleta>();
            TbTiposDesfiliacoesAgremiacos = new HashSet<TbTiposDesfiliacoesAgremiaco>();
            TbTiposDesfiliacoesAtleta = new HashSet<TbTiposDesfiliacoesAtleta>();
            TbTiposIsencoesAgremiacos = new HashSet<TbTiposIsencoesAgremiaco>();
            TbTiposIsencoesAtleta = new HashSet<TbTiposIsencoesAtleta>();
            TbTiposItensRecibos = new HashSet<TbTiposItensRecibo>();
            TbTiposOperacos = new HashSet<TbTiposOperaco>();
            TbTiposPagamentosAnuidades = new HashSet<TbTiposPagamentosAnuidade>();
            TbTiposPagamentosAnuidadesConfederacaos = new HashSet<TbTiposPagamentosAnuidadesConfederacao>();
            TbTiposPagamentosMensalidades = new HashSet<TbTiposPagamentosMensalidade>();
            TbTiposPromocoesArbitros = new HashSet<TbTiposPromocoesArbitro>();
            TbTiposPromocoesAtleta = new HashSet<TbTiposPromocoesAtleta>();
            TbTiposTransferencia = new HashSet<TbTiposTransferencia>();
            TbTransferencia = new HashSet<TbTransferencia>();
            TbUsuarios = new HashSet<TbUsuario>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdCliente { get; set; }
        public string Sigla { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string PastaArquivos { get; set; } = null!;
        public int IdSistema { get; set; }
        public bool Selecao { get; set; }

        public virtual TbSistema IdSistemaNavigation { get; set; } = null!;
        public virtual ICollection<TbAgremiacoesProfessore> TbAgremiacoesProfessores { get; set; }
        public virtual ICollection<TbAgremiaco> TbAgremiacos { get; set; }
        public virtual ICollection<TbAnuidade> TbAnuidades { get; set; }
        public virtual ICollection<TbAnuidadesConfederacao> TbAnuidadesConfederacaos { get; set; }
        public virtual ICollection<TbArbitro> TbArbitros { get; set; }
        public virtual ICollection<TbAtleta> TbAtleta { get; set; }
        public virtual ICollection<TbCategoria> TbCategoria { get; set; }
        public virtual ICollection<TbCidade> TbCidades { get; set; }
        public virtual ICollection<TbClass> TbClasses { get; set; }
        public virtual ICollection<TbCobranca> TbCobrancas { get; set; }
        public virtual ICollection<TbCompeticoesArbitro> TbCompeticoesArbitros { get; set; }
        public virtual ICollection<TbCompeticoesArea> TbCompeticoesAreas { get; set; }
        public virtual ICollection<TbCompeticoesCategoria> TbCompeticoesCategoria { get; set; }
        public virtual ICollection<TbCompeticoesChafe> TbCompeticoesChaves { get; set; }
        public virtual ICollection<TbCompeticoesClass> TbCompeticoesClasses { get; set; }
        public virtual ICollection<TbCompeticoesClassesRegra> TbCompeticoesClassesRegras { get; set; }
        public virtual ICollection<TbCompeticoesFaixa> TbCompeticoesFaixas { get; set; }
        public virtual ICollection<TbCompeticoesInscrico> TbCompeticoesInscricos { get; set; }
        public virtual ICollection<TbCompeticoesLuta> TbCompeticoesLuta { get; set; }
        public virtual ICollection<TbCompeticoesLutasPenalidade> TbCompeticoesLutasPenalidades { get; set; }
        public virtual ICollection<TbCompeticoesLutasPontuaco> TbCompeticoesLutasPontuacos { get; set; }
        public virtual ICollection<TbCompeticoesPatrocinadore> TbCompeticoesPatrocinadores { get; set; }
        public virtual ICollection<TbCompeticoesPenalidade> TbCompeticoesPenalidades { get; set; }
        public virtual ICollection<TbCompeticoesPessoalApoio> TbCompeticoesPessoalApoios { get; set; }
        public virtual ICollection<TbCompeticoesPontuaco> TbCompeticoesPontuacos { get; set; }
        public virtual ICollection<TbCompeticoesResultado> TbCompeticoesResultados { get; set; }
        public virtual ICollection<TbCompeticoesTabelasPeso> TbCompeticoesTabelasPesos { get; set; }
        public virtual ICollection<TbCompeticoesTecnico> TbCompeticoesTecnicos { get; set; }
        public virtual ICollection<TbCompeticoesTipo> TbCompeticoesTipos { get; set; }
        public virtual ICollection<TbCompetico> TbCompeticos { get; set; }
        public virtual ICollection<TbCurriculosAgremiaco> TbCurriculosAgremiacos { get; set; }
        public virtual ICollection<TbCurriculosAtleta> TbCurriculosAtleta { get; set; }
        public virtual ICollection<TbDesfiliacoesAgremiaco> TbDesfiliacoesAgremiacos { get; set; }
        public virtual ICollection<TbDesfiliacoesAtleta> TbDesfiliacoesAtleta { get; set; }
        public virtual ICollection<TbEmissoresIdentidade> TbEmissoresIdentidades { get; set; }
        public virtual ICollection<TbEstado> TbEstados { get; set; }
        public virtual ICollection<TbFaixa> TbFaixas { get; set; }
        public virtual ICollection<TbFormasPagamento> TbFormasPagamentos { get; set; }
        public virtual ICollection<TbFuncoesApoioPessoalApoio> TbFuncoesApoioPessoalApoios { get; set; }
        public virtual ICollection<TbFuncoesApoio> TbFuncoesApoios { get; set; }
        public virtual ICollection<TbFuncoesMenu> TbFuncoesMenus { get; set; }
        public virtual ICollection<TbIsencoesAgremiaco> TbIsencoesAgremiacos { get; set; }
        public virtual ICollection<TbIsencoesAtleta> TbIsencoesAtleta { get; set; }
        public virtual ICollection<TbLocaisCompetico> TbLocaisCompeticos { get; set; }
        public virtual ICollection<TbMensalidade> TbMensalidades { get; set; }
        public virtual ICollection<TbNiveisArbitro> TbNiveisArbitros { get; set; }
        public virtual ICollection<TbPaise> TbPaises { get; set; }
        public virtual ICollection<TbPatrocinadore> TbPatrocinadores { get; set; }
        public virtual ICollection<TbPenalidade> TbPenalidades { get; set; }
        public virtual ICollection<TbPerfi> TbPerfis { get; set; }
        public virtual ICollection<TbPerfisUsuario> TbPerfisUsuarios { get; set; }
        public virtual ICollection<TbPermisso> TbPermissos { get; set; }
        public virtual ICollection<TbPessoalApoio> TbPessoalApoios { get; set; }
        public virtual ICollection<TbPontuaco> TbPontuacos { get; set; }
        public virtual ICollection<TbProfessore> TbProfessores { get; set; }
        public virtual ICollection<TbProfisso> TbProfissos { get; set; }
        public virtual ICollection<TbPromocoesArbitro> TbPromocoesArbitros { get; set; }
        public virtual ICollection<TbPromocoesAtleta> TbPromocoesAtleta { get; set; }
        public virtual ICollection<TbRecibo> TbRecibos { get; set; }
        public virtual ICollection<TbRecibosIten> TbRecibosItens { get; set; }
        public virtual ICollection<TbRegio> TbRegios { get; set; }
        public virtual ICollection<TbRegistroEvento> TbRegistroEventos { get; set; }
        public virtual ICollection<TbTabelaPeso> TbTabelaPesos { get; set; }
        public virtual ICollection<TbTabelaServico> TbTabelaServicos { get; set; }
        public virtual ICollection<TbTabelasAnuidade> TbTabelasAnuidades { get; set; }
        public virtual ICollection<TbTabelasAnuidadesConfederacao> TbTabelasAnuidadesConfederacaos { get; set; }
        public virtual ICollection<TbTabelasMensalidade> TbTabelasMensalidades { get; set; }
        public virtual ICollection<TbTiposAnuidade> TbTiposAnuidades { get; set; }
        public virtual ICollection<TbTiposAnuidadesConfederacao> TbTiposAnuidadesConfederacaos { get; set; }
        public virtual ICollection<TbTiposCurriculosAgremiaco> TbTiposCurriculosAgremiacos { get; set; }
        public virtual ICollection<TbTiposCurriculosAtleta> TbTiposCurriculosAtleta { get; set; }
        public virtual ICollection<TbTiposDesfiliacoesAgremiaco> TbTiposDesfiliacoesAgremiacos { get; set; }
        public virtual ICollection<TbTiposDesfiliacoesAtleta> TbTiposDesfiliacoesAtleta { get; set; }
        public virtual ICollection<TbTiposIsencoesAgremiaco> TbTiposIsencoesAgremiacos { get; set; }
        public virtual ICollection<TbTiposIsencoesAtleta> TbTiposIsencoesAtleta { get; set; }
        public virtual ICollection<TbTiposItensRecibo> TbTiposItensRecibos { get; set; }
        public virtual ICollection<TbTiposOperaco> TbTiposOperacos { get; set; }
        public virtual ICollection<TbTiposPagamentosAnuidade> TbTiposPagamentosAnuidades { get; set; }
        public virtual ICollection<TbTiposPagamentosAnuidadesConfederacao> TbTiposPagamentosAnuidadesConfederacaos { get; set; }
        public virtual ICollection<TbTiposPagamentosMensalidade> TbTiposPagamentosMensalidades { get; set; }
        public virtual ICollection<TbTiposPromocoesArbitro> TbTiposPromocoesArbitros { get; set; }
        public virtual ICollection<TbTiposPromocoesAtleta> TbTiposPromocoesAtleta { get; set; }
        public virtual ICollection<TbTiposTransferencia> TbTiposTransferencia { get; set; }
        public virtual ICollection<TbTransferencia> TbTransferencia { get; set; }
        public virtual ICollection<TbUsuario> TbUsuarios { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
