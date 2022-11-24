using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCompeticoesPessoalApoio
    {
        public int IdCompeticao { get; set; }
        public int IdApoio { get; set; }
        public int IdFuncao { get; set; }
        public bool? Presente { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbPessoalApoio Id { get; set; } = null!;
        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbFuncoesApoio IdNavigation { get; set; } = null!;
    }
}
