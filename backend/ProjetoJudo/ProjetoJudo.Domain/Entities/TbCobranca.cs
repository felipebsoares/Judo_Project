using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCobranca
    {
        public int IdCobranca { get; set; }
        public int IdAgremiacao { get; set; }
        public string Oficio { get; set; } = null!;
        public string MesBase { get; set; } = null!;
        public DateTime DataCobranca { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorCobranca { get; set; }
        public decimal ValorDesconto { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAgremiaco Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
    }
}
