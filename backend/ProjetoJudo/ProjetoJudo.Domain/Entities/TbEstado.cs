namespace ProjetoJudo.Domain.Entities
{
    public partial class TbEstado
    {
        public TbEstado()
        {
            TbAgremiacos = new HashSet<TbAgremiaco>();
            TbArbitros = new HashSet<TbArbitro>();
            TbAtleta = new HashSet<TbAtleta>();
            TbCidades = new HashSet<TbCidade>();
            TbLocaisCompeticos = new HashSet<TbLocaisCompetico>();
            TbPatrocinadores = new HashSet<TbPatrocinadore>();
            TbPessoalApoios = new HashSet<TbPessoalApoio>();
            TbProfessores = new HashSet<TbProfessore>();
            TbRegios = new HashSet<TbRegio>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdEstado { get; set; }
        public int IdPais { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbPaise Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbAgremiaco> TbAgremiacos { get; set; }
        public virtual ICollection<TbArbitro> TbArbitros { get; set; }
        public virtual ICollection<TbAtleta> TbAtleta { get; set; }
        public virtual ICollection<TbCidade> TbCidades { get; set; }
        public virtual ICollection<TbLocaisCompetico> TbLocaisCompeticos { get; set; }
        public virtual ICollection<TbPatrocinadore> TbPatrocinadores { get; set; }
        public virtual ICollection<TbPessoalApoio> TbPessoalApoios { get; set; }
        public virtual ICollection<TbProfessore> TbProfessores { get; set; }
        public virtual ICollection<TbRegio> TbRegios { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
