using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbPromocoesAtleta
    {
        public int IdAtleta { get; set; }
        public DateTime DataPromocao { get; set; }
        public int IdFaixaAnterior { get; set; }
        public int IdFaixaNova { get; set; }
        public int IdTipoPromocaoAtleta { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAtleta Id { get; set; } = null!;
        public virtual TbFaixa Id1 { get; set; } = null!;
        public virtual TbTiposPromocoesAtleta Id2 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbFaixa IdNavigation { get; set; } = null!;
    }
}
