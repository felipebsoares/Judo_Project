namespace ProjetoJudo.Domain.Entities
{
    public partial class TbUsuario
    {
        public TbUsuario()
        {
            TbPerfisUsuarios = new HashSet<TbPerfisUsuario>();
            TbRecibos = new HashSet<TbRecibo>();
            TbRegistroEventos = new HashSet<TbRegistroEvento>();
        }

        public int IdUsuario { get; set; }
        public string Nome { get; set; } = null!;
        public string LoginUsuario { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimoLogin { get; set; }
        public DateTime? DataExpiracao { get; set; }
        public string Senha { get; set; } = null!;
        public string Situacao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbPerfisUsuario> TbPerfisUsuarios { get; set; }
        public virtual ICollection<TbRecibo> TbRecibos { get; set; }
        public virtual ICollection<TbRegistroEvento> TbRegistroEventos { get; set; }
    }
}
