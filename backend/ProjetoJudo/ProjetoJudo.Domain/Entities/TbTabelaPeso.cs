using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbTabelaPeso
    {
        public int IdClasse { get; set; }
        public int IdCategoria { get; set; }
        public int IdSexo { get; set; }
        public double PesoInicial { get; set; }
        public double PesoFinal { get; set; }
        public int OrdemExibicaoClasse { get; set; }
        public int OrdemExibicaoCategoria { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCategoria IdC { get; set; } = null!;
        public virtual TbClass IdCl { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
    }
}
