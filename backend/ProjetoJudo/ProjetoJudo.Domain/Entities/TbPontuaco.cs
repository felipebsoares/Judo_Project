using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbPontuaco
    {
        public TbPontuaco()
        {
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdPontuacao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public int OrdemExibicao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
