using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCompeticoesTipo
    {
        public TbCompeticoesTipo()
        {
            TbCompeticos = new HashSet<TbCompetico>();
        }

        public int IdTipoCompeticao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbCompetico> TbCompeticos { get; set; }
    }
}
