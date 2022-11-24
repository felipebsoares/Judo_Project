using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbFuncoesApoio
    {
        public TbFuncoesApoio()
        {
            TbCompeticoesPessoalApoios = new HashSet<TbCompeticoesPessoalApoio>();
            TbFuncoesApoioPessoalApoios = new HashSet<TbFuncoesApoioPessoalApoio>();
        }

        public int IdFuncao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbCompeticoesPessoalApoio> TbCompeticoesPessoalApoios { get; set; }
        public virtual ICollection<TbFuncoesApoioPessoalApoio> TbFuncoesApoioPessoalApoios { get; set; }
    }
}
