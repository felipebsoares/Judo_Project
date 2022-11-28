namespace ProjetoJudo.Domain.Entities
{
    public partial class TbNiveisArbitro
    {
        public TbNiveisArbitro()
        {
            TbArbitros = new HashSet<TbArbitro>();
            TbPromocoesArbitroId1s = new HashSet<TbPromocoesArbitro>();
            TbPromocoesArbitroIdNavigations = new HashSet<TbPromocoesArbitro>();
            TbValoresDefaultId13s = new HashSet<TbValoresDefault>();
            TbValoresDefaultId14s = new HashSet<TbValoresDefault>();
        }

        public int IdNivelArbitro { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public int OrdemExibicao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbArbitro> TbArbitros { get; set; }
        public virtual ICollection<TbPromocoesArbitro> TbPromocoesArbitroId1s { get; set; }
        public virtual ICollection<TbPromocoesArbitro> TbPromocoesArbitroIdNavigations { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultId13s { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultId14s { get; set; }
    }
}
