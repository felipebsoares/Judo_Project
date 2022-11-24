using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbTabelasAnuidadesConfederacao
    {
        public TbTabelasAnuidadesConfederacao()
        {
            TbAnuidadesConfederacaos = new HashSet<TbAnuidadesConfederacao>();
        }

        public int IdTabela { get; set; }
        public string Descricao { get; set; } = null!;
        public decimal ValorAnuidade { get; set; }
        public decimal ValorRegistro { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbAnuidadesConfederacao> TbAnuidadesConfederacaos { get; set; }
    }
}
