namespace ProjetoJudo.Domain.Entities
{
    public partial class TbCompeticoesClass
    {
        public TbCompeticoesClass()
        {
            TbCompeticoesChaves = new HashSet<TbCompeticoesChafe>();
            TbCompeticoesClassesRegraIdC1s = new HashSet<TbCompeticoesClassesRegra>();
            TbCompeticoesClassesRegraIdCNavigations = new HashSet<TbCompeticoesClassesRegra>();
            TbCompeticoesTabelasPesos = new HashSet<TbCompeticoesTabelasPeso>();
        }

        public int IdClasse { get; set; }
        public int IdCompeticao { get; set; }
        public int IdSexo { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao1 { get; set; } = null!;
        public string Descricao2 { get; set; } = null!;
        public short IdadeInicial { get; set; }
        public short IdadeFinal { get; set; }
        public int OrdemExibicao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbSexo Id { get; set; } = null!;
        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbCompeticoesChafe> TbCompeticoesChaves { get; set; }
        public virtual ICollection<TbCompeticoesClassesRegra> TbCompeticoesClassesRegraIdC1s { get; set; }
        public virtual ICollection<TbCompeticoesClassesRegra> TbCompeticoesClassesRegraIdCNavigations { get; set; }
        public virtual ICollection<TbCompeticoesTabelasPeso> TbCompeticoesTabelasPesos { get; set; }
    }
}
