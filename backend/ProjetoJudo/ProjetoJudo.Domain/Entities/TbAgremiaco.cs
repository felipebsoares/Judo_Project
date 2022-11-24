using System;
using System.Collections.Generic;

namespace ProjetoJudo.Domain.Entities
{
    public partial class TbAgremiaco
    {
        public TbAgremiaco()
        {
            TbAgremiacoesProfessores = new HashSet<TbAgremiacoesProfessore>();
            TbAtleta = new HashSet<TbAtleta>();
            TbCobrancas = new HashSet<TbCobranca>();
            TbCompeticoesInscricos = new HashSet<TbCompeticoesInscrico>();
            TbCompeticoesTecnicos = new HashSet<TbCompeticoesTecnico>();
            TbCurriculosAgremiacos = new HashSet<TbCurriculosAgremiaco>();
            TbDesfiliacoesAgremiacos = new HashSet<TbDesfiliacoesAgremiaco>();
            TbIsencoesAgremiacos = new HashSet<TbIsencoesAgremiaco>();
            TbMensalidades = new HashSet<TbMensalidade>();
            TbRecibos = new HashSet<TbRecibo>();
            TbTransferenciaIdNavigations = new HashSet<TbTransferencia>();
            TbTransferenciaIds = new HashSet<TbTransferencia>();
            TbValoresDefaultId1s = new HashSet<TbValoresDefault>();
            TbValoresDefaultIdNavigations = new HashSet<TbValoresDefault>();
            TbValoresDefaultIds = new HashSet<TbValoresDefault>();
        }

        public int IdAgremiacao { get; set; }
        public string Sigla { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string? Fantasia { get; set; }
        public string Responsavel { get; set; } = null!;
        public string Representante { get; set; } = null!;
        public DateTime DataFiliacao { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cep { get; set; } = null!;
        public string Endereco { get; set; } = null!;
        public string Bairro { get; set; } = null!;
        public string Complemento { get; set; } = null!;
        public int IdCidade { get; set; }
        public int IdEstado { get; set; }
        public int IdPais { get; set; }
        public string Telefone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Cnpj { get; set; } = null!;
        public string? InscricaoMunicipal { get; set; }
        public string? InscricaoEstadual { get; set; }
        public DateTime? DataCnpj { get; set; }
        public DateTime? DataAta { get; set; }
        public string? AlvaraLocacao { get; set; }
        public string? Estatuto { get; set; }
        public string? ContratoSocial { get; set; }
        public string? DocumentacaoAtualizada { get; set; }
        public int IdRegiao { get; set; }
        public string? Anotacoes { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbPaise Id { get; set; } = null!;
        public virtual TbEstado Id1 { get; set; } = null!;
        public virtual TbCidade Id2 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbRegio IdNavigation { get; set; } = null!;
        public virtual ICollection<TbAgremiacoesProfessore> TbAgremiacoesProfessores { get; set; }
        public virtual ICollection<TbAtleta> TbAtleta { get; set; }
        public virtual ICollection<TbCobranca> TbCobrancas { get; set; }
        public virtual ICollection<TbCompeticoesInscrico> TbCompeticoesInscricos { get; set; }
        public virtual ICollection<TbCompeticoesTecnico> TbCompeticoesTecnicos { get; set; }
        public virtual ICollection<TbCurriculosAgremiaco> TbCurriculosAgremiacos { get; set; }
        public virtual ICollection<TbDesfiliacoesAgremiaco> TbDesfiliacoesAgremiacos { get; set; }
        public virtual ICollection<TbIsencoesAgremiaco> TbIsencoesAgremiacos { get; set; }
        public virtual ICollection<TbMensalidade> TbMensalidades { get; set; }
        public virtual ICollection<TbRecibo> TbRecibos { get; set; }
        public virtual ICollection<TbTransferencia> TbTransferenciaIdNavigations { get; set; }
        public virtual ICollection<TbTransferencia> TbTransferenciaIds { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultId1s { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultIdNavigations { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaultIds { get; set; }
    }
}
