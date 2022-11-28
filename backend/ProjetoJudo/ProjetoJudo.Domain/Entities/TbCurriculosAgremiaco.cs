namespace ProjetoJudo.Domain.Entities
{
    public partial class TbCurriculosAgremiaco
    {
        public int IdAgremiacao { get; set; }
        public int IdTipoCurriculoAgremiacao { get; set; }
        public DateTime DataEvento { get; set; }
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAgremiaco Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbTiposCurriculosAgremiaco IdNavigation { get; set; } = null!;
    }
}