using System.ComponentModel.DataAnnotations;

namespace ProjetoJudo.Application.DTOs.Atleta;

public class CreateAtletaDto
{
    public CreateAtletaDto(int idAtleta, string nome, DateTime dataNascimento, string email, string cpf, List<CreateAtletaDto> atletas)
    {
        IdAtleta = idAtleta;
        Nome = nome;
        DataNascimento = dataNascimento;
        Email = email;
        Cpf = cpf;
        Atletas = atletas;
    }

    public int IdAtleta { get; set; }
    public string Nome { get; set; } = null!;
    public DateTime DataNascimento { get; set; }
    public string Email { get; set; } = null!;
    public string Cpf { get; set; } = null!;

    public static List<CreateAtletaDto> Atletas { get; set; } = new();
}