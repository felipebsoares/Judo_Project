using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbTiposPromocoesArbitro
    {
        public TbTiposPromocoesArbitro()
        {
            TbPromocoesArbitros = new HashSet<TbPromocoesArbitro>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdTipoPromocao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbPromocoesArbitro> TbPromocoesArbitros { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
