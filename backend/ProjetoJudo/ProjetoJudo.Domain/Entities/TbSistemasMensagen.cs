namespace ProjetoJudo.Domain.Entities
{
    public partial class TbSistemasMensagen
    {
        public int IdMensagem { get; set; }
        public int IdSistema { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public int IdTipoMensagem { get; set; }
        public bool Selecao { get; set; }

        public virtual TbSistemasTiposMensagen Id { get; set; } = null!;
        public virtual TbSistema IdSistemaNavigation { get; set; } = null!;
    }
}
