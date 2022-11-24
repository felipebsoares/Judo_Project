namespace ProjetoJudo.Domain.Entities
{
    public partial class TbFaixa
    {
        public TbFaixa()
        {
            TbAtleta = new HashSet<TbAtleta>();
            TbPromocoesAtletaId1s = new HashSet<TbPromocoesAtleta>();
            TbPromocoesAtletaIdNavigations = new HashSet<TbPromocoesAtleta>();
            TbValoresDefaultId7s = new HashSet<TbValoresDefault>();
            TbValoresDefaultId8s = new HashSet<TbValoresDefault>();
            TbValoresDefaultId9s = new HashSet<TbValoresDefault>();
        }

        public int IdFaixa { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public short MesesCarencia { get; set; }
        public short IdadeMinima { get; set; }
        public int OrdemExibicao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbAtleta> TbAtleta { get; set; }
        public virtual ICollection<TbPromocoesAtleta> TbPromocoesAtletaId1s { get; set; }
        public virtual ICollection<TbPromocoesAtleta> TbPromocoesAtletaIdNavigations { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultId7s { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultId8s { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultId9s { get; set; }
    }
}
