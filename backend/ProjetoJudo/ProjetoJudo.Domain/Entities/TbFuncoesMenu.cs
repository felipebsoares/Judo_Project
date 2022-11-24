namespace ProjetoJudo.Domain.Entities
{
    public partial class TbFuncoesMenu
    {
        public TbFuncoesMenu()
        {
            TbPermissos = new HashSet<TbPermisso>();
            TbRegistroEventos = new HashSet<TbRegistroEvento>();
        }

        public int IdFuncaoMenu { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Foto { get; set; }
        public bool Anexo { get; set; }
        public bool Anotacoes { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbPermisso> TbPermissos { get; set; }
        public virtual ICollection<TbRegistroEvento> TbRegistroEventos { get; set; }
    }
}
