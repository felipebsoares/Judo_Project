namespace ProjetoJudo.Domain.Entities
{
    public partial class TbRecibo
    {
        public TbRecibo()
        {
            TbRecibosItens = new HashSet<TbRecibosIten>();
        }

        public int NumeroRecibo { get; set; }
        public string Origem { get; set; } = null!;
        public int? IdAgremiacao { get; set; }
        public int? IdAtleta { get; set; }
        public string Nome { get; set; } = null!;
        public string? Cpf { get; set; }
        public string? Cnpj { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal? ValorDinheiro { get; set; }
        public decimal? ValorCheque { get; set; }
        public decimal? ValorCartaoCredito { get; set; }
        public decimal? ValorCartaoDebito { get; set; }
        public decimal? ValorDebitoAutomatico { get; set; }
        public decimal? ValorPix { get; set; }
        public decimal? ValorBonificacao { get; set; }
        public int IdUsuario { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAgremiaco? Id { get; set; }
        public virtual TbUsuario Id1 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbAtleta? IdNavigation { get; set; }
        public virtual ICollection<TbRecibosIten> TbRecibosItens { get; set; }
    }
}
