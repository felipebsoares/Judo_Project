using System;
using System.Collections.Generic;

namespace ProjetoJudo.Domain.Entities
{
    public partial class TbDesfiliacoesAgremiaco
    {
        public int IdAgremiacao { get; set; }
        public DateTime DataDesfiliacao { get; set; }
        public DateTime? DataRefiliacao { get; set; }
        public int IdTipoDesfiliacaoAgremiacao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAgremiaco Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbTiposDesfiliacoesAgremiaco IdNavigation { get; set; } = null!;
    }
}
