using System;
using System.Collections.Generic;

namespace ProjetoJudo.Domain.Entities
{
    public partial class TbArbitro
    {
        public TbArbitro()
        {
            TbCompeticoesArbitros = new HashSet<TbCompeticoesArbitro>();
            TbPromocoesArbitros = new HashSet<TbPromocoesArbitro>();
            TbValoresDefaults = new HashSet<TbValoresDefault>();
        }

        public int IdArbitro { get; set; }
        public int IdAtleta { get; set; }
        public string Apelido { get; set; } = null!;
        public string Nome { get; set; } = null!;
        public DateTime DataNascimento { get; set; }
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
        public int IdNivel { get; set; }
        public int IdSexo { get; set; }
        public int IdEstadoCivil { get; set; }
        public string? Anotacoes { get; set; }
        public bool Selecao { get; set; }
        public int IdCliente { get; set; }

        public virtual TbAtleta Id { get; set; } = null!;
        public virtual TbEstadosCivi Id1 { get; set; } = null!;
        public virtual TbPaise Id2 { get; set; } = null!;
        public virtual TbNiveisArbitro Id3 { get; set; } = null!;
        public virtual TbPaise Id4 { get; set; } = null!;
        public virtual TbSexo Id5 { get; set; } = null!;
        public virtual TbEstado Id6 { get; set; } = null!;
        public virtual TbCidade Id7 { get; set; } = null!;
        public virtual TbCliente IdClienteNavigation { get; set; } = null!;
        public virtual TbEmissoresIdentidade IdNavigation { get; set; } = null!;
        public virtual ICollection<TbCompeticoesArbitro> TbCompeticoesArbitros { get; set; }
        public virtual ICollection<TbPromocoesArbitro> TbPromocoesArbitros { get; set; }
        public virtual ICollection<TbValoresDefault> TbValoresDefaults { get; set; }
    }
}
