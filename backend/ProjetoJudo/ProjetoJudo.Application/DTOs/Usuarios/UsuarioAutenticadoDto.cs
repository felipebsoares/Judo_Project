namespace ProjetoJudo.Application.DTOs.Usuarios;

public class UsuarioAutenticadoDto
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Token { get; set; }

    public record LoginUsuarioDto(string Email, string Senha);
}