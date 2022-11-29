namespace ProjetoJudo.Application.DTOs.Agremiacoes;

public class CadastrarAgremiacaoDto
{
    public int Id { get; set; }
    public string Sigla { get; set; } = null!;
    public string Nome { get; set; } = null!;
    public string Responsavel { get; set; } = null!;
    public string Representante { get; set; } = null!;
    public string Telefone { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Cnpj { get; set; } = null!;
}