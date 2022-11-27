namespace ProjetoJudo.Application.DTOs.Usuarios;

public class RegistrarUsuarioDto
{
    public int IdCliente { get; set; }
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Senha { get; set; } = null!;
    public string ConfirmarSenha { get; set; } = null!;
}