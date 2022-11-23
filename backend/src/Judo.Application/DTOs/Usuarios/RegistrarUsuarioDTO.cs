namespace Judo.Application.DTOs.Usuarios;

public class RegistrarUsuarioDto
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string ConfirmarSenha { get; set; }
    public char Situacao { get; set; }
    public bool Selecao { get; set; }
}