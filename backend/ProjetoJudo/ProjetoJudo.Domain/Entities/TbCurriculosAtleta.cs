using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCurriculosAtleta
    {
        public int IdAtleta { get; set; }
        public int IdTipoCurriculoAtleta { get; set; }
        public DateTime DataEvento { get; set; }
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAtleta Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbTiposCurriculosAtleta IdNavigation { get; set; } = null!;
    }
}
