using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbTabelasMensalidade
    {
        public TbTabelasMensalidade()
        {
            TbMensalidades = new HashSet<TbMensalidade>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdTabela { get; set; }
        public string Descricao { get; set; } = null!;
        public decimal ValorMensalidade { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbMensalidade> TbMensalidades { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
