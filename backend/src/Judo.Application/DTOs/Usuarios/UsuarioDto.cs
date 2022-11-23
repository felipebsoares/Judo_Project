namespace Judo.Application.DTOs.Usuarios;

public class UsuarioDto
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public char Situacao { get; set; }
    public bool Selecao { get; set; }
}