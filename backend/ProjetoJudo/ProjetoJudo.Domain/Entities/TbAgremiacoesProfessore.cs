using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbAgremiacoesProfessore
    {
        public int IdAgremiacao { get; set; }
        public int IdProfessor { get; set; }
        public DateTime DataInicio { get; set; }
        public int IdTipoProfessor { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAgremiaco Id { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbProfessore IdNavigation { get; set; } = null!;
    }
}
