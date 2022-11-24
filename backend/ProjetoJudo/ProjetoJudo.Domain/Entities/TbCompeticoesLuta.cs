namespace ProjetoJudo.Domain.Entities
{
    public partial class TbCompeticoesLuta
    {
        public TbCompeticoesLuta()
        {
            TbCompeticoesLutasPenalidades = new HashSet<TbCompeticoesLutasPenalidade>();
            TbCompeticoesLutasPontuacos = new HashSet<TbCompeticoesLutasPontuaco>();
        }

        public int IdLuta { get; set; }
        public int IdCompeticao { get; set; }
        public int IdChave { get; set; }
        public int OrdemAtleta1Chave { get; set; }
        public int OrdemAtleta2Chave { get; set; }
        public int IdAtleta1 { get; set; }
        public int IdAtleta2 { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public int IdAtletaVencedor { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAtleta Id { get; set; } = null!;
        public virtual TbAtleta Id1 { get; set; } = null!;
        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCompeticoesChafe IdCNavigation { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbAtleta IdNavigation { get; set; } = null!;
        public virtual ICollection<TbCompeticoesLutasPenalidade> TbCompeticoesLutasPenalidades { get; set; }
        public virtual ICollection<TbCompeticoesLutasPontuaco> TbCompeticoesLutasPontuacos { get; set; }
    }
}
