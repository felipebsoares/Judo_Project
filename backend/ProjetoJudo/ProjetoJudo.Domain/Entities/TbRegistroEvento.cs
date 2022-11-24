using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbRegistroEvento
    {
        public int IdEvento { get; set; }
        public DateTime DataHoraEvento { get; set; }
        public int IdUsuario { get; set; }
        public int IdFuncaoMenu { get; set; }
        public int IdTipoOperacao { get; set; }
        public string IdComputador { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbFuncoesMenu Id { get; set; } = null!;
        public virtual TbUsuario Id1 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbTiposOperaco IdNavigation { get; set; } = null!;
    }
}
