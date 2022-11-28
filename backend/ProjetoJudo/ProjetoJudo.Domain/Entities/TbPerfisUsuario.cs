namespace ProjetoJudo.Domain.Entities
{
    public partial class TbPerfisUsuario
    {
        public int IdPerfil { get; set; }
        public int IdUsuario { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbPerfi Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbUsuario IdNavigation { get; set; } = null!;
    }
}
