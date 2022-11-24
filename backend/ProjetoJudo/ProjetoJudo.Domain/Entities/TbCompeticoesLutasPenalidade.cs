using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCompeticoesLutasPenalidade
    {
        public int IdCompeticao { get; set; }
        public int IdLuta { get; set; }
        public int IdAtleta { get; set; }
        public int IdPenalidade { get; set; }
        public int Tempo { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAtleta Id { get; set; } = null!;
        public virtual TbCompeticoesPenalidade Id1 { get; set; } = null!;
        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbCompeticoesLuta IdNavigation { get; set; } = null!;
    }
}
