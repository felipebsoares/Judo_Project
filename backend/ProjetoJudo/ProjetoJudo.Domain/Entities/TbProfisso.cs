using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbProfisso
    {
        public TbProfisso()
        {
            TbAtletaId5s = new HashSet<TbAtleta>();
            TbAtletaId6s = new HashSet<TbAtleta>();
            TbAtletaId7s = new HashSet<TbAtleta>();
            TbValoresDefaultId20s = new HashSet<TbValoresDefault>();
            TbValoresDefaultId21s = new HashSet<TbValoresDefault>();
            TbValoresDefaultId22s = new HashSet<TbValoresDefault>();
        }

        public int IdProfissao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbAtleta> TbAtletaId5s { get; set; }
        public virtual ICollection<TbAtleta> TbAtletaId6s { get; set; }
        public virtual ICollection<TbAtleta> TbAtletaId7s { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultId20s { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultId21s { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultId22s { get; set; }
    }
}
