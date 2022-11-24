using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCompeticoesPontuaco
    {
        public TbCompeticoesPontuaco()
        {
            TbCompeticoesLutasPontuacos = new HashSet<TbCompeticoesLutasPontuaco>();
        }

        public int IdPontuacao { get; set; }
        public int IdCompeticao { get; set; }
        public string Sigla { get; set; } = null!;
        public string DscPontuacao { get; set; } = null!;
        public int OrdemExibicao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbCompeticoesLutasPontuaco> TbCompeticoesLutasPontuacos { get; set; }
    }
}
