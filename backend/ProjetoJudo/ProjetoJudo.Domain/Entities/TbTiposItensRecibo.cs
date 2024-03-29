﻿namespace ProjetoJudo.Domain.Entities
{
    public partial class TbTiposItensRecibo
    {
        public int IdTipoItem { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
    }
}
