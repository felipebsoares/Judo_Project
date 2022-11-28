using FluentValidation.Results;
using ProjetoJudo.Domain.Validations;

namespace ProjetoJudo.Domain.Entities
{
    public partial class TbAtleta : Base
    {
        public TbAtleta()
        {
            TbAnuidades = new HashSet<TbAnuidade>();
            TbAnuidadesConfederacaos = new HashSet<TbAnuidadesConfederacao>();
            TbArbitros = new HashSet<TbArbitro>();
            TbCompeticoesInscricos = new HashSet<TbCompeticoesInscrico>();
            TbCompeticoesLutaId1s = new HashSet<TbCompeticoesLuta>();
            TbCompeticoesLutaIdNavigations = new HashSet<TbCompeticoesLuta>();
            TbCompeticoesLutaIds = new HashSet<TbCompeticoesLuta>();
            TbCompeticoesLutasPenalidades = new HashSet<TbCompeticoesLutasPenalidade>();
            TbCompeticoesLutasPontuacos = new HashSet<TbCompeticoesLutasPontuaco>();
            TbCompeticoesResultados = new HashSet<TbCompeticoesResultado>();
            TbCurriculosAtleta = new HashSet<TbCurriculosAtleta>();
            TbDesfiliacoesAtleta = new HashSet<TbDesfiliacoesAtleta>();
            TbIsencoesAtleta = new HashSet<TbIsencoesAtleta>();
            TbPessoalApoios = new HashSet<TbPessoalApoio>();
            TbProfessores = new HashSet<TbProfessore>();
            TbPromocoesAtleta = new HashSet<TbPromocoesAtleta>();
            TbRecibos = new HashSet<TbRecibo>();
            TbTransferencia = new HashSet<TbTransferencia>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }
        
        public string RegistroFederacao { get; set; } = null!;
        public string? RegistroConfederacao { get; set; }
        public string Nome { get; set; } = null!;
        public DateTime DataNascimento { get; set; }
        public DateTime DataFiliacao { get; set; }
        public int IdAgremiacao { get; set; }
        public string Cep { get; set; } = null!;
        public string Endereco { get; set; } = null!;
        public string? Bairro { get; set; }
        public string? Complemento { get; set; }
        public int IdCidade { get; set; }
        public int IdEstado { get; set; }
        public int IdPais { get; set; }
        public string Telefone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Cpf { get; set; } = null!;
        public string Identidade { get; set; } = null!;
        public DateTime DataIdentidade { get; set; }
        public int IdEmissor { get; set; }
        public int IdNacionalidade { get; set; }
        public int IdProfissaoAtleta { get; set; }
        public string? NomePai { get; set; }
        public int? IdProfissaoPai { get; set; }
        public string? NomeMae { get; set; }
        public int? IdProfissaoMae { get; set; }
        public int IdFaixa { get; set; }
        public int IdSexo { get; set; }
        public int IdEstadoCivil { get; set; }
        public string? Anotacoes { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAgremiaco Agremiaco { get; set; } = null!;
        public virtual TbEstadosCivi EstadoCivil { get; set; } = null!;
        public virtual TbCidade Cidade { get; set; } = null!;
        public virtual TbFaixa Faixa { get; set; } = null!;
        public virtual TbPaise Pais { get; set; } = null!;
        public virtual TbPaise Paise { get; set; } = null!;
        public virtual TbProfisso Profissao { get; set; } = null!;
        public virtual TbProfisso? ProfisaoPai { get; set; }
        public virtual TbProfisso? ProfisaoMae { get; set; }
        public virtual TbSexo Sexo { get; set; } = null!;
        public virtual TbEstado Estado { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbEmissoresIdentidade IdNavigation { get; set; } = null!;
        public virtual ICollection<TbAnuidade> TbAnuidades { get; set; }
        public virtual ICollection<TbAnuidadesConfederacao> TbAnuidadesConfederacaos { get; set; }
        public virtual ICollection<TbArbitro> TbArbitros { get; set; }
        public virtual ICollection<TbCompeticoesInscrico> TbCompeticoesInscricos { get; set; }
        public virtual ICollection<TbCompeticoesLuta> TbCompeticoesLutaId1s { get; set; }
        public virtual ICollection<TbCompeticoesLuta> TbCompeticoesLutaIdNavigations { get; set; }
        public virtual ICollection<TbCompeticoesLuta> TbCompeticoesLutaIds { get; set; }
        public virtual ICollection<TbCompeticoesLutasPenalidade> TbCompeticoesLutasPenalidades { get; set; }
        public virtual ICollection<TbCompeticoesLutasPontuaco> TbCompeticoesLutasPontuacos { get; set; }
        public virtual ICollection<TbCompeticoesResultado> TbCompeticoesResultados { get; set; }
        public virtual ICollection<TbCurriculosAtleta> TbCurriculosAtleta { get; set; }
        public virtual ICollection<TbDesfiliacoesAtleta> TbDesfiliacoesAtleta { get; set; }
        public virtual ICollection<TbIsencoesAtleta> TbIsencoesAtleta { get; set; }
        public virtual ICollection<TbPessoalApoio> TbPessoalApoios { get; set; }
        public virtual ICollection<TbProfessore> TbProfessores { get; set; }
        public virtual ICollection<TbPromocoesAtleta> TbPromocoesAtleta { get; set; }
        public virtual ICollection<TbRecibo> TbRecibos { get; set; }
        public virtual ICollection<TbTransferencia> TbTransferencia { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
        
        public override bool Validar(out ValidationResult validationResult)
        {
            validationResult = new AtletaValidation().Validate(this);
            return validationResult.IsValid;
        }
    }
}
