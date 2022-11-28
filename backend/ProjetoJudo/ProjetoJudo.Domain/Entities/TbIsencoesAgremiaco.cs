namespace ProjetoJudo.Domain.Entities
{
    public partial class TbIsencoesAgremiaco
    {
        public int IdAgremiacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int IdTipoIsencaoAgremiacao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAgremiaco Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbTiposIsencoesAgremiaco IdNavigation { get; set; } = null!;
    }
}
