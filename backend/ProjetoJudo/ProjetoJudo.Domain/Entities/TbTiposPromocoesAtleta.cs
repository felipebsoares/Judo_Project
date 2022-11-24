namespace ProjetoJudo.Domain.Entities
{
    public partial class TbTiposPromocoesAtleta
    {
        public TbTiposPromocoesAtleta()
        {
            TbPromocoesAtleta = new HashSet<TbPromocoesAtleta>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdTipoPromocao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbPromocoesAtleta> TbPromocoesAtleta { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
