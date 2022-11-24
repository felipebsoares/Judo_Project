namespace ProjetoJudo.Domain.Entities
{
    public partial class TbDesfiliacoesAtleta
    {
        public int IdAtleta { get; set; }
        public DateTime DataDesfiliacao { get; set; }
        public DateTime? DataRefiliacao { get; set; }
        public int IdTipoDesfiliacaoAtleta { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAtleta Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbTiposDesfiliacoesAtleta IdNavigation { get; set; } = null!;
    }
}
