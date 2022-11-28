namespace ProjetoJudo.Domain.Entities
{
    public partial class TbIsencoesAtleta
    {
        public int IdAtleta { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int IdTipoIsencaoAtleta { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAtleta Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbTiposIsencoesAtleta IdNavigation { get; set; } = null!;
    }
}
