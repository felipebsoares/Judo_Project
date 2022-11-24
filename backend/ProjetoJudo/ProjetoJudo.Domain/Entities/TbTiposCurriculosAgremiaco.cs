using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbTiposCurriculosAgremiaco
    {
        public TbTiposCurriculosAgremiaco()
        {
            TbCurriculosAgremiacos = new HashSet<TbCurriculosAgremiaco>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdTipoCurriculoAgremiacao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbCurriculosAgremiaco> TbCurriculosAgremiacos { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
