using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbSexo
    {
        public TbSexo()
        {
            TbArbitros = new HashSet<TbArbitro>();
            TbAtleta = new HashSet<TbAtleta>();
            TbClasses = new HashSet<TbClass>();
            TbCompeticoesChaves = new HashSet<TbCompeticoesChafe>();
            TbCompeticoesClasses = new HashSet<TbCompeticoesClass>();
            TbCompeticoesTabelasPesos = new HashSet<TbCompeticoesTabelasPeso>();
            TbPessoalApoios = new HashSet<TbPessoalApoio>();
            TbProfessores = new HashSet<TbProfessore>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdSexo { get; set; }
        public string Sigla { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual ICollection<TbArbitro> TbArbitros { get; set; }
        public virtual ICollection<TbAtleta> TbAtleta { get; set; }
        public virtual ICollection<TbClass> TbClasses { get; set; }
        public virtual ICollection<TbCompeticoesChafe> TbCompeticoesChaves { get; set; }
        public virtual ICollection<TbCompeticoesClass> TbCompeticoesClasses { get; set; }
        public virtual ICollection<TbCompeticoesTabelasPeso> TbCompeticoesTabelasPesos { get; set; }
        public virtual ICollection<TbPessoalApoio> TbPessoalApoios { get; set; }
        public virtual ICollection<TbProfessore> TbProfessores { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
