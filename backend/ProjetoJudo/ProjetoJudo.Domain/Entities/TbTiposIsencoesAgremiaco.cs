namespace ProjetoJudo.Domain.Entities
{
    public partial class TbTiposIsencoesAgremiaco
    {
        public TbTiposIsencoesAgremiaco()
        {
            TbIsencoesAgremiacos = new HashSet<TbIsencoesAgremiaco>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdTipoIsencaoAgremiacao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbIsencoesAgremiaco> TbIsencoesAgremiacos { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
