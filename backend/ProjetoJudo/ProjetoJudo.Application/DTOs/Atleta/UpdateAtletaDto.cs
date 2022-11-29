using System.ComponentModel.DataAnnotations;

namespace ProjetoJudo.Application.DTOs.Atleta;

public class UpdateAtletaDto
{
    [Key]
    [Required(ErrorMessage = "O id não pode ser vazio")]
    public int IdAtleta { get; set; }
    
    [Required(ErrorMessage = "O nome não pode ser vazio")]
    [MaxLength(60, ErrorMessage = "O nome deve ter no máximo 60 caracteres")]
    public string Nome { get; set; } = null!;
    
    [Required(ErrorMessage = "A data de nascimento não pode ser vazio")]
    [MaxLength(60, ErrorMessage = "A data de nascimento deve ter no máximo 60 caracteres")]
    public DateTime DataNascimento { get; set; }
    
    [Required(ErrorMessage = "O telefone não pode ser vazio")]
    [MaxLength(60, ErrorMessage = "O telefone deve ter no máximo 60 caracteres")]
    public string Telefone { get; set; } = null!;
    
    [Required(ErrorMessage = "O email não pode ser vazio")]
    [MaxLength(60, ErrorMessage = "O email deve ter no máximo 60 caracteres")]
    public string Email { get; set; } = null!;
    
    [Key]
    [Required(ErrorMessage = "O cpf não pode ser vazio")]
    [MaxLength(60, ErrorMessage = "O cpf deve ter no máximo 60 caracteres")]
    public string Cpf { get; set; } = null!;
}