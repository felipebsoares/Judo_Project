namespace ProjetoJudo.Domain.Entities
{
    public partial class TbTiposPagamentosAnuidadesConfederacao
    {
        public TbTiposPagamentosAnuidadesConfederacao()
        {
            TbAnuidadesConfederacaos = new HashSet<TbAnuidadesConfederacao>();
        }

        public int IdTipoPagamento { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbAnuidadesConfederacao> TbAnuidadesConfederacaos { get; set; }
    }
}
