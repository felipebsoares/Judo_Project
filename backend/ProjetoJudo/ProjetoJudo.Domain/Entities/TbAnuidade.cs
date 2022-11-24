using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbAnuidade
    {
        public int IdAtleta { get; set; }
        public int IdTipoPagamento { get; set; }
        public int IdTipoAnuidade { get; set; }
        public int IdTabelaAnuidades { get; set; }
        public string AnoBase { get; set; } = null!;
        public int DataPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorDesconto { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAtleta Id { get; set; } = null!;
        public virtual TbTiposAnuidade Id1 { get; set; } = null!;
        public virtual TbTiposPagamentosAnuidade Id2 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbTabelasAnuidade IdNavigation { get; set; } = null!;
    }
}
