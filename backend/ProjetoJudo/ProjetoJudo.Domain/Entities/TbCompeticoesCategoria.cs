namespace ProjetoJudo.Domain.Entities
{
    public partial class TbCompeticoesCategoria
    {
        public TbCompeticoesCategoria()
        {
            TbCompeticoesChaves = new HashSet<TbCompeticoesChafe>();
            TbCompeticoesTabelasPesos = new HashSet<TbCompeticoesTabelasPeso>();
        }

        public int IdCategoria { get; set; }
        public int IdCompeticao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public int OrdemExibicao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbCompeticoesChafe> TbCompeticoesChaves { get; set; }
        public virtual ICollection<TbCompeticoesTabelasPeso> TbCompeticoesTabelasPesos { get; set; }
    }
}
