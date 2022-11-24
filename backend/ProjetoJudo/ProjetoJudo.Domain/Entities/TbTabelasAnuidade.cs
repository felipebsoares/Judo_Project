namespace ProjetoJudo.Domain.Entities
{
    public partial class TbTabelasAnuidade
    {
        public TbTabelasAnuidade()
        {
            TbAnuidades = new HashSet<TbAnuidade>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdTabela { get; set; }
        public string Descricao { get; set; } = null!;
        public decimal ValorAnuidade { get; set; }
        public decimal ValorRegistro { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbAnuidade> TbAnuidades { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
