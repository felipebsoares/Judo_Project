namespace ProjetoJudo.Domain.Entities
{
    public partial class TbSistema
    {
        public TbSistema()
        {
            TbClientes = new HashSet<TbCliente>();
            TbSistemasMensagens = new HashSet<TbSistemasMensagen>();
            TbSistemasTiposMensagens = new HashSet<TbSistemasTiposMensagen>();
        }

        public int IdSistema { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public string Versao { get; set; } = null!;
        public bool Selecao { get; set; }

        public virtual ICollection<TbCliente> TbClientes { get; set; }
        public virtual ICollection<TbSistemasMensagen> TbSistemasMensagens { get; set; }
        public virtual ICollection<TbSistemasTiposMensagen> TbSistemasTiposMensagens { get; set; }
    }
}
