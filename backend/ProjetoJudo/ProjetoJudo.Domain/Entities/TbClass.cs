using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbClass
    {
        public TbClass()
        {
            TbTabelaPesos = new HashSet<TbTabelaPeso>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdClasse { get; set; }
        public string Sigla { get; set; } = null!;
        public int IdSexo { get; set; }
        public string Descricao1 { get; set; } = null!;
        public string Descricao2 { get; set; } = null!;
        public short IdadeInicial { get; set; }
        public short IdadeFinal { get; set; }
        public int OrdemExibicao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbSexo Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbTabelaPeso> TbTabelaPesos { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
