namespace ProjetoJudo.Domain.Entities
{
    public partial class TbTiposPagamentosMensalidade
    {
        public TbTiposPagamentosMensalidade()
        {
            TbMensalidades = new HashSet<TbMensalidade>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdTipoPagamento { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbMensalidade> TbMensalidades { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
