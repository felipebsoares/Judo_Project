namespace ProjetoJudo.Domain.Entities
{
    public partial class TbTabelaServico
    {
        public TbTabelaServico()
        {
            TbRecibosItens = new HashSet<TbRecibosIten>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdServico { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public decimal Valor { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbRecibosIten> TbRecibosItens { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
