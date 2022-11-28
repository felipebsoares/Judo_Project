namespace ProjetoJudo.Domain.Entities
{
    public partial class TbTiposAnuidade
    {
        public TbTiposAnuidade()
        {
            TbAnuidades = new HashSet<TbAnuidade>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdTipoAnuidade { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbAnuidade> TbAnuidades { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
