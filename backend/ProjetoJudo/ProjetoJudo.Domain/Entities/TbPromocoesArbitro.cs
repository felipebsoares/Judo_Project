namespace ProjetoJudo.Domain.Entities
{
    public partial class TbPromocoesArbitro
    {
        public int IdArbitro { get; set; }
        public DateTime DataPromocao { get; set; }
        public int IdNivelArbitroAnterior { get; set; }
        public int IdNivelArbitroNovo { get; set; }
        public int IdTipoPromocaoArbitro { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbArbitro Id { get; set; } = null!;
        public virtual TbNiveisArbitro Id1 { get; set; } = null!;
        public virtual TbTiposPromocoesArbitro Id2 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbNiveisArbitro IdNavigation { get; set; } = null!;
    }
}
