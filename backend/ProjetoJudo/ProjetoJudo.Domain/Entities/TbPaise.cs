using System;
using System.Collections.Generic;

namespace ProjetoJudo.Infra
{
    public partial class TbPaise
    {
        public TbPaise()
        {
            TbAgremiacos = new HashSet<TbAgremiaco>();
            TbArbitroId2s = new HashSet<TbArbitro>();
            TbArbitroId4s = new HashSet<TbArbitro>();
            TbAtletaId3s = new HashSet<TbAtleta>();
            TbAtletaId4s = new HashSet<TbAtleta>();
            TbCidades = new HashSet<TbCidade>();
            TbEstados = new HashSet<TbEstado>();
            TbLocaisCompeticos = new HashSet<TbLocaisCompetico>();
            TbPatrocinadores = new HashSet<TbPatrocinadore>();
            TbPessoalApoioId2s = new HashSet<TbPessoalApoio>();
            TbPessoalApoioId3s = new HashSet<TbPessoalApoio>();
            TbProfessoreId2s = new HashSet<TbProfessore>();
            TbProfessoreId3s = new HashSet<TbProfessore>();
            TbRegios = new HashSet<TbRegio>();
            TbValoresDefaultId12s = new HashSet<TbValoresDefault>();
            TbValoresDefaultId15s = new HashSet<TbValoresDefault>();
        }

        public int IdPais { get; set; }
        public string Descricao { get; set; } = null!;
        public string Sigla3 { get; set; } = null!;
        public string Sigla2 { get; set; } = null!;
        public string? Nacionalidade { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TbAgremiaco> TbAgremiacos { get; set; }
        public virtual ICollection<TbArbitro> TbArbitroId2s { get; set; }
        public virtual ICollection<TbArbitro> TbArbitroId4s { get; set; }
        public virtual ICollection<TbAtleta> TbAtletaId3s { get; set; }
        public virtual ICollection<TbAtleta> TbAtletaId4s { get; set; }
        public virtual ICollection<TbCidade> TbCidades { get; set; }
        public virtual ICollection<TbEstado> TbEstados { get; set; }
        public virtual ICollection<TbLocaisCompetico> TbLocaisCompeticos { get; set; }
        public virtual ICollection<TbPatrocinadore> TbPatrocinadores { get; set; }
        public virtual ICollection<TbPessoalApoio> TbPessoalApoioId2s { get; set; }
        public virtual ICollection<TbPessoalApoio> TbPessoalApoioId3s { get; set; }
        public virtual ICollection<TbProfessore> TbProfessoreId2s { get; set; }
        public virtual ICollection<TbProfessore> TbProfessoreId3s { get; set; }
        public virtual ICollection<TbRegio> TbRegios { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultId12s { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultId15s { get; set; }
    }
}
