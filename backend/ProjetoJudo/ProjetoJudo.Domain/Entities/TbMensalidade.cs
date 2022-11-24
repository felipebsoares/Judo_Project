using System;
using System.Collections.Generic;

namespace ProjetoJudo.Domain.Entities
{
    public partial class TbMensalidade
    {
        public int IdAgremiacao { get; set; }
        public int IdTipoPagamento { get; set; }
        public int IdTabelaMensalidades { get; set; }
        public string MesBase { get; set; } = null!;
        public int DataPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorDesconto { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAgremiaco Id { get; set; } = null!;
        public virtual TbTiposPagamentosMensalidade Id1 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbTabelasMensalidade IdNavigation { get; set; } = null!;
    }
}
