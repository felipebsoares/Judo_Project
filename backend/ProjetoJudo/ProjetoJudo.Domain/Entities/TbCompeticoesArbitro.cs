using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCompeticoesArbitro
    {
        public int IdCompeticao { get; set; }
        public int IdArbitro { get; set; }
        public bool? Presente { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbArbitro Id { get; set; } = null!;
        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
    }
}
