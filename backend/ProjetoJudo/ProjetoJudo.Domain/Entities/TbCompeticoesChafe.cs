using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCompeticoesChafe
    {
        public TbCompeticoesChafe()
        {
            TbCompeticoesInscricos = new HashSet<TbCompeticoesInscrico>();
            TbCompeticoesLuta = new HashSet<TbCompeticoesLuta>();
            TbCompeticoesResultados = new HashSet<TbCompeticoesResultado>();
        }

        public int IdChave { get; set; }
        public int IdCompeticao { get; set; }
        public int IdSexo { get; set; }
        public int IdClasse { get; set; }
        public int IdCategoria { get; set; }
        public int IdFaixaInicial { get; set; }
        public int IdFaixaFinal { get; set; }
        public short OrdemExibicaoChave { get; set; }
        public string Descricao { get; set; } = null!;
        public short PesoRanking { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbSexo Id { get; set; } = null!;
        public virtual TbCompeticoesFaixa Id1 { get; set; } = null!;
        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCompeticoesClass IdC1 { get; set; } = null!;
        public virtual TbCompeticoesCategoria IdCNavigation { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbCompeticoesFaixa IdNavigation { get; set; } = null!;
        public virtual ICollection<TbCompeticoesInscrico> TbCompeticoesInscricos { get; set; }
        public virtual ICollection<TbCompeticoesLuta> TbCompeticoesLuta { get; set; }
        public virtual ICollection<TbCompeticoesResultado> TbCompeticoesResultados { get; set; }
    }
}
