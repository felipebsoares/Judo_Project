namespace ProjetoJudo.Domain.Entities
{
    public partial class TbPatrocinadore
    {
        public TbPatrocinadore()
        {
            TbCompeticoesPatrocinadores = new HashSet<TbCompeticoesPatrocinadore>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdPatrocinador { get; set; }
        public string Sigla { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public string Fantasia { get; set; } = null!;
        public string? Responsavel { get; set; }
        public string Cep { get; set; } = null!;
        public string Endereco { get; set; } = null!;
        public string? Bairro { get; set; }
        public string? Complemento { get; set; }
        public int IdCidade { get; set; }
        public int IdEstado { get; set; }
        public int IdPais { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Cnpj { get; set; }
        public string? InscricaoMunicipal { get; set; }
        public string? InscricaoEstadual { get; set; }
        public string? Anotacoes { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbPaise Id { get; set; } = null!;
        public virtual TbCidade Id1 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbEstado IdNavigation { get; set; } = null!;
        public virtual ICollection<TbCompeticoesPatrocinadore> TbCompeticoesPatrocinadores { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
