namespace ProjetoJudo.Domain.Entities
{
    public partial class TbCompeticoesTabelasPeso
    {
        public int IdCompeticao { get; set; }
        public int IdSexo { get; set; }
        public int IdClasse { get; set; }
        public int IdCategoria { get; set; }
        public double PesoInicial { get; set; }
        public double PesoFinal { get; set; }
        public int OrdemExibicaoClasse { get; set; }
        public int OrdemExibicaoCategoria { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbSexo Id { get; set; } = null!;
        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCompeticoesClass IdC1 { get; set; } = null!;
        public virtual TbCompeticoesCategoria IdCNavigation { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
    }
}
