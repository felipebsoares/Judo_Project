using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbRecibosIten
    {
        public int IdRecibo { get; set; }
        public int IdItemRecibo { get; set; }
        public int IdServico { get; set; }
        public int Quantidade { get; set; }
        public int IdFormaPagamento { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorDesconto { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbFormasPagamento Id { get; set; } = null!;
        public virtual TbTabelaServico Id1 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbRecibo IdNavigation { get; set; } = null!;
    }
}
