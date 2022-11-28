namespace ProjetoJudo.Domain.Entities
{
    public partial class TbTransferencia
    {
        public int IdAtleta { get; set; }
        public DateTime DataTransferencia { get; set; }
        public int IdAgremiacaoAnterior { get; set; }
        public int IdAgremiacaoNova { get; set; }
        public int IdTipoTransferencia { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAgremiaco Id { get; set; } = null!;
        public virtual TbAtleta Id1 { get; set; } = null!;
        public virtual TbTiposTransferencia Id2 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbAgremiaco IdNavigation { get; set; } = null!;
    }
}
