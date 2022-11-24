using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbPermisso
    {
        public int IdPerfil { get; set; }
        public int IdFuncaoMenu { get; set; }
        public int IdTipoOperacao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbFuncoesMenu Id { get; set; } = null!;
        public virtual TbTiposOperaco Id1 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbPerfi IdNavigation { get; set; } = null!;
    }
}
