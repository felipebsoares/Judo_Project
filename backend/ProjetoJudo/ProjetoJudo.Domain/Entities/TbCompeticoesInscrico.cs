namespace ProjetoJudo.Domain.Entities
{
    public partial class TbCompeticoesInscrico
    {
        public int IdInscricao { get; set; }
        public int IdCompeticao { get; set; }
        public int IdAtleta { get; set; }
        public int IdAgremiacao { get; set; }
        public DateTime DataInscricao { get; set; }
        public int IdFaixa { get; set; }
        public int IdChave { get; set; }
        public double Peso { get; set; }
        public bool? Presente { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAgremiaco Id { get; set; } = null!;
        public virtual TbCompeticoesFaixa Id1 { get; set; } = null!;
        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCompeticoesChafe IdCNavigation { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbAtleta IdNavigation { get; set; } = null!;
    }
}
