using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCompeticoesPenalidade
    {
        public TbCompeticoesPenalidade()
        {
            TbCompeticoesLutasPenalidades = new HashSet<TbCompeticoesLutasPenalidade>();
        }

        public int IdPenalidade { get; set; }
        public int IdCompeticao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public int OrdemExibicao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbCompeticoesLutasPenalidade> TbCompeticoesLutasPenalidades { get; set; }
    }
}
