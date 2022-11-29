namespace ProjetoJudo.Application.DTOs.Agremiacao;

public class CadastrarAgremiacaoDto
{
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
}