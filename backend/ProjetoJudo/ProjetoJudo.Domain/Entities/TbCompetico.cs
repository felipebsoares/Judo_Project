namespace ProjetoJudo.Domain.Entities
{
    public partial class TbCompetico
    {
        public TbCompetico()
        {
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
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdCompeticao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao1 { get; set; } = null!;
        public string? Descricao2 { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public int IdLocal { get; set; }
        public int IdadeMinima { get; set; }
        public int IdadeMaxima { get; set; }
        public int IdTipoCompeticao { get; set; }
        public int PesoRanking { get; set; }
        public string? Anotacoes { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbLocaisCompetico Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbCompeticoesTipo IdNavigation { get; set; } = null!;
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
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
