using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCompeticoesClassesRegra
    {
        public int IdCompeticao { get; set; }
        public int IdClasseReal { get; set; }
        public int IdClasseInscricao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCompeticoesClass IdC1 { get; set; } = null!;
        public virtual TbCompeticoesClass IdCNavigation { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
    }
}
