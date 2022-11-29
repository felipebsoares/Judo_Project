using System.ComponentModel.DataAnnotations;

namespace ProjetoJudo.Application.DTOs.Atleta;

public class UpdateAtletaDto
{
    public int IdAtleta { get; set; }
    public string Nome { get; set; } = null!;
    public DateTime DataNascimento { get; set; }
    public string Telefone { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Cpf { get; set; } = null!;
}