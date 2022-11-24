namespace ProjetoJudo.Domain.Entities
{
    public partial class TbTiposDesfiliacoesAtleta
    {
        public TbTiposDesfiliacoesAtleta()
        {
            TbDesfiliacoesAtleta = new HashSet<TbDesfiliacoesAtleta>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdTipoDesfiliacaoAtleta { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbDesfiliacoesAtleta> TbDesfiliacoesAtleta { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
