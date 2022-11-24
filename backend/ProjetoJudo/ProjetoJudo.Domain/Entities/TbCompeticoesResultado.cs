using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbCompeticoesResultado
    {
        public int IdCompeticao { get; set; }
        public int IdChave { get; set; }
        public int IdAtleta { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataResultado { get; set; }
        public short Colocacao { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAtleta Id { get; set; } = null!;
        public virtual TbCompetico IdC { get; set; } = null!;
        public virtual TbCompeticoesChafe IdCNavigation { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
    }
}
