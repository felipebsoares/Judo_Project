using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbEmissoresIdentidade
    {
        public TbEmissoresIdentidade()
        {
            TbArbitros = new HashSet<TbArbitro>();
            TbAtleta = new HashSet<TbAtleta>();
            TbPessoalApoios = new HashSet<TbPessoalApoio>();
            TbProfessores = new HashSet<TbProfessore>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdEmissor { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbArbitro> TbArbitros { get; set; }
        public virtual ICollection<TbAtleta> TbAtleta { get; set; }
        public virtual ICollection<TbPessoalApoio> TbPessoalApoios { get; set; }
        public virtual ICollection<TbProfessore> TbProfessores { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
