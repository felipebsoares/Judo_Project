using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbPerfi
    {
        public TbPerfi()
        {
            TbPerfisUsuarios = new HashSet<TbPerfisUsuario>();
            TbPermissos = new HashSet<TbPermisso>();
        }

        public int IdPerfil { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbPerfisUsuario> TbPerfisUsuarios { get; set; }
        public virtual ICollection<TbPermisso> TbPermissos { get; set; }
    }
}
