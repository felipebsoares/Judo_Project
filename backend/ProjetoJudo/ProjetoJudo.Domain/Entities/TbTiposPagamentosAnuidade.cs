using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbTiposPagamentosAnuidade
    {
        public TbTiposPagamentosAnuidade()
        {
            TbAnuidades = new HashSet<TbAnuidade>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdTipoPagamento { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbAnuidade> TbAnuidades { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
