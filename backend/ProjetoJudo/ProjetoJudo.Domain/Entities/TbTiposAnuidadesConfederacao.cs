using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbTiposAnuidadesConfederacao
    {
        public TbTiposAnuidadesConfederacao()
        {
            TbAnuidadesConfederacaos = new HashSet<TbAnuidadesConfederacao>();
        }

        public int IdTipoAnuidade { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbAnuidadesConfederacao> TbAnuidadesConfederacaos { get; set; }
    }
}
