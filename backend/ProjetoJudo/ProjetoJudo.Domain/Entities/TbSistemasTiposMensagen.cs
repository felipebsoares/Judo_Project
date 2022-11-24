using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbSistemasTiposMensagen
    {
        public TbSistemasTiposMensagen()
        {
            TbSistemasMensagens = new HashSet<TbSistemasMensagen>();
        }

        public int IdTipoMensagem { get; set; }
        public int IdSistema { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }

        public virtual TbSistema IdSistemaNavigation { get; set; } = null!;
        public virtual ICollection<TbSistemasMensagen> TbSistemasMensagens { get; set; }
    }
}
