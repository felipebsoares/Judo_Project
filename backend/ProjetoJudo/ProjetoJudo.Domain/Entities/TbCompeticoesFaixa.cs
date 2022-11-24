using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCompeticoesFaixa
    {
        public TbCompeticoesFaixa()
        {
            TbCompeticoesChafeId1s = new HashSet<TbCompeticoesChafe>();
            TbCompeticoesChafeIdNavigations = new HashSet<TbCompeticoesChafe>();
            TbCompeticoesInscricos = new HashSet<TbCompeticoesInscrico>();
        }

        public int IdFaixa { get; set; }
        public int IdCompeticao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public int OrdemExibicao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbCompeticoesChafe> TbCompeticoesChafeId1s { get; set; }
        public virtual ICollection<TbCompeticoesChafe> TbCompeticoesChafeIdNavigations { get; set; }
        public virtual ICollection<TbCompeticoesInscrico> TbCompeticoesInscricos { get; set; }
    }
}
